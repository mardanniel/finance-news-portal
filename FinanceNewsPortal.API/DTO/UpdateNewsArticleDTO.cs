using FinanceNewsPortal.API.Validations;
using System.ComponentModel.DataAnnotations;

namespace FinanceNewsPortal.API.DTO
{
    public class UpdateNewsArticleDTO
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Context { get; set; }

        [DataType(DataType.Upload)]
        [MaxFileSize(2 * 1024 * 1024)]
        [AllowFileExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile? Image { get; set; }
    }
}