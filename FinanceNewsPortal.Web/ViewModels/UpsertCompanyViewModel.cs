using System.ComponentModel.DataAnnotations;

namespace FinanceNewsPortal.Web.ViewModels
{
    public class UpsertCompanyViewModel
    {
        public Guid? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime FoundedAt { get; set; }
    }
}
