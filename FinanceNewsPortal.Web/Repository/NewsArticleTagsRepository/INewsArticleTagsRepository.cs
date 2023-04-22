using FinanceNewsPortal.Web.Models;

namespace FinanceNewsPortal.Web.Repository.NewsArticleTagsRepository
{
    public interface INewsArticleTagsRepository
    {
        Task<List<NewsArticleTag>> GetNewsArticleTags();
        Task<List<NewsArticleTag>> GetNewsArticleTags(int pageNumber, int pageSize);
        Task CreateNewsArticleTag(NewsArticleTag newsArticleTag);
        Task DeleteNewsArticleTag(Guid newsArticleTagId);
    }
}
