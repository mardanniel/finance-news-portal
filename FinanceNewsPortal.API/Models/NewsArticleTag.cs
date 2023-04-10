namespace FinanceNewsPortal.API.Models
{
    public class NewsArticleTag
    {
        public Guid Id { get; set; }

        public string TagName { get; set; }
        
        public ICollection<NewsArticleType> NewsArticleTypes { get; set; }
    }
}