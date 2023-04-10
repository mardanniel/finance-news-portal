using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FinanceNewsPortal.API.DTO
{
    public class LoginUserDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
