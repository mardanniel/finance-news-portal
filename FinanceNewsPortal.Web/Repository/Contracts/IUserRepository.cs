using FinanceNewsPortal.Web.Models;

namespace FinanceNewsPortal.Web.Repository.Contracts
{
    public interface IUserRepository
    {
        Task<ApplicationUser> GetCurrentUser();
    }
}
