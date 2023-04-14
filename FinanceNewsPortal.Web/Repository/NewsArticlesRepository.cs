using FinanceNewsPortal.Web.Data;
using FinanceNewsPortal.Web.Enums;
using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.Contracts;
using FinanceNewsPortal.Web.ViewModels;
using FinanceNewsPortal.Web.Helper;
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

        public async Task CreateNewsArticleTag(NewsArticleTag newsArticleTag)
        {
            await this._financeNewsPortalDbcontext.NewsArticleTags.AddAsync(newsArticleTag);

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

        public async Task DeleteNewsArticleTag(Guid newsArticleTagId)
        {
            var newsArticleTag = await this._financeNewsPortalDbcontext.NewsArticleTags.FindAsync(newsArticleTagId);

            if(newsArticleTag != null)
            {
                this._financeNewsPortalDbcontext.NewsArticleTags.Remove(newsArticleTag);
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
            NewsArticle news = await this._financeNewsPortalDbcontext.NewsArticle
                .Include(n => n.Author)
                .Include("NewsArticleTypes.NewsArticleTag")
                .FirstOrDefaultAsync(n => n.Id == newsArticleId);

            return news;
        }

        public async Task<List<NewsArticle>> GetNewsArticleByStatus(Guid? excludeUserId, NewsStatus newsStatus, int pageNumber, int pageSize, Guid? newsArticleTagId)
        {
            var newsArticleQuery = this._financeNewsPortalDbcontext.NewsArticle
                .Include(n => n.Author)
                .Include("NewsArticleTypes.NewsArticleTag")
                .Where(n => n.Status == newsStatus && n.ApplicationUserId != excludeUserId.ToString());

            if (newsArticleTagId != null && newsArticleTagId != Guid.Empty)
            {
                newsArticleQuery = newsArticleQuery
                    .Where(news => news.NewsArticleTypes
                        .Where(n => n.NewsArticleTagId == newsArticleTagId).Count() > 0);
            }

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

        public async Task<List<NewsArticle>> GetNewsArticles(int pageNumber, int pageSize, Guid? newsArticleTagId)
        {
            var newsArticleQuery = this._financeNewsPortalDbcontext.NewsArticle
                .Include(n => n.Author)
                .Include("NewsArticleTypes.NewsArticleTag")
                .Where(news => news.Status == NewsStatus.Approved)
                .OrderByDescending(n => n.CreatedAt)
                .Select(news => new NewsArticle
                {
                    Id = news.Id,
                    ApplicationUserId = news.ApplicationUserId,
                    Title = news.Title,
                    Author = news.Author,
                    ImageFilePath = news.ImageFilePath,
                    NewsArticleTypes = news.NewsArticleTypes
                });

            if(newsArticleTagId != null && newsArticleTagId != Guid.Empty)
            {
                newsArticleQuery = newsArticleQuery
                    .Where(news => news.NewsArticleTypes
                        .Where(n => n.NewsArticleTagId == newsArticleTagId).Count() > 0);
            }

            return await PaginatedList<NewsArticle>.CreateAsync(newsArticleQuery, pageNumber, pageSize);
        }

        public async Task<List<NewsArticle>> GetNewsArticlesByUserId(Guid userId, int pageNumber, int pageSize, NewsStatus newsArticleStatus, Guid? newsArticleTagId)
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

            if (newsArticleStatus != NewsStatus.NoStatus)
            {
                newsArticleQuery = newsArticleQuery.Where(news => news.Status == newsArticleStatus);
            }

            if (newsArticleTagId != null && newsArticleTagId != Guid.Empty)
            {
                newsArticleQuery = newsArticleQuery
                    .Where(news => news.NewsArticleTypes
                        .Where(n => n.NewsArticleTagId == newsArticleTagId).Count() > 0);
            }

            return await PaginatedList<NewsArticle>.CreateAsync(newsArticleQuery, pageNumber, pageSize);
        }

        public async Task<List<NewsArticleTag>> GetNewsArticleTags()
        {
            // NOTE: Temporary implementation

            return await this._financeNewsPortalDbcontext.NewsArticleTags.ToListAsync();
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

                if (newsArticleViewModel.Tags != null)
                {
                    List<NewsArticleType> newsArticleTypesToRemove = await this._financeNewsPortalDbcontext.NewsArticleTypes
                        .Where(n => n.NewsArticleId == newsArticleToBeUpdated.Id).ToListAsync();

                    this._financeNewsPortalDbcontext.NewsArticleTypes.RemoveRange(newsArticleTypesToRemove);

                    List<NewsArticleType> newsArticleTypes = new List<NewsArticleType>();

                    foreach (var tag in newsArticleViewModel.Tags)
                    {
                        newsArticleTypes.Add(
                            new NewsArticleType
                            {
                                NewsArticleTagId = tag
                            });
                    }

                    newsArticleToBeUpdated.NewsArticleTypes = newsArticleTypes;
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
