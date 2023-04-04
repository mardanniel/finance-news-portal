using FinanceNewsPortal.Web.Models;

namespace FinanceNewsPortal.Web.Repository.Contracts
{
    public interface IAdminRepository
    {
        Task<List<ApplicationUser>> GetAllUsers();
        Task<ApplicationUser> GetUserById(Guid userId);
        Task<bool> ToggleUserAccountStatus(Guid userId);
        Task<List<ApplicationUser>> GetAllUsersExcept(Guid excludedUserId);
    }
}
