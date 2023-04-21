using FinanceNewsPortal.Web.Helper;
using FinanceNewsPortal.Web.Models;
using System.Text.Json;

namespace FinanceNewsPortal.Web.Repository.RatesRepository
{
    public class RatesAPIRepository : IRatesRepository
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public RatesAPIRepository(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<Currency?> GetCurrencyExchangeRates(string baseCurrencyType)
        {
            Currency? currency;

            try
            {
                string path = $"https://anyapi.io/api/v1/exchange/rates?base={baseCurrencyType}&apiKey={_configuration.GetConnectionString("ANYAPI_KEY")}";

                var responseMessage = await _httpClient.GetAsync(path);

                var contentStream = await responseMessage.Content.ReadAsStreamAsync();

                currency = await JsonSerializer.DeserializeAsync<Currency>(contentStream);
            }
            catch (Exception e)
            {
                currency = null;
            }

            return currency;
        }

        public async Task<Stock> GetStockExchangeRates()
        {
            Stock? stock;

            DateTime currDate = DateTime.Now;
            string prevDateStr = currDate.GetPreviousDayWithinWeekdays();

            try
            {
                string path = $"https://api.polygon.io/v2/aggs/grouped/locale/us/market/stocks/{prevDateStr}?adjusted=false&apiKey={_configuration.GetConnectionString("POLYGONAPI_KEY")}";

                var responseMessage = await _httpClient.GetAsync(path);

                var contentStream = await responseMessage.Content.ReadAsStreamAsync();

                stock = await JsonSerializer.DeserializeAsync<Stock>(contentStream);

                stock.LastUpdateDateString = prevDateStr;
            }
            catch (Exception e)
            {
                stock = null;
            }

            return stock;
        }
    }
}