using System.ComponentModel.DataAnnotations;

namespace FinanceNewsPortal.Web.ViewModels
{
    public class UpdateNewsArticleTagViewModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string TagName { get; set; }
    }
}