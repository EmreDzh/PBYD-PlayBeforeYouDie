﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayBeforeYouDie.Infrastructure.Data;

#nullable disable

namespace PlayBeforeYouDie.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221205175625_ModsYoutubeVideoModComparison")]
    partial class ModsYoutubeVideoModComparison
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PlayBeforeYouDie.Infrastructure.Data.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GameTitle")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("HowLongToBeatId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsGameActive")
                        .HasColumnType("bit");

                    b.Property<int>("ModId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SystemRequirementId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("HowLongToBeatId");

                    b.HasIndex("ModId");

                    b.HasIndex("SystemRequirementId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameTitle = "The Legend of Zelda: Ocarina of Time",
                            GenreId = 3,
                            HowLongToBeatId = 1,
                            ImageUrl = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_3ds_25/SI_3DS_TheLegendofZeldaOcarinaofTime3D_image1600w.jpg",
                            IsGameActive = true,
                            ModId = 1,
                            Rating = 99m,
                            Summary = "As a young boy, Link is tricked by Ganondorf, the King of the Gerudo Thieves. The evil human uses Link to gain access to the Sacred Realm, where he places his tainted hands on Triforce and transforms the beautiful Hyrulean landscape into a barren wasteland. Link is determined to fix the problems he helped to create, so with the help of Rauru he travels through time gathering the powers of the Seven Sages.",
                            SystemRequirementId = 1
                        },
                        new
                        {
                            Id = 3,
                            GameTitle = "Grand Theft Auto IV",
                            GenreId = 2,
                            HowLongToBeatId = 2,
                            ImageUrl = "https://img.redbull.com/images/c_limit,w_1500,h_1000,f_auto,q_auto/redbullcom/2018/03/13/0e032ffe-1b30-4ee4-876e-e31f6a894447/gta-iv",
                            IsGameActive = true,
                            ModId = 2,
                            Rating = 98m,
                            Summary = "[Metacritic's 2008 PS3 Game of the Year; Also known as \"GTA IV\"] What does the American Dream mean today? For Niko Belic, fresh off the boat from Europe. It's the hope he can escape his past. For his cousin, Roman, it is the vision that together they can find fortune in Liberty City, gateway to the land of opportunity. As they slip into debt and are dragged into a criminal underworld by a series of shysters, thieves and sociopaths, they discover that the reality is very different from the dream in a city that worships money and status, and is heaven for those who have them an a living nightmare for those who don't. [Rockstar Games]",
                            SystemRequirementId = 2
                        },
                        new
                        {
                            Id = 4,
                            GameTitle = "Super Mario Galaxy",
                            GenreId = 3,
                            HowLongToBeatId = 3,
                            ImageUrl = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/wii_24/SI_Wii_SuperMarioGalaxy_image1600w.jpg",
                            IsGameActive = true,
                            ModId = 3,
                            Rating = 97m,
                            Summary = "[Metacritic's 2007 Wii Game of the Year] The ultimate Nintendo hero is taking the ultimate step ... out into space. Join Mario as he ushers in a new era of video games, defying gravity across all the planets in the galaxy. When some creature escapes into space with Princess Peach, Mario gives chase, exploring bizarre planets all across the galaxy. Mario, Peach and enemies new and old are here. Players run, jump and battle enemies as they explore all the planets in the galaxy. Since this game makes full use of all the features of the Wii Remote, players have to do all kinds of things to succeed: pressing buttons, swinging the Wii Remote and the Nunchuk, and even pointing at and dragging things with the pointer. Since he's in space, Mario can perform mind-bending jumps unlike anything he's done before. He'll also have a wealth of new moves that are all based around tilting, pointing and shaking the Wii Remote. Shake, tilt and point! Mario takes advantage of all the unique aspects of the Wii Remote and Nunchuk controller, unleashing new moves as players shake the controller and even point at and drag items with the pointer. [Nintendo]",
                            SystemRequirementId = 3
                        },
                        new
                        {
                            Id = 5,
                            GameTitle = "Red Dead Redemption 2",
                            GenreId = 2,
                            HowLongToBeatId = 4,
                            ImageUrl = "https://s1.gaming-cdn.com/images/products/5679/orig-fallback-v1/red-dead-redemption-2-pc-spiel-rockstar-cover.jpg?v=1647026658",
                            IsGameActive = true,
                            ModId = 4,
                            Rating = 97m,
                            Summary = "Developed by the creators of Grand Theft Auto V and Red Dead Redemption, Red Dead Redemption 2 is an epic tale of life in America’s unforgiving heartland. The game’s vast and atmospheric world also provides the foundation for a brand new online multiplayer experience. America, 1899. The end of the Wild West era has begun. After a robbery goes badly wrong in the western town of Blackwater, Arthur Morgan and the Van der Linde gang are forced to flee. With federal agents and the best bounty hunters in the nation massing on their heels, the gang has to rob, steal and fight their way across the rugged heartland of America in order to survive. As deepening internal fissures threaten to tear the gang apart, Arthur must make a choice between his own ideals and loyalty to the gang that raised him. [Rockstar]",
                            SystemRequirementId = 4
                        },
                        new
                        {
                            Id = 6,
                            GameTitle = "The Witcher 3: Wild Hund",
                            GenreId = 2,
                            HowLongToBeatId = 5,
                            ImageUrl = "http://www.tomshw.it/data/images/5/9/4/1/03e512f6782d046f428fe2446f14187c6.jpg",
                            IsGameActive = true,
                            ModId = 5,
                            Rating = 93m,
                            Summary = "With the Empire attacking the Kingdoms of the North and the Wild Hunt, a cavalcade of ghastly riders, breathing down your neck, the only way to survive is to fight back. As Geralt of Rivia, a master swordsman and monster hunter, leave none of your enemies standing. Explore a gigantic open world, slay beasts and decide the fates of whole communities with your actions, all in a genuine next generation format.",
                            SystemRequirementId = 5
                        });
                });

            modelBuilder.Entity("PlayBeforeYouDie.Infrastructure.Data.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "MMOs"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Role-playing"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Adventure"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Shooter"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Sport games"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Fighting"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Racing"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Virtual Reality"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Strategy"
                        });
                });

            modelBuilder.Entity("PlayBeforeYouDie.Infrastructure.Data.Models.HowLongToBeat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("HundredPercentComplete")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("MainPlusSides")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("MainStory")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("SpeedRunAny")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("SpeedRunOneHundredPercent")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("HowLongToBeat");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HundredPercentComplete = "37h 48m",
                            MainPlusSides = "30h 36m",
                            MainStory = "26h 13m",
                            SpeedRunAny = "2h 57m 36s",
                            SpeedRunOneHundredPercent = "5h 30m 31s"
                        },
                        new
                        {
                            Id = 2,
                            HundredPercentComplete = "77h 11m",
                            MainPlusSides = "41h 27m",
                            MainStory = "27h 35m",
                            SpeedRunAny = "10h 40m 40s",
                            SpeedRunOneHundredPercent = "15h 54m 44s"
                        },
                        new
                        {
                            Id = 3,
                            HundredPercentComplete = "36h 53m",
                            MainPlusSides = "22h 14m",
                            MainStory = "13h 41m",
                            SpeedRunAny = "3h 52m 24s",
                            SpeedRunOneHundredPercent = "8h 33m 50s"
                        },
                        new
                        {
                            Id = 4,
                            HundredPercentComplete = "184h 12m",
                            MainPlusSides = "84h 27m",
                            MainStory = "49h 44m",
                            SpeedRunAny = "14h 4m 32s",
                            SpeedRunOneHundredPercent = "35h 13m 26s"
                        },
                        new
                        {
                            Id = 5,
                            HundredPercentComplete = "179h 56m",
                            MainPlusSides = "106h 16m",
                            MainStory = "52h 33m",
                            SpeedRunAny = "16h 48m 48s",
                            SpeedRunOneHundredPercent = "63h 20m"
                        });
                });

            modelBuilder.Entity("PlayBeforeYouDie.Infrastructure.Data.Models.Mod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DownloadModLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("YoutubeVideoModComparison")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Theres no mods available for The Legend of Zelda: Ocarina of Time, since its a Nintendo only title",
                            DownloadModLink = "N/A",
                            ModImage = "https://cdn11.bigcommerce.com/s-2m627o4amu/products/722/images/4096/Playstation-4-PS4-Empty-Custom-Replacement-Case-Box__50578.1507926933.500.750.png?c=2",
                            ModName = "The Legend of Zelda: Ocarina of Time"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Photorealistic ReShade I've been working on for some time, taking out what's best from the great old Grand Theft Auto IV...Adds Anti-Aliasing, Bloom, Color Changes, Sharpness, Shadows, Optional Borders, Depth of Field and SSR.",
                            DownloadModLink = "https://www.nexusmods.com/gta4/mods/238",
                            ModImage = "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669288616-1834557289.png",
                            ModName = "Photorealistic Visuals ReShade",
                            YoutubeVideoModComparison = "https://www.youtube.com/watch?v=btiYnR848RU"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Theres no mods available for Super Mario Galaxy, since its an old title and no longer supported and fit for mods",
                            DownloadModLink = "N/A",
                            ModImage = "https://s3.amazonaws.com/colorslive/png/60685-OcB6fsTJVHR82033.png",
                            ModName = "Super Mario Galaxy"
                        },
                        new
                        {
                            Id = 4,
                            Description = "In an effort to add something small to the community that enrichens this game so much, here are some horses to honor National Native American Heritage Day. I wanted to see more horses influenced by Native Indian Culture. Not meant to be \"realistic\" or even \"immersive\", just respectful and what I like.\r\nHope some of you like it too. Enjoy.",
                            DownloadModLink = "https://www.nexusmods.com/reddeadredemption2/mods/1811",
                            ModImage = "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669436382-504851999.png",
                            ModName = "Native American Horses"
                        },
                        new
                        {
                            Id = 5,
                            Description = "This Project aims to improve the graphics by reworking models and textures to better quality preserving the original style",
                            DownloadModLink = "https://www.nexusmods.com/witcher3/mods/1021",
                            ModImage = "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600548166-1660518323.jpeg",
                            ModName = "The Witcher 3 HD Reworked Project",
                            YoutubeVideoModComparison = "https://www.youtube.com/watch?v=YNKlpvKvKl0"
                        });
                });

            modelBuilder.Entity("PlayBeforeYouDie.Infrastructure.Data.Models.SystemRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdditionalNotes")
                        .HasMaxLength(100000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Graphics")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Memory")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Network")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Os")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Storage")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("SystemRequirements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdditionalNotes = "Can be played in PC with required porting or PC Ports",
                            Graphics = "(Nintendo 65) Graphics",
                            Memory = "(Nintendo 65) Memory",
                            Network = "N/A",
                            Os = "Nintendo 65",
                            Processor = "(Nintendo 65) Processor",
                            Storage = "32 MB"
                        },
                        new
                        {
                            Id = 2,
                            AdditionalNotes = "Initial activation requires internet connection; Online play requires log-in to Games For Windows - Live and Rockstar Games Social Club",
                            Graphics = "256MB Nvidia 7900 / 256MB ATI X1900",
                            Memory = " 1.5GB XP / 1.5GB Vista",
                            Network = "N/A",
                            Os = "Windows 7 (plus Service Pack 1) / PS3 / PS4",
                            Processor = "Intel Core 2 Duo 1.8GHz, AMD Athlon X2 64 2.4GHz",
                            Storage = "32GB of Hard Disc Space"
                        },
                        new
                        {
                            Id = 3,
                            Graphics = "GeForce 210 or Radeon X600 Series",
                            Memory = " 1 GB RAM",
                            Network = "N/A",
                            Os = "Windows 7 64-Bit / PS2/ PS3",
                            Processor = "Intel CPU: Pentium 4 1.8GHz",
                            Storage = "1 GB"
                        },
                        new
                        {
                            Id = 4,
                            Graphics = "Nvidia GeForce GTX 1060 6GB / AMD Radeon RX 480 4GB",
                            Memory = "12 GB RAM",
                            Network = "Broadband Internet connection",
                            Os = "Windows 10 - April 2018 Update (v1803) / PS3 / PS4",
                            Processor = "Intel® Core™ i7-4770K / AMD Ryzen 5 1500X",
                            Storage = "150 GB available space"
                        },
                        new
                        {
                            Id = 5,
                            Graphics = "Nvidia GPU GeForce GTX 660 / AMD GPU Radeon HD 7870",
                            Memory = " 6 GB RAM",
                            Network = "N/A",
                            Os = "64-bit Windows 7, 64-bit Windows 8 (8.1) or 64-bit Windows 10 / PS3 / PS4",
                            Processor = "Intel CPU Core i5-2500K 3.3GHz / AMD CPU Phenom II X4 940",
                            Storage = "35 GB available space"
                        });
                });

            modelBuilder.Entity("PlayBeforeYouDie.Infrastructure.Data.Models.Users.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dea12856-c198-4129-b3f3-b893d8395082",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "65ad7872-0232-43a7-9fa7-d9084d7c2531",
                            Email = "modder@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "modder@mail.com",
                            NormalizedUserName = "modder@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEF2GAoXteVert4KIbuODENyUAqxZ8gSX9/FTRJjkHejplko9xABfOl1M4XG+IufUEw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ced04326-5eaa-416e-94e5-9027f1543775",
                            TwoFactorEnabled = false,
                            UserName = "modder@mail.com"
                        },
                        new
                        {
                            Id = "b1b89182-68ed-489c-93be-a108b9cb5aad",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8eca5a64-9605-4dc3-82a0-4ab6b1400967",
                            Email = "Admin@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "Admin@mail.com",
                            NormalizedUserName = "Admin@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEKzCJu5avwNONxkyFlcovAB4ohL6I38auwRbeKLF8VH+/IizKezVJCUmbHINkFYVBw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7e7d2bad-46bf-4b94-9067-8e242428e258",
                            TwoFactorEnabled = false,
                            UserName = "Admin@mail.com"
                        },
                        new
                        {
                            Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "772a62f6-3ebc-4f2f-962e-9e72e486d355",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "guest@mail.com",
                            NormalizedUserName = "guest@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAECxEOc7rZ0n/BJRPG/+Jv8wMP15f/LG1SgprRv4MTPrfqy56JTXJTTw6ncs8WVQSFA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "840e8564-0a17-4a7d-a627-b540754af832",
                            TwoFactorEnabled = false,
                            UserName = "guest@mail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PlayBeforeYouDie.Infrastructure.Data.Models.Users.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PlayBeforeYouDie.Infrastructure.Data.Models.Users.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlayBeforeYouDie.Infrastructure.Data.Models.Users.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PlayBeforeYouDie.Infrastructure.Data.Models.Users.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlayBeforeYouDie.Infrastructure.Data.Models.Game", b =>
                {
                    b.HasOne("PlayBeforeYouDie.Infrastructure.Data.Models.Genre", "Genre")
                        .WithMany("Games")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlayBeforeYouDie.Infrastructure.Data.Models.HowLongToBeat", "HowLongToBeat")
                        .WithMany("Games")
                        .HasForeignKey("HowLongToBeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlayBeforeYouDie.Infrastructure.Data.Models.Mod", "Mod")
                        .WithMany("Games")
                        .HasForeignKey("ModId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlayBeforeYouDie.Infrastructure.Data.Models.SystemRequirement", "SystemRequirement")
                        .WithMany("Games")
                        .HasForeignKey("SystemRequirementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("HowLongToBeat");

                    b.Navigation("Mod");

                    b.Navigation("SystemRequirement");
                });

            modelBuilder.Entity("PlayBeforeYouDie.Infrastructure.Data.Models.Genre", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("PlayBeforeYouDie.Infrastructure.Data.Models.HowLongToBeat", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("PlayBeforeYouDie.Infrastructure.Data.Models.Mod", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("PlayBeforeYouDie.Infrastructure.Data.Models.SystemRequirement", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}
