using FinanceNewsPortal.Web.Models;

namespace FinanceNewsPortal.Web.Repository.CompanyRepository
{
    public interface ICompanyRepository
    {
        Task<List<Company>> GetAllCompanies();
        Task<Company> CreateCompany(Company company);
        Task<Company> GetCompanyById(Guid companyId);
        Task<Company> UpdateCompany(Guid companyId, Company company);
    }
}
