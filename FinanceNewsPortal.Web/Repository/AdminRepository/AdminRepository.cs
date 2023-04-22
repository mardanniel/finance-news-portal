using FinanceNewsPortal.Web.Data;
using FinanceNewsPortal.Web.Helper;
using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FinanceNewsPortal.Web.Repository.AdminRepository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly FinanceNewsPortalDbContext _financeNewsPortalDbContext;

        public AdminRepository(UserManager<ApplicationUser> userManager,
                                FinanceNewsPortalDbContext financeNewsPortalDbContext)
        {
            _userManager = userManager;
            _financeNewsPortalDbContext = financeNewsPortalDbContext;
        }

        public async Task<List<ApplicationUser>> GetAllUsers()
        {
            List<ApplicationUser> users = await _userManager.Users.ToListAsync();

            return users;
        }

        public async Task<List<UserWithRoleViewModel>> GetAllUsersExcept(Guid excludedUserId, int pageNumber, int pageSize)
        {
            var usersQuery = _userManager.Users
                .Join(_financeNewsPortalDbContext.UserRoles, u => u.Id, ur => ur.UserId, (u, ur) => new { u, ur })
                .Join(_financeNewsPortalDbContext.Roles, ur => ur.ur.RoleId, r => r.Id, (ur, r) => new { ur, r })
                .Select(c => new UserWithRoleViewModel
                {
                    Id = c.ur.u.Id,
                    FirstName = c.ur.u.FirstName,
                    LastName = c.ur.u.LastName,
                    Email = c.ur.u.Email,
                    Gender = c.ur.u.Gender,
                    Status = c.ur.u.Status,
                    Role = c.r.Name
                })
                .Where(u => u.Id != excludedUserId.ToString());

            return await PaginatedList<UserWithRoleViewModel>.CreateAsync(usersQuery, pageNumber, pageSize);
        }

        public async Task<UserWithRoleViewModel> GetUserById(Guid userId)
        {
            ApplicationUser user = await _userManager.Users
                .Include(u => u.Company)
                .FirstOrDefaultAsync(u => u.Id == userId.ToString());
            List<string> roles = (List<string>)await _userManager.GetRolesAsync(user);
            UserWithRoleViewModel userWithRole = new UserWithRoleViewModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Gender = user.Gender,
                Status = user.Status,
                Role = string.Join(", ", roles),
                Company = user.Company,
            };
            return userWithRole;
        }

        public async Task<bool> ToggleUserAccountStatus(Guid userId, Guid companyId)
        {
            ApplicationUser user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId.ToString() && u.CompanyId == companyId);

            user.Status = !user.Status;

            var result = await _userManager.UpdateAsync(user);

            return result.Succeeded;
        }
    }
}
