using System.ComponentModel.DataAnnotations;
using FinanceNewsPortal.Web.Validations;

namespace FinanceNewsPortal.Web.ViewModels
{
    public class UpdateProfileImage
    {
        [DataType(DataType.Upload)]
        [MaxFileSize(2 * 1024 * 1024)]
        [AllowFileExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile? Image { get; set; }

        public string? ImageFilePath { get; set; }
    }
}