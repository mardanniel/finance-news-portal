using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;

namespace FinanceNewsPortal.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        public char Gender { get; set; }

        [DisplayName("Account Status")]
        public bool Status { get; set; }

        [ValidateNever]
        public ICollection<NewsArticle> NewsArticles { get; set; }
    }
}
