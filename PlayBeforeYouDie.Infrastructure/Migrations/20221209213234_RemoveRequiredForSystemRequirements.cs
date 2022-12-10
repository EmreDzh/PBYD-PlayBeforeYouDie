using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class RemoveRequiredForSystemRequirements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce2bafd1-9107-4da4-9645-cd74f06fc043", "AQAAAAEAACcQAAAAEGHckTATlfqtzKTxr8d7CxaSGlG8hGHudzk9SbHoc0z1S45dAEM748Vw0dj8NKDNOA==", "36373524-23f2-46f6-b5f6-22fbbd94b9df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "400f65ef-c12f-4231-aebe-99986165c4bb", "AQAAAAEAACcQAAAAEJhx1sMJJJ6DVMQvzN4MsJ+ZraxFD4LDO1ITP/fD8tYU2Jg946GwmgGAQ4+XxV/eyQ==", "9d1f0039-6637-44e6-883d-cfb63ab35390" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f54d6d7e-3040-433d-a2c6-aa5ebfbbcb6a", "AQAAAAEAACcQAAAAEFrDZe+QEzeNZ8l+OGeAB9QA8NrX7xbk1/wiVD9DoKThK/bULJTBt35sqUToYpo3IA==", "686541dd-2632-489b-a879-e8034eef5915" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f02ecda8-18a3-470e-b619-6c4a76507b16", "AQAAAAEAACcQAAAAEAl0KolmY3IR2V84XgJWKO30JBJj++BLbsyYoLd8neyLz/A2PuRBhbww8bjdw27dVQ==", "87318398-8ffb-425d-8a0e-bb055cab373b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "719d74ba-c558-44dd-80e2-fb5ea4c6f870", "AQAAAAEAACcQAAAAEEQTvKPOCR4FXUMOl2bR+1LW6W2c7BBD8D4O4CJMm+0q+yiPjJvHoQVZuda2EXJQmw==", "bc5a569a-079a-4d66-a3af-07d04bd53d0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c54c9514-e4ff-4677-9238-1be1c3c10666", "AQAAAAEAACcQAAAAEOOW6DuYdY8qWeoiH8/7BeK2eSFPNETpYxFRLn2srHv6z8AHbFMb8JRZ8UwyrF+XRw==", "47d78190-0378-462e-9e80-48778e766897" });
        }
    }
}
