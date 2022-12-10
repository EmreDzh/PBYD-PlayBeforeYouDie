using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class EntitySetMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Genres_GenreId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_SystemRequirements_SystemRequirementId",
                table: "Games");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c124b0b1-1cbf-4a14-a177-bbb6d21f3474", "AQAAAAEAACcQAAAAEDEIzygsH0ZwhGNSVnr3ZFlI4Frf9FI1vweOgG1vmgdrxdNVipYjCHOnERhciFQQzw==", "74592302-ec91-48d6-931b-2bf4acfdfa7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d140896e-71ee-4825-8508-d174650d76ec", "AQAAAAEAACcQAAAAEDACsSAj32kVgNXGRmBMIBU2MfCJWKvvoInPutxCvVMu1B7g8FFLGobCAzFe4ujb9w==", "abc0a4f2-b159-4a5e-8eec-3add183691a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaa2c67c-64dd-49a3-97b8-19a46104299d", "AQAAAAEAACcQAAAAEK8F9xniZT1C1hU+ymZnZR7NNLM31RbHatq9nzjkvqcbY0zXqYFQYxfiwaLwqGwcxg==", "bc212ba7-e381-4d94-bb90-d3cb272c3a78" });

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Genres_GenreId",
                table: "Games",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_SystemRequirements_SystemRequirementId",
                table: "Games",
                column: "SystemRequirementId",
                principalTable: "SystemRequirements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Genres_GenreId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_SystemRequirements_SystemRequirementId",
                table: "Games");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Genres_GenreId",
                table: "Games",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_SystemRequirements_SystemRequirementId",
                table: "Games",
                column: "SystemRequirementId",
                principalTable: "SystemRequirements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
