using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class AddedTheApplicationUserToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUserGame",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserGame", x => new { x.ApplicationUserId, x.GameId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserGame_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserGame_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db9164f3-b8a2-465d-b150-134d13f05c56", "AQAAAAEAACcQAAAAEJzWOJ6KgPU/WXV3c7wkZOx2ARlnGZEwOObB1/OvVEg6DRHZbgS3oQC/TJUjuiKXgQ==", "0ae8b4e4-39da-4222-9943-5aa426a76737" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8f9b4eb-ae3a-4fdf-a436-66a063452ee1", "AQAAAAEAACcQAAAAEN+ngpEfbznK8W5HhlgGbKevByPYLy+XGZv7s5CQXB1S9B/ESIxHVP2QDqf/lhql8A==", "1ed84cc4-9427-4e9a-bcb5-21b74359c064" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac1db208-7ad6-421b-977a-9a5a4839df0e", "AQAAAAEAACcQAAAAEB5T/LvLXsQKkRxBSmtgmGf+jyPz928GV5v95hFC8f5NGlBnqh1AiofTY0fZvWfn5A==", "39d33653-d25a-4b18-8d31-e14eb62b3a7e" });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserGame_GameId",
                table: "ApplicationUserGame",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserGame");

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
        }
    }
}
