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
                    { "08715f79-2c99-4a8b-935a-7ff2e37d1518", "a1ffbe71-c655-438a-975a-9384b5869d81", "Moderator", "MODERATOR" },
                    { "1a73053f-78c6-41c2-94fc-d897ccc8b33c", "47d275e2-8dc0-4377-a6d1-f114e4572cea", "Author", "Author" },
                    { "705c9705-c8a8-44af-99a3-e33b13856856", "a6953d79-64f8-47fe-9343-fba500929e06", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageFilePath", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "147c0de8-847c-4466-ad04-1fc7b563e0c4", 0, "bb344649-1454-457f-9825-04c28db56bde", new DateTime(2023, 4, 17, 9, 51, 52, 860, DateTimeKind.Local).AddTicks(6590), "admindavidacosta@email.com", false, "David", "M", null, "Acosta", false, null, "ADMINDAVIDACOSTA@EMAIL.COM", "ADMINDAVIDACOSTA@EMAIL.COM", "AQAAAAEAACcQAAAAEFGMTwroLPe5FuLdGEZyof5cVd7Gd1VYCFxhT005euJpz9G8eKOvwL0DdnOam+l3bQ==", null, false, "800a521b-da2b-453b-982f-9cbca24ceed0", true, false, "admindavidacosta@email.com" },
                    { "8c0b055f-d24d-43be-b842-4393d0b68d61", 0, "6144f89a-1acb-4888-b654-9001084a450d", new DateTime(2023, 4, 17, 9, 51, 52, 863, DateTimeKind.Local).AddTicks(3330), "modjennylenner@email.com", false, "Jenny", "M", null, "Lenner", false, null, "MODJENNYLENNER@EMAIL.COM", "MODJENNYLENNER@EMAIL.COM", "AQAAAAEAACcQAAAAEA/gwG0nMkFBqiNWlw28BQWKBn10M4FFiS8zxdrt0JN4X78Nmx8vNqWO+Sd6OBbtnw==", null, false, "7a506bc0-d130-4886-b907-d0237f582675", true, false, "modjennylenner@email.com" },
                    { "cba87ff8-bb15-442f-8a47-0e65a93cab8c", 0, "59e265e1-1220-4d83-9f2d-f221150163cb", new DateTime(2023, 4, 17, 9, 51, 52, 862, DateTimeKind.Local).AddTicks(91), "authormikeburner@email.com", false, "Mike", "M", null, "Burner", false, null, "AUTHORMIKEBURNER@EMAIL.COM", "AUTHORMIKEBURNER@EMAIL.COM", "AQAAAAEAACcQAAAAEJBezhilDrr9dHeWDjsACmOIN1AeeLCTDjzfkFangfcSj/3yi6sk9KyA529gUVmksQ==", null, false, "6d483c99-8b4a-403d-9af9-a2d0c82da9aa", true, false, "authormikeburner@email.com" }
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
                    { new Guid("055e32f3-d533-4d75-8a37-8bcbcc8b7496"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(7813), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Reactive multimedia system engine", null },
                    { new Guid("0bdd131f-2130-4192-945d-741fb3455356"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(246), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Multi-layered needs-based portal", null },
                    { new Guid("15aefed3-b7f9-48c3-be33-4c25ced10ccb"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(6944), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Adaptive logistical projection", null },
                    { new Guid("16710d09-e673-4ade-9445-3c2a04406bfc"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(9107), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Customizable mobile portal", null },
                    { new Guid("1aaf8559-9409-46a1-b544-5baeccfbe751"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(8539), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Realigned web-enabled strategy", null },
                    { new Guid("219075cb-32b1-4e9b-b0f5-a55c62659a8a"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(8768), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Visionary foreground circuit", null },
                    { new Guid("25462f5a-e852-4f43-b637-480c6b132421"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(1151), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Persevering high-level encoding", null },
                    { new Guid("2680e553-21e1-4c1f-bb8c-993da5b72e73"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(8201), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Object-based fault-tolerant Graphical User Interface", null },
                    { new Guid("28e4c611-6541-48d5-a3b4-34c8bd0c6d2c"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(811), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Persevering holistic project", null },
                    { new Guid("4256da7e-a8c4-4aca-8d19-725761477b06"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(44), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Proactive bifurcated methodology", null },
                    { new Guid("431953d5-fc89-4b43-bed2-d2840735965b"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(7700), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Intuitive didactic solution", null },
                    { new Guid("48eb88fe-63e3-4649-a9d1-b2097e1013cb"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(699), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Synergized background standardization", null },
                    { new Guid("52d8cb65-c6ac-4da8-9bb0-abb0cb271267"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(7471), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Expanded user-facing model", null },
                    { new Guid("577f4f29-872a-46f4-abd9-d3c7ffcf24d0"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(8431), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Persevering bottom-line website", null },
                    { new Guid("579904c5-ab50-4ca0-b6a3-be26a37b51c9"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(9211), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Horizontal context-sensitive service-desk", null },
                    { new Guid("6192dc3b-b877-4247-a950-a6bd6226fbe3"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(8302), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Triple-buffered 4th generation architecture", null },
                    { new Guid("635f64ee-dad0-4438-88f6-cc5b888b0db4"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(595), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Phased exuding hierarchy", null },
                    { new Guid("736161ca-e8cc-41aa-8ea9-b92dc0614f30"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(1361), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Advanced system-worthy local area network", null },
                    { new Guid("74078e35-a44d-4848-9b04-ad859627ef0d"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(1045), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Decentralized multi-tasking capacity", null },
                    { new Guid("7876f3af-1757-4056-ac01-357193e508f9"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(357), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Secured object-oriented leverage", null },
                    { new Guid("7d76f25e-e2f5-4817-b0b6-b612e36d9b46"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(7590), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Self-enabling uniform adapter", null },
                    { new Guid("84adf947-028d-4ce9-959c-569ae9f31b51"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(7201), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Programmable disintermediate initiative", null },
                    { new Guid("87a667e6-887b-48db-a6d4-3eae2d57459b"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(1476), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Re-engineered hybrid toolset", null },
                    { new Guid("8ddda8a1-f789-402a-b75d-324b39461759"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(9720), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Adaptive bifurcated artificial intelligence", null },
                    { new Guid("8e86085d-70c1-4f0f-8228-4d41dcb34f6b"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(7082), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Managed systematic extranet", null },
                    { new Guid("936172b0-ad73-4d12-9a75-3c4e000a18fe"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(9937), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Proactive well-modulated capacity", null },
                    { new Guid("9a1b0cb0-d321-4546-99db-9f0444a42e0c"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(921), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Ameliorated leading edge strategy", null },
                    { new Guid("a23955f6-3db5-46f4-9d1c-8a5f347a1912"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(9825), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Operative disintermediate ability", null },
                    { new Guid("a43b8b69-1446-4ed9-b207-8e6b0d399aa8"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(7359), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Realigned stable alliance", null },
                    { new Guid("a4d3f17f-f3a0-4433-8565-4eb7f7364f33"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(8888), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Reduced asynchronous secured line", null },
                    { new Guid("a89e045c-b48f-4f2c-a65d-73a1f7d4d400"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(8655), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Customizable asynchronous toolset", null },
                    { new Guid("adb5a4ae-d57f-443f-a99e-9c75f326409e"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(8032), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Reduced secondary portal", null },
                    { new Guid("aeb2827d-cb2c-4f78-b904-7eb2c3417d11"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(1595), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "User-centric leading edge leverage", null },
                    { new Guid("b282c89d-c439-4474-b67d-25cc3d58ef40"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(6687), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Seamless intangible support", null },
                    { new Guid("b8cc723d-17f1-433a-a123-4be7d928bf51"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(486), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Enhanced bifurcated parallelism", null },
                    { new Guid("c4e35d47-6663-4704-855b-64616b96a95a"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(1254), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Total optimal groupware", null },
                    { new Guid("c71694a9-01b2-41d9-b1d5-76d3fc0eed19"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(9445), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Balanced real-time parallelism", null },
                    { new Guid("c770fe19-c1d7-4ee3-847d-4688ec98e3a0"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(7921), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Polarised impactful Graphical User Interface", null },
                    { new Guid("c8ac6589-42d6-4ffd-aa52-46f464ae6d84"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 865, DateTimeKind.Local).AddTicks(144), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Cloned intangible capacity", null }
                });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title", "VerdictMessage" },
                values: new object[] { new Guid("cf5fe698-0678-4d28-b903-6d837627a1a5"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(9007), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Virtual bottom-line flexibility", null });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title", "VerdictMessage" },
                values: new object[] { new Guid("db32aeca-5c5c-4d98-bd11-5e0553c8a782"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(9325), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Universal zero tolerance artificial intelligence", null });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title", "VerdictMessage" },
                values: new object[] { new Guid("f918301a-98d2-40fb-84fc-d2ed5ad7cc0c"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 17, 9, 51, 52, 864, DateTimeKind.Local).AddTicks(9552), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Vision-oriented static policy", null });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[,]
                {
                    { new Guid("047c0c1d-38e6-4457-87e0-3a9cd151e71a"), new Guid("b8cc723d-17f1-433a-a123-4be7d928bf51"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("09144270-6086-4db2-bed4-83759c29c7ea"), new Guid("7d76f25e-e2f5-4817-b0b6-b612e36d9b46"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("0c84a383-c772-42d0-9433-0c5f2d5212cc"), new Guid("736161ca-e8cc-41aa-8ea9-b92dc0614f30"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("0cbfe8a5-efae-4eb9-9b30-5c602dc5e164"), new Guid("635f64ee-dad0-4438-88f6-cc5b888b0db4"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("12dad56e-fe94-4cbc-9941-0c08dd8ec00b"), new Guid("52d8cb65-c6ac-4da8-9bb0-abb0cb271267"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("16baccb8-4a4f-4018-bf08-b6069d6166d9"), new Guid("16710d09-e673-4ade-9445-3c2a04406bfc"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("19698c9c-53e6-468b-898d-ab0ad52f6b67"), new Guid("1aaf8559-9409-46a1-b544-5baeccfbe751"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("1a808b3b-0362-478b-8d89-cb7fb19103d8"), new Guid("7876f3af-1757-4056-ac01-357193e508f9"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("1c8d384b-9a9e-40a6-af95-84015355ccdf"), new Guid("736161ca-e8cc-41aa-8ea9-b92dc0614f30"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("225f4fab-1728-4c78-861e-44518395a7b6"), new Guid("8ddda8a1-f789-402a-b75d-324b39461759"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("2906dd3f-f189-4b45-beb4-1b1168cf084e"), new Guid("adb5a4ae-d57f-443f-a99e-9c75f326409e"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("2c355b32-7fb7-4759-b6c7-7cd7f8de273f"), new Guid("f918301a-98d2-40fb-84fc-d2ed5ad7cc0c"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("32981cea-bb3e-433b-8407-764cd8822d57"), new Guid("c71694a9-01b2-41d9-b1d5-76d3fc0eed19"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("34239ccb-0d6e-4f9b-9c69-02ec8479a7bb"), new Guid("579904c5-ab50-4ca0-b6a3-be26a37b51c9"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("364852db-d38d-4bb5-a709-10f7186e156e"), new Guid("c4e35d47-6663-4704-855b-64616b96a95a"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("37ab1d48-e04e-409b-a197-6086c0114fb7"), new Guid("0bdd131f-2130-4192-945d-741fb3455356"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("39bb862b-2d84-4090-92bb-0d8192b2ff3f"), new Guid("87a667e6-887b-48db-a6d4-3eae2d57459b"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("44c5f75f-788d-43b1-abf1-a5bcf8cce8b0"), new Guid("8e86085d-70c1-4f0f-8228-4d41dcb34f6b"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("52e48d84-8e22-49a8-b0b6-71d9c2e5e8b6"), new Guid("a23955f6-3db5-46f4-9d1c-8a5f347a1912"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("56422af6-2c72-4862-96e5-912413301c2f"), new Guid("a89e045c-b48f-4f2c-a65d-73a1f7d4d400"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("599d79f5-2336-4cea-ba6a-2a3e0a42597f"), new Guid("b282c89d-c439-4474-b67d-25cc3d58ef40"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("60afde22-772b-4df7-aaff-83bbb1cbbd45"), new Guid("431953d5-fc89-4b43-bed2-d2840735965b"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("64621358-adc6-4a13-b038-183ec1e18d39"), new Guid("db32aeca-5c5c-4d98-bd11-5e0553c8a782"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("66c48235-ab1a-46d8-afc6-391b11273117"), new Guid("0bdd131f-2130-4192-945d-741fb3455356"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("6d572a04-0063-42a3-8696-16f3ad0c15f3"), new Guid("c71694a9-01b2-41d9-b1d5-76d3fc0eed19"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("73935f3c-dcff-4c4e-96d6-482882489ea8"), new Guid("6192dc3b-b877-4247-a950-a6bd6226fbe3"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("75bf0cc8-4208-4eab-9772-6ad4f6c3001b"), new Guid("a4d3f17f-f3a0-4433-8565-4eb7f7364f33"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("763df5b8-e941-4723-bc40-1d194ab58a63"), new Guid("52d8cb65-c6ac-4da8-9bb0-abb0cb271267"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("77d784b9-0edc-4cec-a27d-044143a3e1a8"), new Guid("1aaf8559-9409-46a1-b544-5baeccfbe751"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("7a565408-ba6b-4254-a965-ece1d46cf1ba"), new Guid("f918301a-98d2-40fb-84fc-d2ed5ad7cc0c"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("7ad7a24e-4e5f-4e94-94e4-b69b71a114c6"), new Guid("8e86085d-70c1-4f0f-8228-4d41dcb34f6b"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("7fb1618b-5a40-4f43-aa6c-7ff9eaf64170"), new Guid("936172b0-ad73-4d12-9a75-3c4e000a18fe"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("810e5102-47cf-418a-a7a5-d47fc18ff4a6"), new Guid("a4d3f17f-f3a0-4433-8565-4eb7f7364f33"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("81a1522f-2d18-4ff2-9180-fe7bd2acfeb5"), new Guid("db32aeca-5c5c-4d98-bd11-5e0553c8a782"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("83bd7fdc-0385-4085-b90a-c724a850b67a"), new Guid("2680e553-21e1-4c1f-bb8c-993da5b72e73"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("865c964f-763a-4b9c-b96e-15bdbdde3606"), new Guid("84adf947-028d-4ce9-959c-569ae9f31b51"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("8b1c9340-f0e9-4787-860b-592159402987"), new Guid("15aefed3-b7f9-48c3-be33-4c25ced10ccb"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("8dcd970f-9df1-48bb-a7d6-ff3fa24af99a"), new Guid("577f4f29-872a-46f4-abd9-d3c7ffcf24d0"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("8de7b247-8d35-45c1-bb41-795bf5cb693d"), new Guid("db32aeca-5c5c-4d98-bd11-5e0553c8a782"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("90b2f567-9ff1-47df-ae40-48c177456765"), new Guid("579904c5-ab50-4ca0-b6a3-be26a37b51c9"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("97fd0029-2894-4a4b-8c5b-d5e02416bc21"), new Guid("a4d3f17f-f3a0-4433-8565-4eb7f7364f33"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("9a7ea573-4c92-48a2-b00d-9a4d0b15333d"), new Guid("aeb2827d-cb2c-4f78-b904-7eb2c3417d11"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") }
                });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[,]
                {
                    { new Guid("9c1e84da-5e4e-47ac-9c7a-8d90b491fa7d"), new Guid("84adf947-028d-4ce9-959c-569ae9f31b51"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("9ccafabf-7de0-418b-9e2d-11fa50678387"), new Guid("28e4c611-6541-48d5-a3b4-34c8bd0c6d2c"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("a1dbec61-c631-4baa-b7ce-74fa706bbc2d"), new Guid("84adf947-028d-4ce9-959c-569ae9f31b51"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("a488678c-47b6-4787-8a16-3c4215430c50"), new Guid("577f4f29-872a-46f4-abd9-d3c7ffcf24d0"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("a668c9d1-b44c-47c8-b818-c7c5caa61daf"), new Guid("48eb88fe-63e3-4649-a9d1-b2097e1013cb"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("a7849849-13a3-4dca-aaab-3a587f29f550"), new Guid("28e4c611-6541-48d5-a3b4-34c8bd0c6d2c"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("a7c0a857-e61c-4670-b48f-d2957f435c8d"), new Guid("87a667e6-887b-48db-a6d4-3eae2d57459b"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("acfdc94a-8d49-488b-84f2-3ade5d62e538"), new Guid("579904c5-ab50-4ca0-b6a3-be26a37b51c9"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("b53d0b51-c1e8-43b7-8985-d493a11432a9"), new Guid("f918301a-98d2-40fb-84fc-d2ed5ad7cc0c"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("b5f296a7-7a97-4d4f-99f5-5c717e470037"), new Guid("52d8cb65-c6ac-4da8-9bb0-abb0cb271267"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("b7c8f355-8d3d-43d6-90f6-1364e2f6b4dc"), new Guid("936172b0-ad73-4d12-9a75-3c4e000a18fe"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("b9a70b78-12b9-421b-86c9-378f8265503c"), new Guid("b282c89d-c439-4474-b67d-25cc3d58ef40"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("bddbdd6d-71f7-4b68-a19a-c206ecc14d9c"), new Guid("7d76f25e-e2f5-4817-b0b6-b612e36d9b46"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("bfd2ccb6-e1d0-494c-873e-76f093739a83"), new Guid("c770fe19-c1d7-4ee3-847d-4688ec98e3a0"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("c24b8d2d-1296-4b6d-abcf-45fe520dc140"), new Guid("635f64ee-dad0-4438-88f6-cc5b888b0db4"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("c28f003b-8537-4d20-9f23-c4578ac3ca6a"), new Guid("87a667e6-887b-48db-a6d4-3eae2d57459b"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("c2c1a1ea-71ef-4957-8161-95e7cd546e8a"), new Guid("055e32f3-d533-4d75-8a37-8bcbcc8b7496"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("c4efdd4d-becb-40d8-a464-4d73dc405516"), new Guid("9a1b0cb0-d321-4546-99db-9f0444a42e0c"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("c6008097-6694-4803-b7d9-f6f732aa5c99"), new Guid("6192dc3b-b877-4247-a950-a6bd6226fbe3"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("c836edb0-9fa4-4188-90e6-af92d1d2adea"), new Guid("48eb88fe-63e3-4649-a9d1-b2097e1013cb"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("c9093f67-0fa3-4d8e-8cc1-35b690ccd00d"), new Guid("9a1b0cb0-d321-4546-99db-9f0444a42e0c"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("ca21a32a-523f-4160-823c-dc13375f82bb"), new Guid("b8cc723d-17f1-433a-a123-4be7d928bf51"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("d06246a7-fa77-4a40-9b64-af566ffb82d5"), new Guid("74078e35-a44d-4848-9b04-ad859627ef0d"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("d1f97e33-a1df-409f-89e6-68563f1dcaf9"), new Guid("25462f5a-e852-4f43-b637-480c6b132421"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("d2a27068-1765-4aa3-a749-f88ac31fdfb5"), new Guid("28e4c611-6541-48d5-a3b4-34c8bd0c6d2c"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("d356548b-8d31-4503-a6ba-0ca2d51a0326"), new Guid("15aefed3-b7f9-48c3-be33-4c25ced10ccb"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("d3929d0a-900d-430b-90b4-0db5623d6be2"), new Guid("7876f3af-1757-4056-ac01-357193e508f9"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("d560fa16-582e-42c1-abb9-3a04ef688fbb"), new Guid("a43b8b69-1446-4ed9-b207-8e6b0d399aa8"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("d6cf1494-2801-4f08-9b2e-e9d5aef494ec"), new Guid("8ddda8a1-f789-402a-b75d-324b39461759"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("d94ba01d-d4c4-48a3-86fd-60cd685b7706"), new Guid("cf5fe698-0678-4d28-b903-6d837627a1a5"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("dc19c012-ebea-403d-8c80-efb0bec54add"), new Guid("219075cb-32b1-4e9b-b0f5-a55c62659a8a"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("e0301941-4f52-4043-8177-1a6b9c1e20fc"), new Guid("a43b8b69-1446-4ed9-b207-8e6b0d399aa8"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("e13f8be3-50b1-40c8-a1ce-711a14f03e63"), new Guid("736161ca-e8cc-41aa-8ea9-b92dc0614f30"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("e51c7ac4-f838-4567-b23a-af149de600d2"), new Guid("adb5a4ae-d57f-443f-a99e-9c75f326409e"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("eda8904b-6fe5-4715-ab3d-26c2156d8f3c"), new Guid("a89e045c-b48f-4f2c-a65d-73a1f7d4d400"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("f12db738-e734-45a1-bd34-b08f081420f3"), new Guid("1aaf8559-9409-46a1-b544-5baeccfbe751"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("f1e39f3d-20d7-432e-8948-98bdfd754cf3"), new Guid("adb5a4ae-d57f-443f-a99e-9c75f326409e"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("f22e7a49-1711-4ef8-a509-3da1e3d6a5ce"), new Guid("936172b0-ad73-4d12-9a75-3c4e000a18fe"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("f3bffcba-01ce-4cf9-8dde-1cb60b632d2b"), new Guid("431953d5-fc89-4b43-bed2-d2840735965b"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("f4821eda-1d81-443b-a99d-7aadc06ce55b"), new Guid("431953d5-fc89-4b43-bed2-d2840735965b"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("f94eb7ac-9c23-423b-b4ff-0ec26cf19b31"), new Guid("c4e35d47-6663-4704-855b-64616b96a95a"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("f9e9ad35-989e-422e-ba05-14a672ae4270"), new Guid("c8ac6589-42d6-4ffd-aa52-46f464ae6d84"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") }
                });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[] { new Guid("fde1c81f-b066-4d7f-90e8-d471fa61d57c"), new Guid("16710d09-e673-4ade-9445-3c2a04406bfc"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[] { new Guid("fe94967b-af8b-4482-ace7-a4f69bac3fdd"), new Guid("4256da7e-a8c4-4aca-8d19-725761477b06"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") });

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
