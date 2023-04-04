using Microsoft.AspNetCore.Mvc;
using FinanceNewsPortal.Web.Repository.Contracts;
using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.ViewModels;
using FinanceNewsPortal.Web.Enums;
using Microsoft.AspNetCore.Authorization;

namespace FinanceNewsPortal.Web.Controllers
{
    [Authorize]
    public class NewsArticlesController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly INewsArticlesRepository _newsArticlesRepository;

        public NewsArticlesController(IUserRepository userRepository, INewsArticlesRepository newsArticlesRepository)
        {
            this._newsArticlesRepository = newsArticlesRepository;
            this._userRepository = userRepository;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<NewsArticle> newsArticles = await this._newsArticlesRepository.GetNewsArticles();

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

                newsArticle.Author = Guid.Parse(user.Id);

                await this._newsArticlesRepository.CreateNewsArticle(newsArticle);

                return RedirectToAction("Index");
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
                Context = news.Description
            };

            return View(newsArticleVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpsertNewsArticleViewModel newsArticle)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await this._userRepository.GetCurrentUser();
                newsArticle.Author = Guid.Parse(user.Id);
                await this._newsArticlesRepository.UpdateNewsArticle((Guid)newsArticle.Id, newsArticle);
                return RedirectToAction("Index");
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
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Moderator, Administrator")]
        [HttpGet]
        public async Task<IActionResult> GetAllPending()
        {
            ApplicationUser user = await this._userRepository.GetCurrentUser();
            List<NewsArticle> pendingNewsArticles = await this._newsArticlesRepository
                .GetNewsArticleByStatus(Guid.Parse(user.Id), NewsStatus.Pending);

            return View(pendingNewsArticles);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCreated()
        {
            ApplicationUser user = await this._userRepository.GetCurrentUser();
            List<NewsArticle> newsArticles = await this._newsArticlesRepository
                .GetNewsArticlesByUserId(Guid.Parse(user.Id));

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
