using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.ViewModels;

namespace FinanceNewsPortal.Web.Repository.Contracts
{
    public interface IUserRepository
    {
        Task<UserWithRoleViewModel> GetCurrentUser();
    }
}
