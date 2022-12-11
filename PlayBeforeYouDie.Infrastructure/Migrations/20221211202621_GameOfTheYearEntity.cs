using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class GameOfTheYearEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameOfTheYears",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Developers = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameOfTheYears", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a42a5c8e-84ed-4b3e-b156-686958c270fe", "AQAAAAEAACcQAAAAEIA7uzeeIYrQ54C/E9pfQO+UsJVRwYiGaU2e77UdcwT838ErTUx55Gau3xul8aGoiA==", "422ab26c-60c9-4cea-822d-2e3eacaa166e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09d7beaf-833b-4a3c-b4c6-a49c200a6752", "AQAAAAEAACcQAAAAEGJoF/rBXV7zBvyC2AjWtepWqAgJcXLbaa49oapGdkNeXHmsSB/AlJ0SWmcxkeBu2A==", "a96257e5-b30d-4851-a583-0bb42d5ac546" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0f8187c-6e17-4338-8151-f6bcac87ef9d", "AQAAAAEAACcQAAAAEJbyEAPqFAcMw4QTNao56Dsw2fHoTDkP4VTzfWExw8/v4Pi7kgef0MhA9QRCShNCFw==", "55ad70d1-19e7-4497-8802-760fd97c2115" });

            migrationBuilder.InsertData(
                table: "GameOfTheYears",
                columns: new[] { "Id", "Developers", "GameTitle", "ImageUrl", "Year" },
                values: new object[,]
                {
                    { 1, "BioWare", "Dragon Age: Inquisition", "https://image.api.playstation.com/cdn/EP0006/CUSA00503_00/3uJniniN80XZw4jZ7fuXxK3ogaSK3rru.png", 2014 },
                    { 2, "CD Project Red", "The Witcher 3 Wild Hunt", "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png", 2015 },
                    { 3, "Blizzard Entertainment", "Overwatch", "https://m.media-amazon.com/images/I/91lid74MqmL.jpg", 2016 },
                    { 4, "Nintendo", "The Legend of Zelda: Breath of the Wild ", "https://www.zelda.com/breath-of-the-wild/assets/icons/BOTW-Share_icon.jpg", 2017 },
                    { 5, "Santa Monica Studio", "God of War", "https://s3.gaming-cdn.com/images/products/7325/screenshot/god-of-war-pc-spiel-steam-wallpaper-1.jpg?v=1668157899", 2018 },
                    { 6, "FormSoftware", "Sekiro: Shadows Die Twice", "https://www.pcgames.de/screenshots/original/2019/03/Sekiro-Review-PS4-1-pc-games1.jpg", 2019 },
                    { 7, "Naughty Dog", "The Last of Us Part II", "https://www.pcgames.de/screenshots/original/2020/06/The-Last-of-Us-Part-II-Review-Artwork-buffed1.png", 2020 },
                    { 8, "Hazelight Studios", "It Takes Two", "https://www.play3.de/wp-content/uploads/2021/03/It-Takes-Two.jpg", 2021 },
                    { 9, "FromSoftware", "Elden Ring", "https://www.videogameschronicle.com/files/2022/02/sds5.jpg", 2022 }
                });

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 8,
                column: "YoutubeVideoModComparison",
                value: "https://youtube.com/embed/Gkd5h9VYGXE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameOfTheYears");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a541de5-d230-40bd-8962-5f10204eb1f1", "AQAAAAEAACcQAAAAECKCxbCZk/0nVz38D9AT8KUrdfyanKpHDBwUaDz56gQ2y4B7cuqynNaK/QDJtEU+yw==", "013a5eea-4d6e-427a-9662-c54c79964300" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c146b40-7fec-4b19-a8f5-c82766a5de8f", "AQAAAAEAACcQAAAAEJJ5+q8Xfu711VfnyfpMduxGgCUJCuuK9Jhhg8PVOQdARlBf8oU6coMzO2MhcKmwXQ==", "1f30542f-0f47-40b5-a1ce-e85b087d3e6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3b9ab8e-66bf-4ca2-bc37-a88250b73e84", "AQAAAAEAACcQAAAAELRdvbUL7Oif2B66uQoTJgPuBIfHxxht35qiv5El785//XD9+pLToT+3OSZLDFH+JA==", "2d93f61b-069e-4f2e-aa2d-9cab28618044" });

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 8,
                column: "YoutubeVideoModComparison",
                value: "https://youtube/embed/Gkd5h9VYGXE");
        }
    }
}
