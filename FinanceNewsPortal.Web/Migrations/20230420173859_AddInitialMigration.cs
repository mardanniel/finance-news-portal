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
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoundedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
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
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
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
                    { "08715f79-2c99-4a8b-935a-7ff2e37d1518", "1c8f014e-14aa-4896-97e8-2096729f416a", "Moderator", "MODERATOR" },
                    { "1a73053f-78c6-41c2-94fc-d897ccc8b33c", "1325276f-d4c1-4b9a-9d74-f798429e4a2c", "Publisher", "PUBLISHER" },
                    { "705c9705-c8a8-44af-99a3-e33b13856856", "0f982d85-4d9a-4727-8cb0-a0ac63e78092", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyId", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageFilePath", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { "147c0de8-847c-4466-ad04-1fc7b563e0c4", 0, null, "5ee2dc4f-11d3-4c01-9dd4-ff3b68ed0629", new DateTime(2023, 4, 21, 1, 38, 59, 63, DateTimeKind.Local).AddTicks(7623), "admindavidacosta@email.com", false, "David", "M", null, "Acosta", false, null, "ADMINDAVIDACOSTA@EMAIL.COM", "ADMINDAVIDACOSTA@EMAIL.COM", "AQAAAAEAACcQAAAAEJXQbW6YL199qD4LQgGH+LqVb0kAVAyEuDd4QWrWn8KHUxzfWLtEzSyo72mtC++8sQ==", null, false, "f9648b19-9ad1-4fa5-a6c6-94310b3ea5ef", true, false, "admindavidacosta@email.com" });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Address", "FoundedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("45e2f212-8d95-4629-8ff2-a01f999139a3"), "Reliance corner Sheridan Streets, Barangay Buayang Bato, Mandaluyong, Metro Manila, Philippines", new DateTime(2023, 4, 21, 1, 38, 59, 63, DateTimeKind.Local).AddTicks(7582), "TV8 Network" },
                    { new Guid("bc41b6d7-981e-4d53-b291-2b1d8d34bc69"), "EDSA Cor. Timog Ave., Diliman, Quezon City, Philippines", new DateTime(2023, 4, 21, 1, 38, 59, 63, DateTimeKind.Local).AddTicks(7565), "JME Network" },
                    { new Guid("d7bff58e-de3e-4a55-976b-385bc600ac0f"), "Sgt. Esguerra Avenue corner Mother Ignacia Street, Brgy. South Triangle, Diliman, Quezon City", new DateTime(2023, 4, 21, 1, 38, 59, 63, DateTimeKind.Local).AddTicks(7580), "IBS-ZBM Network" }
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
                values: new object[] { "705c9705-c8a8-44af-99a3-e33b13856856", "147c0de8-847c-4466-ad04-1fc7b563e0c4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyId", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageFilePath", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8c0b055f-d24d-43be-b842-4393d0b68d61", 0, new Guid("d7bff58e-de3e-4a55-976b-385bc600ac0f"), "c9e85aab-0fd3-412d-87bc-b33abd170d84", new DateTime(2023, 4, 21, 1, 38, 59, 66, DateTimeKind.Local).AddTicks(7134), "modjennylenner@email.com", false, "Jenny", "M", null, "Lenner", false, null, "MODJENNYLENNER@EMAIL.COM", "MODJENNYLENNER@EMAIL.COM", "AQAAAAEAACcQAAAAEHjImkHD0zRCKxVnvnuzxSySU5uZrMvc3yp5bBcA4xjyJlfsHcd2Vcg95tHJ2GJR+g==", null, false, "09dd87ab-213e-42c3-9f54-c2136d5e2ab2", true, false, "modjennylenner@email.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyId", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageFilePath", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cba87ff8-bb15-442f-8a47-0e65a93cab8c", 0, new Guid("d7bff58e-de3e-4a55-976b-385bc600ac0f"), "279075f1-115a-4802-9f5d-a9d844c25e08", new DateTime(2023, 4, 21, 1, 38, 59, 65, DateTimeKind.Local).AddTicks(2595), "authormikeburner@email.com", false, "Mike", "M", null, "Burner", false, null, "AUTHORMIKEBURNER@EMAIL.COM", "AUTHORMIKEBURNER@EMAIL.COM", "AQAAAAEAACcQAAAAECes/+5H0VhoCuAl3RU7dRCB9TH6Mm/2e2lMWYO+sJuJuCDc/GKdJSh5fSZzKtscCQ==", null, false, "fb895c87-1899-4ee3-b656-183d18f568e1", true, false, "authormikeburner@email.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "08715f79-2c99-4a8b-935a-7ff2e37d1518", "8c0b055f-d24d-43be-b842-4393d0b68d61" },
                    { "1a73053f-78c6-41c2-94fc-d897ccc8b33c", "cba87ff8-bb15-442f-8a47-0e65a93cab8c" }
                });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title", "VerdictMessage" },
                values: new object[,]
                {
                    { new Guid("09c7d20c-24eb-468f-bb5e-f87920e50c5f"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(3505), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Decentralized content-based superstructure", null },
                    { new Guid("135e29df-505d-4f0f-bea4-c8ac714b6325"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(8766), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Self-enabling directional Graphic Interface", null },
                    { new Guid("16b71731-3e44-47de-9b30-e3cecf1861d7"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(6456), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Visionary secondary leverage", null },
                    { new Guid("1b51e9fe-f85b-4539-9c13-0bf0c8175af2"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(4554), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Monitored grid-enabled artificial intelligence", null },
                    { new Guid("22d57093-97e4-4915-a42c-a8da24dc7049"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 69, DateTimeKind.Local).AddTicks(700), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Mandatory empowering architecture", null },
                    { new Guid("265462fc-4390-4a91-9d93-7bc8d3f8aafd"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(6330), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Business-focused hybrid array", null },
                    { new Guid("3043bcea-77f9-4ff3-94ca-03e31d57ce05"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(9398), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Multi-channelled 24 hour capability", null },
                    { new Guid("45b4fc8e-2f95-4182-962f-3df8ee57d202"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(6207), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Synergistic cohesive installation", null },
                    { new Guid("477153c6-4820-449f-b7d7-100a8574b844"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 69, DateTimeKind.Local).AddTicks(65), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Diverse upward-trending encoding", null },
                    { new Guid("505ad716-06bc-4b9b-a7bc-4fa758c08cb0"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(5940), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Front-line maximized policy", null },
                    { new Guid("5307a5a2-338e-4cb5-867b-027f3a514352"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(9018), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Triple-buffered full-range benchmark", null },
                    { new Guid("538193e6-703c-4b28-bb95-3c89f398fedf"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(3680), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Automated exuding moderator", null },
                    { new Guid("65d08a16-0de4-4d0a-a35f-8573c67ddba7"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 69, DateTimeKind.Local).AddTicks(831), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Managed user-facing standardization", null },
                    { new Guid("6a9f9236-982d-43cb-8a8b-756bf6c82c4f"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(9254), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Ergonomic client-driven data-warehouse", null },
                    { new Guid("6b8e5216-9c63-4ae4-a2ed-32f04767d9bf"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(1928), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Integrated discrete internet solution", null },
                    { new Guid("6db1aaaf-d358-4419-adbb-97b69f393467"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(7140), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Automated motivating core", null },
                    { new Guid("6eee5997-1735-4ecd-992b-b7af39f48166"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(6090), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Assimilated systemic internet solution", null },
                    { new Guid("70408819-2d19-4eb6-ae11-7f49c63d20d9"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(9807), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Front-line background emulation", null },
                    { new Guid("70d73ad4-eb17-4fdd-bbb5-5e94c241f009"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 69, DateTimeKind.Local).AddTicks(1106), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Upgradable interactive strategy", null },
                    { new Guid("7f875f9a-ba18-4e56-b8fd-ddde74639b61"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(7627), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Profound multi-state middleware", null },
                    { new Guid("7fd9ec0b-bec1-4f34-b836-47ca7affbf25"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(9675), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Re-contextualized dynamic contingency", null },
                    { new Guid("82cae793-2323-419e-97aa-c50c861abfd4"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 69, DateTimeKind.Local).AddTicks(583), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Right-sized grid-enabled collaboration", null },
                    { new Guid("8891612f-46cd-498a-a7ef-2c1276a309cd"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(9134), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Innovative needs-based interface", null },
                    { new Guid("8bf8561b-94a6-4659-90f6-95df907d3fb9"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(7753), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Progressive solution-oriented support", null },
                    { new Guid("911b7123-864f-48c7-9d71-cdbf159811a9"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 69, DateTimeKind.Local).AddTicks(333), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Realigned web-enabled model", null },
                    { new Guid("92ea0e14-6cdf-410b-9abd-a1cea75da287"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(8642), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Enhanced uniform emulation", null },
                    { new Guid("9e718d2d-a107-4711-a5d5-60476ddc9447"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(5253), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Persevering secondary portal", null },
                    { new Guid("9fcdd70b-9846-4614-9683-ff736975148b"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 69, DateTimeKind.Local).AddTicks(959), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Fundamental heuristic focus group", null },
                    { new Guid("a965fbbd-d3a6-4329-9d54-da381f865e93"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(4315), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Streamlined 3rd generation projection", null },
                    { new Guid("ab6d4d63-121f-4237-b0b1-86baa4576c81"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(9521), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Polarised incremental secured line", null },
                    { new Guid("b29113f7-4bf7-47d2-8eee-e5c8a07b377f"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 69, DateTimeKind.Local).AddTicks(465), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Synergistic discrete throughput", null },
                    { new Guid("c30df4aa-3105-45b8-b98a-2f521561e95d"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(4664), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Horizontal zero administration forecast", null },
                    { new Guid("cc880ba5-e366-4c21-bee6-bcf59393e3d3"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(9925), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Realigned zero tolerance hardware", null },
                    { new Guid("cde386f9-d2c3-4dd5-8f44-60bec4dc406d"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(7497), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Right-sized exuding definition", null },
                    { new Guid("cf36c103-f73c-4bc4-a296-e15b1a0fb8da"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(7359), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Function-based methodical circuit", null },
                    { new Guid("d152c1df-acdd-4490-a982-2ef7640368a1"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(8336), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Public-key explicit synergy", null },
                    { new Guid("d287c88a-9679-4a09-9d54-d02c943eecfc"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(7249), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Diverse client-server installation", null },
                    { new Guid("d4b4496d-87ab-4040-8699-f182eaa31f30"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 69, DateTimeKind.Local).AddTicks(209), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Profound explicit framework", null },
                    { new Guid("d904975f-4ee8-4a19-aa22-61198506d218"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(8528), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Proactive multi-tasking projection", null },
                    { new Guid("ea895d78-fb61-47be-8a63-e8a53071d582"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(5407), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Cloned system-worthy hierarchy", null }
                });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title", "VerdictMessage" },
                values: new object[] { new Guid("f3314484-db21-45f7-8c2e-81e1d21b507d"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(4426), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Multi-lateral intangible interface", null });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title", "VerdictMessage" },
                values: new object[] { new Guid("fb9139de-946c-42cb-bcf1-ee1cd7c98590"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 21, 1, 38, 59, 68, DateTimeKind.Local).AddTicks(8881), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Automated motivating protocol", null });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[,]
                {
                    { new Guid("02de5548-2104-4056-b1e9-6f54eaa8e585"), new Guid("9e718d2d-a107-4711-a5d5-60476ddc9447"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("0466100a-97bc-411f-a4ce-7489f5e34956"), new Guid("09c7d20c-24eb-468f-bb5e-f87920e50c5f"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("09f568d1-3db5-4ba3-9cbe-dd346a9a8ed1"), new Guid("45b4fc8e-2f95-4182-962f-3df8ee57d202"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("0fa9c5a9-eb80-45d7-aeba-052cff664e37"), new Guid("65d08a16-0de4-4d0a-a35f-8573c67ddba7"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("137cffd9-7f6a-4682-942b-d762b322443c"), new Guid("6db1aaaf-d358-4419-adbb-97b69f393467"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("13ac22e2-cb1e-4042-89ad-97a1ba56da80"), new Guid("7fd9ec0b-bec1-4f34-b836-47ca7affbf25"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("170a7bb8-fb45-4ec0-b159-36207be6ad67"), new Guid("505ad716-06bc-4b9b-a7bc-4fa758c08cb0"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("1eb155df-7716-4872-9dc5-0a2a6710a6ff"), new Guid("b29113f7-4bf7-47d2-8eee-e5c8a07b377f"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("1f27256e-6544-4703-83e4-32ccea260760"), new Guid("1b51e9fe-f85b-4539-9c13-0bf0c8175af2"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("29a8e4e2-8d0d-4dd3-b779-f846d7c5f411"), new Guid("70d73ad4-eb17-4fdd-bbb5-5e94c241f009"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("2f6a6161-63eb-46df-a903-326a42f2f5cb"), new Guid("911b7123-864f-48c7-9d71-cdbf159811a9"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("33dd17e9-c334-4410-ac92-a05fd5a86776"), new Guid("cf36c103-f73c-4bc4-a296-e15b1a0fb8da"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("343f1d93-554a-4ec0-b36d-90f0de3af634"), new Guid("ab6d4d63-121f-4237-b0b1-86baa4576c81"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("3b25dc1e-073f-4946-b1ec-a54d50850dd9"), new Guid("fb9139de-946c-42cb-bcf1-ee1cd7c98590"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("417af53f-2143-47b5-a4a1-2e0935a4b583"), new Guid("d287c88a-9679-4a09-9d54-d02c943eecfc"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("42fbd90d-a58c-401a-9567-8cacbf543be5"), new Guid("22d57093-97e4-4915-a42c-a8da24dc7049"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("436b1e1f-ba13-4e04-a97e-2d0360318eab"), new Guid("3043bcea-77f9-4ff3-94ca-03e31d57ce05"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("43fb6435-cd32-48ed-9d53-b5a5d7325ad6"), new Guid("ea895d78-fb61-47be-8a63-e8a53071d582"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("46ccdf00-ba50-4499-b36f-2f9b4339dbf5"), new Guid("6eee5997-1735-4ecd-992b-b7af39f48166"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("4b5ea198-27de-48d6-8090-9b9440783cc7"), new Guid("fb9139de-946c-42cb-bcf1-ee1cd7c98590"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("4f495f76-2523-491b-9d9c-907970edde8b"), new Guid("cc880ba5-e366-4c21-bee6-bcf59393e3d3"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("511470ac-24f2-4a37-8b7a-084de1978cbb"), new Guid("70d73ad4-eb17-4fdd-bbb5-5e94c241f009"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("54ad372d-6ef8-4a1e-b040-d8434f20b2b3"), new Guid("cde386f9-d2c3-4dd5-8f44-60bec4dc406d"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("571b4fae-f0f2-4093-b4a5-3e03cac2581f"), new Guid("70408819-2d19-4eb6-ae11-7f49c63d20d9"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("58ff6d97-a112-4588-bab8-0bcf35f97c1e"), new Guid("a965fbbd-d3a6-4329-9d54-da381f865e93"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("5b68d328-f66f-4e00-9ac4-403fbd311f6f"), new Guid("16b71731-3e44-47de-9b30-e3cecf1861d7"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("5fd44cfa-02f3-46a8-860d-b9795dd99adc"), new Guid("92ea0e14-6cdf-410b-9abd-a1cea75da287"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("627db45d-c226-4bd7-9d36-60b7932a7117"), new Guid("d4b4496d-87ab-4040-8699-f182eaa31f30"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("63d6aaab-095c-4726-8c6d-894346fdfa1b"), new Guid("7f875f9a-ba18-4e56-b8fd-ddde74639b61"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("6518f768-2787-418f-b758-2b3f209ca0fd"), new Guid("70408819-2d19-4eb6-ae11-7f49c63d20d9"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("66e837c6-5277-4c21-8869-bf749e544cc3"), new Guid("d4b4496d-87ab-4040-8699-f182eaa31f30"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("68becda4-58ab-4dfb-a902-21e0490336c5"), new Guid("538193e6-703c-4b28-bb95-3c89f398fedf"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("69b65378-886e-4a65-b9de-c850060287b3"), new Guid("65d08a16-0de4-4d0a-a35f-8573c67ddba7"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("6b925d07-680c-4da1-89ce-5fb176dae523"), new Guid("135e29df-505d-4f0f-bea4-c8ac714b6325"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("6d57dfcb-f388-4621-aa81-fe6004a737a5"), new Guid("f3314484-db21-45f7-8c2e-81e1d21b507d"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("6ff0f221-0b50-4291-96e9-3765250d0c11"), new Guid("911b7123-864f-48c7-9d71-cdbf159811a9"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("7091362c-36fa-40cd-8dd4-1279337646b7"), new Guid("70d73ad4-eb17-4fdd-bbb5-5e94c241f009"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("71f1ce79-bc5a-49d9-b0bb-e4f0c7247721"), new Guid("7fd9ec0b-bec1-4f34-b836-47ca7affbf25"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("743e61db-2f05-4499-92fd-2c4e964a3c96"), new Guid("9fcdd70b-9846-4614-9683-ff736975148b"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("76ff70b9-014f-4c86-a82e-20135de261de"), new Guid("d904975f-4ee8-4a19-aa22-61198506d218"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("77cff84e-7255-4362-ae93-c3cb0b0a05d2"), new Guid("c30df4aa-3105-45b8-b98a-2f521561e95d"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("7b782a20-6f28-4b68-8fc4-d4b92858c064"), new Guid("f3314484-db21-45f7-8c2e-81e1d21b507d"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") }
                });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[,]
                {
                    { new Guid("7de69403-7b5a-462d-a1a3-2b7e42889c13"), new Guid("d152c1df-acdd-4490-a982-2ef7640368a1"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("7f478d03-7db4-40ce-a721-1c1e504ba902"), new Guid("ea895d78-fb61-47be-8a63-e8a53071d582"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("7f827d8d-52a9-4c7f-aff5-8a7e2f712105"), new Guid("135e29df-505d-4f0f-bea4-c8ac714b6325"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("87e1bd33-59a8-469b-840b-67a8af5988e5"), new Guid("505ad716-06bc-4b9b-a7bc-4fa758c08cb0"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("8eee1e5a-250f-46b6-b9da-cc7506ccb783"), new Guid("8bf8561b-94a6-4659-90f6-95df907d3fb9"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("8fa8d272-e6e9-45e0-a440-30464f0931cb"), new Guid("6a9f9236-982d-43cb-8a8b-756bf6c82c4f"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("910e7ccf-14c9-4b0f-835b-d6f21eaaab4f"), new Guid("6a9f9236-982d-43cb-8a8b-756bf6c82c4f"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("917f60a8-f1c0-4266-a2c6-252cf0081584"), new Guid("911b7123-864f-48c7-9d71-cdbf159811a9"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("92637f47-f11c-49e9-be64-d3b82c3b9f31"), new Guid("6b8e5216-9c63-4ae4-a2ed-32f04767d9bf"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("97658a07-322d-4e58-92e1-988e093615c3"), new Guid("fb9139de-946c-42cb-bcf1-ee1cd7c98590"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("996a6d95-d0d5-4098-add4-505d62d39e27"), new Guid("477153c6-4820-449f-b7d7-100a8574b844"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("9ad75d9d-0056-4320-9ba0-f5cf6771c4f8"), new Guid("82cae793-2323-419e-97aa-c50c861abfd4"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("a3e28860-19f2-4f38-96f4-b88c94abf985"), new Guid("6b8e5216-9c63-4ae4-a2ed-32f04767d9bf"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("a40ed0b4-396f-428b-bce6-ab09cbbdbe47"), new Guid("ea895d78-fb61-47be-8a63-e8a53071d582"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("a45d8bec-6a9c-4aa5-ad08-0a8f428c9e2d"), new Guid("cde386f9-d2c3-4dd5-8f44-60bec4dc406d"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("a5ab5676-deaf-48db-bc30-8356c8abf45e"), new Guid("45b4fc8e-2f95-4182-962f-3df8ee57d202"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("a788db9e-0bbb-4091-982c-ac3c979b6360"), new Guid("9e718d2d-a107-4711-a5d5-60476ddc9447"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("a952c9ea-196b-4730-88f4-5900ff881c55"), new Guid("92ea0e14-6cdf-410b-9abd-a1cea75da287"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("ab778f9d-847a-4174-a2b8-e6260ecee3c9"), new Guid("5307a5a2-338e-4cb5-867b-027f3a514352"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("ac0f9f56-5d6b-4baf-9c54-be49f525c17c"), new Guid("09c7d20c-24eb-468f-bb5e-f87920e50c5f"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("adfa03e8-52ce-4134-b5c3-0f1d0867b955"), new Guid("505ad716-06bc-4b9b-a7bc-4fa758c08cb0"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("ae076dd7-b34a-491d-a549-2467a452188d"), new Guid("cf36c103-f73c-4bc4-a296-e15b1a0fb8da"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("ae1065c2-c9f3-49d6-b476-765ee732f134"), new Guid("6eee5997-1735-4ecd-992b-b7af39f48166"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("af1f790b-3c62-4af3-8ea3-924abaa1b178"), new Guid("cf36c103-f73c-4bc4-a296-e15b1a0fb8da"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("b4581785-8113-4403-8eea-45c6cd83e99c"), new Guid("8891612f-46cd-498a-a7ef-2c1276a309cd"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("b63c9cfb-d8d6-47ee-8204-7b2aff7affa8"), new Guid("92ea0e14-6cdf-410b-9abd-a1cea75da287"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("b895ec72-4675-44ee-9c8c-68454382a953"), new Guid("265462fc-4390-4a91-9d93-7bc8d3f8aafd"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("b936f57f-a2e4-49b3-9d1a-5ecfa4a8a701"), new Guid("16b71731-3e44-47de-9b30-e3cecf1861d7"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("ba455c3d-e3fb-4ef2-98d3-c505afc9ce77"), new Guid("d4b4496d-87ab-4040-8699-f182eaa31f30"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("bdcfac06-827c-4a5d-a813-640bf46bc49d"), new Guid("22d57093-97e4-4915-a42c-a8da24dc7049"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("c5426043-f7cc-4de9-9f92-0110bf7229c6"), new Guid("265462fc-4390-4a91-9d93-7bc8d3f8aafd"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("cca6295d-b146-4809-869c-8aaddedc8307"), new Guid("8891612f-46cd-498a-a7ef-2c1276a309cd"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("d446b806-76f3-40a8-bf43-754726af4cb2"), new Guid("477153c6-4820-449f-b7d7-100a8574b844"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("d476a0d5-da74-40e6-b73a-531bc4edb210"), new Guid("c30df4aa-3105-45b8-b98a-2f521561e95d"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("d7c6550a-0d4a-4bb3-9a37-7615434c06d2"), new Guid("6b8e5216-9c63-4ae4-a2ed-32f04767d9bf"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("dc76c241-6006-4f34-947b-cc430fee4a1d"), new Guid("65d08a16-0de4-4d0a-a35f-8573c67ddba7"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("dd2af880-a9d8-41cd-b72c-7b5d7f8edeb8"), new Guid("9fcdd70b-9846-4614-9683-ff736975148b"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("e05989e2-25af-4ca8-a2f6-72dda8e4d04d"), new Guid("d152c1df-acdd-4490-a982-2ef7640368a1"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("e8b9e92f-d492-410f-92a3-2a7c4a89c382"), new Guid("7fd9ec0b-bec1-4f34-b836-47ca7affbf25"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("f6e15619-5cbe-4f3d-b99c-5c35c93daca7"), new Guid("7f875f9a-ba18-4e56-b8fd-ddde74639b61"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("f737a693-6e32-4d86-bd8e-dc7874e5cbe7"), new Guid("f3314484-db21-45f7-8c2e-81e1d21b507d"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("fa5d7bd1-30ae-4ea7-b218-0e00e184290c"), new Guid("cc880ba5-e366-4c21-bee6-bcf59393e3d3"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") }
                });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[] { new Guid("fab57138-093a-43ad-96a4-299da9999bba"), new Guid("9e718d2d-a107-4711-a5d5-60476ddc9447"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") });

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
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

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

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
