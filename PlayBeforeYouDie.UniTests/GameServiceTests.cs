using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Game;
using PlayBeforeYouDie.Core.Service;
using PlayBeforeYouDie.Infrastructure.Data;
using PlayBeforeYouDie.Infrastructure.Data.Common;
using PlayBeforeYouDie.Infrastructure.Data.Models;
using PlayBeforeYouDie.Infrastructure.Data.Models.Users;

namespace PlayBeforeYouDie.UniTests;

[TestFixture]
public class GameServiceTests
{
    private IRepository repo;
    private ApplicationDbContext context;
    private IGameService gameService;

    [SetUp]
    public void Setup()
    {
        var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase("GameDB")
            .Options;

        context = new ApplicationDbContext(contextOptions);

        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
    }

    [Test]
    public async Task GetInitialGames()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        await repo.AddAsync(new Game()
        {
            Id = 0,
            GameTitle = "Witcher 3",
            ImageUrl = "",
            Summary = "",
            IsGameActive = true
        });

        await repo.SaveChangesAsync();
        var initialGames = await gameService.GetInitialGames();

        Assert.That(initialGames.Any(g => g.GameTitle == "Witcher 3"), Is.True);

    }

    
    [Test]
    public async Task GetAllGames()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        await repo.AddRangeAsync(new List<Game>()
        {
            new Game() { GameTitle = "", Summary = "", Id = 1, ImageUrl = "", Rating = 0 },
            new Game() { GameTitle = "", Summary = "", Id = 2, ImageUrl = "", Rating = 0 },
            new Game() { GameTitle = "", Summary = "", Id = 3, ImageUrl = "", Rating = 0 },
            new Game() { GameTitle = "", Summary = "", Id = 4, ImageUrl = "", Rating = 0 },
            new Game() { GameTitle = "", Summary = "", Id = 5, ImageUrl = "", Rating = 0 },
            new Game() { GameTitle = "", Summary = "", Id = 6, ImageUrl = "", Rating = 0 },
            new Game() { GameTitle = "", Summary = "", Id = 7, ImageUrl = "", Rating = 0 },

        });
        
        await repo.SaveChangesAsync();
        var allGames = await gameService.GetAll();

        Assert.That(6, Is.EqualTo(allGames.Count()));
        Assert.That(allGames.Any(g => g.Id == 7), Is.True);


    }

    [Test]
    public async Task AllGerneNames()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        await repo.AddAsync(new Genre()
        {
            Id = 1,
            Category = "MMO"
        });

        await repo.SaveChangesAsync();
        var allGernes = await gameService.AllGenreNames();

        Assert.That(allGernes.Any(g => g.Contains("MMO")));
        Assert.That(allGernes, Is.Not.Null);

    }

    [Test]
    public async Task AllGenres()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        await repo.AddRangeAsync(new List<Genre>()
        {
            new Genre() { Id = 1, Category = "" },
            new Genre() { Id = 2, Category = "" },
            new Genre() { Id = 3, Category = "" },
        });

        await repo.SaveChangesAsync();
        var allGenres = await gameService.AllGenres();

        Assert.That(3, Is.EqualTo(allGenres.Count()));
        Assert.That(allGenres.Any(g => g.Id == 2), Is.True);
    }

    [Test]
    public async Task Exists()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        await repo.AddAsync(new Game()
        {
            Id = 1,
            GameTitle = "Witcher 3",
            ImageUrl = "",
            Summary = "",
            IsGameActive = true
        });

        await repo.SaveChangesAsync();
        var exists = await gameService.Exists(1);

        Assert.That(exists, Is.True);
    }

    [Test]
    public async Task GerneExists()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        await repo.AddAsync(new Genre()
        {
            Id = 1,
            Category = ""
        });

        await repo.SaveChangesAsync();
        var exists = await gameService.GenreExists(1);

        Assert.That(exists, Is.True);

    }

    [Test]
    public async Task GetGameGerneById()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        await repo.AddAsync(new Game()
        {
            Id = 1,
            GameTitle = "",
            ImageUrl = "",
            Summary = "",
            IsGameActive = true,
            GenreId = 2
        });

        await repo.SaveChangesAsync();

        var getGameGerne = await gameService.GetGameGenreById(1);

        Assert.That(getGameGerne, Is.EqualTo(2));

    }

    [Test]
    public async Task AddGameToMyLibrary()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        var hasher = new PasswordHasher<ApplicationUser>();
        var users = new List<ApplicationUser>();

        var user = new ApplicationUser()
        {
            Id = "dea12856-c198-4129-b3f3-b893d8395082",
            UserName = "user@mail.com",
            NormalizedUserName = "user@mail.com",
            Email = "user@mail.com",
            NormalizedEmail = "user@mail.com"
        };

        user.PasswordHash =
            hasher.HashPassword(user, "user123");

        users.Add(user);

        await repo.SaveChangesAsync();

        await repo.AddAsync(new Game()
        {
            Id = 1,
            GameTitle = "",
            ImageUrl = "",
            Summary = "",
            IsGameActive = true,
            
        });

        await repo.SaveChangesAsync();
        var addGameToLibary = gameService.AddGameToMyLibrary(1, "dea12856-c198-4129-b3f3-b893d8395082").ToString();

        Assert.That(addGameToLibary, Is.Not.Empty);
    }

    [Test]
    public async Task AddGame()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);
        
        await gameService.AddGame(new AddGameModel()
        {
            Id = 1,
            GameTitle = "Witcher 3",
            ImageUrl = "",
            Rating = 65,
            Summary = "",
            GenreId = 1,

            Os = "",
            Graphics = "RTX 3080",
            Memory = "",
            AdditionalNotes = "",
            Network = "",
            Processor = "",
            Storage = "",

            MainStory = "",
            HundredPercentComplete = "",
            MainPlusSides = "",
            SpeedRunAny = "",
            SpeedRunOneHundredPercent = "",

            Description = "",
            DownloadModLink = "",
            ModName = "",

            ModImageOne = ""


        });
        
        var game = await repo.GetByIdAsync<Game>(1);

        Assert.That(game.GameTitle, Is.EqualTo("Witcher 3"));
        Assert.That(game.SystemRequirement.Graphics, Is.EqualTo("RTX 3080"));
        
    }

    [Test]
    public async Task EditGame()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        await repo.AddAsync(new Game()
        {
            Id = 1,
            GameTitle = "",
            ImageUrl = "",
            Summary = "",
            IsGameActive = true,
        });

        await repo.SaveChangesAsync();

        await gameService.EditGame(new GameModel()
        {
            Id = 1,
            GameTitle = "Witcher has been edited!",
            ImageUrl = "",
            Summary = ""
        }, 1);

        var game = await repo.GetByIdAsync<Game>(1);

        Assert.That(game.GameTitle, Is.EqualTo("Witcher has been edited!"));
    }

    [Test]
    public async Task EditGameById()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        await repo.AddRangeAsync(new List<Game>()
        {
            new Game() { GameTitle = "Witcher", Summary = "", Id = 1, ImageUrl = "", Rating = 0 },
            new Game() { GameTitle = "WoW", Summary = "", Id = 2, ImageUrl = "", Rating = 0 },
            new Game() { GameTitle = "Batman", Summary = "", Id = 3, ImageUrl = "", Rating = 0 },
            new Game() { GameTitle = "", Summary = "", Id = 4, ImageUrl = "", Rating = 0 },
            new Game() { GameTitle = "", Summary = "", Id = 5, ImageUrl = "", Rating = 0 },
            new Game() { GameTitle = "", Summary = "", Id = 6, ImageUrl = "", Rating = 0 },
            new Game() { GameTitle = "", Summary = "", Id = 7, ImageUrl = "", Rating = 0 },

        });
        
        await repo.SaveChangesAsync();

        var game = await gameService.GameEditModelById(3);

        Assert.That(game.GameTitle, Is.EqualTo("Batman"));
        Assert.That(game.Id == 3);

    }

    [Test]
    public async Task GetMyLibaryAsync()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        var hasher = new PasswordHasher<ApplicationUser>();
        var users = new List<ApplicationUser>();

        var user = new ApplicationUser()
        {
            Id = "dea12856-c198-4129-b3f3-b893d8395082",
            UserName = "user@mail.com",
            NormalizedUserName = "user@mail.com",
            Email = "user@mail.com",
            NormalizedEmail = "user@mail.com"
        };

        user.PasswordHash =
            hasher.HashPassword(user, "user123");

        users.Add(user);

        await repo.AddAsync(new Game()
        {
            Id = 1,
            GameTitle = "Witcher",
            ImageUrl = "",
            Summary = "",
            IsGameActive = true,

        });

        await repo.SaveChangesAsync();

        await gameService.AddGameToMyLibrary(1, "dea12856-c198-4129-b3f3-b893d8395082");

        var game = await gameService.GetMyLibraryAsync("dea12856-c198-4129-b3f3-b893d8395082");

        Assert.That(game.Any(g => g.GameTitle == "Witcher"), Is.True);

    }


    [Test]
    public async Task RemoveGameFromMyLibrary()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        var hasher = new PasswordHasher<ApplicationUser>();
        var users = new List<ApplicationUser>();

        var user = new ApplicationUser()
        {
            Id = "dea12856-c198-4129-b3f3-b893d8395082",
            UserName = "user@mail.com",
            NormalizedUserName = "user@mail.com",
            Email = "user@mail.com",
            NormalizedEmail = "user@mail.com"
        };

        user.PasswordHash =
            hasher.HashPassword(user, "user123");

        users.Add(user);

        await repo.AddRangeAsync(new List<Game>()
        {
            new Game() { GameTitle = "Witcher", Summary = "", Id = 1, ImageUrl = "", Rating = 0 },
            new Game() { GameTitle = "WoW", Summary = "", Id = 2, ImageUrl = "", Rating = 0 },
            
        });

        await repo.SaveChangesAsync();

        await gameService.AddGameToMyLibrary(1, "dea12856-c198-4129-b3f3-b893d8395082");
        await gameService.AddGameToMyLibrary(2, "dea12856-c198-4129-b3f3-b893d8395082");

        await gameService.RemoveGameFromLibrary(2, "dea12856-c198-4129-b3f3-b893d8395082");

        var game = await gameService.GetMyLibraryAsync("dea12856-c198-4129-b3f3-b893d8395082");

        Assert.That(1, Is.EqualTo(game.Count()));
        Assert.That(game.Any(g => g.GameTitle == "Witcher" && g.Id == 1), Is.True);

    }

    [Test]
    public async Task DeleteGameById()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        await repo.AddRangeAsync(new List<Game>()
        {
            new Game() { GameTitle = "Witcher", Summary = "", Id = 1, ImageUrl = "", Rating = 0, IsGameActive = true},
            new Game() { GameTitle = "WoW", Summary = "", Id = 2, ImageUrl = "", Rating = 0, IsGameActive = true },
            new Game() { GameTitle = "Batman", Summary = "", Id = 3, ImageUrl = "", Rating = 0, IsGameActive = true },
            
        });

        await repo.SaveChangesAsync();

        var game = await gameService.DeleteGameById(3);

        Assert.That(game.GameTitle, Is.EqualTo("Batman"));
        Assert.That(game.Id == 3);

    }

    [Test]
    public async Task DeleteGame()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        await repo.AddAsync(new Game()
        {
            Id = 1,
            GameTitle = "",
            ImageUrl = "",
            Summary = "",
            IsGameActive = true,
        });

        await repo.SaveChangesAsync();

        await gameService.DeleteGame(1);

        var game = await repo.GetByIdAsync<Game>(1);

        Assert.That(game.IsGameActive, Is.EqualTo(false));

    }

    [Test]
    public async Task All()
    {
        var repo = new Repository(context);
        gameService = new GameService(repo, context);

        await repo.AddAsync(new Game()
        {
            Id = 1,
            GameTitle = "Witcher 3",
            ImageUrl = "",
            Summary = "",
            IsGameActive = true
        });

        await repo.AddAsync(new Genre()
        {
            Id = 2,
            Category = "MMO"
        });

        await repo.SaveChangesAsync();


        var allGames = await gameService.All("MMO", "Witcher 3", 1, 1);

        Assert.That(allGames, Is.Not.Null);
    }

    [TearDown]
    public void TearDown()
    {
        context.Dispose();
    }
}