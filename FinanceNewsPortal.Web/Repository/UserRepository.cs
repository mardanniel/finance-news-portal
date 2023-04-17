using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.Contracts;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace FinanceNewsPortal.Web.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserRepository(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager)
        {
            this._userManager = _userManager;
            this._signInManager = _signInManager;
        }

        public async Task<UserWithRoleViewModel> GetCurrentUser()
        {
            ApplicationUser user = await this._userManager.GetUserAsync(this._signInManager.Context.User);
            List<string> roles = (List<string>)await this._userManager.GetRolesAsync(user);
            UserWithRoleViewModel userWithRole = new UserWithRoleViewModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Gender = user.Gender,
                Status = user.Status,
                Role = string.Join(", ", roles)
            };
            return userWithRole;
        }
    }
}
