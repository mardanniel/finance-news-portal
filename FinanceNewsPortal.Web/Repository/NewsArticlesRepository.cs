using FinanceNewsPortal.Web.Data;
using FinanceNewsPortal.Web.Enums;
using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.Contracts;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FinanceNewsPortal.Web.Repository
{
    public class NewsArticlesRepository : INewsArticlesRepository
    {
        private readonly FinanceNewsPortalDbContext _financeNewsPortalDbcontext;

        public NewsArticlesRepository(FinanceNewsPortalDbContext financeNewsPortalDbContext)
        {
            this._financeNewsPortalDbcontext = financeNewsPortalDbContext;
        }

        public async Task CreateNewsArticle(NewsArticle newsArticle)
        {
            await this._financeNewsPortalDbcontext.AddAsync<NewsArticle>(newsArticle);

            await this._financeNewsPortalDbcontext.SaveChangesAsync();
        }

        public async Task DeleteNewsArticle(Guid newsArticleId)
        {
            var news = await this._financeNewsPortalDbcontext.NewsArticle.FindAsync(newsArticleId);

            if (news != null)
            {
                this._financeNewsPortalDbcontext.NewsArticle.Remove(news);
            }

            await this._financeNewsPortalDbcontext.SaveChangesAsync();
        }

        public async Task<List<NewsArticle>> GetLatestNewsArticles(int count)
        {
            return await this._financeNewsPortalDbcontext.NewsArticle
                .Include(n => n.Author)
                .Where(n => n.Status == NewsStatus.Approved)
                .OrderByDescending(n => n.CreatedAt)
                .Take(count)
                .ToListAsync();
        }

        public async Task<NewsArticle?> GetNewsArticleById(Guid newsArticleId)
        {
            NewsArticle news = await this._financeNewsPortalDbcontext
                .NewsArticle
                .Include(n => n.Author)
                .FirstOrDefaultAsync(n => n.Id == newsArticleId);

            return news;
        }

        public async Task<List<NewsArticle>> GetNewsArticleByStatus(Guid? excludeUserId, NewsStatus newsStatus)
        {
            List<NewsArticle> newsArticles = await this._financeNewsPortalDbcontext.NewsArticle
                .Include(n => n.Author)
                .Where(n => n.Status == newsStatus && n.ApplicationUserId != excludeUserId.ToString())
                .ToListAsync();

            return newsArticles;
        }

        public async Task<NewsArticle> GetNewsArticleImageFilePathById(Guid newsArticleId, Guid userId)
        {
            return await this._financeNewsPortalDbcontext.NewsArticle
                .Where(n => n.Id == newsArticleId)
                .Select(n => new NewsArticle
                {
                    Id = n.Id,
                    ImageFilePath = n.ImageFilePath
                })
                .FirstOrDefaultAsync();
        }

        public async Task<List<NewsArticle>> GetNewsArticles()
        {
            return await this._financeNewsPortalDbcontext.NewsArticle
                .Include(n => n.Author)
                .Where(news => news.Status == NewsStatus.Approved)
                .OrderByDescending(n => n.CreatedAt)
                .Select(news => new NewsArticle
                {
                    Id = news.Id,
                    ApplicationUserId = news.ApplicationUserId,
                    Title = news.Title,
                    Author = news.Author,
                })
                .ToListAsync();
        }

        public async Task<List<NewsArticle>> GetNewsArticlesByUserId(Guid userId)
        {
            return await this._financeNewsPortalDbcontext.NewsArticle
                .Include(n => n.Author)
                .Where(news => news.ApplicationUserId == userId.ToString())
                .Select(news => new NewsArticle
                {
                    Id = news.Id,
                    ApplicationUserId = news.ApplicationUserId,
                    Title = news.Title,
                    Status = news.Status,
                    Author = news.Author,
                    ImageFilePath = news.ImageFilePath,
                })
                .ToListAsync();
        }

        public async Task UpdateNewsArticle(Guid newsArticleId, UpsertNewsArticleViewModel newsArticleViewModel)
        {
            NewsArticle newsArticleToBeUpdated = await this.GetNewsArticleById(newsArticleId);

            if (newsArticleToBeUpdated != null)
            {
                if (newsArticleViewModel.ImageFilePath != null)
                {
                    newsArticleToBeUpdated.ImageFilePath = newsArticleViewModel.ImageFilePath;
                }
                
                newsArticleToBeUpdated.Title = newsArticleViewModel.Title;
                newsArticleToBeUpdated.Description = newsArticleViewModel.Context;

                this._financeNewsPortalDbcontext.Update(newsArticleToBeUpdated);
            }

            await this._financeNewsPortalDbcontext.SaveChangesAsync();
        }

        public async Task UpdateNewsArticleStatus(Guid newsArticleId, NewsStatus status)
        {
            NewsArticle newsArticleToBeUpdated = await this.GetNewsArticleById(newsArticleId);

            if (newsArticleToBeUpdated != null)
            {
                newsArticleToBeUpdated.Status = status;

                this._financeNewsPortalDbcontext.Update(newsArticleToBeUpdated);
            }

            await this._financeNewsPortalDbcontext.SaveChangesAsync();
        }
    }
}
