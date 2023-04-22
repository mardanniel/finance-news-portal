using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.AdminRepository;
using FinanceNewsPortal.Web.Repository.CompanyRepository;
using FinanceNewsPortal.Web.Repository.UserRepository;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FinanceNewsPortal.Web.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministratorController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IAdminRepository _adminRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdministratorController(IAdminRepository adminRepository, 
                                        IUserRepository userRepository,
                                        ICompanyRepository companyRepository,
                                        UserManager<ApplicationUser> userManager,
                                        SignInManager<ApplicationUser> signInManager,
                                        RoleManager<IdentityRole> roleManager)
        {
            this._adminRepository = adminRepository;
            this._userRepository = userRepository;
            this._companyRepository = companyRepository;
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers(int? pageNumber)
        {
            int pageSize = 4;

            UserWithRoleViewModel user = await this._userRepository.GetCurrentUser();
            List<UserWithRoleViewModel> users = await _adminRepository.GetAllUsersExcept(Guid.Parse(user.Id), pageNumber ?? 1, pageSize);

            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid userId)
        {
            UserWithRoleViewModel user = await this._adminRepository.GetUserById(userId);

            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> ToggleAccountStatus(Guid userId, Guid companyId)
        {
            await this._adminRepository.ToggleUserAccountStatus(userId, companyId);

            return RedirectToAction("GetStaffs", "Company", new { companyId = companyId });
        }

        [HttpGet]
        public async Task<IActionResult> CreateUser()
        {
            List<object> genderList = new List<object> 
            { 
                new { Id = 'M', Name = "Male" }, 
                new { Id = 'F', Name = "Female" }, 
            };

            List<IdentityRole> roleList = await this._roleManager.Roles
                .Where(r => r.Name != UserRole.Administrator)
                .ToListAsync();

            List<Company> companies = await this._companyRepository.GetAllCompanies();

            ViewData["GenderList"] = new SelectList(genderList, "Id", "Name");
            ViewData["RoleList"] = new SelectList(roleList, "Id", "Name");
            ViewData["CompanyList"] = new SelectList(companies, "Id", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(RegisterUserViewModel user)
        {
            if (ModelState.IsValid)
            {
                var userModel = new ApplicationUser
                {
                    UserName = user.Email,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Gender = user.Gender,
                    Status = true,
                    CompanyId = user.Company
                };

                var result = await this._userManager.CreateAsync(userModel, user.Password);

                if (result.Succeeded)
                {
                    var role = await this._roleManager.Roles.Where(r => r.Id == user.Role).FirstOrDefaultAsync();

                    if(role == null)
                    {
                        ModelState.AddModelError(String.Empty, "Role doesn't exist. Please try again.");

                        return View(user);
                    }

                    var roleResult = await this._userManager.AddToRoleAsync(userModel, role.Name);

                    if (!roleResult.Succeeded)
                    {
                        ModelState.AddModelError(String.Empty, "User Role cannot be assigned.");
                    }

                    return RedirectToAction("GetStaffs", "Company", new { companyId = user.Company });
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                }
            }

            List<object> genderList = new List<object> 
            { 
                new { Id = 'M', Name = "Male" }, 
                new { Id = 'F', Name = "Female" }, 
            };

            List<IdentityRole> roleList = await this._roleManager.Roles
                .Where(r => r.Name != UserRole.Administrator)
                .ToListAsync();

            ViewData["GenderList"] = new SelectList(genderList, "Id", "Name");
            ViewData["RoleList"] = new SelectList(roleList, "Id", "");

            return View(user);
        }
    }
}
