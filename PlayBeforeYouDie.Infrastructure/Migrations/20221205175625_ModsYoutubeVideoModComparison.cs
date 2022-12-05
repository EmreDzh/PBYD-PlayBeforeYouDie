using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class ModsYoutubeVideoModComparison : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "YoutubeVideoModComparison",
                table: "Mods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpeedRunOneHundredPercent",
                table: "HowLongToBeat",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpeedRunAny",
                table: "HowLongToBeat",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MainStory",
                table: "HowLongToBeat",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "MainPlusSides",
                table: "HowLongToBeat",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "HundredPercentComplete",
                table: "HowLongToBeat",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

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
                keyValue: 2,
                column: "YoutubeVideoModComparison",
                value: "https://www.youtube.com/watch?v=btiYnR848RU");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 5,
                column: "YoutubeVideoModComparison",
                value: "https://www.youtube.com/watch?v=YNKlpvKvKl0");

            migrationBuilder.UpdateData(
                table: "SystemRequirements",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdditionalNotes",
                value: "Initial activation requires internet connection; Online play requires log-in to Games For Windows - Live and Rockstar Games Social Club");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YoutubeVideoModComparison",
                table: "Mods");

            migrationBuilder.AlterColumn<string>(
                name: "SpeedRunOneHundredPercent",
                table: "HowLongToBeat",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpeedRunAny",
                table: "HowLongToBeat",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MainStory",
                table: "HowLongToBeat",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "MainPlusSides",
                table: "HowLongToBeat",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "HundredPercentComplete",
                table: "HowLongToBeat",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d1df4cd-f185-40ca-b897-688552c65a81", "AQAAAAEAACcQAAAAEBXdoiSuuGmGdzSS/6xY5RICmT8V586BtybFzlEOBAhNep5cI3Y66LM+rhAQyd55tw==", "349cd1fc-853d-4162-8553-3c11c900d27d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bf37c15-4d42-4d8d-bbf4-e65f8bf516b5", "AQAAAAEAACcQAAAAEHLpfEWEPmuPemBsdRnDy9bt03rd7heNkYEmr7fTjXRGYW4Pff7dbad+aqrvx2AU/g==", "cdb11825-4ec8-4a30-ac77-2dd1dc51af4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55895eda-8019-4cad-8dcc-4a21b75d4ee2", "AQAAAAEAACcQAAAAEDBAfPu9PnReHW1hgQ9pnug+b681rpqNebNoZeMDXIpW3hk4Fpl4cJtiz6xrKvFnlQ==", "66458eef-9b0f-4c64-9dab-95ab526bd57a" });

            migrationBuilder.UpdateData(
                table: "SystemRequirements",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdditionalNotes",
                value: "Initial activation requires internet connection; Online play requires log-in to Games For Windows - Live and Rockstar Games Social Club (");
        }
    }
}
