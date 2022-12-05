using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4216f137-bda6-45f3-8cc2-c88a60050496", "AQAAAAEAACcQAAAAEAk6CnS9USEw2iyBy0MAaPZ+jDh8q8RdiGu2BdTFH/d/LeQPHjkpzmuDQazWnaKBWQ==", "9ebe91c1-2ddc-4684-bf30-a694434c9b95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b89182-68ed-489c-93be-a108b9cb5aad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12a59121-6662-4018-81b4-6f636075a240", "AQAAAAEAACcQAAAAEDLyTN/9wtQkn9oI5p6U9Lc43NMZ0rGvDBaM8GW13kDv4CaCjw9NOIVKqXuSLI/5zA==", "eb431007-7c0a-48c2-82bf-ce6624be24b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "669cec50-c2f7-4e94-a1ff-b28d7fa23840", "AQAAAAEAACcQAAAAECAPUpIPL9aIELPVXhvmq+BxO9G4SQ10ERBCyvUED12VGt7lRzxpBgUJ4ZmqDcVfcA==", "99f96132-b71e-487a-8bdf-9c779b391de9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
