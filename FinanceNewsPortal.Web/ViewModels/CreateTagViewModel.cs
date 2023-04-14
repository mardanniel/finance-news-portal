using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinanceNewsPortal.Web.ViewModels
{
    public class CreateTagViewModel
    {
        [DisplayName("Tag Name")]
        [Required]
        public string TagName { get; set; }
    }
}