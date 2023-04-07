using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceNewsPortal.Web.Migrations
{
    public partial class ApplicationUserImageFilePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("0438a88b-747f-45fd-b3c4-3e581664ead7"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("0991481f-2481-4577-9870-e8dfbbfefcca"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("0e125826-347e-4ffa-b7ff-4df175067905"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("27593c70-1dbf-4d8d-97da-f008a626e27b"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("29fd36ef-1662-4a0f-91fb-60a0319d217a"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("2c5ff508-86a0-4275-894e-d2d70880870f"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("2e64953c-fb10-4500-9a73-dc2842e260b5"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("3ceef4dd-17db-45c6-a104-ac398fb0cd7a"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("518fface-9bb0-4628-b1ab-dab86757e884"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("5f9986ea-4c3d-4a66-aa67-3f3bc9474485"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("6527cd71-7291-4f98-8a4d-13e279ee9106"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("68e4da6c-ee7d-4078-aecf-061baec00dfc"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("6a0e5d13-ea0b-415a-bcc3-7f0029e62336"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("7f648b1d-2e13-42b8-a076-1c97f8584db7"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("906966d3-00c5-47e3-ba51-6ad64c9ffac0"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("95da46ba-f614-42e6-b6be-c935d8faaaa7"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("a1354ccf-28ae-44fe-b5a8-42a9387c150c"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("a43f14a4-4c8f-4326-ba53-4646b1c74731"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("b37bc1e8-e1e3-450c-ad95-e8547eea92b3"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("b3ab3186-037c-42ef-a224-e35deeec7f87"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("b542b79a-00e7-4c07-a7e5-88511d4d2bcb"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("bcb5e573-7fd6-45a5-a654-d27d3efdc157"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("c2c12bd4-3908-4474-bde4-e394e6891baf"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("c47e7eed-6fd3-4267-8768-7a5064ccd291"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("c631f6b0-20b9-4c65-b743-05889647cdb2"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("ce86483a-289b-43b5-b67a-9dddb048b70f"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("e6ab3300-c9fa-4d78-9a46-14df449d1fe3"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("ec1a1c12-db0e-4dd1-b3fc-4e51f36ef786"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("ed4c9224-6b11-4960-b956-041e095baae5"));

            migrationBuilder.DeleteData(
                table: "NewsArticle",
                keyColumn: "Id",
                keyValue: new Guid("ff7a4e0f-f9e6-427f-87b7-0e791cffe5fe"));

            migrationBuilder.AddColumn<string>(
                name: "ImageFilePath",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "ImageFilePath",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08715f79-2c99-4a8b-935a-7ff2e37d1518",
                column: "ConcurrencyStamp",
                value: "42630669-2ba3-4aef-bde6-790efe5fb2c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a73053f-78c6-41c2-94fc-d897ccc8b33c",
                column: "ConcurrencyStamp",
                value: "89b608a7-1572-453b-89bd-58dfd0662d8f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "705c9705-c8a8-44af-99a3-e33b13856856",
                column: "ConcurrencyStamp",
                value: "ebc20c3a-4b34-43cf-bcb5-0fffbee214d1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "147c0de8-847c-4466-ad04-1fc7b563e0c4",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d44bd32e-9541-4581-9ef8-3ea4c36cdda4", new DateTime(2023, 4, 6, 0, 21, 51, 296, DateTimeKind.Local).AddTicks(1230), "AQAAAAEAACcQAAAAEOsltGw1/sRKHM5Cn6cAImMg0+eeTSBIYmUzo44ilwiTPhw1tBB5NqtkHwdnlm5+CQ==", "d6735b1c-f627-4109-9db4-c7fccab5ce76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c0b055f-d24d-43be-b842-4393d0b68d61",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a45583c8-f5a0-4b2c-981d-3ed6c44598aa", new DateTime(2023, 4, 6, 0, 21, 51, 298, DateTimeKind.Local).AddTicks(7974), "AQAAAAEAACcQAAAAEOCheIBEufGY9W04d1mJtC3/vEtah15nztHOnGYgCpd9dnrQuNkVAzyy46iIZjfocQ==", "95abec11-9867-486f-b1fc-b6a9335fbc62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba87ff8-bb15-442f-8a47-0e65a93cab8c",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dc51675-b7f0-4253-9607-b73dab01b14e", new DateTime(2023, 4, 6, 0, 21, 51, 297, DateTimeKind.Local).AddTicks(4689), "AQAAAAEAACcQAAAAEAwQ7P3oqjbP/9U2AGz81k2GuqKdwDHffK/MmAxdlpsRtN88Wpm0sorA9u3eST9M1Q==", "0a506f86-7eab-43df-8d5c-f66703281460" });

            migrationBuilder.InsertData(
                table: "NewsArticle",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "Description", "ImageFilePath", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("0438a88b-747f-45fd-b3c4-3e581664ead7"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1242), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 7" },
                    { new Guid("0991481f-2481-4577-9870-e8dfbbfefcca"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1183), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 3" },
                    { new Guid("0e125826-347e-4ffa-b7ff-4df175067905"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1238), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 6" },
                    { new Guid("27593c70-1dbf-4d8d-97da-f008a626e27b"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1185), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 3" },
                    { new Guid("29fd36ef-1662-4a0f-91fb-60a0319d217a"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1254), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 9" },
                    { new Guid("2c5ff508-86a0-4275-894e-d2d70880870f"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1246), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 8" },
                    { new Guid("2e64953c-fb10-4500-9a73-dc2842e260b5"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1237), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 6" },
                    { new Guid("3ceef4dd-17db-45c6-a104-ac398fb0cd7a"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1230), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 4" },
                    { new Guid("518fface-9bb0-4628-b1ab-dab86757e884"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1171), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 1" },
                    { new Guid("5f9986ea-4c3d-4a66-aa67-3f3bc9474485"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1173), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 2" },
                    { new Guid("6527cd71-7291-4f98-8a4d-13e279ee9106"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1231), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 5" },
                    { new Guid("68e4da6c-ee7d-4078-aecf-061baec00dfc"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1259), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 10" },
                    { new Guid("6a0e5d13-ea0b-415a-bcc3-7f0029e62336"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1245), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 7" },
                    { new Guid("7f648b1d-2e13-42b8-a076-1c97f8584db7"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1233), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 5" },
                    { new Guid("906966d3-00c5-47e3-ba51-6ad64c9ffac0"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1241), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 6" },
                    { new Guid("95da46ba-f614-42e6-b6be-c935d8faaaa7"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1226), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 4" },
                    { new Guid("a1354ccf-28ae-44fe-b5a8-42a9387c150c"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1228), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 4" },
                    { new Guid("a43f14a4-4c8f-4326-ba53-4646b1c74731"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1162), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 1" },
                    { new Guid("b37bc1e8-e1e3-450c-ad95-e8547eea92b3"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1252), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 9" },
                    { new Guid("b3ab3186-037c-42ef-a224-e35deeec7f87"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1182), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 3" },
                    { new Guid("b542b79a-00e7-4c07-a7e5-88511d4d2bcb"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1257), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 10" },
                    { new Guid("bcb5e573-7fd6-45a5-a654-d27d3efdc157"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1249), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 8" },
                    { new Guid("c2c12bd4-3908-4474-bde4-e394e6891baf"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1250), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 8" },
                    { new Guid("c47e7eed-6fd3-4267-8768-7a5064ccd291"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1179), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 2" },
                    { new Guid("c631f6b0-20b9-4c65-b743-05889647cdb2"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1243), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 7" },
                    { new Guid("ce86483a-289b-43b5-b67a-9dddb048b70f"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1175), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 2" },
                    { new Guid("e6ab3300-c9fa-4d78-9a46-14df449d1fe3"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1236), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 101, "Some Pending News 5" },
                    { new Guid("ec1a1c12-db0e-4dd1-b3fc-4e51f36ef786"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1253), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 102, "Some Rejected News 9" },
                    { new Guid("ed4c9224-6b11-4960-b956-041e095baae5"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1135), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 1" },
                    { new Guid("ff7a4e0f-f9e6-427f-87b7-0e791cffe5fe"), "cba87ff8-bb15-442f-8a47-0e65a93cab8c", new DateTime(2023, 4, 6, 0, 21, 51, 300, DateTimeKind.Local).AddTicks(1256), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pharetra volutpat iaculis. Praesent ultricies, enim et finibus maximus, nunc enim efficitur neque, eget suscipit erat orci quis dolor. Morbi sed lobortis sapien, at luctus nisl. In non sodales tortor, id elementum nisi. Sed nunc erat, fermentum ut viverra in, pulvinar in lectus. Suspendisse a lorem sem. Nulla tristique non ligula nec consequat. Praesent at viverra felis, nec dapibus turpis. Mauris ac tempor mi, in imperdiet sem. Praesent fermentum libero arcu, a malesuada tellus rhoncus a. Nunc sed dolor nulla. In hac habitasse platea dictumst. Fusce ac suscipit erat. Etiam sed justo sit amet erat pharetra viverra. In porta arcu quis mi cursus consequat. Pellentesque eu odio justo. Vivamus pretium neque velit, ut lobortis sapien dapibus in. Suspendisse blandit odio at convallis mattis. Nam ac felis eu diam bibendum rutrum. Nulla eget libero placerat, facilisis nisl quis, condimentum neque. Mauris laoreet bibendum mi sed tristique. Interdum et malesuada fames ac ante ipsum primis in faucibus.", null, 103, "Some Approved News 10" }
                });
        }
    }
}
