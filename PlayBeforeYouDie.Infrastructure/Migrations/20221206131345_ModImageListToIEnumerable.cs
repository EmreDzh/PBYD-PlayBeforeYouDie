using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class ModImageListToIEnumerable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mods_ModPictures_ModPictureId",
                table: "Mods");

            migrationBuilder.DropIndex(
                name: "IX_Mods_ModPictureId",
                table: "Mods");

            migrationBuilder.CreateTable(
                name: "ModModPicture",
                columns: table => new
                {
                    ModPictureId = table.Column<int>(type: "int", nullable: false),
                    ModsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModModPicture", x => new { x.ModPictureId, x.ModsId });
                    table.ForeignKey(
                        name: "FK_ModModPicture_ModPictures_ModPictureId",
                        column: x => x.ModPictureId,
                        principalTable: "ModPictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModModPicture_Mods_ModsId",
                        column: x => x.ModsId,
                        principalTable: "Mods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92a12cca-ba3c-4387-b323-4b7f765858ac", "AQAAAAEAACcQAAAAEEOpgQvgxqD3OnzGwDzuHaZLAq5J8f+0mTO0F3J2FzK0eIWBWSAKWuFnMrP5IdKjkw==", "e20389a9-4ae5-43ff-ad7e-25191dc5909b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0107fed2-8ec7-4b72-8e8c-f99cb1514a34", "AQAAAAEAACcQAAAAEJzLjvNRytlpsKWjtMPWQk2fEivgvxKfT+sTuvdb1M+XTkHqiENXEcW4mBUXOAsxZQ==", "473f7fbf-7a8d-478f-914e-89d27fc3222b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90ee1f3d-efca-44ba-8320-ce75bae36e08", "AQAAAAEAACcQAAAAECCbE1xG/0hT5IdSiXPPuucF0S9Y4VosiCcwQJA7iodiJeN2hV74wPGsSIZqixgoZw==", "ecddd6b0-f7d7-4e5f-9085-c79664015aa9" });

            migrationBuilder.CreateIndex(
                name: "IX_ModModPicture_ModsId",
                table: "ModModPicture",
                column: "ModsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModModPicture");

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
    }
}
