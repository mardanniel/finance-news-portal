using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;

namespace FinanceNewsPortal.Web.Controllers
{
    public class RatesController : Controller
    {
        private readonly IRatesRepository _ratesRepository;

        public RatesController(IRatesRepository ratesRepository)
        {
            this._ratesRepository = ratesRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Currency(string currencyType)
        {
            Currency? currency = await this._ratesRepository.GetCurrencyExchangeRates(currencyType);

            if(currency.Rates != null)
            {
                Type modelType = currency.Rates.GetType();
                PropertyInfo[] props = modelType.GetProperties();
                List<SelectListItem> currencyNameList = new List<SelectListItem>();
                foreach (PropertyInfo currencyProp in props)
                {
                    currencyNameList.Add(new SelectListItem
                    {
                        Text = currencyProp.Name,
                        Value = currencyProp.Name,
                        Selected = currencyType == currencyProp.Name,
                    });
                }

                ViewData["CurrencyList"] = currencyNameList;
            }

            return View(currency);
        }

        public async Task<IActionResult> Stocks()
        {
            Stock? stocks = null;

            stocks = await this._ratesRepository.GetStockExchangeRates();

            if(stocks.Results != null)
            {
                stocks.Results = stocks.Results.Take(25);
            }

            return View(stocks);
        }
    }
}
