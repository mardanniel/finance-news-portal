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
        public async Task<IActionResult> Index(int? pageNumber)
        {
            int pageSize = 10;

            List<NewsArticle> newsArticles = await this._newsArticlesRepository.GetNewsArticles(pageNumber ?? 1, pageSize);

            return View(newsArticles);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UpsertNewsArticleViewModel newsArticle)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await this._userRepository.GetCurrentUser();

                string imageName = this._fileUpload.UploadFile(newsArticle.Image, user.Id, "news-image");

                NewsArticle news = new NewsArticle
                {
                    ApplicationUserId = user.Id,
                    Title = newsArticle.Title,
                    Description = newsArticle.Context,
                    Status = NewsStatus.Pending,
                    ImageFilePath = imageName
                };

                await this._newsArticlesRepository.CreateNewsArticle(news);

                return RedirectToAction("GetAllCreated");
            }

            return View(newsArticle);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid newsArticle)
        {
            NewsArticle news = await this._newsArticlesRepository.GetNewsArticleById(newsArticle);

            UpsertNewsArticleViewModel newsArticleVM = new UpsertNewsArticleViewModel
            {
                Id = news.Id,
                Title = news.Title,
                Context = news.Description,
                ImageFilePath = news.ImageFilePath,
            };

            return View(newsArticleVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpsertNewsArticleViewModel newsArticle)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await this._userRepository.GetCurrentUser();

                if (newsArticle.Image != null)
                {
                    // Find the news article with the image file path
                    NewsArticle newsArticleWithImageFilePath = await this._newsArticlesRepository
                        .GetNewsArticleImageFilePathById((Guid)newsArticle.Id, Guid.Parse(user.Id));

                    // Delete image file
                    this._fileUpload.DeleteFile(newsArticleWithImageFilePath.ImageFilePath, "news-image");

                    // Upload file and take generated filename
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
        public async Task<IActionResult> GetAllPending(int? pageNumber)
        {
            int pageSize = 10;

            ApplicationUser user = await this._userRepository.GetCurrentUser();
            List<NewsArticle> pendingNewsArticles = await this._newsArticlesRepository
                .GetNewsArticleByStatus(Guid.Parse(user.Id), NewsStatus.Pending, pageNumber ?? 1, pageSize);

            return View(pendingNewsArticles);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCreated(int? pageNumber, NewsStatus newsArticleStatus = NewsStatus.NoStatus)
        {
            int pageSize = 10;

            ApplicationUser user = await this._userRepository.GetCurrentUser();
            List<NewsArticle> newsArticles = await this._newsArticlesRepository
                .GetNewsArticlesByUserId(Guid.Parse(user.Id), pageNumber ?? 1, pageSize, newsArticleStatus);

            List<SelectListItem> newsArticleStatusList = new List<SelectListItem>
            {
                new SelectListItem { Value = "100", Text = "All" },
                new SelectListItem { Value = "101", Text = "Pending" },
                new SelectListItem { Value = "102", Text = "Rejected" },
                new SelectListItem { Value = "103", Text = "Approved" },
            };

            ViewData["NewsArticleStatusList"] = new SelectList(newsArticleStatusList, 
                                                            "Value", 
                                                            "Text",
                                                            (int)newsArticleStatus);

            ViewData["SelectedNewsArticleStatus"] = newsArticleStatus;
                                                        

            return View(newsArticles);
        }

        [Authorize(Roles = "Moderator, Administrator")]
        [HttpGet]
        public async Task<IActionResult> ViewPending(Guid newsArticle)
        {
            NewsArticle news = await this._newsArticlesRepository.GetNewsArticleById(newsArticle);
            return View(news);
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
    }
}
