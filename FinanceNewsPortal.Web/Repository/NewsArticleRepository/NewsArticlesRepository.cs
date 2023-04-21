using FinanceNewsPortal.Web.Data;
using FinanceNewsPortal.Web.Enums;
using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.ViewModels;
using FinanceNewsPortal.Web.Helper;
using Microsoft.EntityFrameworkCore;

namespace FinanceNewsPortal.Web.Repository.NewsArticleRepository
{
    public class NewsArticlesRepository : INewsArticlesRepository
    {
        private readonly FinanceNewsPortalDbContext _financeNewsPortalDbcontext;

        public NewsArticlesRepository(FinanceNewsPortalDbContext financeNewsPortalDbContext)
        {
            _financeNewsPortalDbcontext = financeNewsPortalDbContext;
        }

        public async Task CreateNewsArticle(NewsArticle newsArticle)
        {
            await _financeNewsPortalDbcontext.AddAsync<NewsArticle>(newsArticle);

            await _financeNewsPortalDbcontext.SaveChangesAsync();
        }

        public async Task CreateNewsArticleTag(NewsArticleTag newsArticleTag)
        {
            await _financeNewsPortalDbcontext.NewsArticleTags.AddAsync(newsArticleTag);

            await _financeNewsPortalDbcontext.SaveChangesAsync();
        }

        public async Task DeleteNewsArticle(Guid newsArticleId)
        {
            var news = await _financeNewsPortalDbcontext.NewsArticle.FindAsync(newsArticleId);

            if (news != null)
            {
                _financeNewsPortalDbcontext.NewsArticle.Remove(news);
            }

            await _financeNewsPortalDbcontext.SaveChangesAsync();
        }

        public async Task DeleteNewsArticleTag(Guid newsArticleTagId)
        {
            var newsArticleTag = await _financeNewsPortalDbcontext.NewsArticleTags.FindAsync(newsArticleTagId);

            if (newsArticleTag != null)
            {
                _financeNewsPortalDbcontext.NewsArticleTags.Remove(newsArticleTag);
            }

            await _financeNewsPortalDbcontext.SaveChangesAsync();
        }

        public async Task<List<NewsArticle>> GetLatestNewsArticles(int count)
        {
            return await _financeNewsPortalDbcontext.NewsArticle
                .Include(n => n.Author)
                .Include("NewsArticleTypes.NewsArticleTag")
                .Where(n => n.Status == NewsStatus.Approved)
                .OrderByDescending(n => n.CreatedAt)
                .Take(count)
                .ToListAsync();
        }

        public async Task<NewsArticle?> GetNewsArticleById(Guid newsArticleId)
        {
            NewsArticle news = await _financeNewsPortalDbcontext.NewsArticle
                .Include(n => n.Author)
                .Include("NewsArticleTypes.NewsArticleTag")
                .FirstOrDefaultAsync(n => n.Id == newsArticleId);

            return news;
        }

        public async Task<List<NewsArticle>> GetNewsArticleByStatus(Guid? excludeUserId, NewsStatus newsStatus, int pageNumber, int pageSize, Guid? newsArticleTagId)
        {
            var newsArticleQuery = _financeNewsPortalDbcontext.NewsArticle
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
            return await _financeNewsPortalDbcontext.NewsArticle
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
            var newsArticleQuery = _financeNewsPortalDbcontext.NewsArticle
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
                    NewsArticleTypes = news.NewsArticleTypes,
                    CreatedAt = news.CreatedAt
                });

            if (newsArticleTagId != null && newsArticleTagId != Guid.Empty)
            {
                newsArticleQuery = newsArticleQuery
                    .Where(news => news.NewsArticleTypes
                        .Where(n => n.NewsArticleTagId == newsArticleTagId).Count() > 0);
            }

            return await PaginatedList<NewsArticle>.CreateAsync(newsArticleQuery, pageNumber, pageSize);
        }

        public async Task<List<NewsArticle>> GetNewsArticlesByUserId(Guid userId, int pageNumber, int pageSize, NewsStatus newsArticleStatus, Guid? newsArticleTagId)
        {
            var newsArticleQuery = _financeNewsPortalDbcontext.NewsArticle
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
                    NewsArticleTypes = news.NewsArticleTypes,
                    CreatedAt = news.CreatedAt
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

            return await _financeNewsPortalDbcontext.NewsArticleTags.ToListAsync();
        }

        public async Task UpdateNewsArticle(Guid newsArticleId, UpsertNewsArticleViewModel newsArticleViewModel)
        {
            NewsArticle newsArticleToBeUpdated = await GetNewsArticleById(newsArticleId);

            if (newsArticleToBeUpdated != null)
            {
                if (newsArticleViewModel.ImageFilePath != null)
                {
                    newsArticleToBeUpdated.ImageFilePath = newsArticleViewModel.ImageFilePath;
                }

                if (newsArticleViewModel.Tags != null)
                {
                    List<NewsArticleType> newsArticleTypesToRemove = await _financeNewsPortalDbcontext.NewsArticleTypes
                        .Where(n => n.NewsArticleId == newsArticleToBeUpdated.Id).ToListAsync();

                    _financeNewsPortalDbcontext.NewsArticleTypes.RemoveRange(newsArticleTypesToRemove);

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

                if (newsArticleViewModel.Status != null)
                {
                    newsArticleToBeUpdated.Status = (NewsStatus)newsArticleViewModel.Status;
                }

                if (newsArticleViewModel.VerdictMessage != null)
                {
                    newsArticleToBeUpdated.VerdictMessage = newsArticleViewModel.VerdictMessage;
                }

                newsArticleToBeUpdated.Title = newsArticleViewModel.Title;
                newsArticleToBeUpdated.Description = newsArticleViewModel.Context;

                _financeNewsPortalDbcontext.Update(newsArticleToBeUpdated);
            }

            await _financeNewsPortalDbcontext.SaveChangesAsync();
        }

        public async Task UpdateNewsArticleStatus(Guid newsArticleId, NewsStatus status)
        {
            NewsArticle newsArticleToBeUpdated = await GetNewsArticleById(newsArticleId);

            if (newsArticleToBeUpdated != null)
            {
                newsArticleToBeUpdated.Status = status;

                _financeNewsPortalDbcontext.Update(newsArticleToBeUpdated);
            }

            await _financeNewsPortalDbcontext.SaveChangesAsync();
        }
    }
}
