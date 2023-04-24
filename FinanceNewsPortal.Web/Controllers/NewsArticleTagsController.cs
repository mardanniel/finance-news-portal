using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.NewsArticleTagsRepository;
using FinanceNewsPortal.Web.Repository.UserRepository;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace FinanceNewsPortal.Web.Controllers
{
    public class NewsArticleTagsController : Controller
    {
        private readonly INewsArticleTagsRepository _newsArticleTagsRepository;

        public NewsArticleTagsController(INewsArticleTagsRepository newsArticleTagsRepository)
        {
            this._newsArticleTagsRepository = newsArticleTagsRepository;
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> GetAll(int? pageNumber)
        {
            int pageSize = 12;

            List<NewsArticleTag> newsArticleTags = await this._newsArticleTagsRepository
                .GetNewsArticleTags(pageNumber ?? 1, pageSize);

            return View(newsArticleTags);
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateTagViewModel newTag)
        {
            if (!ModelState.IsValid)
            {
                return View(newTag);
            }

            NewsArticleTag newsArticleTag = new NewsArticleTag
            {
                TagName = newTag.TagName
            };

            await this._newsArticleTagsRepository.CreateNewsArticleTag(newsArticleTag);

            return RedirectToAction("GetAll");
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid newsArticleTagId)
        {
            NewsArticleTag newsArticleTag = await this._newsArticleTagsRepository.GetNewsArticleTagById(newsArticleTagId);

            UpdateNewsArticleTagViewModel newsArticleTagViewModel = new UpdateNewsArticleTagViewModel
            {
                Id = newsArticleTag.Id,
                TagName = newsArticleTag.TagName
            };

            return View(newsArticleTagViewModel);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateNewsArticleTagViewModel newTag)
        {
            if (!ModelState.IsValid)
            {
                return View(newTag);
            }

            await this._newsArticleTagsRepository.UpdateNewsArticleTag(newTag.Id, newTag);

            return RedirectToAction("GetAll");
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> Delete(Guid? newsArticleTagId)
        {
            if (newsArticleTagId != null)
            {
                await this._newsArticleTagsRepository.DeleteNewsArticleTag((Guid)newsArticleTagId);
            }

            return RedirectToAction("GetAll");
        }
    }
}
