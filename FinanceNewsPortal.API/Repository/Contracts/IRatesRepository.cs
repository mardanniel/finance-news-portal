using FinanceNewsPortal.API.Models;

namespace FinanceNewsPortal.API.Repository.Contracts
{
    public interface IRatesRepository
    {
        Task<Currency> GetCurrencyExchangeRates(string baseCurrencyType = "EUR");
        Task<Stock> GetStockExchangeRates();
    }
}
