using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class fixedYoutubeModLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 1,
                column: "YoutubeVideoModComparison",
                value: "https://youtube.com/embed/WZK19L2JUGc");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 2,
                column: "YoutubeVideoModComparison",
                value: "https://youtube.com/embed/btiYnR848RU");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 4,
                column: "YoutubeVideoModComparison",
                value: "https://youtube.com/PA-gd8DBR8o");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 5,
                column: "YoutubeVideoModComparison",
                value: "https://youtube.com/embed/YNKlpvKvKl0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4216f137-bda6-45f3-8cc2-c88a60050496", "AQAAAAEAACcQAAAAEAk6CnS9USEw2iyBy0MAaPZ+jDh8q8RdiGu2BdTFH/d/LeQPHjkpzmuDQazWnaKBWQ==", "9ebe91c1-2ddc-4684-bf30-a694434c9b95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12a59121-6662-4018-81b4-6f636075a240", "AQAAAAEAACcQAAAAEDLyTN/9wtQkn9oI5p6U9Lc43NMZ0rGvDBaM8GW13kDv4CaCjw9NOIVKqXuSLI/5zA==", "eb431007-7c0a-48c2-82bf-ce6624be24b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "669cec50-c2f7-4e94-a1ff-b28d7fa23840", "AQAAAAEAACcQAAAAECAPUpIPL9aIELPVXhvmq+BxO9G4SQ10ERBCyvUED12VGt7lRzxpBgUJ4ZmqDcVfcA==", "99f96132-b71e-487a-8bdf-9c779b391de9" });

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 1,
                column: "YoutubeVideoModComparison",
                value: "https://youtu.be/embed/WZK19L2JUGc");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 2,
                column: "YoutubeVideoModComparison",
                value: "https://youtu.be/embed/btiYnR848RU");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 4,
                column: "YoutubeVideoModComparison",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 5,
                column: "YoutubeVideoModComparison",
                value: "https://youtu.be/embed/YNKlpvKvKl0");
        }
    }
}
