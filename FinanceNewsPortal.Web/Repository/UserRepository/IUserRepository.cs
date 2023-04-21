using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.ViewModels;

namespace FinanceNewsPortal.Web.Repository.UserRepository
{
    public interface IUserRepository
    {
        Task<UserWithRoleViewModel> GetCurrentUser();
    }
}
