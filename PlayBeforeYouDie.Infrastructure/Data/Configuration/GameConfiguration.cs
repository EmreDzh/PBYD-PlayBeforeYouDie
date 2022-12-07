using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.Infrastructure.Data.Configuration;

internal class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.HasData(CreateGames());
    }

    private List<Game> CreateGames()
    {
        var games = new List<Game>()
        {
            new Game()
            {
                Id = 1,
                GameTitle = "The Legend of Zelda: Ocarina of Time",
                Summary =
                    "As a young boy, Link is tricked by Ganondorf, the King of the Gerudo Thieves. The evil human uses Link to gain access to the Sacred Realm, where he places his tainted hands on Triforce and transforms the beautiful Hyrulean landscape into a barren wasteland. Link is determined to fix the problems he helped to create, so with the help of Rauru he travels through time gathering the powers of the Seven Sages.",
                ImageUrl =
                    "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_3ds_25/SI_3DS_TheLegendofZeldaOcarinaofTime3D_image1600w.jpg",
                Rating = 99,
                GenreId = 3,
                SystemRequirementId = 1,
                
            },
            
            new Game()
            {
                Id = 3,
                GameTitle = "Grand Theft Auto IV",
                Summary =
                    "[Metacritic's 2008 PS3 Game of the Year; Also known as \"GTA IV\"] What does the American Dream mean today? For Niko Belic, fresh off the boat from Europe. It's the hope he can escape his past. For his cousin, Roman, it is the vision that together they can find fortune in Liberty City, gateway to the land of opportunity. As they slip into debt and are dragged into a criminal underworld by a series of shysters, thieves and sociopaths, they discover that the reality is very different from the dream in a city that worships money and status, and is heaven for those who have them an a living nightmare for those who don't. [Rockstar Games]",
                ImageUrl =
                    "https://img.redbull.com/images/c_limit,w_1500,h_1000,f_auto,q_auto/redbullcom/2018/03/13/0e032ffe-1b30-4ee4-876e-e31f6a894447/gta-iv",
                Rating = 98,
                GenreId = 2,
                SystemRequirementId = 2,
                
            },
            new Game()
            {
                Id = 4,
                GameTitle = "Super Mario Galaxy",
                Summary =
                    "[Metacritic's 2007 Wii Game of the Year] The ultimate Nintendo hero is taking the ultimate step ... out into space. Join Mario as he ushers in a new era of video games, defying gravity across all the planets in the galaxy. When some creature escapes into space with Princess Peach, Mario gives chase, exploring bizarre planets all across the galaxy. Mario, Peach and enemies new and old are here. Players run, jump and battle enemies as they explore all the planets in the galaxy. Since this game makes full use of all the features of the Wii Remote, players have to do all kinds of things to succeed: pressing buttons, swinging the Wii Remote and the Nunchuk, and even pointing at and dragging things with the pointer. Since he's in space, Mario can perform mind-bending jumps unlike anything he's done before. He'll also have a wealth of new moves that are all based around tilting, pointing and shaking the Wii Remote. Shake, tilt and point! Mario takes advantage of all the unique aspects of the Wii Remote and Nunchuk controller, unleashing new moves as players shake the controller and even point at and drag items with the pointer. [Nintendo]",
                ImageUrl =
                    "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/wii_24/SI_Wii_SuperMarioGalaxy_image1600w.jpg",
                Rating = 97,
                GenreId = 3,
                SystemRequirementId = 3,
                
            },
            new Game()
            {
                Id = 5,
                GameTitle = "Red Dead Redemption 2",
                Summary =
                    "Developed by the creators of Grand Theft Auto V and Red Dead Redemption, Red Dead Redemption 2 is an epic tale of life in America’s unforgiving heartland. The game’s vast and atmospheric world also provides the foundation for a brand new online multiplayer experience. America, 1899. The end of the Wild West era has begun. After a robbery goes badly wrong in the western town of Blackwater, Arthur Morgan and the Van der Linde gang are forced to flee. With federal agents and the best bounty hunters in the nation massing on their heels, the gang has to rob, steal and fight their way across the rugged heartland of America in order to survive. As deepening internal fissures threaten to tear the gang apart, Arthur must make a choice between his own ideals and loyalty to the gang that raised him. [Rockstar]",
                ImageUrl =
                    "https://assets1.ignimgs.com/2016/10/18/red-dead-redemption-2-buttonjpg-f9ad35.jpg",
                Rating = 97,
                GenreId = 2,
                SystemRequirementId = 4,
                
            },
            new Game()
            {
                Id = 6,
                GameTitle = "The Witcher 3: Wild Hund",
                Summary =
                    "With the Empire attacking the Kingdoms of the North and the Wild Hunt, a cavalcade of ghastly riders, breathing down your neck, the only way to survive is to fight back. As Geralt of Rivia, a master swordsman and monster hunter, leave none of your enemies standing. Explore a gigantic open world, slay beasts and decide the fates of whole communities with your actions, all in a genuine next generation format.",
                ImageUrl =
                    "https://static.giga.de/15/68/17/cbb82352a0e62e5ad8c613c207_AzE4Yzg1MDJhYzMw_thewitcher3.jpg",
                Rating = 93,
                GenreId = 2,
                SystemRequirementId = 5,
                
            }

        };

        return games;
    }
}