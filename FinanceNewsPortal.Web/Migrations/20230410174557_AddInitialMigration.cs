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
                name: "NewsArticleRatings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    NewsArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsArticleRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsArticleRatings_NewsArticle_NewsArticleId",
                        column: x => x.NewsArticleId,
                        principalTable: "NewsArticle",
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
                    { "08715f79-2c99-4a8b-935a-7ff2e37d1518", "85910fce-2691-4ca6-bbf9-644f4021b063", "Moderator", "MODERATOR" },
                    { "1a73053f-78c6-41c2-94fc-d897ccc8b33c", "589c78e6-0f51-44b1-abbe-b0951a114780", "Registered", "REGISTERED" },
                    { "705c9705-c8a8-44af-99a3-e33b13856856", "a7761c3f-8fe4-468d-8d8a-7f764dc2f60c", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageFilePath", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "147c0de8-847c-4466-ad04-1fc7b563e0c4", 0, "b1dd3a61-ca14-4d8d-83c7-8d09b843e6fb", new DateTime(2023, 4, 11, 1, 45, 57, 381, DateTimeKind.Local).AddTicks(8917), "adminone@email.com", false, "Admin", "M", null, "One", false, null, "ADMINONE@EMAIL.COM", "ADMINONE@EMAIL.COM", "AQAAAAEAACcQAAAAEBkqPupsl81Cc/HF4d44paH77Fsj/GtQ4KwSaok6J1eSxXt/QJwI7QbC6s3ybLU20Q==", null, false, "39ca3277-aecc-41e2-a5ad-12596bc75086", true, false, "adminone@email.com" },
                    { "8c0b055f-d24d-43be-b842-4393d0b68d61", 0, "7c361608-6ab6-4073-86c7-b2a3ecd49722", new DateTime(2023, 4, 11, 1, 45, 57, 384, DateTimeKind.Local).AddTicks(9538), "moderatorone@email.com", false, "Moderator", "M", null, "One", false, null, "MODERATORONE@EMAIL.COM", "MODERATORONE@EMAIL.COM", "AQAAAAEAACcQAAAAEFmh0Q6YxaTgVeKyGO+7jv/jLTn20NzxEZDzPo3ASTHvP/45eOiUDmCD+Yhrfg6kKA==", null, false, "f014e464-60ad-45d8-b8da-9291ee68c949", true, false, "moderatorone@email.com" },
                    { "cba87ff8-bb15-442f-8a47-0e65a93cab8c", 0, "238d35ac-0f5f-4105-af49-81d0030c9341", new DateTime(2023, 4, 11, 1, 45, 57, 383, DateTimeKind.Local).AddTicks(3807), "registeredone@email.com", false, "Registered", "M", null, "One", false, null, "REGISTEREDONE@EMAIL.COM", "REGISTEREDONE@EMAIL.COM", "AQAAAAEAACcQAAAAEJ1lW0Bl7J6lQMZ3eawFYS0rN6LFZZx2Hze87+4yr0N/mGR6WBw2Bl8QSs/lIfbLQA==", null, false, "ef424766-1c9c-4f06-aaf2-ec86f3bca367", true, false, "registeredone@email.com" }
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
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("096b097d-a966-4ace-aecc-e6c8efff4f6d"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3834), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 1" },
                    { new Guid("0e3b7f5d-c051-4a45-8a59-f20d44226a46"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4137), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 9" },
                    { new Guid("109f328d-fb69-4e9c-978d-c545e2af5cb9"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4030), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 7" },
                    { new Guid("1969ca0f-f95f-43ea-a273-b6bac3d5dc60"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3881), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 3" },
                    { new Guid("1a8e1f1b-c641-4e2a-afc8-717bcd8d7a63"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3859), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 2" },
                    { new Guid("1c3dd41a-95e1-4f73-881c-f439818e39a7"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4167), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 10" },
                    { new Guid("25d1235d-70c9-4f6b-8b1c-0589d534f10f"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4021), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 6" },
                    { new Guid("2e9782c7-7f46-4ad8-acbd-f0a98bf5c62a"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4109), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 8" },
                    { new Guid("4eadf4ed-2efe-4f63-b866-f829ce13a65e"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4118), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 9" },
                    { new Guid("52180721-cc44-4c37-a64e-537a06d9dffa"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4000), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 6" },
                    { new Guid("5d657acd-d7d1-4a44-9d3e-205046571056"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4147), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 10" },
                    { new Guid("5da125e8-12f0-49cf-9460-718760be91b7"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4040), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 7" },
                    { new Guid("7418c3a3-79ac-4382-a772-77bfe3108aae"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3802), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 1" },
                    { new Guid("769c14b5-25cd-4dcf-8cf8-ce16b64afb95"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4009), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 6" },
                    { new Guid("8434be5a-0807-455f-86bb-7c975f217acd"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3990), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 5" },
                    { new Guid("911846d2-74f2-4de8-9711-34a168a946ee"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3900), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 3" },
                    { new Guid("9266c529-2975-49f1-b2ec-847c6db4e0c7"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4156), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 10" },
                    { new Guid("9d2a05be-fca2-4e38-ac95-aaf908e4f222"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3912), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 4" },
                    { new Guid("a25a35b8-7b7a-4c0b-b5be-a9b4642334d3"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3982), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 5" },
                    { new Guid("a8bdee20-cdaa-47a1-b041-03a1bb8867ce"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4049), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 7" },
                    { new Guid("ac0e4810-8a36-4f43-975c-3a6b05b7da41"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3920), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 4" },
                    { new Guid("b3d6e867-8a7f-4074-bd80-13b884245b2a"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3850), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 2" },
                    { new Guid("b4539e6e-3348-4675-bcb5-3c5896388c13"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4059), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 8" },
                    { new Guid("b8f45a85-4643-4f46-bac4-ecde904276ad"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3741), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 1" },
                    { new Guid("bcd6c827-44cf-4098-a456-e8264c92917c"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3971), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 5" },
                    { new Guid("e3694b33-f59b-4178-9c2b-a669e2ad7a58"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3871), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 2" },
                    { new Guid("e915bc10-7820-4566-87dd-2c47304e0de6"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3960), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 4" },
                    { new Guid("f5d44170-b28c-4c19-be11-d51b732c5c0a"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4097), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 8" },
                    { new Guid("f6080e34-40ef-4310-b5b9-0d6462850fc3"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(4128), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 9" },
                    { new Guid("fa07e4f1-c81f-47e4-9558-1e7b31438236"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 11, 1, 45, 57, 386, DateTimeKind.Local).AddTicks(3891), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 3" }
                });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[,]
                {
                    { new Guid("01503d40-d64f-401e-aaae-aaf8a05f8e0a"), new Guid("b4539e6e-3348-4675-bcb5-3c5896388c13"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("01b1684f-400f-439b-98b9-fcbf6df3e9d4"), new Guid("5da125e8-12f0-49cf-9460-718760be91b7"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("07308693-73e1-4752-be97-f9beeb3dab15"), new Guid("4eadf4ed-2efe-4f63-b866-f829ce13a65e"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("091b46e0-d752-4073-9d26-5a0d4a75f2f8"), new Guid("fa07e4f1-c81f-47e4-9558-1e7b31438236"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("0ab48133-0ca8-4233-bb42-3f557a454cf1"), new Guid("5da125e8-12f0-49cf-9460-718760be91b7"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("0e0c6520-f5b8-43cb-b8c2-989633cd222a"), new Guid("f5d44170-b28c-4c19-be11-d51b732c5c0a"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("17766d77-8fb5-41bc-a3e4-21eab8b12f93"), new Guid("1c3dd41a-95e1-4f73-881c-f439818e39a7"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("1f89e606-7f3f-4f5b-823f-cedf82dccc86"), new Guid("b3d6e867-8a7f-4074-bd80-13b884245b2a"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("2048c913-8770-4fba-9474-2aa5ca55f388"), new Guid("4eadf4ed-2efe-4f63-b866-f829ce13a65e"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("2049e107-6bed-4d99-bf2e-eb180cb9b908"), new Guid("f5d44170-b28c-4c19-be11-d51b732c5c0a"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("21475499-701b-4151-b73b-1c4c76dcd86e"), new Guid("2e9782c7-7f46-4ad8-acbd-f0a98bf5c62a"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("214b83fe-c67f-492e-919f-dc6d23e52432"), new Guid("b8f45a85-4643-4f46-bac4-ecde904276ad"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("217f12d9-85f2-4870-ba13-89fb0bacd8eb"), new Guid("52180721-cc44-4c37-a64e-537a06d9dffa"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("2278923e-de90-47e1-beb7-01dc4d718d15"), new Guid("a8bdee20-cdaa-47a1-b041-03a1bb8867ce"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("231b0a70-491c-4944-819d-be30c0bc9786"), new Guid("25d1235d-70c9-4f6b-8b1c-0589d534f10f"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("23e7fcf5-a8e1-4790-8fd1-8d585644ee61"), new Guid("e915bc10-7820-4566-87dd-2c47304e0de6"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("251be589-4e4f-4d38-8a3f-4f046a5e571b"), new Guid("52180721-cc44-4c37-a64e-537a06d9dffa"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("2dcf42d3-9fe1-4f30-9302-10318f3bee16"), new Guid("7418c3a3-79ac-4382-a772-77bfe3108aae"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("3956022b-5b06-4a57-8b00-34d157a2d2d2"), new Guid("bcd6c827-44cf-4098-a456-e8264c92917c"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("39e26d6e-fb63-4f43-bd1f-bd9ce41df62c"), new Guid("0e3b7f5d-c051-4a45-8a59-f20d44226a46"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("3c55cc62-266f-4fc5-a64d-d7450c5df9e5"), new Guid("b3d6e867-8a7f-4074-bd80-13b884245b2a"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("4106dc34-6aa4-42e4-87f8-7088dcdb75db"), new Guid("9266c529-2975-49f1-b2ec-847c6db4e0c7"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("44153a41-2a11-414f-8a0a-b6767f500d99"), new Guid("1969ca0f-f95f-43ea-a273-b6bac3d5dc60"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("4ab437ce-f74e-4142-b3fb-d7ead7fa1053"), new Guid("e3694b33-f59b-4178-9c2b-a669e2ad7a58"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("513e89ff-17b4-4481-bc0f-95d823f32d83"), new Guid("7418c3a3-79ac-4382-a772-77bfe3108aae"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("570aa859-a6df-4b34-b96f-149f3464708f"), new Guid("b8f45a85-4643-4f46-bac4-ecde904276ad"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("5aa6fd80-533c-4ac6-a14e-87de65b3f220"), new Guid("1969ca0f-f95f-43ea-a273-b6bac3d5dc60"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("5ca2207e-0408-4c6a-807f-0fdedea10755"), new Guid("a25a35b8-7b7a-4c0b-b5be-a9b4642334d3"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("5d2c279b-a9eb-4f4b-aae0-85dd3ef9fb3f"), new Guid("fa07e4f1-c81f-47e4-9558-1e7b31438236"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("5f8def63-554c-4b98-b28c-a3a7109b0c2b"), new Guid("4eadf4ed-2efe-4f63-b866-f829ce13a65e"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("6252b359-e41f-4235-8ab6-e8897b736785"), new Guid("f6080e34-40ef-4310-b5b9-0d6462850fc3"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("67c55a02-27e8-4c97-8a1e-712e4dd8a747"), new Guid("0e3b7f5d-c051-4a45-8a59-f20d44226a46"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("6a325c5d-f907-4f94-8e0d-780e6f6f2319"), new Guid("2e9782c7-7f46-4ad8-acbd-f0a98bf5c62a"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("6b4ca30c-8e37-422c-8ccc-f4c6bf7b7ecf"), new Guid("25d1235d-70c9-4f6b-8b1c-0589d534f10f"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("6c6514f1-5f60-4616-8c14-d255f9704961"), new Guid("096b097d-a966-4ace-aecc-e6c8efff4f6d"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("73b6359e-77fb-44b5-9374-2b1258915e0a"), new Guid("a8bdee20-cdaa-47a1-b041-03a1bb8867ce"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("741d6084-3849-40cc-a212-f629a23e8b04"), new Guid("e915bc10-7820-4566-87dd-2c47304e0de6"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("75718693-94b6-4ee1-9a07-7d74a4f71e05"), new Guid("ac0e4810-8a36-4f43-975c-3a6b05b7da41"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("79fb4473-11cf-4663-819c-b397e15620cb"), new Guid("a25a35b8-7b7a-4c0b-b5be-a9b4642334d3"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("7a79a1a4-7cd4-4e66-b8a1-dd9bb0552972"), new Guid("1a8e1f1b-c641-4e2a-afc8-717bcd8d7a63"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("7c240f82-0eff-44ba-9517-126bd9cba0a6"), new Guid("769c14b5-25cd-4dcf-8cf8-ce16b64afb95"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("89babd9f-dd12-44c7-84e3-71e7a7968d30"), new Guid("096b097d-a966-4ace-aecc-e6c8efff4f6d"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") }
                });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[,]
                {
                    { new Guid("8a673f9d-a34c-4205-bab3-9b9b27681b22"), new Guid("769c14b5-25cd-4dcf-8cf8-ce16b64afb95"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("8d9f73ad-3ea9-4229-8b86-7d017d5bc52f"), new Guid("9d2a05be-fca2-4e38-ac95-aaf908e4f222"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("9164a361-5b4e-48a7-ac6b-077111370561"), new Guid("911846d2-74f2-4de8-9711-34a168a946ee"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("941e50f2-4725-4716-8fbe-95a2f0c680f2"), new Guid("e3694b33-f59b-4178-9c2b-a669e2ad7a58"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("95800892-c85f-4786-af9f-53167ccf5922"), new Guid("1a8e1f1b-c641-4e2a-afc8-717bcd8d7a63"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("96679a1b-b7dd-4822-86a3-448631d7ae8b"), new Guid("096b097d-a966-4ace-aecc-e6c8efff4f6d"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("9f3ea216-2008-44a4-bd2d-05bd294ccc73"), new Guid("5d657acd-d7d1-4a44-9d3e-205046571056"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("a02a96ba-f0d8-41a3-be0a-043676f5ee18"), new Guid("a25a35b8-7b7a-4c0b-b5be-a9b4642334d3"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("a62eca47-35c3-419d-b1ba-8cb11f602e7f"), new Guid("e915bc10-7820-4566-87dd-2c47304e0de6"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("a67c6e74-d429-4dc7-b358-dac482133253"), new Guid("769c14b5-25cd-4dcf-8cf8-ce16b64afb95"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("a7aba120-4d7e-4055-a72b-f439f89dbf1c"), new Guid("f5d44170-b28c-4c19-be11-d51b732c5c0a"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("a7f6bae4-eb88-4f4e-b192-171e828d9d6a"), new Guid("fa07e4f1-c81f-47e4-9558-1e7b31438236"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("ab16b912-fd3f-4a5f-84d0-bfaa68355827"), new Guid("f6080e34-40ef-4310-b5b9-0d6462850fc3"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("ab44970f-5bf2-474b-85f3-643599ea01a0"), new Guid("1c3dd41a-95e1-4f73-881c-f439818e39a7"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("abc30ed8-a646-43d4-8b3b-1c17a57677b3"), new Guid("1969ca0f-f95f-43ea-a273-b6bac3d5dc60"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("ad7b648b-0267-40c9-bdb8-fb5ad593da6e"), new Guid("0e3b7f5d-c051-4a45-8a59-f20d44226a46"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("b2063284-ec8a-4893-821c-909dd0235111"), new Guid("9d2a05be-fca2-4e38-ac95-aaf908e4f222"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("b33141a7-2db9-4fe8-af34-168a5ae72bb5"), new Guid("1c3dd41a-95e1-4f73-881c-f439818e39a7"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("b36164bc-9af8-498c-ba19-d434bbd11973"), new Guid("9d2a05be-fca2-4e38-ac95-aaf908e4f222"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("b511b44c-2bab-4940-9c11-f5ea7817d400"), new Guid("109f328d-fb69-4e9c-978d-c545e2af5cb9"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("b823c64d-c740-4429-86a0-172f9bd1a2a6"), new Guid("e3694b33-f59b-4178-9c2b-a669e2ad7a58"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("b8b45190-3bd7-4ce2-a2ed-4d178c444b61"), new Guid("25d1235d-70c9-4f6b-8b1c-0589d534f10f"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("b9338418-40fb-498a-a907-d2ad4356786e"), new Guid("109f328d-fb69-4e9c-978d-c545e2af5cb9"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("bb542788-2516-4608-a2f8-912bc2282992"), new Guid("52180721-cc44-4c37-a64e-537a06d9dffa"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("c4a92062-ab58-4ce3-976f-74e77fd25044"), new Guid("ac0e4810-8a36-4f43-975c-3a6b05b7da41"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("c89c541a-92fd-4ef1-b11b-3fde5306a33e"), new Guid("1a8e1f1b-c641-4e2a-afc8-717bcd8d7a63"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("c8d5f655-ae90-4035-9d46-19cf2e21f39d"), new Guid("5d657acd-d7d1-4a44-9d3e-205046571056"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("cd58e700-5c87-4294-b1bd-dc904776813d"), new Guid("8434be5a-0807-455f-86bb-7c975f217acd"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("cf5be8b4-3485-4fc0-a73b-07114edd0a7c"), new Guid("bcd6c827-44cf-4098-a456-e8264c92917c"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("d000a2c1-351c-43fe-8e7b-987edea9f242"), new Guid("2e9782c7-7f46-4ad8-acbd-f0a98bf5c62a"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("d0dcd9fb-6cd7-4724-a38c-6a1cc935609e"), new Guid("9266c529-2975-49f1-b2ec-847c6db4e0c7"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("d48f347a-0fa8-421c-85a0-2f67a493d599"), new Guid("a8bdee20-cdaa-47a1-b041-03a1bb8867ce"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("d8738bb1-5954-45f7-9d98-7314d2b49e0a"), new Guid("7418c3a3-79ac-4382-a772-77bfe3108aae"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("d9531d8c-94bd-49d6-85ec-9ab2b50e248c"), new Guid("8434be5a-0807-455f-86bb-7c975f217acd"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("dc083dba-1c50-4e9f-b4e4-a71475a4f89e"), new Guid("f6080e34-40ef-4310-b5b9-0d6462850fc3"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("dd71a354-dba4-4ce3-aed2-084a8d789a76"), new Guid("8434be5a-0807-455f-86bb-7c975f217acd"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("e4ddbdd4-2191-4551-8374-07e73288d274"), new Guid("9266c529-2975-49f1-b2ec-847c6db4e0c7"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("e88c1aab-aed7-4bb1-bf76-a49031a4be17"), new Guid("b4539e6e-3348-4675-bcb5-3c5896388c13"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("e92c928f-a6c0-4043-b05d-5569a46fcc4d"), new Guid("b8f45a85-4643-4f46-bac4-ecde904276ad"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("edb3e4e3-3e7a-4243-90b0-a0243e27466a"), new Guid("b3d6e867-8a7f-4074-bd80-13b884245b2a"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("f032f95f-753a-4926-aabb-69e3e69fb16d"), new Guid("109f328d-fb69-4e9c-978d-c545e2af5cb9"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") },
                    { new Guid("f1c9db4e-5dce-48ff-aeb9-e074a7278861"), new Guid("911846d2-74f2-4de8-9711-34a168a946ee"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") }
                });

            migrationBuilder.InsertData(
                table: "NewsArticleTypes",
                columns: new[] { "Id", "NewsArticleId", "NewsArticleTagId" },
                values: new object[,]
                {
                    { new Guid("f1f284f4-1466-4407-a705-109e3c477701"), new Guid("5d657acd-d7d1-4a44-9d3e-205046571056"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("f25504b9-4607-4fcc-bd7b-741f98e7410b"), new Guid("911846d2-74f2-4de8-9711-34a168a946ee"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("f56c1070-7505-4eb8-9517-adc4d74f584c"), new Guid("bcd6c827-44cf-4098-a456-e8264c92917c"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("f6849470-65da-4e10-8b6d-776206cbb8d0"), new Guid("ac0e4810-8a36-4f43-975c-3a6b05b7da41"), new Guid("ef670b9d-ab1f-46e7-8fb8-5c021e8a682b") },
                    { new Guid("f7cbe8e3-2443-40fe-911d-def1a3570b05"), new Guid("5da125e8-12f0-49cf-9460-718760be91b7"), new Guid("68cd9ec4-de98-4b5e-b374-da0d3affd593") },
                    { new Guid("fdb934df-9711-4074-b670-c39c626b2e3d"), new Guid("b4539e6e-3348-4675-bcb5-3c5896388c13"), new Guid("dea5a0d4-a73f-4bc8-a539-bb989f6d5a30") }
                });

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
                name: "IX_NewsArticleRatings_NewsArticleId",
                table: "NewsArticleRatings",
                column: "NewsArticleId",
                unique: true);

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
                name: "NewsArticleRatings");

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
