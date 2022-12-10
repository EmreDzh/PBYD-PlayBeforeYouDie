using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class RequiredForSystemRequirements2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_SystemRequirements_SystemRequirementId",
                table: "Games");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "430f429d-a5b9-4740-a3cb-b56b490117ba", "AQAAAAEAACcQAAAAEN9S7RkQyDfk0DO2vyrNOrIPgdivWUEXYKj8aIhFTH1lkh4wHu/ckMgY70V0lM+AVg==", "a973e820-cdb2-4694-b58a-e4bbc5953bb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d083bcb0-15d1-4a32-a8a6-4fdbf7b8ed11", "AQAAAAEAACcQAAAAEDWrXylsYD2HEjLY8V/+7ZpihCmmU2hvYeym5MixNp+aZjfjZRT5GbJ0A8pqATIC6Q==", "02e797a2-7a71-4af5-a121-253e71a2c275" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0a230cf-1628-4a04-b0d2-3421f58f685d", "AQAAAAEAACcQAAAAEL3WdgKP6u3A3seUYnK7uC121Pmud3SvLGE25vJuSayqYJYm2vo7icRJtt8HmzSeTA==", "b2b58be4-b14f-4306-8a62-c4bfe5441018" });

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
                name: "FK_Games_SystemRequirements_SystemRequirementId",
                table: "Games",
                column: "SystemRequirementId",
                principalTable: "SystemRequirements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
