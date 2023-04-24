using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.ViewModels;

namespace FinanceNewsPortal.Web.Repository.NewsArticleTagsRepository
{
    public interface INewsArticleTagsRepository
    {
        Task<List<NewsArticleTag>> GetNewsArticleTags();
        Task<List<NewsArticleTag>> GetNewsArticleTags(int pageNumber, int pageSize);
        Task CreateNewsArticleTag(NewsArticleTag newsArticleTag);
        Task DeleteNewsArticleTag(Guid newsArticleTagId);
        Task<NewsArticleTag> GetNewsArticleTagById(Guid newsArticleTagId);
        Task UpdateNewsArticleTag(Guid newsArticleTagId, UpdateNewsArticleTagViewModel newsArticleTag);
    }
}
