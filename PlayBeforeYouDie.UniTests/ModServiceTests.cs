using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Mod;
using PlayBeforeYouDie.Core.Service;
using PlayBeforeYouDie.Infrastructure.Data.Common;
using PlayBeforeYouDie.Infrastructure.Data;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.UniTests;

public class ModServiceTests
{
    private IRepository repo;
    private ApplicationDbContext context;
    private IModService modService;

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
    public async Task ModsByGameId()
    {
        var repo = new Repository(context);
        modService = new ModService(repo);

        await repo.AddAsync(new Game()
        {
            Id = 2,
            GameTitle = "Witcher 3",
            ImageUrl = "",
            Summary = "",
            IsGameActive = true,
        });

        await repo.AddAsync(new Mod()
        {
            Id = 1,
            Description = "Awesome mod!",
            ModName = "",
            DownloadModLink = "",
            ModPicture = new ModPicture()
            {
                Id = 1,
                ModImageOne = "awesome pic"
            },
            GameId = 2
        });

        await repo.SaveChangesAsync();

        var mods = await modService.ModsByGameById(2);

        Assert.That(mods.Any(m => m.Description == "Awesome mod!"), Is.True);
        Assert.That(mods.Any(m => m.ModImageOne == "awesome pic"), Is.True);
    }

    [Test]
    public async Task SubmitMod()
    {
        var repo = new Repository(context);
        modService = new ModService(repo);

        await modService.SubmitMod(new ModModel()
        {
            Id = 1,
            Description = "Awesome mod!",
            ModName = "",
            DownloadModLink = "",

            ModImageId = 1,
            ModImageOne = "awesome pic"

        });

        var mods = await repo.GetByIdAsync<Mod>(1);

        Assert.That(mods.Description, Is.EqualTo("Awesome mod!"));
        Assert.That(mods.ModPicture.ModImageOne, Is.EqualTo("awesome pic"));
    }

    [Test]
    public async Task Exists()
    {
        var repo = new Repository(context);
        modService = new ModService(repo);

        await repo.AddAsync(new Mod()
        {
            Id = 1,
            Description = "Awesome mod!",
            ModName = "",
            DownloadModLink = "",
            ModPicture = new ModPicture()
            {
                Id = 1,
                ModImageOne = "awesome pic"
            },
            GameId = 2
        });

        await repo.SaveChangesAsync();

        var exists = await modService.Exists(1);

        Assert.That(exists, Is.True);
    }

    [Test]
    public async Task DeleteModById()
    {
        var repo = new Repository(context);
        modService = new ModService(repo);

        await repo.AddRangeAsync(new List<Mod>()
        {
           new Mod()
           {
               Id = 1,
               Description = "Awesome mod!",
               ModName = "",
               DownloadModLink = "",
               ModPicture = new ModPicture()
               {
                   Id = 1,
                   ModImageOne = "awesome pic"
               },
               GameId = 2
           },
           new Mod()
           {
               Id = 2,
               Description = "Best graphics",
               ModName = "",
               DownloadModLink = "",
               ModPicture = new ModPicture()
               {
                   Id = 3,
                   ModImageOne = ""
               },
               GameId = 2
           }
        });

        await repo.SaveChangesAsync();

        var mod = await modService.DeleteModById(2);

        Assert.That(mod.Description, Is.EqualTo("Best graphics"));
        Assert.That(mod.Id, Is.EqualTo(2));
    }

    [Test]
    public async Task DeleteMod()
    {
        var repo = new Repository(context);
        modService = new ModService(repo);

        await repo.AddRangeAsync(new List<Mod>()
        {
            new Mod()
            {
                Id = 1,
                Description = "Awesome mod!",
                ModName = "",
                DownloadModLink = "",
                ModPicture = new ModPicture()
                {
                    Id = 1,
                    ModImageOne = "awesome pic"
                },
                GameId = 2
            },
            new Mod()
            {
                Id = 2,
                Description = "Best graphics",
                ModName = "",
                DownloadModLink = "",
                ModPicture = new ModPicture()
                {
                    Id = 3,
                    ModImageOne = ""
                },
                GameId = 2
            }
        });

        await repo.SaveChangesAsync();

        await modService.DeleteMod(2);

        var mods = await repo.GetByIdAsync<Mod>(2);

        Assert.That(mods, Is.EqualTo(null));
    }

    [TearDown]
    public void TearDown()
    {
        context.Dispose();
    }
}