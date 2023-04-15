using FinanceNewsPortal.API.DTO;
using FinanceNewsPortal.API.Models;

namespace FinanceNewsPortal.API.Repository.Contracts
{
    public interface IAdminRepository
    {
        Task<List<ApplicationUser>> GetAllUsers();
        Task<List<UserWithRoleDTO>> GetAllUsersExcept(Guid excludedUserId, int pageNumber, int pageSize);
    }
}