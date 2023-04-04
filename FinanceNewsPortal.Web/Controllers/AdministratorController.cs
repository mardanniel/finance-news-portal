using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceNewsPortal.Web.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministratorController: Controller 
    {
        private readonly IAdminRepository _adminRepository;

        public AdministratorController(IAdminRepository adminRepository)
        {
            this._adminRepository = adminRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            List<ApplicationUser> users = await _adminRepository.GetAllUsers();

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
