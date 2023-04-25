using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.CompanyRepository;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace FinanceNewsPortal.Web.Repository.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserRepository(ICompanyRepository _companyRepository,
                                UserManager<ApplicationUser> _userManager, 
                                SignInManager<ApplicationUser> _signInManager)
        {
            this._userManager = _userManager;
            this._signInManager = _signInManager;
            this._companyRepository = _companyRepository;
        }

        public async Task<UserWithRoleViewModel> GetCurrentUser()
        {
            ApplicationUser userFromContext = await _userManager.GetUserAsync(_signInManager.Context.User);
            ApplicationUser user = await _userManager.FindByIdAsync(userFromContext.Id);
            List<string> roles = (List<string>)await _userManager.GetRolesAsync(user);
            Company? userCompany = null;

            if(user.CompanyId != null)
            {
                userCompany = await _companyRepository.GetCompanyById((Guid)user.CompanyId);
            }

            UserWithRoleViewModel userWithRole = new UserWithRoleViewModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Gender = user.Gender,
                Status = user.Status,
                ImageFilePath = user.ImageFilePath,
                Role = string.Join(", ", roles),
                Company = userCompany
            };
            return userWithRole;
        }
    }
}
