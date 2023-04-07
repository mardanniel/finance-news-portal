using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FinanceNewsPortal.Web.Validations;

namespace FinanceNewsPortal.Web.ViewModels
{
    public class UpdateUserInfoViewModel
    {
        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }

        [DataType(DataType.Upload)]
        [MaxFileSize(2 * 1024 * 1024)]
        [AllowFileExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile? Image { get; set; }

        public string? ImageFilePath { get; set; }
    }
}