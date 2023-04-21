using FinanceNewsPortal.Web.Data;
using FinanceNewsPortal.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceNewsPortal.Web.Repository.CompanyRepository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly FinanceNewsPortalDbContext _financeNewsPortalDbContext;

        public CompanyRepository(FinanceNewsPortalDbContext financeNewsPortalDbContext)
        {
            this._financeNewsPortalDbContext = financeNewsPortalDbContext;
        }

        public async Task<Company> CreateCompany(Company company)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Company>> GetAllCompanies()
        {
            return await this._financeNewsPortalDbContext.Company
                .ToListAsync();
        }

        public async Task<Company?> GetCompanyById(Guid companyId)
        {
            if (companyId == null) return null;

            return await this._financeNewsPortalDbContext.Company
                .Where(c => c.Id == companyId)
                .FirstOrDefaultAsync();
        }

        public async Task<Company> UpdateCompany(Guid companyId, Company company)
        {
            throw new NotImplementedException();
        }
    }
}
