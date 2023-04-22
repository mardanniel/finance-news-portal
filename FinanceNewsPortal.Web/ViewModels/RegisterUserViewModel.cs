using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FinanceNewsPortal.Web.ViewModels
{
    public class RegisterUserViewModel
    {
        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("Email Address")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirm password doesnt match")]
        public string ConfirmPassword { get; set; }

        [Required]
        public char Gender { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public Guid Company { get; set; }
    }
}
