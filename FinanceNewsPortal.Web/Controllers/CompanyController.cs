using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.CompanyRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceNewsPortal.Web.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            this._companyRepository = companyRepository;
        }

        [HttpGet]
        public async Task<IActionResult> CreateCompany()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany(Company company)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            List<Company> companies = await this._companyRepository.GetAllCompanies();
            return View(companies);
        }
    }
}
