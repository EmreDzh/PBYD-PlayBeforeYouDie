using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayBeforeYouDie.Infrastructure.Data.Models;
using static System.Net.WebRequestMethods;

namespace PlayBeforeYouDie.Infrastructure.Data.Configuration;

public class ModPictureConfiguration : IEntityTypeConfiguration<ModPicture>
{
    public void Configure(EntityTypeBuilder<ModPicture> builder)
    {
        builder.HasData(CreateModPicture());
    }

    private List<ModPicture> CreateModPicture()
    {
        var modPicture = new List<ModPicture>()
        {
            new ModPicture()
            {
                Id = 1,
                ModImageOne =
                    "https://cdn11.bigcommerce.com/s-2m627o4amu/products/722/images/4096/Playstation-4-PS4-Empty-Custom-Replacement-Case-Box__50578.1507926933.500.750.png?c=2",

            },
            new ModPicture()
            {
                Id = 2,
                ModImageOne = "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669288616-1834557289.png",
                ModImageTwo = "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669668228-1945410031.png",
                ModImageThree =
                    "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669740973-1427404846.png",
                ModImageFour = "https://staticdelivery.nexusmods.com/mods/253/images/238/238-1669740976-2124795078.png"
            },
            new ModPicture()
            {
                Id = 3,
                ModImageOne = "https://s3.amazonaws.com/colorslive/png/60685-OcB6fsTJVHR82033.png"
            },
            new ModPicture()
            {
                Id = 4,
                ModImageOne =
                    "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669436382-504851999.png",
                ModImageTwo =
                    "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669436162-343965417.png",
                ModImageThree =
                    "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669435747-1676982520.png",
                ModImageFour =
                    "https://staticdelivery.nexusmods.com/mods/3024/images/1811/1811-1669435927-1894312792.png"
            },
            new ModPicture()
            {
                Id = 5,
                ModImageOne =
                    "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600548166-1660518323.jpeg",
                ModImageTwo =
                    "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600594032-1731970147.jpeg",
                ModImageThree =
                    "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600594030-2005225404.jpeg",
                ModImageFour =
                    "https://staticdelivery.nexusmods.com/mods/952/images/1021/1021-1600612171-1839423964.jpeg"
            },
            new ModPicture()
            {
                Id = 8,
                ModImageOne = "https://staticdelivery.nexusmods.com/mods/4333/images/2618/2618-1670061311-1458428997.jpeg",
                ModImageTwo = "https://staticdelivery.nexusmods.com/mods/4333/images/2618/2618-1670061316-1509434001.jpeg",
                ModImageThree = "https://staticdelivery.nexusmods.com/mods/4333/images/2618/2618-1670061321-366436897.jpeg",
                ModImageFour = "https://staticdelivery.nexusmods.com/mods/4333/images/2618/2618-1670061310-466516695.jpeg"
            }

        };

        return modPicture;
    }
}