using FinanceNewsPortal.Web.Helper;
using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.Contracts;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FinanceNewsPortal.Web.Repository
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

        public async Task<List<UserWithRoleViewModel>> GetAllUsersExcept(Guid excludedUserId, int pageNumber, int pageSize)
        {
            // TODO: Change implementation, still causes error
            // https://go.microsoft.com/fwlink/?linkid=2097913

            var usersQuery = this._userManager.Users
                .Select(u => new UserWithRoleViewModel
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email,
                    Gender = u.Gender,
                    Status = u.Status
                })
                .Where(u => u.Id != excludedUserId.ToString());

            return await PaginatedList<UserWithRoleViewModel>.CreateAsync(usersQuery, pageNumber, pageSize);
        }

        public async Task<ApplicationUser> GetUserById(Guid userId)
        {
            ApplicationUser user = await this._userManager.Users.FirstOrDefaultAsync(u => u.Id == userId.ToString());

            return user;
        }

        public async Task<bool> ToggleUserAccountStatus(Guid userId)
        {
            ApplicationUser user = await this._userManager.Users.FirstOrDefaultAsync(u => u.Id == userId.ToString());

            user.Status = !user.Status;

            var result = await this._userManager.UpdateAsync(user);

            return result.Succeeded;
        }
    }
}
