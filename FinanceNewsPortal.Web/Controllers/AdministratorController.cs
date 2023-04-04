using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceNewsPortal.Web.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministratorController: Controller 
    {
        private readonly IUserRepository _userRepository;
        private readonly IAdminRepository _adminRepository;

        public AdministratorController(IAdminRepository adminRepository, IUserRepository userRepository)
        {
            this._adminRepository = adminRepository;
            this._userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            ApplicationUser user = await this._userRepository.GetCurrentUser();
            List<ApplicationUser> users = await _adminRepository.GetAllUsersExcept(Guid.Parse(user.Id));

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
    }
}
