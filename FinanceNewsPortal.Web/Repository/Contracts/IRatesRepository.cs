using FinanceNewsPortal.Web.Models;

namespace FinanceNewsPortal.Web.Repository.Contracts
{
    public interface IRatesRepository
    {
        Task<Currency> GetCurrencyExchangeRates(string baseCurrencyType = "EUR");
    }
}
