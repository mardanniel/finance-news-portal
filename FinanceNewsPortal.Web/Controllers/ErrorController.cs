using Microsoft.AspNetCore.Mvc;

namespace FinanceNewsPortal.Web.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult AccessDenied()
        {
            return Problem();
        }

        public IActionResult NotFound()
        {
            return View();
        }

        public IActionResult Unauthorized()
        {
            return View();
        }
    }
}
