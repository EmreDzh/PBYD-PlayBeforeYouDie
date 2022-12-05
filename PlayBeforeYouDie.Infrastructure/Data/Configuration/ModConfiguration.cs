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
                ModImage = "https://cdn11.bigcommerce.com/s-2m627o4amu/products/722/images/4096/Playstation-4-PS4-Empty-Custom-Replacement-Case-Box__50578.1507926933.500.750.png?c=2",
                YoutubeVideoModComparison = "https://youtube.com/embed/WZK19L2JUGc"

            },
            new Mod()
            {
                Id = 2,
                ModName = "Photorealistic Visuals ReShade",
                Description = "Photorealistic ReShade I've been working on for some time, taking out what's best from the great old Grand Theft Auto IV...Adds Anti-Aliasing, Bloom, Color Changes, Sharpness, Shadows, Optional Borders, Depth of Field and SSR.",
                DownloadModLink = "https://www.nexusmods.com/gta4/mods/238",
                ModImage = "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669288616-1834557289.png",
                YoutubeVideoModComparison = "https://youtube.com/embed/btiYnR848RU"
            },
            new Mod()
            {
                Id = 3,
                ModName = "Super Mario Galaxy",
                Description = "Theres no mods available for Super Mario Galaxy, since its an old title and no longer supported and fit for mods",
                ModImage = "https://s3.amazonaws.com/colorslive/png/60685-OcB6fsTJVHR82033.png"
                
            },
            new Mod()
            {
                Id = 4,
                ModName = "Native American Horses",
                Description = "In an effort to add something small to the community that enrichens this game so much, here are some horses to honor National Native American Heritage Day. I wanted to see more horses influenced by Native Indian Culture. Not meant to be \"realistic\" or even \"immersive\", just respectful and what I like.\r\nHope some of you like it too. Enjoy.",
                DownloadModLink = "https://www.nexusmods.com/reddeadredemption2/mods/1811",
                ModImage = "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669436382-504851999.png",
                YoutubeVideoModComparison = "https://youtube.com/embed/PA-gd8DBR8o"

            },
            new Mod()
            {
                Id = 5,
                ModName = "The Witcher 3 HD Reworked Project",
                Description = "This Project aims to improve the graphics by reworking models and textures to better quality preserving the original style",
                DownloadModLink = "https://www.nexusmods.com/witcher3/mods/1021",
                ModImage =  "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600548166-1660518323.jpeg",
                YoutubeVideoModComparison = "https://youtube.com/embed/YNKlpvKvKl0"
            }

        };
        
        return mods;
    }
}