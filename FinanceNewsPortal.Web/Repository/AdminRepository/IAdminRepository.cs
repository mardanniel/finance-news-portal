using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.ViewModels;

namespace FinanceNewsPortal.Web.Repository.AdminRepository
{
    public interface IAdminRepository
    {
        Task<List<ApplicationUser>> GetAllUsers();
        Task<UserWithRoleViewModel> GetUserById(Guid userId);
        Task<bool> ToggleUserAccountStatus(Guid userId, Guid companyId);
        Task<List<UserWithRoleViewModel>> GetAllUsersExcept(Guid excludedUserId, int pageNumber, int pageSize);
    }
}
