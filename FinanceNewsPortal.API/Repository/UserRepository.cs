using FinanceNewsPortal.API.Models;
using FinanceNewsPortal.API.Repository.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FinanceNewsPortal.API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _contextAccessor;

        public UserRepository(UserManager<ApplicationUser> _userManager, 
                                IHttpContextAccessor contextAccessor)
        {
            this._userManager = _userManager;
            this._contextAccessor = contextAccessor;
        }

        public async Task<ApplicationUser> GetCurrentUser()
        {
            string userEmail = this._contextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            ApplicationUser applicationUser = await this._userManager.FindByEmailAsync(userEmail);
            return applicationUser;
        }
    }
}