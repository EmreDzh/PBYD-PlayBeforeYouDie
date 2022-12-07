using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class ChangedModsWithGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Mods_ModId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_ModId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "ModId",
                table: "Games");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Mods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53f28724-61c0-47ae-913d-c4fd3a68d155", "AQAAAAEAACcQAAAAECY1B1S5nhGzBXjcyFFqdNk3HzIla9ugpZqsZphuswntQanPo97kkrG+9xQwsrqS2w==", "9c9c0761-63e1-4828-bfa3-af98cbd953a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f9dbb65-480b-4f08-a760-861fd9576c91", "AQAAAAEAACcQAAAAEOa6YMAds9hkrVKVkfaWAPYKlTzsBYOWrHDUpTxAw+OQ1mloQzOsGlpd/QSNPI8mng==", "a41ef7dc-a9b6-43d0-9763-ed296920b8cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e99042c7-b1b1-462d-b693-74b3946fc614", "AQAAAAEAACcQAAAAEIC/ABa0aad4jmTTuyss76qeAnu0NDVEtwtU0f3SkaGy8KDOuWc6mzzJ1C0WVdV0yg==", "aad7370e-4f7c-48d3-86de-6c39bd09ce5b" });

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 1,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 2,
                column: "GameId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 3,
                column: "GameId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 4,
                column: "GameId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 5,
                column: "GameId",
                value: 6);

            migrationBuilder.CreateIndex(
                name: "IX_Mods_GameId",
                table: "Mods",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mods_Games_GameId",
                table: "Mods",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mods_Games_GameId",
                table: "Mods");

            migrationBuilder.DropIndex(
                name: "IX_Mods_GameId",
                table: "Mods");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Mods");

            migrationBuilder.AddColumn<int>(
                name: "ModId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70853159-28ef-4091-afb3-74cba5727ab7", "AQAAAAEAACcQAAAAEJbBm+l6RyyJ7XKBvd0ssXMMsqkskfg1AfMJk1zeU++Xpy3hH0NQtj9sWQeQwGLQWQ==", "03084221-5d97-4235-871b-b6aea5ac1816" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81694569-5b66-40be-8a89-1cf48f711cb0", "AQAAAAEAACcQAAAAEOFEktcIMkp50dsxNmKsG0xNRKzgp+ZuiC7EavGreY7lWPvhXbVnfK7k2KEg/LCnFg==", "ccb8704c-a017-460a-a652-18d23161cc39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c23cdca5-5b88-450c-acc1-3e98fe76c6f1", "AQAAAAEAACcQAAAAEMIV6n4eRAp/vftLJh1W7y3ve5w8EsMba2yaRby0ZwrVwsG3WV+IS0EyksyqayOaiw==", "969f8786-1d5b-4762-91dd-a291690f328d" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModId",
                value: 5);

            migrationBuilder.CreateIndex(
                name: "IX_Games_ModId",
                table: "Games",
                column: "ModId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Mods_ModId",
                table: "Games",
                column: "ModId",
                principalTable: "Mods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
