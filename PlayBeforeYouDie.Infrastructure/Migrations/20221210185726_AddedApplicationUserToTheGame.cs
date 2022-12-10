using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class AddedApplicationUserToTheGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81b3dc14-607a-4cb1-8f77-3d6a5e98a4dc", "AQAAAAEAACcQAAAAECsQUiNaYYFvm/GoQ7/n7q18dE9rQBGyPlgg54MMZuUQo4tFdiuQ6X/lBGyCScSivQ==", "33417e6b-a859-41fa-8687-0d1e37aac715" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7db67e0-a457-487f-ae58-26aa26c41b81", "AQAAAAEAACcQAAAAECv4L4Aph7kD63k18D2l/77Tp2MgQCZabiBMRmSeSjtQptPWM8UiuwlclDoqqPlLpQ==", "4f31070e-2ff4-43c1-a205-bd37ac3892f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b47006f8-4d4f-421b-a087-7bd30ab920c3", "AQAAAAEAACcQAAAAEOETioBSMQWKdv2k5heRmpq6/osqulLd7R7MQGVKWl7JaunrxaQghOdyxP3DcpPVjA==", "ce145187-96b8-4587-af6b-9a6db7c713be" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "430f429d-a5b9-4740-a3cb-b56b490117ba", "AQAAAAEAACcQAAAAEN9S7RkQyDfk0DO2vyrNOrIPgdivWUEXYKj8aIhFTH1lkh4wHu/ckMgY70V0lM+AVg==", "a973e820-cdb2-4694-b58a-e4bbc5953bb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d083bcb0-15d1-4a32-a8a6-4fdbf7b8ed11", "AQAAAAEAACcQAAAAEDWrXylsYD2HEjLY8V/+7ZpihCmmU2hvYeym5MixNp+aZjfjZRT5GbJ0A8pqATIC6Q==", "02e797a2-7a71-4af5-a121-253e71a2c275" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0a230cf-1628-4a04-b0d2-3421f58f685d", "AQAAAAEAACcQAAAAEL3WdgKP6u3A3seUYnK7uC121Pmud3SvLGE25vJuSayqYJYm2vo7icRJtt8HmzSeTA==", "b2b58be4-b14f-4306-8a62-c4bfe5441018" });
        }
    }
}
