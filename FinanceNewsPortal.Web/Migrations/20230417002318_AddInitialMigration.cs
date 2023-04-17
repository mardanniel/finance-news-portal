using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceNewsPortal.Web.Migrations
{
    public partial class AddInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ImageFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsArticleTags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsArticleTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsArticle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ImageFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerdictMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsArticle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsArticle_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsArticleTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NewsArticleTagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NewsArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsArticleTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsArticleTypes_NewsArticle_NewsArticleId",
                        column: x => x.NewsArticleId,
                        principalTable: "NewsArticle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewsArticleTypes_NewsArticleTags_NewsArticleTagId",
                        column: x => x.NewsArticleTagId,
                        principalTable: "NewsArticleTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08715f79-2c99-4a8b-935a-7ff2e37d1518", "b29b1468-3a00-4693-ab69-b10aae6101c4", "Moderator", "MODERATOR" },
                    { "1a73053f-78c6-41c2-94fc-d897ccc8b33c", "ee472e6b-99a1-4f65-a36b-0c6342e22b92", "Author", "Author" },
                    { "705c9705-c8a8-44af-99a3-e33b13856856", "d75d5ca9-027f-4eaf-81fa-ce1ab1bb9560", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageFilePath", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "147c0de8-847c-4466-ad04-1fc7b563e0c4", 0, "c123d18e-5d4b-44fe-99be-80355045346c", new DateTime(2023, 4, 17, 8, 23, 18, 493, DateTimeKind.Local).AddTicks(5910), "administrator@email.com", false, "Admin", "M", null, "Nistrator", false, null, "ADMINISTRATOR@EMAIL.COM", "ADMINISTRATOR@EMAIL.COM", "AQAAAAEAACcQAAAAECGzrp497EkaRSqkgQGGGcRq8f1lrkwrODNIT7+v5XeUJ4HpIe5krC6z16BTuyvLWQ==", null, false, "9523a52e-659c-4c10-a907-1315520601ba", true, false, "administrator@email.com" },
                    { "8c0b055f-d24d-43be-b842-4393d0b68d61", 0, "d6f1df5a-38f8-4759-9ca0-36bc49788540", new DateTime(2023, 4, 17, 8, 23, 18, 496, DateTimeKind.Local).AddTicks(8335), "moderator@email.com", false, "Mod", "M", null, "Erator", false, null, "MODERATOR@EMAIL.COM", "MODERATOR@EMAIL.COM", "AQAAAAEAACcQAAAAEExA7oIaJT0iWn6LjAr0DS9M27T4Abnf6ANjGQOMeijoRKhboJkTJ7lOakLnWm1hIg==", null, false, "bc25bef7-b447-4999-9487-0dce9e25ee8f", true, false, "moderator@email.com" },
                    { "cba87ff8-bb15-442f-8a47-0e65a93cab8c", 0, "a563eda6-aa72-4480-a83e-b48d768f562b", new DateTime(2023, 4, 17, 8, 23, 18, 494, DateTimeKind.Local).AddTicks(9840), "mikeburner@email.com", false, "Mike", "M", null, "Burner", false, null, "MIKEBURNER@EMAIL.COM", "MIKEBURNER@EMAIL.COM", "AQAAAAEAACcQAAAAEBvLQCxvkS64dsmUFLWpUhZez5xBPmAjR+T9TkOB00yuYarMaCZYKYRzogV4ZTgrIw==", null, false, "8e7470a0-6145-4dc6-b799-998ddc751268", true, false, "mikeburner@email.com" }
                });

            migrationBuilder.InsertData(
                table: "NewsArticleTags",
                columns: new[] { "Id", "TagName" },
                values: new object[,]
                {
                    { new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593"), "Stock" },
                    { new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30"), "Banking" },
                    { new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b"), "Finance" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "705c9705-c8a8-44af-99a3-e33b13856856", "147c0de8-847c-4466-ad04-1fc7b563e0c4" },
                    { "08715f79-2c99-4a8b-935a-7ff2e37d1518", "8c0b055f-d24d-43be-b842-4393d0b68d61" },
                    { "1a73053f-78c6-41c2-94fc-d897ccc8b33c", "cba87ff8-bb15-442f-8a47-0e65a93cab8c" }
                });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title", "VerdictMessage" },
                values: new object[,]
                {
                    { new Guid("02d45ffc-6e30-4d05-80af-963a7d7e87e1"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 499, DateTimeKind.Local).AddTicks(823), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Vision-oriented solution-oriented customer loyalty", null },
                    { new Guid("07ed5cf9-0aaa-403a-859b-d696d51aacf4"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 499, DateTimeKind.Local).AddTicks(191), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Streamlined tangible paradigm", null },
                    { new Guid("0aa4613d-f187-4044-8625-7c943ecaecd3"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(6065), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Profound bifurcated product", null },
                    { new Guid("0c021841-6ab6-4fe3-9942-a0c57247251b"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(8677), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Triple-buffered multimedia time-frame", null },
                    { new Guid("113a7222-6b6f-43dd-8af1-7bcaa64905ff"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(6535), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Customer-focused next generation Graphical User Interface", null },
                    { new Guid("21f212d5-34b4-48c0-b4e6-0a2294c2c15f"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(5915), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Cross-platform fresh-thinking analyzer", null },
                    { new Guid("32a7021c-a924-4ea2-9183-0f80f996a8e0"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 499, DateTimeKind.Local).AddTicks(1716), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Profound value-added software", null },
                    { new Guid("37d0f214-6391-4f90-a1b9-f795e21ae10c"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 499, DateTimeKind.Local).AddTicks(1827), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Multi-channelled methodical knowledge base", null },
                    { new Guid("3c3a2caa-f01b-447e-acbd-3181cd47a370"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 499, DateTimeKind.Local).AddTicks(1337), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Diverse exuding migration", null },
                    { new Guid("4214e211-eef9-4483-841f-24a02e4039a6"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 499, DateTimeKind.Local).AddTicks(1466), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "De-engineered non-volatile encoding", null },
                    { new Guid("49cf2685-1344-40b4-bf80-f5ccd7b579f0"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 499, DateTimeKind.Local).AddTicks(2051), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Cloned non-volatile function", null },
                    { new Guid("4fe63fa9-ba06-4404-af9b-ccf7b2e4a2e4"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(8244), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Front-line didactic strategy", null },
                    { new Guid("50f01697-a1bf-4883-a225-39e4dec66b45"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(9114), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Fundamental zero tolerance moratorium", null },
                    { new Guid("59c363d1-e5a9-42fb-94e4-81fa27c74f56"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 499, DateTimeKind.Local).AddTicks(528), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Re-contextualized exuding software", null },
                    { new Guid("617f4b4c-2d29-41c5-aa7f-8b893b3dac91"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(8849), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Polarised homogeneous help-desk", null },
                    { new Guid("6712106e-cdb9-4481-a41d-b4b517a26299"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 499, DateTimeKind.Local).AddTicks(1588), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Managed object-oriented contingency", null },
                    { new Guid("69c77754-1bec-44e9-aef3-097c744e2247"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(8573), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Team-oriented cohesive instruction set", null },
                    { new Guid("6fc00a48-2bc5-404d-b48b-214fab79c583"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(7195), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Devolved bi-directional contingency", null },
                    { new Guid("71409c14-261b-4067-90f2-eb7e5ebef32e"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 499, DateTimeKind.Local).AddTicks(2527), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Pre-emptive reciprocal capacity", null },
                    { new Guid("717f2459-a5d6-4bc6-9e8a-55b7de2be55a"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(8464), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Configurable uniform service-desk", null },
                    { new Guid("7d3c300e-c150-4130-a6f1-16d3ad445e93"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 499, DateTimeKind.Local).AddTicks(357), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Switchable user-facing budgetary management", null },
                    { new Guid("8151c6c3-7ee8-4990-a04b-99c54b37efe1"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 499, DateTimeKind.Local).AddTicks(1172), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Realigned human-resource circuit", null },
                    { new Guid("820b5df6-fd6c-49d4-b591-ad6e8054320d"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(8005), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Upgradable modular encryption", null },
                    { new Guid("928d6b64-29d0-44c5-a2d6-8f88575ced41"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(8339), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Horizontal motivating orchestration", null },
                    { new Guid("92bad905-ff0e-47f3-97b0-6fdc07d9b0ae"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(7899), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Stand-alone client-driven monitoring", null },
                    { new Guid("a4900554-4ed5-4312-b3aa-930d8ab63808"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(9010), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Open-source scalable portal", null },
                    { new Guid("a77b4142-a85e-4ce5-9ee7-8a9d8f1ce9e7"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(7429), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Synergized homogeneous moratorium", null },
                    { new Guid("b21cac7a-a094-4736-a2a1-1569e8767fb7"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(6216), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Profound uniform matrix", null },
                    { new Guid("b9f69986-ed61-4b4c-8cc3-8509c9c8365d"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(6737), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Horizontal system-worthy archive", null },
                    { new Guid("bb335c1d-764e-4c07-a913-7cac7b7d32e6"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(7329), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Polarised grid-enabled task-force", null },
                    { new Guid("be1ec014-e6ce-43dc-8c41-9de66f18a510"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(6921), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Multi-tiered eco-centric flexibility", null },
                    { new Guid("be33fef1-0757-4f3a-b5bf-3bb8a983750c"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(5498), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Face to face needs-based adapter", null },
                    { new Guid("bfde229a-3a7d-4ab1-80fa-e1665f616c23"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(8139), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Re-contextualized system-worthy database", null },
                    { new Guid("c77b13da-1887-4d7e-a150-dd21b465fec6"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(9589), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Self-enabling background encryption", null },
                    { new Guid("d531d9a9-be87-4667-b6a9-11b38385a084"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(9243), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Managed bottom-line definition", null },
                    { new Guid("d5e82a16-0422-468e-a2fc-9de7eb5d9b87"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(5112), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Vision-oriented heuristic standardization", null },
                    { new Guid("d8a04a36-fc61-49a4-aab0-aa3d459c9871"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 499, DateTimeKind.Local).AddTicks(2231), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Adaptive directional paradigm", null },
                    { new Guid("e6a92058-e506-4f2e-ab5b-9e5093676ab5"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(7683), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Right-sized intangible artificial intelligence", null },
                    { new Guid("e725d3e7-f0fe-44a2-bf80-7fb5be41674b"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(7798), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Upgradable maximized open system", null }
                });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title", "VerdictMessage" },
                values: new object[] { new Guid("f45ff338-ff67-4ba2-8e37-6a294a1c9c72"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(7531), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Ameliorated incremental frame", null });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title", "VerdictMessage" },
                values: new object[] { new Guid("f4a7b6eb-a667-499a-9aea-1411e45466f8"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 498, DateTimeKind.Local).AddTicks(5743), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Compatible solution-oriented infrastructure", null });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title", "VerdictMessage" },
                values: new object[] { new Guid("fe9293f6-8429-4982-926d-44d785516bd4"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 8, 23, 18, 499, DateTimeKind.Local).AddTicks(1), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Reactive motivating ability", null });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[,]
                {
                    { new Guid("02a180ca-0126-487c-aa2e-750dae180072"), new Guid("d8a04a36-fc61-49a4-aab0-aa3d459c9871"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("0458b20e-b598-49a4-8017-4bcfec861d59"), new Guid("b21cac7a-a094-4736-a2a1-1569e8767fb7"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("082af6ae-2fe9-43b6-88af-1a18dcf2684a"), new Guid("e6a92058-e506-4f2e-ab5b-9e5093676ab5"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("09a7f37a-fc38-4461-a53c-987cb573c921"), new Guid("d531d9a9-be87-4667-b6a9-11b38385a084"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("0c6f0c0a-0c29-4f1a-be8b-d596ea5abc22"), new Guid("8151c6c3-7ee8-4990-a04b-99c54b37efe1"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("0d761384-bac8-4dc7-b572-91a23158fce8"), new Guid("a77b4142-a85e-4ce5-9ee7-8a9d8f1ce9e7"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("0eba59c5-84c1-4418-bfb8-b704a5d2729a"), new Guid("0aa4613d-f187-4044-8625-7c943ecaecd3"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("11c02392-8922-4bde-8e2f-3c4046a03984"), new Guid("e725d3e7-f0fe-44a2-bf80-7fb5be41674b"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("13384913-6add-4596-9065-aa7d41822c0d"), new Guid("92bad905-ff0e-47f3-97b0-6fdc07d9b0ae"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("14cf87de-b6d1-4062-8efd-4c369cd5f144"), new Guid("4214e211-eef9-4483-841f-24a02e4039a6"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("1f42b080-2195-4f4c-9fb8-55803f600c46"), new Guid("a4900554-4ed5-4312-b3aa-930d8ab63808"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("1fe87145-792d-4216-b3a1-23c1cc69d25b"), new Guid("b21cac7a-a094-4736-a2a1-1569e8767fb7"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("207c7ab7-005b-4e90-8c04-3c6d42704610"), new Guid("be33fef1-0757-4f3a-b5bf-3bb8a983750c"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("2196f266-1f66-4136-b5ba-323b5f3dc095"), new Guid("820b5df6-fd6c-49d4-b591-ad6e8054320d"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("228e2559-046f-493f-879c-a9cc3ac6742e"), new Guid("c77b13da-1887-4d7e-a150-dd21b465fec6"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("27b67db5-f6af-4329-9166-aba06feedbf3"), new Guid("717f2459-a5d6-4bc6-9e8a-55b7de2be55a"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("2c9aad05-730c-441d-9586-0aa248ca4efc"), new Guid("7d3c300e-c150-4130-a6f1-16d3ad445e93"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("2c9e634e-8785-4049-9f31-3bd2a3d1ea64"), new Guid("92bad905-ff0e-47f3-97b0-6fdc07d9b0ae"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("2d4e818a-fb16-46da-aa17-303ddcf6ef87"), new Guid("d5e82a16-0422-468e-a2fc-9de7eb5d9b87"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("2d512ff1-d3a2-4209-8725-15c11eab59df"), new Guid("50f01697-a1bf-4883-a225-39e4dec66b45"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("2e87aa0d-38c7-49cd-b642-2f97e507d527"), new Guid("d5e82a16-0422-468e-a2fc-9de7eb5d9b87"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("34628631-25fe-4a53-bdd9-1fa778e33c8a"), new Guid("bb335c1d-764e-4c07-a913-7cac7b7d32e6"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("355326a6-2860-46d6-a6f6-6cc83f6df395"), new Guid("59c363d1-e5a9-42fb-94e4-81fa27c74f56"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("357a00f0-d2d2-4afe-9c4b-cfa086b0afde"), new Guid("6fc00a48-2bc5-404d-b48b-214fab79c583"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("38836be7-c26a-4462-ac62-d30a96313d72"), new Guid("6fc00a48-2bc5-404d-b48b-214fab79c583"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("39edf25f-a99d-40ce-8997-bd8ffbb2f677"), new Guid("71409c14-261b-4067-90f2-eb7e5ebef32e"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("40eee108-c4d0-4897-b534-4b6a6b1a2de4"), new Guid("820b5df6-fd6c-49d4-b591-ad6e8054320d"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("43b3cee5-264f-41a5-91b9-25c1caa8375f"), new Guid("617f4b4c-2d29-41c5-aa7f-8b893b3dac91"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("4b251240-25eb-4a3a-8bdc-c617cead493f"), new Guid("21f212d5-34b4-48c0-b4e6-0a2294c2c15f"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("5516b9c9-f00c-4be7-a24a-246d08e76803"), new Guid("c77b13da-1887-4d7e-a150-dd21b465fec6"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("5610cd63-e720-4782-b7a7-e66cd1beb533"), new Guid("07ed5cf9-0aaa-403a-859b-d696d51aacf4"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("568a4c5a-f8de-443c-a636-ce0d9ef763b8"), new Guid("32a7021c-a924-4ea2-9183-0f80f996a8e0"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("5972b07b-a6ad-4c8f-929b-01a205c7447e"), new Guid("d531d9a9-be87-4667-b6a9-11b38385a084"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("598ef9b9-65d1-442b-88f4-ce922561fd61"), new Guid("3c3a2caa-f01b-447e-acbd-3181cd47a370"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("59f2a808-850c-44b6-8f3f-31304b4c23a1"), new Guid("37d0f214-6391-4f90-a1b9-f795e21ae10c"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("5db40b3c-fce4-4df3-89ff-919786fe4b29"), new Guid("59c363d1-e5a9-42fb-94e4-81fa27c74f56"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("6192f151-0044-4a2d-8b90-5afaaa02a37a"), new Guid("59c363d1-e5a9-42fb-94e4-81fa27c74f56"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("641456d5-9364-4fa5-81fe-d3958f55062a"), new Guid("4fe63fa9-ba06-4404-af9b-ccf7b2e4a2e4"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("66a7e32a-b716-4b27-bdd2-1bf0444cbeaa"), new Guid("0aa4613d-f187-4044-8625-7c943ecaecd3"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("6a3b4bcc-002c-4b88-9905-13cec2fb5ddb"), new Guid("6712106e-cdb9-4481-a41d-b4b517a26299"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("6b70faba-414e-46bd-a7da-8518225adddd"), new Guid("69c77754-1bec-44e9-aef3-097c744e2247"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("6ea903be-d743-4242-a492-0c761d740dff"), new Guid("71409c14-261b-4067-90f2-eb7e5ebef32e"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") }
                });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[,]
                {
                    { new Guid("7272950c-27ab-4a56-8c1a-f2cced9c28af"), new Guid("3c3a2caa-f01b-447e-acbd-3181cd47a370"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("84b04c2f-6cc5-4272-a27b-a4b568b35430"), new Guid("e6a92058-e506-4f2e-ab5b-9e5093676ab5"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("857c4001-9009-40ef-8ca1-dfe327531112"), new Guid("4214e211-eef9-4483-841f-24a02e4039a6"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("89b8ddf1-aca3-4fb0-be96-1c57ebf54bcd"), new Guid("02d45ffc-6e30-4d05-80af-963a7d7e87e1"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("89db081b-56b7-4813-b588-cb1601810be3"), new Guid("0aa4613d-f187-4044-8625-7c943ecaecd3"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("8a709eba-0a17-46b8-9b5b-3d329f68f6a5"), new Guid("be33fef1-0757-4f3a-b5bf-3bb8a983750c"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("8aa43597-40b8-4a4c-b925-cf91e8bb60f1"), new Guid("b9f69986-ed61-4b4c-8cc3-8509c9c8365d"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("8b341e6f-7816-4c67-b671-c78ec27155a0"), new Guid("0c021841-6ab6-4fe3-9942-a0c57247251b"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("8f919dff-96a4-4594-a833-b2bb8d662962"), new Guid("bfde229a-3a7d-4ab1-80fa-e1665f616c23"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("910cdf75-0467-431d-8bd3-c1e564a426b2"), new Guid("6712106e-cdb9-4481-a41d-b4b517a26299"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("924d2c6f-a602-4706-a5d2-75d3b1ba20ac"), new Guid("50f01697-a1bf-4883-a225-39e4dec66b45"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("92583227-3181-4efa-b45d-670af608933a"), new Guid("fe9293f6-8429-4982-926d-44d785516bd4"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("947f2820-329b-4eef-9ed2-fddac521412b"), new Guid("0c021841-6ab6-4fe3-9942-a0c57247251b"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("999ca944-037e-4c1d-91cc-eb55ef8ccea2"), new Guid("fe9293f6-8429-4982-926d-44d785516bd4"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("9b2588b8-8f71-4fda-a885-5473a2049aba"), new Guid("be33fef1-0757-4f3a-b5bf-3bb8a983750c"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("a105c00d-250a-4cb6-941d-d1e6fed72ce0"), new Guid("b9f69986-ed61-4b4c-8cc3-8509c9c8365d"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("a2e959e9-73b6-4fbd-82e5-b5aa8dc63c17"), new Guid("f45ff338-ff67-4ba2-8e37-6a294a1c9c72"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("a85603e4-255f-4cba-b2ab-ed647bc4881d"), new Guid("928d6b64-29d0-44c5-a2d6-8f88575ced41"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("a8fb98f1-3007-4376-9a1a-3559d7bab5a6"), new Guid("f45ff338-ff67-4ba2-8e37-6a294a1c9c72"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("b5c463b3-2ebf-4a35-a6fc-787ddfd6332b"), new Guid("50f01697-a1bf-4883-a225-39e4dec66b45"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("b69e4834-f74b-4fcf-a175-a6d723326dd1"), new Guid("21f212d5-34b4-48c0-b4e6-0a2294c2c15f"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("b8ef0fd1-3a7f-4431-8fde-f1df05498965"), new Guid("21f212d5-34b4-48c0-b4e6-0a2294c2c15f"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("ba33b6de-49c4-4bc2-89ce-d19e287477d3"), new Guid("b9f69986-ed61-4b4c-8cc3-8509c9c8365d"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("bf289e19-bbf9-4685-ac5b-869f31f9ba09"), new Guid("69c77754-1bec-44e9-aef3-097c744e2247"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("cb8d540c-9099-438e-b8b4-d6cc9fda477e"), new Guid("e6a92058-e506-4f2e-ab5b-9e5093676ab5"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("cc543919-1955-42f0-8744-c5d0ca5ea1c8"), new Guid("113a7222-6b6f-43dd-8af1-7bcaa64905ff"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("ce856781-bd01-42f5-abde-1fd43aa83fad"), new Guid("69c77754-1bec-44e9-aef3-097c744e2247"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("d2b8cc02-b885-46c8-8ede-25e97d55c930"), new Guid("be1ec014-e6ce-43dc-8c41-9de66f18a510"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("d76bc9a9-7546-426b-ace6-07ef27737d1a"), new Guid("a4900554-4ed5-4312-b3aa-930d8ab63808"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("dced7700-4d2d-4058-9f96-e43c9b00491c"), new Guid("113a7222-6b6f-43dd-8af1-7bcaa64905ff"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("e1f2f473-8c3f-4bd9-8d76-19f9e258a0dd"), new Guid("6712106e-cdb9-4481-a41d-b4b517a26299"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("e4cadf8b-370f-44eb-931e-40081a7ddfd1"), new Guid("f4a7b6eb-a667-499a-9aea-1411e45466f8"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("e61d7872-469f-4d50-870e-3695151f85df"), new Guid("820b5df6-fd6c-49d4-b591-ad6e8054320d"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("e8325fc2-f9cb-4c39-88e9-cba0faf510fd"), new Guid("113a7222-6b6f-43dd-8af1-7bcaa64905ff"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("e97b5fc9-1848-4a1c-a685-6cfeda2758ce"), new Guid("b21cac7a-a094-4736-a2a1-1569e8767fb7"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("eb984249-bb0f-4c36-8c6f-51ec18975738"), new Guid("fe9293f6-8429-4982-926d-44d785516bd4"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("ec5d4f3a-2ce2-4c11-80e4-554a3e32d3c4"), new Guid("d8a04a36-fc61-49a4-aab0-aa3d459c9871"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("ecb49b16-e68a-47e6-ba17-0f8fd0111bf4"), new Guid("49cf2685-1344-40b4-bf80-f5ccd7b579f0"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("eeeac78c-1840-46b7-bfc3-afd7a0e53585"), new Guid("4214e211-eef9-4483-841f-24a02e4039a6"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("f3648bc2-2bac-4bab-abe8-15f212773b3d"), new Guid("c77b13da-1887-4d7e-a150-dd21b465fec6"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("f4cae4c9-b475-4164-bf6b-23cee7bf20bd"), new Guid("717f2459-a5d6-4bc6-9e8a-55b7de2be55a"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("f91423d8-904f-48a6-98d9-a230eb7f8506"), new Guid("be1ec014-e6ce-43dc-8c41-9de66f18a510"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") }
                });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[] { new Guid("f9b140f1-5638-4586-8594-b7546fc4b01c"), new Guid("32a7021c-a924-4ea2-9183-0f80f996a8e0"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NewsArticle_ApplicationUserId",
                table: "NewsArticle",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsArticleTypes_NewsArticleId",
                table: "NewsArticleTypes",
                column: "NewsArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsArticleTypes_NewsArticleTagId",
                table: "NewsArticleTypes",
                column: "NewsArticleTagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "NewsArticleTypes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "NewsArticle");

            migrationBuilder.DropTable(
                name: "NewsArticleTags");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
