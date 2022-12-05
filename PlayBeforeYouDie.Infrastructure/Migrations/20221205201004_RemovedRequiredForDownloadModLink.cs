using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class RemovedRequiredForDownloadModLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DownloadModLink",
                table: "Mods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                table: "Mods",
                keyColumn: "Id",
                keyValue: 1,
                column: "DownloadModLink",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 3,
                column: "DownloadModLink",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DownloadModLink",
                table: "Mods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                keyValue: 1,
                column: "DownloadModLink",
                value: "N/A");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 3,
                column: "DownloadModLink",
                value: "N/A");
        }
    }
}
