using FinanceNewsPortal.API.Models;
using FinanceNewsPortal.API.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;

namespace FinanceNewsPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatesController : ControllerBase
    {
        private readonly IRatesRepository _ratesRepository;

        public RatesController(IRatesRepository ratesRepository)
        {
            this._ratesRepository = ratesRepository;
        }

        [HttpGet("currency/{currencyType}")]
        public async Task<IActionResult> Currency([FromRoute] string currencyType = "EUR")
        {
            Currency currency = await this._ratesRepository.GetCurrencyExchangeRates(currencyType);

            return Ok(currency);
        }

        [HttpGet("stocks")]
        public async Task<IActionResult> Stocks()
        {
            Stock stocks = await this._ratesRepository.GetStockExchangeRates();

            return Ok(stocks);
        }
    }
}
