using FinanceNewsPortal.API.DTO;
using FinanceNewsPortal.API.Models;
using FinanceNewsPortal.API.Repository.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinanceNewsPortal.API.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdministratorController : ControllerBase
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

        [HttpGet("AllUsers")]
        public async Task<IActionResult> GetAllUsers(int? pageNumber, int? pageSize)
        {
            ApplicationUser user = await this._userRepository.GetCurrentUser();
            List<UserWithRoleDTO> users = await _adminRepository.GetAllUsersExcept(Guid.Parse(user.Id), pageNumber ?? 1, pageSize ?? 10);

            return Ok(users);
        }
    }
}