using FinanceNewsPortal.API.DTO;
using FinanceNewsPortal.API.Enums;
using FinanceNewsPortal.API.Models;

namespace FinanceNewsPortal.API.Repository.Contracts
{
    public interface INewsArticlesRepository
    {
        Task<List<NewsArticle>> GetNewsArticles(int pageNumber, int pageSize);
        Task<NewsArticle> GetNewsArticleById(Guid newsArticleId);
        Task<List<NewsArticle>> GetNewsArticlesByUserId(Guid userId, int pageNumber, int pageSize, NewsStatus newsArticleStatus);
        Task<List<NewsArticle>> GetNewsArticleByStatus(Guid? excludeUserId, NewsStatus newsStatus, int pageNumber, int pageSize);
        Task CreateNewsArticle(NewsArticle newsArticle);
        Task UpdateNewsArticle(Guid newsArticleId, UpsertNewsArticleDTO newsArticleDTO);
        Task DeleteNewsArticle(Guid newsArticleId);
        Task UpdateNewsArticleStatus(Guid newsArticleId, NewsStatus status);
        Task<List<NewsArticle>> GetLatestNewsArticles(int count);
        Task<NewsArticle> GetNewsArticleImageFilePathById(Guid newsArticleId, Guid userId);
        Task<List<NewsArticleTag>> GetNewsArticleTags();
    }
}