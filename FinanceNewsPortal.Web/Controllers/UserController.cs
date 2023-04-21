using FinanceNewsPortal.Web.Repository.UserRepository;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceNewsPortal.Web.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public async Task<IActionResult> Profile()
        {
            UserWithRoleViewModel currentUser = await this._userRepository.GetCurrentUser();

            return View(currentUser);
        }
    }
}
