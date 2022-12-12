using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class FixedImgSizeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b26ef264-2d88-4207-a82d-96328fd4b309", "AQAAAAEAACcQAAAAEJzCp1KNhGPJKs/lfjVLGvzq4Oi0qvDslRpKuSOdDAKdX2iUDB31vKEGHouLAK2eZw==", "d9d0ec8d-7e2f-4da5-85d8-4e665cca2149" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1caff42a-07d5-47db-bef0-34f5af8ccacb", "AQAAAAEAACcQAAAAEE3A6idUvZJl2OTXo8cPlzqkfD9absDEY+huG4sHxDRqVgok4pfZViEQA/5WE/943g==", "9f13246e-7510-4ce6-b1e4-d38882b5352b" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://store-images.s-microsoft.com/image/apps.58752.68182501197884443.ac728a87-7bc1-4a0d-8bc6-0712072da93c.0cf58754-9802-46f8-8557-8d3ff32a627a?mode=scale&q=90&h=720&w=1280&background=%23FFFFFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9eabfda0-78b2-43ae-aab2-8e925008d03f", "AQAAAAEAACcQAAAAEG8jVrniDjBmh2zKivvZy+hZm47zFgXlnI+nEZfexva7OH4Pv8wY3bs/Z9mXRj3BOA==", "fecb38a9-5726-4398-9632-c63e10d26e73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32acb9f3-c7de-4085-836f-2222c144cc64", "AQAAAAEAACcQAAAAEPdvwRF63YH3p93s+5WaQ+yFZYD8Hjww4E6moQ/+W9de9XCCEw1PwxYlA1zxFkKXbQ==", "eadf2aeb-f459-48aa-a5dc-cc7c78a6d933" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://image.api.playstation.com/cdn/UP1004/CUSA03041_00/Hpl5MtwQgOVF9vJqlfui6SDB5Jl4oBSq.png");
        }
    }
}
