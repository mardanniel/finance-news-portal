using FinanceNewsPortal.Web.Data;
using FinanceNewsPortal.Web.Helper;
using FinanceNewsPortal.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceNewsPortal.Web.Repository.NewsArticleTagsRepository
{
    public class NewsArticleTagsRepository : INewsArticleTagsRepository
    {
        private readonly FinanceNewsPortalDbContext _financeNewsPortalDbcontext;

        public NewsArticleTagsRepository(FinanceNewsPortalDbContext financeNewsPortalDbcontext)
        {
            this._financeNewsPortalDbcontext = financeNewsPortalDbcontext;
        }

        public async Task CreateNewsArticleTag(NewsArticleTag newsArticleTag)
        {
            await this._financeNewsPortalDbcontext.NewsArticleTags.AddAsync(newsArticleTag);

            await this._financeNewsPortalDbcontext.SaveChangesAsync();
        }

        public async Task DeleteNewsArticleTag(Guid newsArticleTagId)
        {
            var newsArticleTag = await this._financeNewsPortalDbcontext.NewsArticleTags.FindAsync(newsArticleTagId);

            if (newsArticleTag != null)
            {
                this._financeNewsPortalDbcontext.NewsArticleTags.Remove(newsArticleTag);
            }

            await this._financeNewsPortalDbcontext.SaveChangesAsync();
        }

        public async Task<List<NewsArticleTag>> GetNewsArticleTags()
        {
            return await this._financeNewsPortalDbcontext.NewsArticleTags.ToListAsync();
        }

        public async Task<List<NewsArticleTag>> GetNewsArticleTags(int pageNumber, int pageSize)
        {
            var newsArticleTagsQuery = this._financeNewsPortalDbcontext.NewsArticleTags
                .AsQueryable();

            return await PaginatedList<NewsArticleTag>.CreateAsync(newsArticleTagsQuery, pageNumber, pageSize);
        }
    }
}
