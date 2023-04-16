using FinanceNewsPortal.Web.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceNewsPortal.Web.Models
{
    public class NewsArticle
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public NewsStatus Status { get; set; }

        public string? ImageFilePath { get; set; }

        public string ApplicationUserId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MMMM dd, yyyy}")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ValidateNever]
        public ApplicationUser Author { get; set; }

        [ValidateNever]
        public ICollection<NewsArticleType> NewsArticleTypes { get; set; }

        [ValidateNever]
        public NewsArticleRating NewsArticleRating { get; set; }
    }
}
