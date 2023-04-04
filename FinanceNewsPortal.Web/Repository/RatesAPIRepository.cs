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
    }
}