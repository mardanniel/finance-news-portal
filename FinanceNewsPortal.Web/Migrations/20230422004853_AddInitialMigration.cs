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
                    { "08715f79-2c99-4a8b-935a-7ff2e37d1518", "35644d0d-96f1-406c-b802-0d32b6c7bc09", "Moderator", "MODERATOR" },
                    { "1a73053f-78c6-41c2-94fc-d897ccc8b33c", "8f3c4cbb-8dd2-4535-81b8-ccbc4c5d74b2", "Publisher", "PUBLISHER" },
                    { "705c9705-c8a8-44af-99a3-e33b13856856", "6ec655bb-87c2-4863-96f0-0f7ed3a93fb2", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyId", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageFilePath", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { "147c0de8-847c-4466-ad04-1fc7b563e0c4", 0, null, "35e6b9b2-6c5f-485e-b969-c334404d8e41", new DateTime(2023, 4, 22, 8, 48, 53, 122, DateTimeKind.Local).AddTicks(3005), "admindavidacosta@email.com", false, "David", "M", null, "Acosta", false, null, "ADMINDAVIDACOSTA@EMAIL.COM", "ADMINDAVIDACOSTA@EMAIL.COM", "AQAAAAEAACcQAAAAEMVvSC1wAgiPhZLqplYltskHGq8RmjUHIDS0lM8ArsGGCw2ZaIMAf3gsheHy7dHyMQ==", null, false, "5e3a07ee-d3d4-4d46-ba1e-33e4940cd821", true, false, "admindavidacosta@email.com" });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Address", "FoundedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("45e2f212-8d95-4629-8ff2-a01f999139a3"), "Reliance corner Sheridan Streets, Barangay Buayang Bato, Mandaluyong, Metro Manila, Philippines", new DateTime(2023, 4, 22, 8, 48, 53, 122, DateTimeKind.Local).AddTicks(2934), "TV8 Network" },
                    { new Guid("bc41b6d7-981e-4d53-b291-2b1d8d34bc69"), "EDSA Cor. Timog Ave., Diliman, Quezon City, Philippines", new DateTime(2023, 4, 22, 8, 48, 53, 122, DateTimeKind.Local).AddTicks(2916), "JME Network" },
                    { new Guid("d7bff58e-de3e-4a55-976b-385bc600ac0f"), "Sgt. Esguerra Avenue corner Mother Ignacia Street, Brgy. South Triangle, Diliman, Quezon City", new DateTime(2023, 4, 22, 8, 48, 53, 122, DateTimeKind.Local).AddTicks(2932), "IBS-ZBM Network" }
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
                values: new object[] { "8c0b055f-d24d-43be-b842-4393d0b68d61", 0, new Guid("d7bff58e-de3e-4a55-976b-385bc600ac0f"), "9410a4b6-a591-4f3f-8e40-5864ed44a241", new DateTime(2023, 4, 22, 8, 48, 53, 125, DateTimeKind.Local).AddTicks(1788), "modjennylenner@email.com", false, "Jenny", "M", null, "Lenner", false, null, "MODJENNYLENNER@EMAIL.COM", "MODJENNYLENNER@EMAIL.COM", "AQAAAAEAACcQAAAAELRqJNN1uNjJKcF1FVnXXf6P77XfcFMmq1WeBwl82t4gGX0Z+EbznjNCzIHwUt0u+g==", null, false, "2875b072-7591-4fdb-ae5f-a97cb80badfe", true, false, "modjennylenner@email.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyId", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageFilePath", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cba87ff8-bb15-442f-8a47-0e65a93cab8c", 0, new Guid("d7bff58e-de3e-4a55-976b-385bc600ac0f"), "f5360adb-01fd-4b35-9674-18871c6aa954", new DateTime(2023, 4, 22, 8, 48, 53, 123, DateTimeKind.Local).AddTicks(8403), "authormikeburner@email.com", false, "Mike", "M", null, "Burner", false, null, "AUTHORMIKEBURNER@EMAIL.COM", "AUTHORMIKEBURNER@EMAIL.COM", "AQAAAAEAACcQAAAAENwzJsIJnd60k1PPl/8bwvZRuK8JLGy7RivzngfjWwrDlSt72FY2/e3IIbDZ569f6A==", null, false, "599b0fc3-e6f6-43cf-9fae-b16acda65093", true, false, "authormikeburner@email.com" });

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
                    { new Guid("056a00bd-24bc-4b15-8cd6-b46bec54a2e9"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(7753), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Cross-platform systemic structure", null },
                    { new Guid("0eedba95-019e-40bf-a5cc-e0e06e3165e3"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(5030), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Visionary incremental collaboration", null },
                    { new Guid("0fb0b93b-a782-4326-8578-940afd524ea6"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(2875), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Automated even-keeled artificial intelligence", null },
                    { new Guid("15413a1b-b72c-49ff-86c3-4b3f0efbb3e2"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(7882), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Distributed object-oriented core", null },
                    { new Guid("17ff939f-b502-4b52-9624-f2e79266bd95"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(5185), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Cross-group 24 hour encoding", null },
                    { new Guid("215c45d2-80a5-435d-932e-92df29d680f3"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(8237), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Inverse background ability", null },
                    { new Guid("22f394f4-f952-4c94-bc76-df8fcf61db2a"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(3028), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Quality-focused dedicated workforce", null },
                    { new Guid("2e74b34d-5357-42e7-8321-8ade6a95181f"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(8507), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Virtual disintermediate frame", null },
                    { new Guid("2e9ab576-bc05-4766-9a80-d29316ea2322"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 126, DateTimeKind.Local).AddTicks(8505), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Balanced content-based task-force", null },
                    { new Guid("32af05fc-6048-4a88-8ead-608af913996e"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(6696), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Phased tangible project", null },
                    { new Guid("37e4a15e-0727-4342-90ff-039b06f45ead"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(6205), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "User-friendly tertiary hierarchy", null },
                    { new Guid("3a3eea7a-d80c-4811-93f1-e5571e0f20bf"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(1340), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "User-centric interactive concept", null },
                    { new Guid("3f7f141c-ea98-4ae8-86d0-7c9cbcf97488"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(8647), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Right-sized attitude-oriented utilisation", null },
                    { new Guid("47b62aae-4923-418a-9cbb-248965981b12"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 126, DateTimeKind.Local).AddTicks(8897), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Cloned 4th generation moratorium", null },
                    { new Guid("4939e2b8-fc8a-4014-b580-1455ed506e34"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(7500), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Multi-lateral multimedia functionalities", null },
                    { new Guid("4a121607-ce51-4671-85fd-ab1741b9b824"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(1084), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Enterprise-wide hybrid ability", null },
                    { new Guid("4f22de1f-d072-4900-913c-ad36cc5626d2"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(4245), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "User-friendly demand-driven task-force", null },
                    { new Guid("4f5e20ce-164b-4bec-927a-0c8bfe7b5ba3"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 126, DateTimeKind.Local).AddTicks(9867), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Upgradable scalable intranet", null },
                    { new Guid("530af0b3-f10e-4956-8fdd-3b532b29d949"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(7298), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Profound well-modulated paradigm", null },
                    { new Guid("54814a15-94c5-4a95-9a6c-a73e69b77b2e"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(1920), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Team-oriented motivating capability", null },
                    { new Guid("55197821-ed3a-4228-b9d9-355678c9569f"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(3945), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Diverse even-keeled website", null },
                    { new Guid("63283afa-dd8c-4bcb-9001-d57e9a19f0d2"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(7152), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Intuitive needs-based neural-net", null },
                    { new Guid("64cb493e-52f8-4f96-99f3-5d6ee873a23e"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 126, DateTimeKind.Local).AddTicks(9234), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Managed dynamic projection", null },
                    { new Guid("651ab29d-bb8f-4b16-824d-83727527524c"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(8398), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Profound heuristic secured line", null },
                    { new Guid("70075ce7-fd72-4643-ac43-b971be540e6b"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(6313), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Re-contextualized upward-trending structure", null },
                    { new Guid("796c9df3-2298-4294-afac-15d9031b4288"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(7040), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Horizontal tangible moderator", null },
                    { new Guid("8297ddc5-1ddd-436b-aaa7-34e5c1c13e6e"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(5327), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "User-centric background encoding", null },
                    { new Guid("839776cd-85bf-403a-b28c-f48dfd29cc84"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 126, DateTimeKind.Local).AddTicks(9523), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Polarised web-enabled pricing structure", null },
                    { new Guid("9684587f-0753-4aa1-b819-65a6eb42bb2c"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(6426), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Future-proofed homogeneous methodology", null },
                    { new Guid("9db7819c-8f2e-45bd-a2dd-681e4d646dbf"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(8099), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Front-line human-resource synergy", null },
                    { new Guid("9e6a9d5c-6119-4925-83a2-7d4641bd93a6"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(7626), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Decentralized actuating hierarchy", null },
                    { new Guid("af065766-30f1-4a7e-92d3-2f0a5049c01d"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(4899), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Distributed next generation challenge", null },
                    { new Guid("ccd6201a-fcce-4280-8baa-e84a64eb2e13"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(6928), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Compatible full-range matrix", null },
                    { new Guid("dcd8883e-1d63-4da8-898f-bfaa629bce18"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(1647), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Seamless needs-based database", null },
                    { new Guid("dee52872-b3ec-4a37-9d61-4757c8294ca6"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(6812), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Switchable object-oriented budgetary management", null },
                    { new Guid("e20c799e-3412-496b-a92a-940af4d4d282"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(6545), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Optimized heuristic collaboration", null },
                    { new Guid("e5668f0b-ed05-454e-af7a-399f100b476c"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 126, DateTimeKind.Local).AddTicks(7144), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Assimilated mobile service-desk", null },
                    { new Guid("ed72668e-92ab-4f9b-bb8b-8857a138a2e0"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(4616), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Distributed zero administration policy", null },
                    { new Guid("efb7c1c7-b911-49bf-a6a5-fe30671dbfa1"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(7998), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Synergized 6th generation analyzer", null },
                    { new Guid("eff798d8-3d2f-420a-9529-345593e1fe41"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(4485), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Public-key zero administration artificial intelligence", null }
                });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title", "VerdictMessage" },
                values: new object[] { new Guid("f2cae8b2-66aa-4046-98d5-1294c82306b7"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(5879), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Reverse-engineered systematic pricing structure", null });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title", "VerdictMessage" },
                values: new object[] { new Guid("fe92bfd0-bc71-455d-93cc-0ec75f1fb483"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 22, 8, 48, 53, 127, DateTimeKind.Local).AddTicks(6010), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Innovative didactic initiative", null });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[,]
                {
                    { new Guid("025c1ca0-8e9c-4aac-aad3-e7bda839b8f4"), new Guid("796c9df3-2298-4294-afac-15d9031b4288"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("02ffe2a4-1ae9-4e03-a557-32fd8ac79638"), new Guid("55197821-ed3a-4228-b9d9-355678c9569f"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("057e8ac0-7782-4a0b-8bdf-521956fd74ce"), new Guid("9db7819c-8f2e-45bd-a2dd-681e4d646dbf"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("059a9377-f379-49b0-877b-68ae1e5cce8f"), new Guid("54814a15-94c5-4a95-9a6c-a73e69b77b2e"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("05cd399f-c6b5-45e1-8b70-1809e6b63b5d"), new Guid("47b62aae-4923-418a-9cbb-248965981b12"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("0c92dcdb-1bd1-4f9e-b419-f694a3685028"), new Guid("3a3eea7a-d80c-4811-93f1-e5571e0f20bf"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("11ec6676-3e19-4eca-b2f6-6c33d97770b9"), new Guid("e20c799e-3412-496b-a92a-940af4d4d282"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("12867bfa-4a33-4a50-b9c2-bb3edf491e2b"), new Guid("af065766-30f1-4a7e-92d3-2f0a5049c01d"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("1369f18f-c985-4812-a2c2-c81fd2fc7f5d"), new Guid("63283afa-dd8c-4bcb-9001-d57e9a19f0d2"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("1d99cae9-fd93-4e32-9d40-9b67e3b68f47"), new Guid("215c45d2-80a5-435d-932e-92df29d680f3"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("24f91e35-e015-4b7b-b38f-fd9ca0ad5e20"), new Guid("796c9df3-2298-4294-afac-15d9031b4288"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("2d9c0377-2304-4ab7-91dc-dc9764030719"), new Guid("0fb0b93b-a782-4326-8578-940afd524ea6"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("2e5fc641-136a-495d-9a65-2ea61e731c54"), new Guid("4f22de1f-d072-4900-913c-ad36cc5626d2"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("30fad281-1ec9-4f84-bd9b-5b65273d0bb3"), new Guid("efb7c1c7-b911-49bf-a6a5-fe30671dbfa1"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("34939cf8-9298-476a-9633-069c63700c70"), new Guid("0eedba95-019e-40bf-a5cc-e0e06e3165e3"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("37747686-99ef-49af-9e24-effbaa60fb00"), new Guid("22f394f4-f952-4c94-bc76-df8fcf61db2a"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("3b3ad3b6-6dc0-4f2d-9582-9df44f9bbef4"), new Guid("32af05fc-6048-4a88-8ead-608af913996e"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("41482fbe-f19a-4503-a332-3d00cf71a83e"), new Guid("4f22de1f-d072-4900-913c-ad36cc5626d2"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("4492bd67-f1b3-4298-9ef8-639edc78fff2"), new Guid("4a121607-ce51-4671-85fd-ab1741b9b824"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("44b5b4be-9494-4b81-84e4-17cfa89c2e11"), new Guid("ccd6201a-fcce-4280-8baa-e84a64eb2e13"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("45593ea9-336e-4b17-9da2-d809aa938de1"), new Guid("9db7819c-8f2e-45bd-a2dd-681e4d646dbf"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("47205ea2-7780-4a63-8c63-4f8b2c2fbe28"), new Guid("dcd8883e-1d63-4da8-898f-bfaa629bce18"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("47b039d2-516c-4170-94ce-5ca148ed6778"), new Guid("64cb493e-52f8-4f96-99f3-5d6ee873a23e"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("4b1957cd-a4d4-4fce-89aa-8f39bb4233d9"), new Guid("dcd8883e-1d63-4da8-898f-bfaa629bce18"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("4bacfc5f-bc37-45f4-b1ce-14d5df86422f"), new Guid("ed72668e-92ab-4f9b-bb8b-8857a138a2e0"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("4e0069f3-24b2-43b2-b749-b0bb0a19dfea"), new Guid("70075ce7-fd72-4643-ac43-b971be540e6b"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("4e6788ec-1e1c-4700-8ee8-cf1186987e1e"), new Guid("ccd6201a-fcce-4280-8baa-e84a64eb2e13"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("4eb0f629-74ae-42c6-934b-ca7a46bcbe61"), new Guid("fe92bfd0-bc71-455d-93cc-0ec75f1fb483"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("53982ef7-4ec7-49fb-ac65-fdc0043d55a1"), new Guid("3f7f141c-ea98-4ae8-86d0-7c9cbcf97488"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("58817f11-6a9d-4f6e-adbe-fbb9757b1de6"), new Guid("651ab29d-bb8f-4b16-824d-83727527524c"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("5dfe4c68-d0b0-40b3-809a-1c247116963e"), new Guid("af065766-30f1-4a7e-92d3-2f0a5049c01d"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("5fffecaa-64da-4475-a980-b53cafaa6736"), new Guid("f2cae8b2-66aa-4046-98d5-1294c82306b7"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("6165fd34-90b4-4087-b522-46252ee4443b"), new Guid("17ff939f-b502-4b52-9624-f2e79266bd95"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("6410fb44-71aa-4a00-adea-893412a075d1"), new Guid("32af05fc-6048-4a88-8ead-608af913996e"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("658fd617-fd5c-4e61-9faf-47463a4ddbbf"), new Guid("32af05fc-6048-4a88-8ead-608af913996e"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("69e3a3c7-4492-44cc-95e2-572fdcc8c72a"), new Guid("15413a1b-b72c-49ff-86c3-4b3f0efbb3e2"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("69ffa9be-1ca9-44f9-9637-146bbd063cb1"), new Guid("9e6a9d5c-6119-4925-83a2-7d4641bd93a6"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("6dca05b8-b38b-43a9-a538-5d55eb3b2197"), new Guid("530af0b3-f10e-4956-8fdd-3b532b29d949"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("6e81bdae-858c-40f5-8fe0-f407441a2c1e"), new Guid("796c9df3-2298-4294-afac-15d9031b4288"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("6f2bafb5-4ca9-4039-b2a1-41ffeb1c4d28"), new Guid("15413a1b-b72c-49ff-86c3-4b3f0efbb3e2"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("7a2355f3-807b-42e9-a339-9e3acbfc8cc5"), new Guid("f2cae8b2-66aa-4046-98d5-1294c82306b7"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("7c594efb-053f-4bfa-a300-a1a220b4268d"), new Guid("54814a15-94c5-4a95-9a6c-a73e69b77b2e"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") }
                });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[,]
                {
                    { new Guid("7d245892-469d-4302-b83f-b589df0a5eba"), new Guid("839776cd-85bf-403a-b28c-f48dfd29cc84"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("7f472c08-5daf-42d5-8183-40e705ca62fb"), new Guid("9db7819c-8f2e-45bd-a2dd-681e4d646dbf"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("805e7741-b3c2-48a4-8765-79cb5b0d046a"), new Guid("70075ce7-fd72-4643-ac43-b971be540e6b"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("8755dd19-7498-42b1-bce0-c82fffd9370c"), new Guid("37e4a15e-0727-4342-90ff-039b06f45ead"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("890f18ea-a2c7-4304-a62f-0bb038946438"), new Guid("0fb0b93b-a782-4326-8578-940afd524ea6"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("8d5bb353-2449-4388-b7a7-18f9ea1c5684"), new Guid("47b62aae-4923-418a-9cbb-248965981b12"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("8e924ed0-f293-4735-bf92-1ee90839feb1"), new Guid("37e4a15e-0727-4342-90ff-039b06f45ead"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("9022b459-1e3b-45c8-8037-ce00f23446b1"), new Guid("fe92bfd0-bc71-455d-93cc-0ec75f1fb483"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("912b6fd2-7ff2-4e42-86c2-3aec596cc9bc"), new Guid("eff798d8-3d2f-420a-9529-345593e1fe41"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("94a17026-83e9-47d5-85f3-0703da12a79d"), new Guid("839776cd-85bf-403a-b28c-f48dfd29cc84"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("9c30a60f-26c6-4a14-885e-36fc1cf32644"), new Guid("3a3eea7a-d80c-4811-93f1-e5571e0f20bf"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("9d206428-0975-4082-b024-8e4e458b51fc"), new Guid("4939e2b8-fc8a-4014-b580-1455ed506e34"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("a014b28b-a030-4d46-8584-1655f2125aa8"), new Guid("4f5e20ce-164b-4bec-927a-0c8bfe7b5ba3"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("a1ecbcdb-2cfd-4603-a880-c4b63e7e58bd"), new Guid("651ab29d-bb8f-4b16-824d-83727527524c"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("a2fe6a0d-b303-4d5d-b9ce-b49bb1454ed4"), new Guid("215c45d2-80a5-435d-932e-92df29d680f3"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("ac853001-d78c-46e7-a4af-64e7ace13560"), new Guid("2e74b34d-5357-42e7-8321-8ade6a95181f"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("ad464200-3e77-4d4e-8d84-0e69594a4af4"), new Guid("63283afa-dd8c-4bcb-9001-d57e9a19f0d2"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("ad4f4506-c3f7-4ce9-aebf-2b4551c89e13"), new Guid("fe92bfd0-bc71-455d-93cc-0ec75f1fb483"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("aeab77e5-8b6e-47d2-a496-320d1facd97b"), new Guid("15413a1b-b72c-49ff-86c3-4b3f0efbb3e2"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("b12fb5b8-f416-4193-a9a8-ffc3311f8d6f"), new Guid("70075ce7-fd72-4643-ac43-b971be540e6b"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("b24fee0c-4fd0-4644-99cc-a85db60fa49e"), new Guid("eff798d8-3d2f-420a-9529-345593e1fe41"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("b2d3d634-e6a4-4a21-9395-d27417628909"), new Guid("4f5e20ce-164b-4bec-927a-0c8bfe7b5ba3"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("b47d7d9c-2c67-43e4-8cea-e42c616350c9"), new Guid("3a3eea7a-d80c-4811-93f1-e5571e0f20bf"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("bc9bb152-a7fb-40b6-876e-424e7284e73d"), new Guid("0eedba95-019e-40bf-a5cc-e0e06e3165e3"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("bf2be2e3-5e59-47c0-8f25-f17289e158af"), new Guid("530af0b3-f10e-4956-8fdd-3b532b29d949"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("c1c8b96d-04e4-48fd-8655-cb0d9ae35b68"), new Guid("2e9ab576-bc05-4766-9a80-d29316ea2322"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("c233e078-9377-4af2-bdad-f67710d6e8da"), new Guid("056a00bd-24bc-4b15-8cd6-b46bec54a2e9"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("c38b7e4b-f04a-42a6-9e18-03be04dc97d4"), new Guid("4f5e20ce-164b-4bec-927a-0c8bfe7b5ba3"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("c3c52cc9-d75c-4b60-94d7-c9e13afe8be1"), new Guid("9e6a9d5c-6119-4925-83a2-7d4641bd93a6"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("c4c92393-4a11-4ddf-b571-e6aed2062fa4"), new Guid("dee52872-b3ec-4a37-9d61-4757c8294ca6"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("cb977fde-a335-4a08-bd43-ec782388bd7b"), new Guid("530af0b3-f10e-4956-8fdd-3b532b29d949"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("d38a7847-4eb7-40bb-b4f5-d85aa2f3e21f"), new Guid("eff798d8-3d2f-420a-9529-345593e1fe41"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("d4c17b11-3310-416d-8106-a27b57a32547"), new Guid("dee52872-b3ec-4a37-9d61-4757c8294ca6"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("d94d9c4a-9bfa-4226-b0e8-f3bd2b9dd100"), new Guid("9684587f-0753-4aa1-b819-65a6eb42bb2c"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("dae95703-59d8-48a6-9c17-37638b6d467c"), new Guid("2e74b34d-5357-42e7-8321-8ade6a95181f"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("dfe23108-bc6e-410b-af23-3a809ed65129"), new Guid("0eedba95-019e-40bf-a5cc-e0e06e3165e3"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("e17bdf44-bdd7-43c6-a2d0-e92c31dd58cf"), new Guid("9684587f-0753-4aa1-b819-65a6eb42bb2c"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("e6fec344-cb77-409f-8de8-ac07fc20b386"), new Guid("215c45d2-80a5-435d-932e-92df29d680f3"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("f1fb1a8e-4703-4da7-8091-622579a51ff6"), new Guid("ed72668e-92ab-4f9b-bb8b-8857a138a2e0"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("f788b5d6-a856-44d9-a5ed-52f411bce129"), new Guid("839776cd-85bf-403a-b28c-f48dfd29cc84"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("f93e15cd-0d9c-470e-8179-c16392011c45"), new Guid("e5668f0b-ed05-454e-af7a-399f100b476c"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("fa94710d-daae-428e-88fb-b6523054f26f"), new Guid("47b62aae-4923-418a-9cbb-248965981b12"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") }
                });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[] { new Guid("fe623476-758d-4de3-a0ee-bd486d6a6608"), new Guid("3f7f141c-ea98-4ae8-86d0-7c9cbcf97488"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[] { new Guid("fefdcfa6-449a-47ad-b00d-971a72688517"), new Guid("8297ddc5-1ddd-436b-aaa7-34e5c1c13e6e"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") });

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
