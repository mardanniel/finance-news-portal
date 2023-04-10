using FinanceNewsPortal.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinanceNewsPortal.API.Data
{
    public class FinanceNewsPortalDbContext : IdentityDbContext<ApplicationUser>
    {
        private ILogger _logger { get; }
        private IConfiguration _appConfig { get; }

        public FinanceNewsPortalDbContext(
            ILogger<FinanceNewsPortalDbContext> logger,
            IConfiguration appConfig)
        {
            this._logger = logger;
            this._appConfig = appConfig;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var server = _appConfig.GetConnectionString("Server");
            //var db = _appConfig.GetConnectionString("DB");
            //var userName = _appConfig.GetConnectionString("UserName");
            //var password = _appConfig.GetConnectionString("Password");
            //string connectionString = $"Server={server};Database={db};User Id={userName};Password={password};MultipleActiveResultSets=true";

            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=FinanceDBTest;Integrated Security=True;MultipleActiveResultSets=true;";
            optionsBuilder
                .UseSqlServer(connectionString)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<NewsArticle> NewsArticle { get; set; }
        public DbSet<NewsArticleType> NewsArticleTypes { get; set; }
        public DbSet<NewsArticleRating> NewsArticleRatings { get; set; }
        public DbSet<NewsArticleTag> NewsArticleTags { get; set; }
    }
}
