using System.ComponentModel.DataAnnotations;
using FinanceNewsPortal.Web.Validations;

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

        [DataType(DataType.Upload)]
        [MaxFileSize(2 * 1024 * 1024)]
        [AllowFileExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile? Image { get; set; }

        public string? ImageFilePath { get; set; }
    }
}