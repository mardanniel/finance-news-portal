using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.Contracts;
using System.Text.Json;

namespace FinanceNewsPortal.Web.Repository
{
    public class RatesAPIRepository : IRatesRepository
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public RatesAPIRepository(HttpClient httpClient, IConfiguration configuration)
        {
            this._httpClient = httpClient;
            this._httpClient.BaseAddress = new Uri("https://anyapi.io");
            this._configuration = configuration;
        }

        public async Task<Currency?> GetCurrencyExchangeRates(string baseCurrencyType)
        {
            //string path = $"/api/v1/exchange/rates?base={baseCurrencyType}&apiKey={this._configuration.GetConnectionString("API_KEY")}";

            //var responseMessage = await this._httpClient.GetAsync(path);

            //var contentStream = await responseMessage.Content.ReadAsStreamAsync();

            //return await JsonSerializer.DeserializeAsync<Currency>(contentStream);

            return new Currency
            {
                Base = "EUR",
                LastUpdate = 00000000,
                Rates = new ExchangeRates()
            };
        }

        public async Task<Stock> GetStockExchangeRates()
        {
            // Dummy data, not final

            Stock stock = new Stock
            {
                StockValues = new List<StockValue>
                {
                    new StockValue { Name = "S&P 500", Value = 4100.60, Percentage = -0.58 },
                    new StockValue { Name = "Nasdaq", Value = 12126.33, Percentage = -0.52 },
                    new StockValue { Name = "Crude Oil", Value = 81.00, Percentage = 0.36 },
                    new StockValue { Name = "US 10 Yr3", Value = 3.34, Percentage = -0.05 },
                    new StockValue { Name = "Euro", Value = 1.10, Percentage = 0.11 },
                }
            };

            return stock;

        }
    }
}