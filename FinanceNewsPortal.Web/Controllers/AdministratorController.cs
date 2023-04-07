using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.Contracts;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceNewsPortal.Web.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministratorController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IAdminRepository _adminRepository;

        public AdministratorController(IAdminRepository adminRepository, IUserRepository userRepository)
        {
            this._adminRepository = adminRepository;
            this._userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers(int? pageNumber)
        {
            int pageSize = 10;

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
    }
}
