using System.ComponentModel.DataAnnotations;

namespace FinanceNewsPortal.Web.ViewModels
{
    public class UpsertNewsArticleViewModel
    {
        public Guid? Id { get; set; }

        public Guid? Author { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Context { get; set; }
    }
}