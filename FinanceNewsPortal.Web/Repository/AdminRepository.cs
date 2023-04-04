using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.Contracts;
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

        public async Task<List<ApplicationUser>> GetAllUsersExcept(Guid excludedUserId)
        {
            return await this._userManager.Users
                .Where(u => u.Id != excludedUserId.ToString())
                .ToListAsync();
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
