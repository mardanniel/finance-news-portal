using FinanceNewsPortal.Web.Enums;
using FinanceNewsPortal.Web.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinanceNewsPortal.Web.ViewModels
{
    public class PendingNewsArticleVerdict
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public NewsStatus Status { get; set; }

        [ValidateNever]
        public string? ImageFilePath { get; set; }

        [DisplayName("Verdict Message")]
        [Required]
        public string? VerdictMessage { get; set; }

        [ValidateNever]
        public string ApplicationUserId { get; set; }

        [ValidateNever]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MMMM dd, yyyy}")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ValidateNever]
        public ApplicationUser Author { get; set; }

        [ValidateNever]
        public ICollection<NewsArticleType> NewsArticleTypes { get; set; }
    }
}
