using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.Contracts;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinanceNewsPortal.Web.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministratorController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IAdminRepository _adminRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdministratorController(IAdminRepository adminRepository, 
                                        IUserRepository userRepository,
                                        UserManager<ApplicationUser> userManager,
                                        SignInManager<ApplicationUser> signInManager,
                                        RoleManager<IdentityRole> roleManager)
        {
            this._adminRepository = adminRepository;
            this._userRepository = userRepository;
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers(int? pageNumber)
        {
            int pageSize = 4;

            ApplicationUser user = await this._userRepository.GetCurrentUser();
            List<UserWithRoleViewModel> users = await _adminRepository.GetAllUsersExcept(Guid.Parse(user.Id), pageNumber ?? 1, pageSize);

            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid userId)
        {
            ApplicationUser user = await this._adminRepository.GetUserById(userId);

            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> ToggleAccountStatus(Guid userId)
        {
            await this._adminRepository.ToggleUserAccountStatus(userId);

            return RedirectToAction("GetAllUsers");
        }

        [HttpGet]
        public async Task<IActionResult> CreateModerator()
        {
            List<object> genderList = new List<object> { new { Id = 'M', Name = "Male" }, new { Id = 'F', Name = "Female" }, };

            ViewData["GenderList"] = new SelectList(genderList, "Id", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateModerator(RegisterUserViewModel moderatorUser)
        {
            if (ModelState.IsValid)
            {
                var userModel = new ApplicationUser
                {
                    UserName = moderatorUser.Email,
                    Email = moderatorUser.Email,
                    FirstName = moderatorUser.FirstName,
                    LastName = moderatorUser.LastName,
                    Gender = moderatorUser.Gender,
                    Status = true
                };

                var result = await this._userManager.CreateAsync(userModel, moderatorUser.Password);

                if (result.Succeeded)
                {
                    bool roleExist = await this._roleManager.RoleExistsAsync(UserRole.Moderator);

                    if (!roleExist)
                    {
                        await this._roleManager.CreateAsync(new IdentityRole(UserRole.Moderator));
                    }

                    var roleResult = await this._userManager.AddToRoleAsync(userModel, UserRole.Moderator);

                    if (!roleResult.Succeeded)
                    {
                        ModelState.AddModelError(String.Empty, "User Role cannot be assigned.");
                    }

                    return RedirectToAction("GetAllUsers", "Administrator");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                }
            }

            List<object> genderList = new List<object> { new { Id = 'M', Name = "Male" }, new { Id = 'F', Name = "Female" }, };
            ViewData["GenderList"] = new SelectList(genderList, "Id", "Name");
            return View(moderatorUser);
        }
    }
}
