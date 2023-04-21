using FinanceNewsPortal.Web.Models;

namespace FinanceNewsPortal.Web.Repository.RatesRepository
{
    public interface IRatesRepository
    {
        Task<Currency> GetCurrencyExchangeRates(string baseCurrencyType = "EUR");
        Task<Stock> GetStockExchangeRates();
    }
}
