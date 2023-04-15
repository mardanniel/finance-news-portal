using FinanceNewsPortal.API.Models;

namespace FinanceNewsPortal.API.Repository.Contracts
{
    public interface IUserRepository
    {
        Task<ApplicationUser> GetCurrentUser();
    }
}