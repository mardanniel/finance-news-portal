using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.Contracts;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinanceNewsPortal.Web.Controllers
{

    public class HomeController : Controller
    {
        private readonly INewsArticlesRepository newsArticlesRepository;
        private readonly IRatesRepository _ratesRepository;

        public HomeController(IRatesRepository ratesRepository, INewsArticlesRepository newsArticlesRepository)
        {
            this._ratesRepository = ratesRepository;
            this.newsArticlesRepository = newsArticlesRepository;
        }

        public async Task<IActionResult> Index()
        {
            Currency currency = await this._ratesRepository.GetCurrencyExchangeRates();

            return View(currency);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}