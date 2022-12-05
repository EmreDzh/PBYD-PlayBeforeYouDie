using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class FixedYoutubeLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4172de4d-4220-4045-af29-30a4a5f5036e", "AQAAAAEAACcQAAAAED5oIFXuqJg+JML0ykn5kDQHuVY/iOo2gbQz25jLA+SR39ajx3u0XQEcJLRImhQjOQ==", "ebf32268-e4d8-4854-9531-5791c18706d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "283644d6-03ee-44fe-96aa-da99a6e61a21", "AQAAAAEAACcQAAAAEImMUD1JSLsYjynB1pDsMftoI3G2pcdXh3D0EoGSldDKlFZWGEO/WHEHQFgpHa+rfA==", "045c7ba6-af20-4963-9bf8-305e9fe65f91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c63f970-3d20-47b7-996f-c052308dc649", "AQAAAAEAACcQAAAAEOhj0rByGc9n012AaPrkEx8AcpwKb2suPgqM/hMB0IpJelbeq5LN0M88ZFJGQJgamA==", "0f074870-2876-419b-a9db-f75d20763cd4" });

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 4,
                column: "YoutubeVideoModComparison",
                value: "https://youtube.com/embed/PA-gd8DBR8o");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31571e29-4e59-453c-8121-a850352be7a7", "AQAAAAEAACcQAAAAEMqaXhMCK50NDw3sIRIODF3ZAIHvO9rPIA6eq7G/1QId0iNkjD8P1N35a7htgHMHDw==", "0a98e000-9caa-4ea5-bf4b-e5d6992f67a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09162c95-3bd5-458e-a4a8-ee9190ea631c", "AQAAAAEAACcQAAAAEB6YjKPPpNjWzkAcAECyY8uPnU3PmGKUNtREf9JvpEkaEVtMtRdgT1wm4k+u+G2PTQ==", "1401cbc4-726a-4ba3-99f6-3925f1ab46d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de1cd28b-4e1d-44eb-aabf-8a20887c18a9", "AQAAAAEAACcQAAAAEPF8qn9x8q61lgn7PIfDmH8D1+pGEXpAHTBc+mKQW2yPnnieGwxhupgqAkKhFQGE6w==", "74eafd6b-7dbf-48a9-a134-68b6c91ff79d" });

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 4,
                column: "YoutubeVideoModComparison",
                value: "https://youtube.com/PA-gd8DBR8o");
        }
    }
}
