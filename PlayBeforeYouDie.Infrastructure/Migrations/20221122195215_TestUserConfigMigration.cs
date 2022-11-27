using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class TestUserConfigMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "4a5b911c-16d5-4a2c-aa28-30b0b3a999c4", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEOdgnOejfR9RK7ibFxEqH8D9qetSUKvwr7IIqBMgXB5GWU0dt/LW1XxCazyhFZ5YFw==", null, false, "ead2a56d-d298-4dfa-a0a6-df16685dd658", false, "guest@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dea12856-c198-4129-b3f3-b893d8395082", 0, "b66f83c6-2029-4349-946d-bff2664c4c58", "modder@mail.com", false, false, null, "modder@mail.com", "modder@mail.com", "AQAAAAEAACcQAAAAEOZkUHUFnHGrtgFxVJlf7bTyMD3gB3S76J8qJDwb1lSTPhOFw/pW5oNKyELHvCzDKg==", null, false, "3f9f173d-305d-410c-a154-3bbf2d014e4f", false, "modder@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");
        }
    }
}
