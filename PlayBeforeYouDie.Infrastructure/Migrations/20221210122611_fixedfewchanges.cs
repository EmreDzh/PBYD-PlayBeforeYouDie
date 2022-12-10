using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class fixedfewchanges : Migration
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
                values: new object[] { "343a30ef-f6f9-4a62-b3c3-6c70675d47c3", "AQAAAAEAACcQAAAAEN+Y1OUetH1N3MAQ4N6EyvD1pTzNqn2mSHTLF1rWx7OWWVts4g32Tr9LU9haLU4POQ==", "99bf997a-72f0-42c2-9503-9869221b4814" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02eef981-8673-4835-8481-ad64f4f2fbf6", "AQAAAAEAACcQAAAAEK2/NkHr5AEeGaec3oX2UOaM93j4GhxQp6PawZ2UDBAJu+lJ5+Qrx2Er+VCPCNRG8A==", "bf550a1b-58b2-4c8e-9cf7-f1b99b4ec51b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8667411f-e5ed-46a2-a8c8-0d7f8ff65fb9", "AQAAAAEAACcQAAAAEFAanrSdAJn9jZZDH22ayRje6KYir5Ht03QDq374tvQRD+629o1ABE3c0R10LJpvnw==", "b46e5971-9a31-40a8-a8bf-d7eafecbc37c" });

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
    }
}
