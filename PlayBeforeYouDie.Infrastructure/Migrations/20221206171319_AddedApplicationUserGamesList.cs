using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class AddedApplicationUserGamesList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7fb3c57-5d1c-40a1-8203-f61ceaf9c9c9", "AQAAAAEAACcQAAAAEEgMlJ8NStzS/Q35/YT37aEmgxZLIkPl76M6+bcDE8pC6x/mLYzYK89k3ZPW3U4vBg==", "8a4728b1-5042-46fe-bf06-f12dbc3788f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "005d7c21-7394-47fa-9a64-baa743fc1fd1", "AQAAAAEAACcQAAAAEEBNk7r19P4WpNCrxHeFvTBYWMLoCH1mvv0PTMegsKMTU7eOVRw7qzkADtEMAoXj6g==", "2a2016da-b2fa-4aeb-bdc6-cbf4e828d868" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57cb6a02-d3cf-4f50-9efd-01c6888ebd09", "AQAAAAEAACcQAAAAEO+keFy34bVX1wdtyRhEaXwV5L1T/xe1AhLjmIJpenYx2GJQsfS5e1fvHfOepHpdQA==", "d5933a2c-3c1a-4925-8ac2-c40144794a50" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
