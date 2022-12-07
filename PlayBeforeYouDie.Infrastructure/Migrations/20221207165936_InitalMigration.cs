﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModPictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModImageOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModImageTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModImageThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModImageFour = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModPictures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Os = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Memory = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Graphics = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Network = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Storage = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AdditionalNotes = table.Column<string>(type: "nvarchar(max)", maxLength: 100000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemRequirements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 100000, nullable: false),
                    DownloadModLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeVideoModComparison = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModPictureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mods_ModPictures_ModPictureId",
                        column: x => x.ModPictureId,
                        principalTable: "ModPictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameTitle = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    SystemRequirementId = table.Column<int>(type: "int", nullable: false),
                    ModId = table.Column<int>(type: "int", nullable: false),
                    IsGameActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Mods_ModId",
                        column: x => x.ModId,
                        principalTable: "Mods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_SystemRequirements_SystemRequirementId",
                        column: x => x.SystemRequirementId,
                        principalTable: "SystemRequirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserGame",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserGame", x => new { x.ApplicationUserId, x.GameId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserGame_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserGame_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HowLongToBeat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainStory = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    MainPlusSides = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    HundredPercentComplete = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    SpeedRunAny = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    SpeedRunOneHundredPercent = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HowLongToBeat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HowLongToBeat_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "70853159-28ef-4091-afb3-74cba5727ab7", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEJbBm+l6RyyJ7XKBvd0ssXMMsqkskfg1AfMJk1zeU++Xpy3hH0NQtj9sWQeQwGLQWQ==", null, false, "03084221-5d97-4235-871b-b6aea5ac1816", false, "guest@mail.com" },
                    { "b1b89182-68ed-489c-93be-a108b9cb5aad", 0, "81694569-5b66-40be-8a89-1cf48f711cb0", "Admin@mail.com", false, false, null, "Admin@mail.com", "Admin@mail.com", "AQAAAAEAACcQAAAAEOFEktcIMkp50dsxNmKsG0xNRKzgp+ZuiC7EavGreY7lWPvhXbVnfK7k2KEg/LCnFg==", null, false, "ccb8704c-a017-460a-a652-18d23161cc39", false, "Admin@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "c23cdca5-5b88-450c-acc1-3e98fe76c6f1", "modder@mail.com", false, false, null, "modder@mail.com", "modder@mail.com", "AQAAAAEAACcQAAAAEMIV6n4eRAp/vftLJh1W7y3ve5w8EsMba2yaRby0ZwrVwsG3WV+IS0EyksyqayOaiw==", null, false, "969f8786-1d5b-4762-91dd-a291690f328d", false, "modder@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Category" },
                values: new object[,]
                {
                    { 1, "MMOs" },
                    { 2, "Role-playing" },
                    { 3, "Adventure" },
                    { 4, "Shooter" },
                    { 5, "Sport games" },
                    { 6, "Fighting" },
                    { 7, "Racing" },
                    { 8, "Virtual Reality" },
                    { 9, "Strategy" }
                });

            migrationBuilder.InsertData(
                table: "ModPictures",
                columns: new[] { "Id", "ModImageFour", "ModImageOne", "ModImageThree", "ModImageTwo" },
                values: new object[,]
                {
                    { 1, null, "https://cdn11.bigcommerce.com/s-2m627o4amu/products/722/images/4096/Playstation-4-PS4-Empty-Custom-Replacement-Case-Box__50578.1507926933.500.750.png?c=2", null, null },
                    { 2, "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669740976-2124795078.png", "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669288616-1834557289.png", "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669740973-1427404846.png", "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669668228-1945410031.png" },
                    { 3, null, "https://s3.amazonaws.com/colorslive/png/60685-OcB6fsTJVHR82033.png", null, null },
                    { 4, "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669435927-1894312792.png", "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669436382-504851999.png", "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669435747-1676982520.png", "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669436162-343965417.png" },
                    { 5, "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600612171-1839423964.jpeg", "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600548166-1660518323.jpeg", "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600594030-2005225404.jpeg", "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600594032-1731970147.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "SystemRequirements",
                columns: new[] { "Id", "AdditionalNotes", "Graphics", "Memory", "Network", "Os", "Processor", "Storage" },
                values: new object[,]
                {
                    { 1, "Can be played in PC with required porting or PC Ports", "(Nintendo 65) Graphics", "(Nintendo 65) Memory", "N/A", "Nintendo 65", "(Nintendo 65) Processor", "32 MB" },
                    { 2, "Initial activation requires internet connection; Online play requires log-in to Games For Windows - Live and Rockstar Games Social Club", "256MB Nvidia 7900 / 256MB ATI X1900", " 1.5GB XP / 1.5GB Vista", "N/A", "Windows 7 (plus Service Pack 1) / PS3 / PS4", "Intel Core 2 Duo 1.8GHz, AMD Athlon X2 64 2.4GHz", "32GB of Hard Disc Space" },
                    { 3, null, "GeForce 210 or Radeon X600 Series", " 1 GB RAM", "N/A", "Windows 7 64-Bit / PS2/ PS3", "Intel CPU: Pentium 4 1.8GHz", "1 GB" },
                    { 4, null, "Nvidia GeForce GTX 1060 6GB / AMD Radeon RX 480 4GB", "12 GB RAM", "Broadband Internet connection", "Windows 10 - April 2018 Update (v1803) / PS3 / PS4", "Intel® Core™ i7-4770K / AMD Ryzen 5 1500X", "150 GB available space" },
                    { 5, null, "Nvidia GPU GeForce GTX 660 / AMD GPU Radeon HD 7870", " 6 GB RAM", "N/A", "64-bit Windows 7, 64-bit Windows 8 (8.1) or 64-bit Windows 10 / PS3 / PS4", "Intel CPU Core i5-2500K 3.3GHz / AMD CPU Phenom II X4 940", "35 GB available space" }
                });

            migrationBuilder.InsertData(
                table: "Mods",
                columns: new[] { "Id", "Description", "DownloadModLink", "ModName", "ModPictureId", "YoutubeVideoModComparison" },
                values: new object[,]
                {
                    { 1, "Theres no mods available for The Legend of Zelda: Ocarina of Time, since its a Nintendo only title", null, "The Legend of Zelda: Ocarina of Time", 1, "https://youtube.com/embed/WZK19L2JUGc" },
                    { 2, "Photorealistic ReShade I've been working on for some time, taking out what's best from the great old Grand Theft Auto IV...Adds Anti-Aliasing, Bloom, Color Changes, Sharpness, Shadows, Optional Borders, Depth of Field and SSR.", "https://www.nexusmods.com/gta4/mods/238", "Photorealistic Visuals ReShade", 2, "https://youtube.com/embed/btiYnR848RU" },
                    { 3, "Theres no mods available for Super Mario Galaxy, since its an old title and no longer supported and fit for mods", null, "Super Mario Galaxy", 3, null },
                    { 4, "In an effort to add something small to the community that enrichens this game so much, here are some horses to honor National Native American Heritage Day. I wanted to see more horses influenced by Native Indian Culture. Not meant to be \"realistic\" or even \"immersive\", just respectful and what I like.\r\nHope some of you like it too. Enjoy.", "https://www.nexusmods.com/reddeadredemption2/mods/1811", "Native American Horses", 4, "https://youtube.com/embed/PA-gd8DBR8o" },
                    { 5, "This Project aims to improve the graphics by reworking models and textures to better quality preserving the original style", "https://www.nexusmods.com/witcher3/mods/1021", "The Witcher 3 HD Reworked Project", 5, "https://youtube.com/embed/YNKlpvKvKl0" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GameTitle", "GenreId", "ImageUrl", "IsGameActive", "ModId", "Rating", "Summary", "SystemRequirementId" },
                values: new object[,]
                {
                    { 1, "The Legend of Zelda: Ocarina of Time", 3, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_3ds_25/SI_3DS_TheLegendofZeldaOcarinaofTime3D_image1600w.jpg", true, 1, 99m, "As a young boy, Link is tricked by Ganondorf, the King of the Gerudo Thieves. The evil human uses Link to gain access to the Sacred Realm, where he places his tainted hands on Triforce and transforms the beautiful Hyrulean landscape into a barren wasteland. Link is determined to fix the problems he helped to create, so with the help of Rauru he travels through time gathering the powers of the Seven Sages.", 1 },
                    { 3, "Grand Theft Auto IV", 2, "https://img.redbull.com/images/c_limit,w_1500,h_1000,f_auto,q_auto/redbullcom/2018/03/13/0e032ffe-1b30-4ee4-876e-e31f6a894447/gta-iv", true, 2, 98m, "[Metacritic's 2008 PS3 Game of the Year; Also known as \"GTA IV\"] What does the American Dream mean today? For Niko Belic, fresh off the boat from Europe. It's the hope he can escape his past. For his cousin, Roman, it is the vision that together they can find fortune in Liberty City, gateway to the land of opportunity. As they slip into debt and are dragged into a criminal underworld by a series of shysters, thieves and sociopaths, they discover that the reality is very different from the dream in a city that worships money and status, and is heaven for those who have them an a living nightmare for those who don't. [Rockstar Games]", 2 },
                    { 4, "Super Mario Galaxy", 3, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/wii_24/SI_Wii_SuperMarioGalaxy_image1600w.jpg", true, 3, 97m, "[Metacritic's 2007 Wii Game of the Year] The ultimate Nintendo hero is taking the ultimate step ... out into space. Join Mario as he ushers in a new era of video games, defying gravity across all the planets in the galaxy. When some creature escapes into space with Princess Peach, Mario gives chase, exploring bizarre planets all across the galaxy. Mario, Peach and enemies new and old are here. Players run, jump and battle enemies as they explore all the planets in the galaxy. Since this game makes full use of all the features of the Wii Remote, players have to do all kinds of things to succeed: pressing buttons, swinging the Wii Remote and the Nunchuk, and even pointing at and dragging things with the pointer. Since he's in space, Mario can perform mind-bending jumps unlike anything he's done before. He'll also have a wealth of new moves that are all based around tilting, pointing and shaking the Wii Remote. Shake, tilt and point! Mario takes advantage of all the unique aspects of the Wii Remote and Nunchuk controller, unleashing new moves as players shake the controller and even point at and drag items with the pointer. [Nintendo]", 3 },
                    { 5, "Red Dead Redemption 2", 2, "https://assets1.ignimgs.com/2016/10/18/red-dead-redemption-2-buttonjpg-f9ad35.jpg", true, 4, 97m, "Developed by the creators of Grand Theft Auto V and Red Dead Redemption, Red Dead Redemption 2 is an epic tale of life in America’s unforgiving heartland. The game’s vast and atmospheric world also provides the foundation for a brand new online multiplayer experience. America, 1899. The end of the Wild West era has begun. After a robbery goes badly wrong in the western town of Blackwater, Arthur Morgan and the Van der Linde gang are forced to flee. With federal agents and the best bounty hunters in the nation massing on their heels, the gang has to rob, steal and fight their way across the rugged heartland of America in order to survive. As deepening internal fissures threaten to tear the gang apart, Arthur must make a choice between his own ideals and loyalty to the gang that raised him. [Rockstar]", 4 },
                    { 6, "The Witcher 3: Wild Hund", 2, "https://static.giga.de/15/68/17/cbb82352a0e62e5ad8c613c207_AzE4Yzg1MDJhYzMw_thewitcher3.jpg", true, 5, 93m, "With the Empire attacking the Kingdoms of the North and the Wild Hunt, a cavalcade of ghastly riders, breathing down your neck, the only way to survive is to fight back. As Geralt of Rivia, a master swordsman and monster hunter, leave none of your enemies standing. Explore a gigantic open world, slay beasts and decide the fates of whole communities with your actions, all in a genuine next generation format.", 5 }
                });

            migrationBuilder.InsertData(
                table: "HowLongToBeat",
                columns: new[] { "Id", "GameId", "HundredPercentComplete", "MainPlusSides", "MainStory", "SpeedRunAny", "SpeedRunOneHundredPercent" },
                values: new object[,]
                {
                    { 1, 1, "37h 48m", "30h 36m", "26h 13m", "2h 57m 36s", "5h 30m 31s" },
                    { 2, 3, "77h 11m", "41h 27m", "27h 35m", "10h 40m 40s", "15h 54m 44s" },
                    { 3, 4, "36h 53m", "22h 14m", "13h 41m", "3h 52m 24s", "8h 33m 50s" },
                    { 4, 5, "184h 12m", "84h 27m", "49h 44m", "14h 4m 32s", "35h 13m 26s" },
                    { 5, 6, "179h 56m", "106h 16m", "52h 33m", "16h 48m 48s", "63h 20m" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserGame_GameId",
                table: "ApplicationUserGame",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GenreId",
                table: "Games",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_ModId",
                table: "Games",
                column: "ModId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_SystemRequirementId",
                table: "Games",
                column: "SystemRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_HowLongToBeat_GameId",
                table: "HowLongToBeat",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Mods_ModPictureId",
                table: "Mods",
                column: "ModPictureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserGame");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "HowLongToBeat");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Mods");

            migrationBuilder.DropTable(
                name: "SystemRequirements");

            migrationBuilder.DropTable(
                name: "ModPictures");
        }
    }
}
