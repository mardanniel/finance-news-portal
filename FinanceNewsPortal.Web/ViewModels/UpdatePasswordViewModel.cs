using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinanceNewsPortal.Web.ViewModels
{
    public class UpdatePasswordViewModel
    {
        [DisplayName("Current Password")]
        [Required]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [DisplayName("New Password")]
        [Required]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [DisplayName("Confirm New Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; }
    }
}