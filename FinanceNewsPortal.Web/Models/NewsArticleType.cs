using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace FinanceNewsPortal.Web.Models
{
    public class NewsArticleType
    {
        public Guid Id { get; set; }

        public Guid NewsArticleTagId { get; set; }

        [ValidateNever]
        public NewsArticleTag NewsArticleTag { get; set; }

        public Guid NewsArticleId { get; set; }

        [ValidateNever]
        public NewsArticle NewsArticle { get; set; }
    }
}
