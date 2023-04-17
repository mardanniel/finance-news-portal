using FinanceNewsPortal.Web.Enums;
using FinanceNewsPortal.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace FinanceNewsPortal.Web.Data
{
    public static class FinanceNewsPortalSeed
    {
        public static void AutoMigrate(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<FinanceNewsPortalDbContext>();
                {
                    dbContext.Database.Migrate();
                }
            }
        }

        public static void InvokeIdentityRoleSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "705c9705-c8a8-44af-99a3-e33b13856856",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole
                {
                    Id = "1a73053f-78c6-41c2-94fc-d897ccc8b33c",
                    Name = "Author",
                    NormalizedName = "Author"
                },
                new IdentityRole
                {
                    Id = "08715f79-2c99-4a8b-935a-7ff2e37d1518",
                    Name = "Moderator",
                    NormalizedName = "MODERATOR"
                }
            );
        }

        public static void InvokeUsersSeed(this ModelBuilder modelBuilder)
        {
            string defaultPassword = "P@ssword123";

            var passwordHasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "147c0de8-847c-4466-ad04-1fc7b563e0c4",
                    FirstName = "David",
                    LastName = "Acosta",
                    DateOfBirth = DateTime.Now,
                    Gender = 'M',
                    Status = true,
                    UserName = "admindavidacosta@email.com",
                    Email = "admindavidacosta@email.com",
                    NormalizedUserName = "admindavidacosta@email.com".ToUpper(),
                    NormalizedEmail = "admindavidacosta@email.com".ToUpper(),
                    PasswordHash = passwordHasher.HashPassword(null, defaultPassword)
                },
                new ApplicationUser
                {
                    Id = "cba87ff8-bb15-442f-8a47-0e65a93cab8c",
                    FirstName = "Mike",
                    LastName = "Burner",
                    DateOfBirth = DateTime.Now,
                    Gender = 'M',
                    Status = true,
                    UserName = "authormikeburner@email.com",
                    Email = "authormikeburner@email.com",
                    NormalizedUserName = "authormikeburner@email.com".ToUpper(),
                    NormalizedEmail = "authormikeburner@email.com".ToUpper(),
                    PasswordHash = passwordHasher.HashPassword(null, defaultPassword)
                },
                new ApplicationUser
                {
                    Id = "8c0b055f-d24d-43be-b842-4393d0b68d61",
                    FirstName = "Jenny",
                    LastName = "Lenner",
                    DateOfBirth = DateTime.Now,
                    Gender = 'M',
                    Status = true,
                    UserName = "modjennylenner@email.com",
                    Email = "modjennylenner@email.com",
                    NormalizedUserName = "modjennylenner@email.com".ToUpper(),
                    NormalizedEmail = "modjennylenner@email.com".ToUpper(),
                    PasswordHash = passwordHasher.HashPassword(null, defaultPassword)
                }
            );
        }

        public static void InvokeNewsArticleTags(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsArticleTag>().HasData(
                new NewsArticleTag
                {
                    Id = Guid.Parse("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b"),
                    TagName = "Finance"
                },
                new NewsArticleTag
                {
                    Id = Guid.Parse("68cd9ec4-de98-4b5e-b374-da0d3affd593"),
                    TagName = "Stock"
                },
                new NewsArticleTag
                {
                    Id = Guid.Parse("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30"),
                    TagName = "Banking"
                }
            );
        }

        public static void InvokeIdentityUserRoleSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "705c9705-c8a8-44af-99a3-e33b13856856",
                    UserId = "147c0de8-847c-4466-ad04-1fc7b563e0c4"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "1a73053f-78c6-41c2-94fc-d897ccc8b33c",
                    UserId = "cba87ff8-bb15-442f-8a47-0e65a93cab8c"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "08715f79-2c99-4a8b-935a-7ff2e37d1518",
                    UserId = "8c0b055f-d24d-43be-b842-4393d0b68d61"
                }
            );
        }

        public static void InvokeNewsArticleSeed(this ModelBuilder modelBuilder)
        {
            List<NewsArticle> articles = new List<NewsArticle>();
            List<Guid> newsArticleTypes = new List<Guid>()
            {
                Guid.Parse("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b"),
                Guid.Parse("68cd9ec4-de98-4b5e-b374-da0d3affd593"),
                Guid.Parse("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30")
            };
            Random random = new Random();

            for (int i = 1; i <= 14; i++)
            {
                // For Approved News Articles
                Guid approvedGuid = Guid.NewGuid();

                articles.Add(
                    new NewsArticle
                    {
                        Id = approvedGuid,
                        ApplicationUserId = "cba87ff8-bb15-442f-8a47-0e65a93cab8c",
                        Title = Faker.Company.CatchPhrase(),
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.",
                        Status = NewsStatus.Approved
                    });

                int numberOfTagsForApproved = random.Next(1, 4);

                for (int p = 0; p < numberOfTagsForApproved; p++)
                {
                    modelBuilder.Entity<NewsArticleType>().HasData(
                        new NewsArticleType
                        {
                            Id = Guid.NewGuid(),
                            NewsArticleId = approvedGuid,
                            NewsArticleTagId = newsArticleTypes[p]
                        });
                }

                // For Rejected News Articles
                Guid rejectedGuid = Guid.NewGuid();

                articles.Add(
                    new NewsArticle
                    {
                        Id = rejectedGuid,
                        ApplicationUserId = "cba87ff8-bb15-442f-8a47-0e65a93cab8c",
                        Title = Faker.Company.CatchPhrase(),
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.",
                        Status = NewsStatus.Rejected
                    });

                int numberOfTagsForRejected = random.Next(1, 4);

                for (int p = 0; p < numberOfTagsForRejected; p++)
                {
                    modelBuilder.Entity<NewsArticleType>().HasData(
                        new NewsArticleType
                        {
                            Id = Guid.NewGuid(),
                            NewsArticleId = rejectedGuid,
                            NewsArticleTagId = newsArticleTypes[p]
                        });
                }

                // For Pending News Articles
                Guid pendingGuid = Guid.NewGuid();

                articles.Add(
                    new NewsArticle
                    {
                        Id = pendingGuid,
                        ApplicationUserId = "cba87ff8-bb15-442f-8a47-0e65a93cab8c",
                        Title = Faker.Company.CatchPhrase(),
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.",
                        Status = NewsStatus.Pending
                    });

                int numberOfTagsForPending = random.Next(1, 4);

                for (int p = 0; p < numberOfTagsForPending; p++)
                {
                    modelBuilder.Entity<NewsArticleType>().HasData(
                        new NewsArticleType
                        {
                            Id = Guid.NewGuid(),
                            NewsArticleId = pendingGuid,
                            NewsArticleTagId = newsArticleTypes[p]
                        });
                }
            }

            foreach (var article in articles)
            {
                modelBuilder.Entity<NewsArticle>().HasData(article);
            }
        }
    }
}
