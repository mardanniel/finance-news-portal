using FinanceNewsPortal.API.Models;

namespace FinanceNewsPortal.API.DTO
{
    public class NewsArticleWithAuthorDTO
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Context { get; set; }

        public string Author { get; set; }

        public ICollection<NewsArticleType> NewsArticleTypes { get; set; }
    }
}
