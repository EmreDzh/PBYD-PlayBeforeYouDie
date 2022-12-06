using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class FixedMigTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModModPicture");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f86c867-38d3-4434-8369-5f816e029995", "AQAAAAEAACcQAAAAEF/E5kZF1HEgXaAiUG9WvFMB6UGedf8VGIGbeWanS3suZClT1QIU7RFkhdSJy7r5ew==", "b490dde4-668d-4c8b-9180-f196013d34e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35731853-11cd-4079-bbbc-fd644501d272", "AQAAAAEAACcQAAAAEINkhcrWUKZAuklWrqgClRYxwtObPHHl7JUJSMN94uQGxmcocNYDqMHH1/m2ez42jQ==", "7c812185-c154-47fd-93a4-9fd34d304e6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b400b3e5-d39e-4259-99f4-8769215dbccc", "AQAAAAEAACcQAAAAECcZz1uidPCqyD4x2nH3yUzyShk2YQxAtPiN43O+GzgaP4Z9YBOyM3PC6A5gAeFMLg==", "d513ceb6-a3d9-4859-a100-5ab52aa775a3" });

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

            migrationBuilder.CreateIndex(
                name: "IX_ModModPicture_ModsId",
                table: "ModModPicture",
                column: "ModsId");
        }
    }
}
