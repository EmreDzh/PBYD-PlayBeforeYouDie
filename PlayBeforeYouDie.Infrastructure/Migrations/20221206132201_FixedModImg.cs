using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class FixedModImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1951d13-0376-413f-a402-5f26742f9a4c", "AQAAAAEAACcQAAAAEEaWX6VR+IGiAZtyViOLDHCDdBYCWsNKmVhcv/p5l1zDf8YsMReQeCWKoYeHGbTOYQ==", "c17a9a7b-aca3-46a6-8cd0-f62e58407143" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ac55c68-1487-4589-984e-cc729a122730", "AQAAAAEAACcQAAAAEN1tTg9AzY/xZ7aQImUwR1p6LaJCxN7OkcHf2kmzG3/qVnWL2XLNNLJU6kboqgJznA==", "085033fc-b7f1-4f42-a913-deddee2a095d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a06527e3-3bfb-48c5-a6f0-49e52380d249", "AQAAAAEAACcQAAAAEDWkWoR1skCSWKkV4OwHxfifEo5ILK4ImHkenmu/VG2cIOixgOGYbCzfmEaS060/8w==", "c87ede69-b79d-482d-a771-a055046495a2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d59184c-48f3-4c9e-b265-4685ee2f8291", "AQAAAAEAACcQAAAAEB6ldBKFOd++Dc9191ibCq1tMTmEy9UBPbpWt05PTS0vAh7W7nQidNxjaTPzhCAtsw==", "c4fc5941-a65b-42a4-934b-4a7b451fe6ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6088314-d9a8-4f43-9478-be9d0231c9e3", "AQAAAAEAACcQAAAAEEeb9lRbqxgk+u2yfLP0CvXyvNB1pZ14Obbe5p0DNVjxnoHEjQDgoKvQNWFObZFbqw==", "240174f2-8297-4fcd-8167-539c0af52b06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff0b5072-2f8a-4243-b027-b9511049f687", "AQAAAAEAACcQAAAAENsIfhC8xHuvrPkWfRatH4XLxbcchIxxs7m2SKGra6Xydw7pnrercv+/HXRL0UCQ0w==", "c186bed0-babc-4e48-8910-ae9f280f0d96" });
        }
    }
}
