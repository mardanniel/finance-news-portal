using FinanceNewsPortal.Web.Helper;
using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.ViewModels;

namespace FinanceNewsPortal.Web.Repository.CompanyRepository
{
    public interface ICompanyRepository
    {
        Task<List<Company>> GetAllCompanies();
        Task<List<Company>> GetAllCompanies(int pageNumber, int pageSize);
        Task CreateCompany(Company company);
        Task<Company> GetCompanyById(Guid companyId);
        Task UpdateCompany(Guid companyId, UpsertCompanyViewModel company);
        Task<PaginatedList<UserWithRoleViewModel>> GetCompanyStaffs(Guid companyId, int pageNumber, int pageSize);
    }
}
