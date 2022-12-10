using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class RequiredForSystemRequirements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41fa346d-fab3-42d6-8b2f-7ac9db42a351", "AQAAAAEAACcQAAAAEOlLUzZbDnCqqvUqLG09aRHUj78Qi0NxjmJyd9hUn1Yw8hSqKAdDJbwWxkhjw2+tZg==", "bb101c4a-0736-4c7f-8811-69d1f1cfc116" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d66890c-6c83-43f7-9b06-bbd0888eb3c5", "AQAAAAEAACcQAAAAEH5pZGT3cBg0QjcDOkGn6V7T77nslfk7L6kCVgNWH/Hq/RqfSg9OeZA04rP9ZeiflA==", "fa500ae1-9677-435e-96d9-5b23c12f533b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2802ec3-41b0-4072-831b-c201d36d8196", "AQAAAAEAACcQAAAAECQHd38Nxys0JIO6ChuHX5jdxoQ3C9+zSYhJagTg2oGRLBjz5u00Ah1xhZMUABpvZg==", "ec0db068-1672-4184-9198-1ea05a96d4bb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce2bafd1-9107-4da4-9645-cd74f06fc043", "AQAAAAEAACcQAAAAEGHckTATlfqtzKTxr8d7CxaSGlG8hGHudzk9SbHoc0z1S45dAEM748Vw0dj8NKDNOA==", "36373524-23f2-46f6-b5f6-22fbbd94b9df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "400f65ef-c12f-4231-aebe-99986165c4bb", "AQAAAAEAACcQAAAAEJhx1sMJJJ6DVMQvzN4MsJ+ZraxFD4LDO1ITP/fD8tYU2Jg946GwmgGAQ4+XxV/eyQ==", "9d1f0039-6637-44e6-883d-cfb63ab35390" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f54d6d7e-3040-433d-a2c6-aa5ebfbbcb6a", "AQAAAAEAACcQAAAAEFrDZe+QEzeNZ8l+OGeAB9QA8NrX7xbk1/wiVD9DoKThK/bULJTBt35sqUToYpo3IA==", "686541dd-2632-489b-a879-e8034eef5915" });
        }
    }
}
