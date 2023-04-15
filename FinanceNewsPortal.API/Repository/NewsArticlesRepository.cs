using FinanceNewsPortal.API.Data;
using FinanceNewsPortal.API.Enums;
using FinanceNewsPortal.API.Models;
using FinanceNewsPortal.API.Repository.Contracts;
using FinanceNewsPortal.API.DTO;
using FinanceNewsPortal.API.Helper;
using Microsoft.EntityFrameworkCore;

namespace FinanceNewsPortal.API.Repository
{
    public class NewsArticlesRepository : INewsArticlesRepository
    {
        private readonly FinanceNewsPortalDbContext _financeNewsPortalDbcontext;
        private readonly FileUpload _fileUpload;

        public NewsArticlesRepository(FinanceNewsPortalDbContext financeNewsPortalDbContext,
                                        FileUpload fileUpload)
        {
            this._financeNewsPortalDbcontext = financeNewsPortalDbContext;
            this._fileUpload = fileUpload;
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
                .Include("NewsArticleTypes.NewsArticleTag")
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
                .Include("NewsArticleTypes.NewsArticleTag")
                .FirstOrDefaultAsync(n => n.Id == newsArticleId);

            return news;
        }

        public async Task<List<NewsArticle>> GetNewsArticleByStatus(Guid? excludeUserId, NewsStatus newsStatus, int pageNumber, int pageSize)
        {
            var newsArticleQuery = this._financeNewsPortalDbcontext.NewsArticle
                .Include(n => n.Author)
                .Where(n => n.Status == newsStatus && n.ApplicationUserId != excludeUserId.ToString());

            return await PaginatedList<NewsArticle>.CreateAsync(newsArticleQuery, pageNumber, pageSize);
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

        public async Task<List<NewsArticle>> GetNewsArticles(int pageNumber, int pageSize)
        {
            var newsArticleQuery = this._financeNewsPortalDbcontext.NewsArticle
                .Include(n => n.Author)
                .Include("NewsArticleTypes.NewsArticleTag")
                .OrderByDescending(n => n.CreatedAt)
                .Select(news => new NewsArticle
                {
                    Id = news.Id,
                    ApplicationUserId = news.ApplicationUserId,
                    Description = news.Description,
                    Title = news.Title,
                    Author = news.Author,
                    ImageFilePath = news.ImageFilePath,
                    NewsArticleTypes = news.NewsArticleTypes
                });

            return await PaginatedList<NewsArticle>.CreateAsync(newsArticleQuery, pageNumber, pageSize);
        }

        public async Task<List<NewsArticle>> GetNewsArticlesByUserId(Guid userId, int pageNumber, int pageSize, NewsStatus newsArticleStatus)
        {
            var newsArticleQuery = this._financeNewsPortalDbcontext.NewsArticle
                .Include(n => n.Author)
                .Include("NewsArticleTypes.NewsArticleTag")
                .Select(news => new NewsArticle
                {
                    Id = news.Id,
                    ApplicationUserId = news.ApplicationUserId,
                    Title = news.Title,
                    Status = news.Status,
                    Author = news.Author,
                    ImageFilePath = news.ImageFilePath,
                    NewsArticleTypes = news.NewsArticleTypes
                })
                .Where(news => news.ApplicationUserId == userId.ToString());

                if(newsArticleStatus != NewsStatus.NoStatus)
                {
                    newsArticleQuery = newsArticleQuery.Where(news => news.Status == newsArticleStatus);
                }

            return await PaginatedList<NewsArticle>.CreateAsync(newsArticleQuery, pageNumber, pageSize);
        }

        public async Task<List<NewsArticleTag>> GetNewsArticleTags()
        {
            return await this._financeNewsPortalDbcontext.NewsArticleTags.ToListAsync();
        }

        public async Task UpdateNewsArticle(Guid newsArticleId, UpdateNewsArticleDTO newsArticleDTO)
        {
            NewsArticle newsArticleToBeUpdated = await this.GetNewsArticleById(newsArticleId);

            if (newsArticleToBeUpdated != null)
            {
                if (newsArticleDTO.Image != null)
                {
                    // Delete image file
                    this._fileUpload.DeleteFile(newsArticleToBeUpdated.ImageFilePath, "news-image");

                    // Upload file and take generated filename
                    newsArticleToBeUpdated.ImageFilePath = this._fileUpload.UploadFile(newsArticleDTO.Image, newsArticleToBeUpdated.Author.Id, "news-image");
                }

                newsArticleToBeUpdated.Title = newsArticleDTO.Title;
                newsArticleToBeUpdated.Description = newsArticleDTO.Context;

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
