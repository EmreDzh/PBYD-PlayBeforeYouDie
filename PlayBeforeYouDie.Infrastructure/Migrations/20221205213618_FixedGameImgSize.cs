using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class FixedGameImgSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2de48b9-cc50-45f3-b847-4723a60f575b", "AQAAAAEAACcQAAAAEISSOEaviuDDzR67Ory3AASDfFFXgaNm1aWgqdbxbcQOvc5dax9CPfjHLSBzJUo6ug==", "af72ff38-35ab-4814-8561-2e7d7d69c04e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76debe20-935d-4bcb-a8c2-983295bbb307", "AQAAAAEAACcQAAAAEJ8qEemq+6/LUTt9NbR74R4iRn5/wrXSChb8pVrS5tzh8KEjWQ96yhzspkadJ+Jmiw==", "129b7b05-525c-46f4-8216-5a9560661ed7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64d0e9ee-523e-4bcb-8afa-af610ec64e43", "AQAAAAEAACcQAAAAEK5P4UC76j9mltvS9icr+OiC8/lgnuz7hq6Khh1xMlxv1XmRr1KYLSe+mpro6SkgGw==", "2d3fc984-3f00-432c-8e9b-30e9ed1afd59" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://assets1.ignimgs.com/2016/10/18/red-dead-redemption-2-buttonjpg-f9ad35.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://static.giga.de/15/68/17/cbb82352a0e62e5ad8c613c207_AzE4Yzg1MDJhYzMw_thewitcher3.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a59f057c-1749-45ab-a24e-99b4ec52107c", "AQAAAAEAACcQAAAAEI+OelpxBwz3BWLDgxqqbNyLRc3g0bWlsNQ/9W7ukGyg/WPB132uFxxpMn79gJz9ig==", "5178cefb-78f3-411e-8bf6-d26588f6768d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0c6da5b-fa6e-4ac8-8b14-b39c0571a4fc", "AQAAAAEAACcQAAAAEANnjIc16xIL3kdCV5d6oxZ0924LaBdkNBT9w79/szQ3kl0EtmHL+tsWqNw5cNChqA==", "07a6ed0b-963d-40d2-9030-290c13115ef9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "134f3411-f832-4705-a8e4-66b6aad28ba8", "AQAAAAEAACcQAAAAENdHUVWrAwXD/P8fCAsmo2jns90MEOjHyX0k1+cAAvLDqJo9A+zvdNhWZohe9U+6ZQ==", "ad297ecd-f84d-47ba-a8ac-50da3c818e3a" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://s1.gaming-cdn.com/images/products/5679/orig-fallback-v1/red-dead-redemption-2-pc-spiel-rockstar-cover.jpg?v=1647026658");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "http://www.tomshw.it/data/images/5/9/4/1/03e512f6782d046f428fe2446f14187c6.jpg");
        }
    }
}
