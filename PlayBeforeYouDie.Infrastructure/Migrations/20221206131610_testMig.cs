using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class testMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
