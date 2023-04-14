using FinanceNewsPortal.API.DTO;
using FinanceNewsPortal.API.Helper;
using FinanceNewsPortal.API.Models;
using FinanceNewsPortal.API.Repository.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FinanceNewsPortal.API.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminRepository(UserManager<ApplicationUser> userManager)
        {
            this._userManager = userManager;
        }

        public async Task<List<ApplicationUser>> GetAllUsers()
        {
            List<ApplicationUser> users = await this._userManager.Users.ToListAsync();

            return users;
        }

        public async Task<List<UserWithRoleDTO>> GetAllUsersExcept(Guid excludedUserId, int pageNumber, int pageSize)
        {
            var usersQuery = this._userManager.Users
                .Select(u => new UserWithRoleDTO
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email,
                    Gender = u.Gender,
                    Status = u.Status
                })
                .Where(u => u.Id != excludedUserId.ToString());

            return await PaginatedList<UserWithRoleDTO>.CreateAsync(usersQuery, pageNumber, pageSize);
        }
    }
}