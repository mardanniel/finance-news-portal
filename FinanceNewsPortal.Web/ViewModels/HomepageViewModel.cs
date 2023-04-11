using FinanceNewsPortal.Web.Models;

namespace FinanceNewsPortal.Web.ViewModels
{
    public class HomepageViewModel
    {
        public Currency? Currency { get; set; }
        
        public List<NewsArticle>? LatestNews { get; set; }

        public Stock? Stock { get; set; }
    }
}