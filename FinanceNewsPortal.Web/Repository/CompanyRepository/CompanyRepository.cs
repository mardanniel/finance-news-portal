using FinanceNewsPortal.Web.Data;
using FinanceNewsPortal.Web.Helper;
using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FinanceNewsPortal.Web.Repository.CompanyRepository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly FinanceNewsPortalDbContext _financeNewsPortalDbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public CompanyRepository(FinanceNewsPortalDbContext financeNewsPortalDbContext,
                                    UserManager<ApplicationUser> userManager)
        {
            this._financeNewsPortalDbContext = financeNewsPortalDbContext;
            this._userManager = userManager;
        }

        public async Task CreateCompany(Company company)
        {
            await this._financeNewsPortalDbContext.Company.AddAsync(company);

            await this._financeNewsPortalDbContext.SaveChangesAsync();
        }

        public async Task<List<Company>> GetAllCompanies()
        {
            return await this._financeNewsPortalDbContext.Company
                .ToListAsync();
        }

        public async Task<List<Company>> GetAllCompanies(int pageNumber, int pageSize)
        {
            var companiesQuery = this._financeNewsPortalDbContext.Company
                .AsQueryable();

            return await PaginatedList<Company>.CreateAsync(companiesQuery, pageNumber, pageSize);
        }

        public async Task<Company?> GetCompanyById(Guid companyId)
        {
            return await this._financeNewsPortalDbContext.Company
                .Where(c => c.Id == companyId)
                .FirstOrDefaultAsync();
        }

        public async Task<PaginatedList<UserWithRoleViewModel>> GetCompanyStaffs(Guid companyId, int pageNumber, int pageSize)
        {
            var companyStaffQuery = this._userManager.Users
                .Where(u => u.CompanyId == companyId)
                .Include(u => u.Company)
                .Join(this._financeNewsPortalDbContext.UserRoles, u => u.Id, ur => ur.UserId, (u, ur) => new { u, ur })
                .Join(this._financeNewsPortalDbContext.Roles, ur => ur.ur.RoleId, r => r.Id, (ur, r) => new { ur, r })
                .Select(c => new UserWithRoleViewModel
                {
                    Id = c.ur.u.Id,
                    FirstName = c.ur.u.FirstName,
                    LastName = c.ur.u.LastName,
                    Email = c.ur.u.Email,
                    Gender = c.ur.u.Gender,
                    Status = c.ur.u.Status,
                    Company = c.ur.u.Company,
                    CompanyId = (Guid)c.ur.u.CompanyId,
                    Role = c.r.Name,
                });

            return await PaginatedList<UserWithRoleViewModel>.CreateAsync(companyStaffQuery, pageNumber, pageSize);
        }

        public async Task UpdateCompany(Guid companyId, UpsertCompanyViewModel companyViewModel)
        {
            Company companyToBeUpdated = await this.GetCompanyById(companyId);

            if(companyToBeUpdated == null) return;

            companyToBeUpdated.Name = companyViewModel.Name;
            companyToBeUpdated.Address = companyViewModel.Address;
            companyToBeUpdated.FoundedAt = companyViewModel.FoundedAt;

            this._financeNewsPortalDbContext.Update(companyToBeUpdated);

            await this._financeNewsPortalDbContext.SaveChangesAsync();
        }
    }
}
