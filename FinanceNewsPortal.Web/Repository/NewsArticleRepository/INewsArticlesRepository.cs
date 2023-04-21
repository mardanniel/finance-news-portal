using FinanceNewsPortal.Web.Enums;
using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.ViewModels;

namespace FinanceNewsPortal.Web.Repository.NewsArticleRepository
{
    public interface INewsArticlesRepository
    {
        Task<List<NewsArticle>> GetNewsArticles(int pageNumber, int pageSize, Guid? newsArticleTagId);
        Task<NewsArticle> GetNewsArticleById(Guid newsArticleId);
        Task<List<NewsArticle>> GetNewsArticlesByUserId(Guid userId, int pageNumber, int pageSize, NewsStatus newsArticleStatus, Guid? newsArticleTagId);
        Task<List<NewsArticle>> GetNewsArticleByStatus(Guid? excludeUserId, NewsStatus newsStatus, int pageNumber, int pageSize, Guid? newsArticleTagId);
        Task CreateNewsArticle(NewsArticle newsArticle);
        Task UpdateNewsArticle(Guid newsArticleId, UpsertNewsArticleViewModel newsArticleViewModel);
        Task DeleteNewsArticle(Guid newsArticleId);
        Task UpdateNewsArticleStatus(Guid newsArticleId, NewsStatus status);
        Task<List<NewsArticle>> GetLatestNewsArticles(int count);
        Task<NewsArticle> GetNewsArticleImageFilePathById(Guid newsArticleId, Guid userId);
        Task<List<NewsArticleTag>> GetNewsArticleTags();
        Task CreateNewsArticleTag(NewsArticleTag newsArticleTag);
        Task DeleteNewsArticleTag(Guid newsArticleTagId);
    }
}