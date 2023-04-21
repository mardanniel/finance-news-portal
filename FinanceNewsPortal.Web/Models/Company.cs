using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace FinanceNewsPortal.Web.Models
{
    public class Company
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MMMM dd, yyyy}")]
        public DateTime FoundedAt { get; set; }

        [ValidateNever]
        public ICollection<ApplicationUser> Staffs { get; set; }
    }
}
