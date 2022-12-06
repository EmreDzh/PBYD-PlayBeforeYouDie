using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class implementedModPictureClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModImage",
                table: "Mods");

            migrationBuilder.AddColumn<int>(
                name: "ModPictureId",
                table: "Mods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ModPictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModImageOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModImageTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModImageThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModImageFour = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModPictures", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ddc60f0-a67e-4dde-aa89-df139387fbef", "AQAAAAEAACcQAAAAELG9Q9D+/PZk6yYnUtRA8XO0cOHB6W7mQkrGmEZ/wQY6tpVplELAjCrociz6kxCihw==", "0c2a92d1-e214-4abc-aeec-1f7f44bbbbf0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc9b2312-999f-49f8-b621-535dcfcb64ba", "AQAAAAEAACcQAAAAEBZpZ5w8SSlE1ZF3Rr4vMPBWyIwjsxfwiJ/prVvwIig6vGFHBGtNzNVy1bphRAnyQQ==", "a17e9957-65c6-438c-8c0e-f66b75a868fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb5e5a7c-0a00-4032-a493-9c834d84a300", "AQAAAAEAACcQAAAAEKwMZgc9np72spNRCDIxcvhOL3qXK4K5r709r72SyikTUuXg+6BER9R2rM9/lCF9Cw==", "8f36568d-386a-437b-82fe-77c0ede87489" });

            migrationBuilder.InsertData(
                table: "ModPictures",
                columns: new[] { "Id", "ModImageFour", "ModImageOne", "ModImageThree", "ModImageTwo" },
                values: new object[,]
                {
                    { 1, null, "https://cdn11.bigcommerce.com/s-2m627o4amu/products/722/images/4096/Playstation-4-PS4-Empty-Custom-Replacement-Case-Box__50578.1507926933.500.750.png?c=2", null, null },
                    { 2, "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669740976-2124795078.png", "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669288616-1834557289.png", "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669740973-1427404846.png", "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669668228-1945410031.png" },
                    { 3, null, "https://s3.amazonaws.com/colorslive/png/60685-OcB6fsTJVHR82033.png", null, null },
                    { 4, "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669435927-1894312792.png", "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669436382-504851999.png", "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669435747-1676982520.png", "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669436162-343965417.png" },
                    { 5, "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600612171-1839423964.jpeg", "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600548166-1660518323.jpeg", "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600594030-2005225404.jpeg", "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600594032-1731970147.jpeg" }
                });

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModPictureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModPictureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModPictureId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModPictureId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModPictureId",
                value: 5);

            migrationBuilder.CreateIndex(
                name: "IX_Mods_ModPictureId",
                table: "Mods",
                column: "ModPictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mods_ModPictures_ModPictureId",
                table: "Mods",
                column: "ModPictureId",
                principalTable: "ModPictures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mods_ModPictures_ModPictureId",
                table: "Mods");

            migrationBuilder.DropTable(
                name: "ModPictures");

            migrationBuilder.DropIndex(
                name: "IX_Mods_ModPictureId",
                table: "Mods");

            migrationBuilder.DropColumn(
                name: "ModPictureId",
                table: "Mods");

            migrationBuilder.AddColumn<string>(
                name: "ModImage",
                table: "Mods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                table: "Mods",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModImage",
                value: "https://cdn11.bigcommerce.com/s-2m627o4amu/products/722/images/4096/Playstation-4-PS4-Empty-Custom-Replacement-Case-Box__50578.1507926933.500.750.png?c=2");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModImage",
                value: "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669288616-1834557289.png");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModImage",
                value: "https://s3.amazonaws.com/colorslive/png/60685-OcB6fsTJVHR82033.png");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModImage",
                value: "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669436382-504851999.png");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModImage",
                value: "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600548166-1660518323.jpeg");
        }
    }
}
