using FinanceNewsPortal.Web.Helper;

namespace FinanceNewsPortal.Web.ViewModels
{
    public class StaffListViewModel
    {
        public string CompanyName { get; set; }
        public PaginatedList<UserWithRoleViewModel> Staffs { get; set; }
    }
}
