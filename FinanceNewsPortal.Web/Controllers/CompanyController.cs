using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.CompanyRepository;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UpsertCompanyViewModel companyViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(companyViewModel);
            }

            Company company = new Company
            {
                Name = companyViewModel.Name,
                Address = companyViewModel.Address,
                FoundedAt = companyViewModel.FoundedAt,
            };

            await this._companyRepository.CreateCompany(company);

            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid? companyId)
        {
            if(companyId == null)
            {
                return NotFound();
            }

            Company company = await this._companyRepository.GetCompanyById((Guid)companyId);

            if(company == null)
            {
                return null;
            }

            UpsertCompanyViewModel companyViewModel = new UpsertCompanyViewModel
            {
                Id = company.Id,
                Name = company.Name,
                Address = company.Address,
                FoundedAt = company.FoundedAt
            };

            return View(companyViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpsertCompanyViewModel companyViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(companyViewModel);
            }

            await this._companyRepository.UpdateCompany((Guid)companyViewModel.Id, companyViewModel);

            return RedirectToAction("Details", new { companyId = companyViewModel.Id });
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid? companyId)
        {
            if(companyId == null)
            {
                return NotFound();
            }

            Company company = await this._companyRepository.GetCompanyById((Guid)companyId);

            if(company == null)
            {
                return NotFound();
            }

            CompanyDetailsViewModel companyDetailsViewModel = new CompanyDetailsViewModel
            {
                Id = company.Id,
                Name = company.Name,
                Address = company.Address,
                FoundedAt = company.FoundedAt,
            };

            return View(companyDetailsViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(int? pageNumber)
        {
            int pageSize = 12;

            List<Company> companies = await this._companyRepository.GetAllCompanies(pageNumber ?? 1, pageSize);
            
            return View(companies);
        }

        [HttpGet]
        public async Task<IActionResult> GetStaffs(Guid? companyId, int? pageNumber)
        {
            if(companyId == null)
            {
                return RedirectToAction("GetAll");
            }

            Company company = await this._companyRepository.GetCompanyById((Guid) companyId);

            if(company == null)
            {
                // TODO: Add model error
                return RedirectToAction("GetAll");
            }

            int pageSize = 12;

            ViewData["CompanyId"] = companyId;

            StaffListViewModel staffListViewModel = new StaffListViewModel
            {
                CompanyName = company.Name,
                Staffs = await this._companyRepository.GetCompanyStaffs((Guid)companyId, pageNumber ?? 1, pageSize)
            };
 
            return View(staffListViewModel);
        }
    }
}
