using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class CreatedANewGameThroughConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ModPictures",
                columns: new[] { "Id", "ModImageFour", "ModImageOne", "ModImageThree", "ModImageTwo" },
                values: new object[] { 8, "https://staticdelivery.nexusmods.com/mods/4333/images/2618/2618-1670061310-466516695.jpeg", "https://staticdelivery.nexusmods.com/mods/4333/images/2618/2618-1670061311-1458428997.jpeg", "https://staticdelivery.nexusmods.com/mods/4333/images/2618/2618-1670061321-366436897.jpeg", "https://staticdelivery.nexusmods.com/mods/4333/images/2618/2618-1670061316-1509434001.jpeg" });

            migrationBuilder.InsertData(
                table: "SystemRequirements",
                columns: new[] { "Id", "AdditionalNotes", "Graphics", "Memory", "Network", "Os", "Processor", "Storage" },
                values: new object[] { 10, null, "NVIDIA GEFORCE GTX 1060 3 GB or AMD RADEON RX 580 4 GB.", "12 GB RAM", "N/A", "Windows 10", "INTEL CORE I5-8400 or AMD RYZEN 3 3300X", "60 GB" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GameTitle", "GenreId", "ImageUrl", "IsGameActive", "Rating", "Summary", "SystemRequirementId" },
                values: new object[] { 6, "Elden Ring", 3, "https://xboxplay.games/uploadStream/28009.jpg", true, 96m, "Elden Ring is an action role-playing game played in a third person perspective, with gameplay focusing on combat and exploration. It features elements similar to those found in other games developed by FromSoftware, such as the Dark Souls series, Bloodborne, and Sekiro: Shadows Die Twice.", 10 });

            migrationBuilder.InsertData(
                table: "HowLongToBeat",
                columns: new[] { "Id", "GameId", "HundredPercentComplete", "MainPlusSides", "MainStory", "SpeedRunAny", "SpeedRunOneHundredPercent" },
                values: new object[] { 9, 6, "136h 37m", "102h 28m", "53h 46m", "4h 23m 18s", "8h 30m 5s" });

            migrationBuilder.InsertData(
                table: "Mods",
                columns: new[] { "Id", "Description", "DownloadModLink", "GameId", "ModName", "ModPictureId", "YoutubeVideoModComparison" },
                values: new object[] { 8, "An overhaul of the legendary Sword of Night and Flame to be cooler, stronger, and maybe just a little OP. Download to get an all new moveset and Ash of War!", "https://www.nexusmods.com/eldenring/mods/2618", 6, "Sword of Night and Flame - Unbound", 8, "https://youtube/embed/Gkd5h9VYGXE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HowLongToBeat",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ModPictures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SystemRequirements",
                keyColumn: "Id",
                keyValue: 10);

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
    }
}
