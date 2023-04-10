using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceNewsPortal.Web.Migrations
{
    public partial class NewsArticleTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("097a4744-e3bf-4226-8e5e-08fbdbd5d777"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("1a111bc0-dc63-4481-a0ec-4b4ec277212a"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("26e56c63-b6f9-4328-b081-fb59af41cc20"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("287d5f1c-8a99-4417-8599-b1c92cfb596e"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("315b6286-3269-4fa2-969c-353dfbb07257"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("370ca172-cc85-4910-bb0a-cd3effd10481"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("3bdb1d71-78e0-4378-a0cc-8c8b6ca87ed2"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("540533af-8aa6-43fe-84bb-0c61d31bcff0"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("58cd3a06-5525-4561-83a0-4e8ade162685"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("595d29f9-169f-4f39-87b3-03df204f9165"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("66c9c492-73db-441c-8e28-48e963a372bb"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("67d71746-27e9-4c01-a52c-a0e8609163c3"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("6b84b0d8-54b5-4ce4-b009-6529998c7665"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("6da1b401-d31a-44c2-8956-55195183925c"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("72713f33-0420-4e51-8475-3c20b1beb516"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("79749e15-ccba-44c1-9482-83e2c77874ba"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("8b4fe5b3-b4ae-416b-80c0-5fd1f93e6d6f"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("9149e704-2487-483f-abe4-4e3d16cf7f0d"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("91804527-6c2e-44a7-a421-27ae2bcb14c2"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("ac2dc59f-6937-4285-b3c6-aa4f1a38415f"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("b0c0d4d3-b8fd-453c-b280-a192862525c6"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("b1c6aaef-544a-4855-a7e5-492d20607393"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("b3a398c9-ea94-4733-ba37-ac32e239f1b0"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("b87f91cf-cb40-4d62-8e78-79ab63dcf5d2"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("b8b53104-dd4e-42ae-a240-6c1be2ebf87f"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("baf233da-4d79-40b5-86be-08fe430567cb"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("c3cbacb8-32c2-4983-8d6c-183a276f9955"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("e142935d-a758-43fe-ad7d-b080de3daa0d"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("eb3e6a28-f8a0-4255-b7b0-f5cb8cab27bb"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("fc5918e2-6527-4f62-b2b7-295f4f280e36"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "NewsArticleTypes");

            migrationBuilder.AddColumn<Guid>(
                name: "NewsArticleTagId",
                table: "NewsArticleTypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08715f79-2c99-4a8b-935a-7ff2e37d1518",
                column: "ConcurrencyStamp",
                value: "d21962d6-040b-47a1-adb4-2ff4f2152f9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a73053f-78c6-41c2-94fc-d897ccc8b33c",
                column: "ConcurrencyStamp",
                value: "922bf931-26d0-4a15-9b7e-ce69de0d2b96");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "705c9705-c8a8-44af-99a3-e33b13856856",
                column: "ConcurrencyStamp",
                value: "537b81ee-d599-4125-a21f-2db93e1301b2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "147c0de8-847c-4466-ad04-1fc7b563e0c4",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb42f73e-423a-4414-8c9f-d81833572485", new DateTime(2023, 4, 10, 17, 5, 57, 423, DateTimeKind.Local).AddTicks(3632), "AQAAAAEAACcQAAAAENcMk2YyqmGiwwxrB04QAdZnRtjIrXNxOjSgbMJS4dgDYvUGyIFkwHUGKeNXFdjCrw==", "c2aaf4cf-97c5-410a-84e0-d5867c306707" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c0b055f-d24d-43be-b842-4393d0b68d61",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dcb469e-2852-474c-8f02-4c5100667d95", new DateTime(2023, 4, 10, 17, 5, 57, 426, DateTimeKind.Local).AddTicks(8091), "AQAAAAEAACcQAAAAELrXOZiupqdigYyz5UjeGmdVEP2eYLy7goZskFiTH3eI029DgWhGdh8SCNQEilrNdA==", "471fa9dd-d08d-403a-bb99-e526769a1e14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba87ff8-bb15-442f-8a47-0e65a93cab8c",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acc72fae-e921-4263-889f-f1addcc02187", new DateTime(2023, 4, 10, 17, 5, 57, 424, DateTimeKind.Local).AddTicks(9173), "AQAAAAEAACcQAAAAEAJAHPnAXJnKDb+F5Uf5feUtry/kIgNwFufRzzE/z+d05rgOgGhUxPOYSyBYBCczkQ==", "864f7764-8280-47dc-9bc0-a0fc21c70a7f" });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("04645e14-50a8-4eff-a093-98a483b4655f"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(476), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 7" },
                    { new Guid("0710e652-7aae-43cc-a466-7dccc3bbebd6"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(499), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 10" },
                    { new Guid("23f0fd7c-ee36-46cb-990d-f80ab68726da"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(479), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 8" },
                    { new Guid("2511f392-6572-4bdb-92b9-f8e55cc36c8e"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(399), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 1" },
                    { new Guid("2e5f9d09-e1e6-4956-86c8-90d4f5af8f53"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(422), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 2" },
                    { new Guid("31344c18-7b9e-4592-aa16-b0181781da68"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(463), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 6" },
                    { new Guid("3e9688da-1e0c-46c7-af60-706a742d8bad"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(484), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 8" },
                    { new Guid("47ed55bf-b4be-451a-91d8-e187724ad50d"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(404), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 2" },
                    { new Guid("56c4ca21-df52-4bfc-8de4-a848c42b09fb"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(443), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 4" },
                    { new Guid("598722b1-889e-40c5-b74a-227ec5e625bf"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(490), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 9" },
                    { new Guid("5b178597-56af-444f-a8d4-50d7f14bede8"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(473), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 7" },
                    { new Guid("5ff0a58b-cad5-40c5-9042-1f1fc710d0fb"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(431), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 3" },
                    { new Guid("645b67ef-6386-4cd0-a651-60621882b1c5"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(459), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 6" },
                    { new Guid("6b2cf1d7-4596-4f03-8f09-4ba61153b034"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(407), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 2" },
                    { new Guid("6c96a686-2348-4605-a473-186b64e0a934"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(428), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 3" },
                    { new Guid("75472bb0-918b-461f-bbe0-bd15e23a906a"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(453), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 5" },
                    { new Guid("8e4f6b0c-ef5c-4f71-8900-5db5f202ac09"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(448), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 5" },
                    { new Guid("9256706f-e7e7-45bd-9c71-8a8de36b6fd6"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(470), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 7" },
                    { new Guid("943f0d82-2325-4003-9245-1122ae011e79"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(487), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 9" },
                    { new Guid("9adcd991-4330-49ef-aea1-fd0159c783c3"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(457), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 6" },
                    { new Guid("ab85937c-1747-44c5-814f-1af7b6ca6a28"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(451), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 5" },
                    { new Guid("b2054664-e6ff-45f6-abfb-45bac6addccb"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(436), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 4" },
                    { new Guid("b2acd75a-b0be-46af-8348-172d3261c536"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(425), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 3" },
                    { new Guid("b6cdc06c-8fec-4aef-ba40-994cbb27ab1d"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(481), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 8" },
                    { new Guid("bdb8ce9a-8c52-45ae-a0a8-a1bcc511c320"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(377), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 1" },
                    { new Guid("dbc95939-ea5d-4674-92c2-7fbcd71f7766"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(446), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 4" },
                    { new Guid("f2093d2e-b6b1-4608-bac0-6bf96715a12d"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(288), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 1" },
                    { new Guid("f23bb4b8-313e-47a3-b3b9-9020cb48e3a7"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(505), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 10" },
                    { new Guid("f65f6476-7690-4727-b62d-bfaf654f2594"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(496), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 9" },
                    { new Guid("fe9f6c6d-f84f-4062-9f1a-dab55367e2cc"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 10, 17, 5, 57, 429, DateTimeKind.Local).AddTicks(502), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 10" }
                });

            migrationBuilder.InsertData(
                table: "NewsArticleTags",
                columns: new[] { "Id", "TagName" },
                values: new object[,]
                {
                    { new Guid("1281b11c-ab1f-4479-826b-3b8c2092b93b"), "Finance" },
                    { new Guid("24c84beb-31d4-40d3-9ec6-f07234189e97"), "Banking" },
                    { new Guid("8d64cc1b-6fd4-4b8d-9de6-e6d2a44a57df"), "Stock" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewsArticleTypes_NewsArticleTagId",
                table: "NewsArticleTypes",
                column: "NewsArticleTagId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsArticleTypes_NewsArticleTags_NewsArticleTagId",
                table: "NewsArticleTypes",
                column: "NewsArticleTagId",
                principalTable: "NewsArticleTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsArticleTypes_NewsArticleTags_NewsArticleTagId",
                table: "NewsArticleTypes");

            migrationBuilder.DropTable(
                name: "NewsArticleTags");

            migrationBuilder.DropIndex(
                name: "IX_NewsArticleTypes_NewsArticleTagId",
                table: "NewsArticleTypes");

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("04645e14-50a8-4eff-a093-98a483b4655f"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("0710e652-7aae-43cc-a466-7dccc3bbebd6"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("23f0fd7c-ee36-46cb-990d-f80ab68726da"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("2511f392-6572-4bdb-92b9-f8e55cc36c8e"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("2e5f9d09-e1e6-4956-86c8-90d4f5af8f53"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("31344c18-7b9e-4592-aa16-b0181781da68"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("3e9688da-1e0c-46c7-af60-706a742d8bad"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("47ed55bf-b4be-451a-91d8-e187724ad50d"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("56c4ca21-df52-4bfc-8de4-a848c42b09fb"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("598722b1-889e-40c5-b74a-227ec5e625bf"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("5b178597-56af-444f-a8d4-50d7f14bede8"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("5ff0a58b-cad5-40c5-9042-1f1fc710d0fb"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("645b67ef-6386-4cd0-a651-60621882b1c5"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("6b2cf1d7-4596-4f03-8f09-4ba61153b034"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("6c96a686-2348-4605-a473-186b64e0a934"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("75472bb0-918b-461f-bbe0-bd15e23a906a"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("8e4f6b0c-ef5c-4f71-8900-5db5f202ac09"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("9256706f-e7e7-45bd-9c71-8a8de36b6fd6"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("943f0d82-2325-4003-9245-1122ae011e79"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("9adcd991-4330-49ef-aea1-fd0159c783c3"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("ab85937c-1747-44c5-814f-1af7b6ca6a28"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("b2054664-e6ff-45f6-abfb-45bac6addccb"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("b2acd75a-b0be-46af-8348-172d3261c536"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("b6cdc06c-8fec-4aef-ba40-994cbb27ab1d"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("bdb8ce9a-8c52-45ae-a0a8-a1bcc511c320"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("dbc95939-ea5d-4674-92c2-7fbcd71f7766"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("f2093d2e-b6b1-4608-bac0-6bf96715a12d"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("f23bb4b8-313e-47a3-b3b9-9020cb48e3a7"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("f65f6476-7690-4727-b62d-bfaf654f2594"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("fe9f6c6d-f84f-4062-9f1a-dab55367e2cc"));

            migrationBuilder.DropColumn(
                name: "NewsArticleTagId",
                table: "NewsArticleTypes");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "NewsArticleTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08715f79-2c99-4a8b-935a-7ff2e37d1518",
                column: "ConcurrencyStamp",
                value: "e44ca2db-d8cc-423a-8d16-1c1546e694e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a73053f-78c6-41c2-94fc-d897ccc8b33c",
                column: "ConcurrencyStamp",
                value: "b95b9afa-d615-499e-b3fe-044b1b10c188");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "705c9705-c8a8-44af-99a3-e33b13856856",
                column: "ConcurrencyStamp",
                value: "bf484d14-4ad0-4cdd-82c3-ff9e971b0b01");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "147c0de8-847c-4466-ad04-1fc7b563e0c4",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57de115a-00e5-416d-a064-beb60b96b191", new DateTime(2023, 4, 7, 16, 40, 33, 48, DateTimeKind.Local).AddTicks(2950), "AQAAAAEAACcQAAAAEC87Y39ED27ahGFWAsem0KUd/UmOJDehsplSA/cGNILPshp78uhIK/6vSVbtjiwr7g==", "21a341b1-5823-4d14-98aa-0e56bad816fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c0b055f-d24d-43be-b842-4393d0b68d61",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bd777af-829f-4fef-bf51-3a441077cba5", new DateTime(2023, 4, 7, 16, 40, 33, 50, DateTimeKind.Local).AddTicks(9462), "AQAAAAEAACcQAAAAEE+0JHT8DypbnS5ylsqqtxQefyDz1fNyN8pjzT61jMlZFg5xB7Ym+UanNI99sIIAHg==", "cbe231c5-0ace-4b44-ae86-1862c88b135b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba87ff8-bb15-442f-8a47-0e65a93cab8c",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cd50959-3803-4291-a42e-54f923dc1687", new DateTime(2023, 4, 7, 16, 40, 33, 49, DateTimeKind.Local).AddTicks(6376), "AQAAAAEAACcQAAAAEI5Nm7/xqIDfuBxqhYkYJDR7uZaaxTa48FbHS66UqLEZljfsydS2ozPzFFg5Tt98LQ==", "30f451bc-4444-4987-83b0-186e53bfe10a" });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("097a4744-e3bf-4226-8e5e-08fbdbd5d777"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3413), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 10" },
                    { new Guid("1a111bc0-dc63-4481-a0ec-4b4ec277212a"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3407), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 9" },
                    { new Guid("26e56c63-b6f9-4328-b081-fb59af41cc20"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3411), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 10" },
                    { new Guid("287d5f1c-8a99-4417-8599-b1c92cfb596e"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3403), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 8" },
                    { new Guid("315b6286-3269-4fa2-969c-353dfbb07257"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3391), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 6" },
                    { new Guid("370ca172-cc85-4910-bb0a-cd3effd10481"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3283), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 1" },
                    { new Guid("3bdb1d71-78e0-4378-a0cc-8c8b6ca87ed2"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3398), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 7" },
                    { new Guid("540533af-8aa6-43fe-84bb-0c61d31bcff0"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3405), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 9" },
                    { new Guid("58cd3a06-5525-4561-83a0-4e8ade162685"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3381), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 4" },
                    { new Guid("595d29f9-169f-4f39-87b3-03df204f9165"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3388), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 5" },
                    { new Guid("66c9c492-73db-441c-8e28-48e963a372bb"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3373), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 3" },
                    { new Guid("67d71746-27e9-4c01-a52c-a0e8609163c3"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3321), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 2" },
                    { new Guid("6b84b0d8-54b5-4ce4-b009-6529998c7665"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3379), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 4" },
                    { new Guid("6da1b401-d31a-44c2-8956-55195183925c"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3399), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 8" },
                    { new Guid("72713f33-0420-4e51-8475-3c20b1beb516"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3408), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 9" },
                    { new Guid("79749e15-ccba-44c1-9482-83e2c77874ba"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3395), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 7" },
                    { new Guid("8b4fe5b3-b4ae-416b-80c0-5fd1f93e6d6f"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3378), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 4" },
                    { new Guid("9149e704-2487-483f-abe4-4e3d16cf7f0d"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3402), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 8" },
                    { new Guid("91804527-6c2e-44a7-a421-27ae2bcb14c2"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3396), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 7" },
                    { new Guid("ac2dc59f-6937-4285-b3c6-aa4f1a38415f"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3375), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 3" },
                    { new Guid("b0c0d4d3-b8fd-453c-b280-a192862525c6"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3409), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 10" },
                    { new Guid("b1c6aaef-544a-4855-a7e5-492d20607393"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3385), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 5" },
                    { new Guid("b3a398c9-ea94-4733-ba37-ac32e239f1b0"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3318), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 1" },
                    { new Guid("b87f91cf-cb40-4d62-8e78-79ab63dcf5d2"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3389), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 6" },
                    { new Guid("b8b53104-dd4e-42ae-a240-6c1be2ebf87f"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3320), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 2" },
                    { new Guid("baf233da-4d79-40b5-86be-08fe430567cb"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3372), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 3" },
                    { new Guid("c3cbacb8-32c2-4983-8d6c-183a276f9955"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3314), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 1" },
                    { new Guid("e142935d-a758-43fe-ad7d-b080de3daa0d"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3383), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 5" },
                    { new Guid("eb3e6a28-f8a0-4255-b7b0-f5cb8cab27bb"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3393), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 6" },
                    { new Guid("fc5918e2-6527-4f62-b2b7-295f4f280e36"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 7, 16, 40, 33, 52, DateTimeKind.Local).AddTicks(3328), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 2" }
                });
        }
    }
}
