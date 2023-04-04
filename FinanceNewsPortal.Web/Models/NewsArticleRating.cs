using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace FinanceNewsPortal.Web.Models
{
    public class NewsArticleRating
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public float Rating { get; set; }

        public Guid NewsArticleId { get; set; }

        [ValidateNever]
        public NewsArticle NewsArticle { get; set; }
    }
}
