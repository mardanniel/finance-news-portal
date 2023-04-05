using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.Repository.Contracts;
using FinanceNewsPortal.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinanceNewsPortal.Web.Controllers
{

    public class HomeController : Controller
    {
        private readonly INewsArticlesRepository _newsArticlesRepository;
        private readonly IRatesRepository _ratesRepository;

        public HomeController(IRatesRepository ratesRepository, INewsArticlesRepository newsArticlesRepository)
        {
            this._ratesRepository = ratesRepository;
            this._newsArticlesRepository = newsArticlesRepository;
        }

        public async Task<IActionResult> Index()
        {
            HomepageViewModel homepageViewModel = new HomepageViewModel {
                Currency = await this._ratesRepository.GetCurrencyExchangeRates(),
                LatestNews = await this._newsArticlesRepository.GetLatestNewsArticles(4),
                Stock = await this._ratesRepository.GetStockExchangeRates(),
            };

            return View(homepageViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}