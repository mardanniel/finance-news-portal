using FinanceNewsPortal.Web.Enums;
using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FinanceNewsPortal.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthController(UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager,
                                RoleManager<IdentityRole> roleManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginUserViewModel loginUser)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await this._userManager.Users.FirstOrDefaultAsync(u => u.Email == loginUser.Username);

                if(user != null)
                {
                    if (user.Status == Convert.ToBoolean(UserAccountStatus.Disabled))
                    {
                        ModelState.AddModelError(string.Empty, "Account Disabled. Please contact administrator.");

                        return View(loginUser);
                    }

                    var result = await this._signInManager.PasswordSignInAsync(loginUser.Username,
                    loginUser.Password,
                    loginUser.RememberMe,
                    false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "NewsArticles");
                    }
                }

                ModelState.AddModelError(string.Empty, "Invalid login credentials");
            }

            return View(loginUser);
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            List<object> genderList = new List<object> { new { Id = 'M', Name = "Male" }, new { Id = 'F', Name = "Female" }, };

            ViewData["GenderList"] = new SelectList(genderList, "Id", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel registerUser)
        {
            if (ModelState.IsValid)
            {
                var userModel = new ApplicationUser
                {
                    UserName = registerUser.Email,
                    Email = registerUser.Email,
                    FirstName = registerUser.FirstName,
                    LastName = registerUser.LastName,
                    Gender = registerUser.Gender,
                    Status = true
                };

                var result = await this._userManager.CreateAsync(userModel, registerUser.Password);

                if (result.Succeeded)
                {
                    bool roleExist = await this._roleManager.RoleExistsAsync(UserRole.Registered);

                    if (!roleExist)
                    {
                        await this._roleManager.CreateAsync(new IdentityRole(UserRole.Registered));
                    }

                    var roleResult = await this._userManager.AddToRoleAsync(userModel, UserRole.Registered);

                    if (!roleResult.Succeeded)
                    {
                        ModelState.AddModelError(String.Empty, "User Role cannot be assigned.");
                    }

                    await _signInManager.SignInAsync(userModel, isPersistent: false);

                    return RedirectToAction("Index", "NewsArticles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                }
            }

            List<object> genderList = new List<object> { new { Id = 'M', Name = "Male" }, new { Id = 'F', Name = "Female" }, };
            ViewData["GenderList"] = new SelectList(genderList, "Id", "Name");
            return View(registerUser);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await this._signInManager.SignOutAsync();
            return RedirectToAction("Login", "Auth");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateUserInfo()
        {
            return View();
        }

        [HttpGet]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateUserInfo(UpdateUserInfoViewModel userInfo)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(UpdatePasswordViewModel userPassword)
        {
            return View();
        }
    }
}
