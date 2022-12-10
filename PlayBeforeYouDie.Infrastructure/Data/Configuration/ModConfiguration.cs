using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.Infrastructure.Data.Configuration;

public class ModConfiguration : IEntityTypeConfiguration<Mod>
{
    public void Configure(EntityTypeBuilder<Mod> builder)
    {
        builder.HasData(CreateMods());
    }

    private List<Mod> CreateMods()
    {
        var mods = new List<Mod>()
        {
            new Mod()
            {
                Id = 1,
                ModName = "The Legend of Zelda: Ocarina of Time",
                Description = "Theres no mods available for The Legend of Zelda: Ocarina of Time, since its a Nintendo only title",
                ModPictureId = 1,
                YoutubeVideoModComparison = "https://youtube.com/embed/WZK19L2JUGc",
                GameId = 1

            },
            new Mod()
            {
                Id = 2,
                ModName = "Photorealistic Visuals ReShade",
                Description = "Photorealistic ReShade I've been working on for some time, taking out what's best from the great old Grand Theft Auto IV...Adds Anti-Aliasing, Bloom, Color Changes, Sharpness, Shadows, Optional Borders, Depth of Field and SSR.",
                DownloadModLink = "https://www.nexusmods.com/gta4/mods/238",
                ModPictureId = 2,
                YoutubeVideoModComparison = "https://youtube.com/embed/btiYnR848RU",
                GameId = 2
            },
            new Mod()
            {
                Id = 3,
                ModName = "Super Mario Galaxy",
                Description = "Theres no mods available for Super Mario Galaxy, since its an old title and no longer supported and fit for mods",
                ModPictureId = 3,
                GameId = 3
                
            },
            new Mod()
            {
                Id = 4,
                ModName = "Native American Horses",
                Description = "In an effort to add something small to the community that enrichens this game so much, here are some horses to honor National Native American Heritage Day. I wanted to see more horses influenced by Native Indian Culture. Not meant to be \"realistic\" or even \"immersive\", just respectful and what I like.\r\nHope some of you like it too. Enjoy.",
                DownloadModLink = "https://www.nexusmods.com/reddeadredemption2/mods/1811",
                ModPictureId = 4,
                YoutubeVideoModComparison = "https://youtube.com/embed/PA-gd8DBR8o",
                GameId = 4

            },
            new Mod()
            {
                Id = 5,
                ModName = "The Witcher 3 HD Reworked Project",
                Description = "This Project aims to improve the graphics by reworking models and textures to better quality preserving the original style",
                DownloadModLink = "https://www.nexusmods.com/witcher3/mods/1021",
                ModPictureId = 5,
                YoutubeVideoModComparison = "https://youtube.com/embed/YNKlpvKvKl0",
                GameId = 5
            },
            new Mod()
            {
                Id = 8,
                ModName = "Sword of Night and Flame - Unbound",
                Description = "An overhaul of the legendary Sword of Night and Flame to be cooler, stronger, and maybe just a little OP. Download to get an all new moveset and Ash of War!",
                DownloadModLink = "https://www.nexusmods.com/eldenring/mods/2618",
                YoutubeVideoModComparison = "https://youtube/embed/Gkd5h9VYGXE",
                ModPictureId = 8,
                GameId = 6
            }

        };
        
        return mods;
    }
}