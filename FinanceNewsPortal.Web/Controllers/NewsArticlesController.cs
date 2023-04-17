using Microsoft.AspNetCore.Mvc;
using FinanceNewsPortal.Web.Repository.Contracts;
using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.ViewModels;
using FinanceNewsPortal.Web.Enums;
using Microsoft.AspNetCore.Authorization;
using FinanceNewsPortal.Web.Helper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinanceNewsPortal.Web.Controllers
{
    [Authorize]
    public class NewsArticlesController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly INewsArticlesRepository _newsArticlesRepository;
        private readonly FileUpload _fileUpload;

        public NewsArticlesController(IUserRepository userRepository,
                                        INewsArticlesRepository newsArticlesRepository,
                                        FileUpload fileUpload)
        {
            this._newsArticlesRepository = newsArticlesRepository;
            this._userRepository = userRepository;
            this._fileUpload = fileUpload;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index(int? pageNumber, Guid? newsArticleTagId)
        {
            int pageSize = 12;

            List<NewsArticle> newsArticles = await this._newsArticlesRepository.GetNewsArticles(pageNumber ?? 1, pageSize, newsArticleTagId);

            List<NewsArticleTag> newsArticleTags = new List<NewsArticleTag>();

            newsArticleTags.Add(new NewsArticleTag { Id = Guid.Empty, TagName = "All" });

            newsArticleTags.AddRange(await this._newsArticlesRepository.GetNewsArticleTags());

            ViewData["NewsArticleTagsList"] = new SelectList(newsArticleTags,
                                                            "Id",
                                                            "TagName",
                                                            newsArticleTagId ?? Guid.Empty);

            return View(newsArticles);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            List<NewsArticleTag> newsArticleTags = await this._newsArticlesRepository.GetNewsArticleTags();
            ViewData["NewsArticleTags"] = newsArticleTags;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UpsertNewsArticleViewModel newsArticle)
        {
            if (ModelState.IsValid)
            {
                UserWithRoleViewModel user = await this._userRepository.GetCurrentUser();

                NewsArticle news = new NewsArticle
                {
                    ApplicationUserId = user.Id,
                    Title = newsArticle.Title,
                    Description = newsArticle.Context,
                    Status = user.Role == UserRole.Administrator ? NewsStatus.Approved : NewsStatus.Pending,
                };

                if (newsArticle.Image != null)
                {
                    string imageName = this._fileUpload.UploadFile(newsArticle.Image, user.Id, "news-image");

                    news.ImageFilePath = imageName;
                }

                if (newsArticle.Tags != null)
                {
                    List<NewsArticleType> newsArticleTypes = new List<NewsArticleType>();

                    foreach (var tag in newsArticle.Tags)
                    {
                        newsArticleTypes.Add(
                            new NewsArticleType
                            {
                                NewsArticleTagId = tag
                            });
                    }

                    news.NewsArticleTypes = newsArticleTypes;
                }

                await this._newsArticlesRepository.CreateNewsArticle(news);

                return RedirectToAction("GetAllCreated");
            }

            List<NewsArticleTag> newsArticleTags = await this._newsArticlesRepository.GetNewsArticleTags();
            ViewData["NewsArticleTags"] = newsArticleTags;

            return View(newsArticle);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid newsArticle)
        {
            NewsArticle news = await this._newsArticlesRepository.GetNewsArticleById(newsArticle);

            List<NewsArticleTag> newsArticleTags = await this._newsArticlesRepository.GetNewsArticleTags();
            ViewData["NewsArticleTags"] = newsArticleTags;

            UpsertNewsArticleViewModel newsArticleVM = new UpsertNewsArticleViewModel
            {
                Id = news.Id,
                Title = news.Title,
                Context = news.Description,
                ImageFilePath = news.ImageFilePath
            };

            if (news.NewsArticleTypes != null)
            {
                List<Guid> selectedTagsId = new List<Guid>();

                foreach (var tagsId in news.NewsArticleTypes)
                {
                    selectedTagsId.Add(tagsId.NewsArticleTagId);
                }

                newsArticleVM.SelectedTagsOnEdit = selectedTagsId;
            }

            return View(newsArticleVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpsertNewsArticleViewModel newsArticle)
        {
            if (ModelState.IsValid)
            {
                UserWithRoleViewModel user = await this._userRepository.GetCurrentUser();

                if (newsArticle.Image != null)
                {
                    NewsArticle newsArticleWithImageFilePath = await this._newsArticlesRepository
                        .GetNewsArticleImageFilePathById((Guid)newsArticle.Id, Guid.Parse(user.Id));

                    this._fileUpload.DeleteFile(newsArticleWithImageFilePath.ImageFilePath, "news-image");

                    newsArticle.ImageFilePath = this._fileUpload.UploadFile(newsArticle.Image, user.Id, "news-image");
                }

                newsArticle.Author = Guid.Parse(user.Id);
                await this._newsArticlesRepository.UpdateNewsArticle((Guid)newsArticle.Id, newsArticle);
                return RedirectToAction("GetAllCreated");
            }

            return View(newsArticle);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(Guid newsArticle)
        {
            NewsArticle news = await this._newsArticlesRepository.GetNewsArticleById(newsArticle);
            return View(news);
        }

        [HttpGet]
        public async Task<IActionResult> ViewCreated(Guid newsArticle)
        {
            NewsArticle news = await this._newsArticlesRepository.GetNewsArticleById(newsArticle);
            return View(news);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid newsArticle)
        {
            NewsArticle news = await this._newsArticlesRepository.GetNewsArticleById(newsArticle);
            return View(news);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await this._newsArticlesRepository.DeleteNewsArticle(id);
            return RedirectToAction("GetAllCreated");
        }

        [Authorize(Roles = "Moderator, Administrator")]
        [HttpGet]
        public async Task<IActionResult> GetAllPending(int? pageNumber, Guid? newsArticleTagId)
        {
            int pageSize = 12;

            UserWithRoleViewModel user = await this._userRepository.GetCurrentUser();
            List<NewsArticle> pendingNewsArticles = await this._newsArticlesRepository
                .GetNewsArticleByStatus(Guid.Parse(user.Id), NewsStatus.Pending, pageNumber ?? 1, pageSize, newsArticleTagId);

            List<NewsArticleTag> newsArticleTags = new List<NewsArticleTag>();

            newsArticleTags.Add(new NewsArticleTag { Id = Guid.Empty, TagName = "All" });

            newsArticleTags.AddRange(await this._newsArticlesRepository.GetNewsArticleTags());

            ViewData["NewsArticleTagsList"] = new SelectList(newsArticleTags,
                                                            "Id",
                                                            "TagName",
                                                            newsArticleTagId ?? Guid.Empty);

            if (newsArticleTagId != null)
            {
                ViewData["SelectedNewsArticleTag"] = newsArticleTagId;
            }

            return View(pendingNewsArticles);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCreated(int? pageNumber, Guid? newsArticleTagId, NewsStatus newsArticleStatus = NewsStatus.NoStatus)
        {
            int pageSize = 12;

            UserWithRoleViewModel user = await this._userRepository.GetCurrentUser();
            List<NewsArticle> newsArticles = await this._newsArticlesRepository
                .GetNewsArticlesByUserId(Guid.Parse(user.Id), pageNumber ?? 1, pageSize, newsArticleStatus, newsArticleTagId);

            List<SelectListItem> newsArticleStatusList = new List<SelectListItem>
            {
                new SelectListItem { Value = "100", Text = "All" },
                new SelectListItem { Value = "101", Text = "Pending" },
                new SelectListItem { Value = "102", Text = "Rejected" },
                new SelectListItem { Value = "103", Text = "Approved" },
            };

            List<NewsArticleTag> newsArticleTags = new List<NewsArticleTag>();

            newsArticleTags.Add(new NewsArticleTag { Id = Guid.Empty, TagName = "All" });

            newsArticleTags.AddRange(await this._newsArticlesRepository.GetNewsArticleTags());

            ViewData["NewsArticleStatusList"] = new SelectList(newsArticleStatusList,
                                                            "Value",
                                                            "Text",
                                                            (int)newsArticleStatus);

            ViewData["NewsArticleTagsList"] = new SelectList(newsArticleTags,
                                                            "Id",
                                                            "TagName",
                                                            newsArticleTagId ?? Guid.Empty);

            ViewData["SelectedNewsArticleStatus"] = newsArticleStatus;

            if (newsArticleTagId != null)
            {
                ViewData["SelectedNewsArticleTag"] = newsArticleTagId;
            }


            return View(newsArticles);
        }

        [Authorize(Roles = "Moderator, Administrator")]
        [HttpGet]
        public async Task<IActionResult> ManagePending(Guid newsArticle)
        {
            NewsArticle news = await this._newsArticlesRepository.GetNewsArticleById(newsArticle);
            PendingNewsArticleVerdict pendingNewsArticleVerdict = new PendingNewsArticleVerdict()
            {
                Id = news.Id,
                Title = news.Title,
                Description = news.Description,
                Status = news.Status,
                ImageFilePath = news.ImageFilePath,
                Author = news.Author,
                NewsArticleTypes = news.NewsArticleTypes,
            };

            List<SelectListItem> newsArticleStatusList = new List<SelectListItem>
            {
                new SelectListItem { Value = "103", Text = "Approved" },
                new SelectListItem { Value = "102", Text = "Rejected" },
            };

            ViewData["NewsArticleStatusList"] = new SelectList(newsArticleStatusList,
                                                            "Value",
                                                            "Text");

            return View(pendingNewsArticleVerdict);
        }

        [Authorize(Roles = "Moderator, Administrator")]
        [HttpPost]
        public async Task<IActionResult> ManagePending(PendingNewsArticleVerdict pendingNewsArticleVerdict)
        {
            if(!ModelState.IsValid)
            {
                NewsArticle news = await this._newsArticlesRepository.GetNewsArticleById(pendingNewsArticleVerdict.Id);
                PendingNewsArticleVerdict newPendingNewsArticleVerdict = new PendingNewsArticleVerdict()
                {
                    Id = news.Id,
                    Title = news.Title,
                    Description = news.Description,
                    Status = news.Status,
                    ImageFilePath = news.ImageFilePath,
                    Author = news.Author,
                    NewsArticleTypes = news.NewsArticleTypes,
                };
                List<SelectListItem> newsArticleStatusList = new List<SelectListItem>
                {
                    new SelectListItem { Value = "103", Text = "Approved" },
                    new SelectListItem { Value = "102", Text = "Rejected" },
                };

                ViewData["NewsArticleStatusList"] = new SelectList(newsArticleStatusList,
                                                                "Value",
                                                                "Text");
                return View(newPendingNewsArticleVerdict);
            }

            NewsArticle newsArticleToBeUpdate = await this._newsArticlesRepository
                        .GetNewsArticleById(pendingNewsArticleVerdict.Id);

            UpsertNewsArticleViewModel upsertNewsArticleViewModel = new UpsertNewsArticleViewModel()
            {
                Id = pendingNewsArticleVerdict.Id,
                Title = pendingNewsArticleVerdict.Title,
                Context = pendingNewsArticleVerdict.Description,
                Status = pendingNewsArticleVerdict.Status,
                VerdictMessage = pendingNewsArticleVerdict.VerdictMessage,
            };

            await this._newsArticlesRepository.UpdateNewsArticle(pendingNewsArticleVerdict.Id, upsertNewsArticleViewModel);

            return RedirectToAction("GetAllPending");
        }

        [Authorize(Roles = "Moderator, Administrator")]
        [HttpGet]
        public async Task<IActionResult> ApproveStatus(Guid newsArticleId)
        {
            await this._newsArticlesRepository.UpdateNewsArticleStatus(newsArticleId, NewsStatus.Approved);
            return RedirectToAction("GetAllPending");
        }

        [Authorize(Roles = "Moderator, Administrator")]
        [HttpGet]
        public async Task<IActionResult> DeclineStatus(Guid newsArticleId)
        {
            await this._newsArticlesRepository.UpdateNewsArticleStatus(newsArticleId, NewsStatus.Rejected);
            return RedirectToAction("GetAllPending");
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> GetAllTags()
        {
            List<NewsArticleTag> newsArticleTags = await this._newsArticlesRepository.GetNewsArticleTags();
            return View(newsArticleTags);
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> CreateTag()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTag(CreateTagViewModel newTag)
        {
            if (!ModelState.IsValid)
            {
                return View(newTag);
            }

            NewsArticleTag newsArticleTag = new NewsArticleTag
            {
                TagName = newTag.TagName
            };

            await this._newsArticlesRepository.CreateNewsArticleTag(newsArticleTag);

            return RedirectToAction("GetAllTags");
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> DeleteTag(Guid? newsArticleTagId)
        {
            if(newsArticleTagId != null)
            {
                await this._newsArticlesRepository.DeleteNewsArticleTag((Guid)newsArticleTagId);
            }

            return RedirectToAction("GetAllTags");
        }
    }
}
