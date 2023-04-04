using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.Contracts;
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

        public async Task<ApplicationUser> GetCurrentUser()
        {
            return await this._userManager.GetUserAsync(this._signInManager.Context.User);
        }
    }
}
