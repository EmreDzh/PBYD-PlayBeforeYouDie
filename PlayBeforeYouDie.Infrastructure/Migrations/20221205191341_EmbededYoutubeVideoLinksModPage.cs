using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class EmbededYoutubeVideoLinksModPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc636e99-e85c-4c45-a931-fc33bcbadab8", "AQAAAAEAACcQAAAAEMBxF6CL9Q8zcqBpArSbxjVYoAc3CB0CTls8nT7NxV1DlQQrsM4/GGaoFktICmTTQw==", "f324b293-dbf7-45f1-8ce7-d261a77a5dcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dd7833b-bda5-43c8-8250-3b31ee3a796a", "AQAAAAEAACcQAAAAECQjP//9MGC1YHVDUYVFGuVB6sEGPzQamMeJfSsKtWFMugLZU+ZWVgTDk8yiJ4+27Q==", "f7c0e81c-a76f-4c6f-baa5-d123294f1376" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77af3e20-7a97-46fd-8e25-8aab83ed2cfa", "AQAAAAEAACcQAAAAEO+NGiGC5IyBcgzlnhpLdi8hAqDhpQ+Q6m6/8QpF6tjHh1IVluzxT1jpWpMC/mv9BA==", "0c6249a0-ab2d-4526-903c-5bc1243a21fa" });

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
                keyValue: 5,
                column: "YoutubeVideoModComparison",
                value: "https://youtu.be/embed/YNKlpvKvKl0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "772a62f6-3ebc-4f2f-962e-9e72e486d355", "AQAAAAEAACcQAAAAECxEOc7rZ0n/BJRPG/+Jv8wMP15f/LG1SgprRv4MTPrfqy56JTXJTTw6ncs8WVQSFA==", "840e8564-0a17-4a7d-a627-b540754af832" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8eca5a64-9605-4dc3-82a0-4ab6b1400967", "AQAAAAEAACcQAAAAEKzCJu5avwNONxkyFlcovAB4ohL6I38auwRbeKLF8VH+/IizKezVJCUmbHINkFYVBw==", "7e7d2bad-46bf-4b94-9067-8e242428e258" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65ad7872-0232-43a7-9fa7-d9084d7c2531", "AQAAAAEAACcQAAAAEF2GAoXteVert4KIbuODENyUAqxZ8gSX9/FTRJjkHejplko9xABfOl1M4XG+IufUEw==", "ced04326-5eaa-416e-94e5-9027f1543775" });

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 1,
                column: "YoutubeVideoModComparison",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 2,
                column: "YoutubeVideoModComparison",
                value: "https://www.youtube.com/watch?v=btiYnR848RU");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 5,
                column: "YoutubeVideoModComparison",
                value: "https://www.youtube.com/watch?v=YNKlpvKvKl0");
        }
    }
}
