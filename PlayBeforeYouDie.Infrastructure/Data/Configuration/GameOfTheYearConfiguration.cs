using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.Infrastructure.Data.Configuration;

public class GameOfTheYearConfiguration : IEntityTypeConfiguration<GameOfTheYear>
{
    public void Configure(EntityTypeBuilder<GameOfTheYear> builder)
    {
        builder.HasData(CreateGameOfTheYear());
    }

    private List<GameOfTheYear> CreateGameOfTheYear()
    {
        var gameOfTheYear = new List<GameOfTheYear>()
        {
            new GameOfTheYear()
            {
                Id = 1,
                Year = 2014,
                GameTitle = "Dragon Age: Inquisition",
                Developers = "BioWare",
                ImageUrl =
                    "https://image.api.playstation.com/cdn/EP0006/CUSA00503_00/3uJniniN80XZw4jZ7fuXxK3ogaSK3rru.png"
            },
            new GameOfTheYear()
            {
                Id = 2,
                Year = 2015,
                GameTitle = "The Witcher 3 Wild Hunt",
                Developers = "CD Project Red",
                ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png"
            },
            new GameOfTheYear()
            {
                Id = 3,
                Year = 2016,
                GameTitle = "Overwatch",
                Developers = "Blizzard Entertainment",
                ImageUrl = "https://m.media-amazon.com/images/I/91lid74MqmL.jpg"
            },
            new GameOfTheYear()
            {
                Id = 4,
                Year = 2017,
                GameTitle = "The Legend of Zelda: Breath of the Wild ",
                Developers = "Nintendo",
                ImageUrl = "https://www.zelda.com/breath-of-the-wild/assets/icons/BOTW-Share_icon.jpg"
            },
            new GameOfTheYear()
            {
                Id = 5,
                Year = 2018,
                GameTitle = "God of War",
                Developers = "Santa Monica Studio",
                ImageUrl =
                    "https://s3.gaming-cdn.com/images/products/7325/screenshot/god-of-war-pc-spiel-steam-wallpaper-1.jpg?v=1668157899"
            },
            new GameOfTheYear()
            {
                Id = 6,
                Year = 2019,
                GameTitle = "Sekiro: Shadows Die Twice",
                Developers = "FormSoftware",
                ImageUrl = "https://www.pcgames.de/screenshots/original/2019/03/Sekiro-Review-PS4-1-pc-games1.jpg"
            },
            new GameOfTheYear()
            {
                Id = 7,
                Year = 2020,
                GameTitle = "The Last of Us Part II",
                Developers = "Naughty Dog",
                ImageUrl =
                    "https://www.pcgames.de/screenshots/original/2020/06/The-Last-of-Us-Part-II-Review-Artwork-buffed1.png"
            },
            new GameOfTheYear()
            {
                Id = 8,
                Year = 2021,
                GameTitle = "It Takes Two",
                Developers = "Hazelight Studios",
                ImageUrl = "https://www.play3.de/wp-content/uploads/2021/03/It-Takes-Two.jpg"
            },
            new GameOfTheYear()
            {
                Id = 9,
                Year = 2022,
                GameTitle = "Elden Ring",
                Developers = "FromSoftware",
                ImageUrl = "https://www.videogameschronicle.com/files/2022/02/sds5.jpg"
            }

        };

        return gameOfTheYear;
    }
}