using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FinanceNewsPortal.API.DTO
{
    public class RegisterUserDTO
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirm password doesnt match")]
        public string ConfirmPassword { get; set; }

        [Required]
        public char Gender { get; set; }
    }
}
