using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.HowLongToBeat;
using PlayBeforeYouDie.Core.Service;
using PlayBeforeYouDie.Infrastructure.Data.Common;
using PlayBeforeYouDie.Infrastructure.Data;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.UniTests;

public class HowLongToBeatServiceTests
{
    private IRepository repo;
    private ApplicationDbContext context;
    private IHowLongToBeatService howLongToBeatService;

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
    public async Task GameHowLongToBeatById()
    {
        var repo = new Repository(context);
        howLongToBeatService = new HowLongToBeatService(repo);

        await repo.AddAsync(new Game()
        {
            Id = 2,
            GameTitle = "Witcher 3",
            ImageUrl = "",
            Summary = "",
            IsGameActive = true,
        });

        await repo.AddAsync(new HowLongToBeat()
        {
            Id = 1,
            HundredPercentComplete = "54h",
            MainPlusSides = "",
            MainStory = "",
            SpeedRunAny = "",
            SpeedRunOneHundredPercent = "",
            GameId = 2
        });

        await repo.SaveChangesAsync();

        var howLong = await howLongToBeatService.GameHowLongToBeatById(2);

        Assert.That(howLong.Any(g => g.HundredPercentComplete == "54h"), Is.True);
        Assert.That(howLong.Any(g => g.GameId == 2), Is.True);
    }

    [Test]
    public async Task SubmitPlayTime()
    {
        var repo = new Repository(context);
        howLongToBeatService = new HowLongToBeatService(repo);

        await repo.AddAsync(new Game()
        {
            Id = 2,
            GameTitle = "Witcher 3",
            ImageUrl = "",
            Summary = "",
            IsGameActive = true,
        });

        await repo.SaveChangesAsync();

        await howLongToBeatService.SubmitPlayTime(new HowLongToBeatModel()
        {
            Id = 4,
            GameId = 2,
            GamesTitle = "Witcher 3",
            HundredPercentComplete = "54h",
            MainPlusSides = "",
            MainStory = "",
            SpeedRunAny = "",
            SpeedRunOneHundredPercent = ""

        });

        var howLong = await repo.GetByIdAsync<HowLongToBeat>(4);

        Assert.That(howLong.Game.GameTitle, Is.EqualTo("Witcher 3"));
        Assert.That(howLong.HundredPercentComplete, Is.EqualTo("54h"));
    }

    [Test]
    public async Task Exists()
    {
        var repo = new Repository(context);
        howLongToBeatService = new HowLongToBeatService(repo);

        await repo.AddAsync(new HowLongToBeat()
        {
            Id = 1,
            HundredPercentComplete = "54h",
            MainPlusSides = "",
            MainStory = "",
            SpeedRunAny = "",
            SpeedRunOneHundredPercent = "",
            GameId = 2
        });

        await repo.SaveChangesAsync();

        var exists = await howLongToBeatService.Exists(1);

        Assert.That(exists, Is.True);
    }

    [Test]
    public async Task DeleteHowLongToPlayById()
    {
        var repo = new Repository(context);
        howLongToBeatService = new HowLongToBeatService(repo);

        await repo.AddRangeAsync(new List<HowLongToBeat>()
        {
            new HowLongToBeat()
            {
                Id = 1,
                HundredPercentComplete = "54h",
                MainPlusSides = "",
                MainStory = "",
                SpeedRunAny = "",
                SpeedRunOneHundredPercent = "",
                GameId = 2
            },
            new HowLongToBeat()
            {
                Id = 2,
                HundredPercentComplete = "100h",
                MainPlusSides = "",
                MainStory = "",
                SpeedRunAny = "",
                SpeedRunOneHundredPercent = "",
                GameId = 2
            }
        });

        await repo.SaveChangesAsync();

        var howLong = await howLongToBeatService.DeleteHowLongToBeatById(2);

        Assert.That(howLong.Id, Is.EqualTo(2));
        Assert.That(howLong.HundredPercentComplete, Is.EqualTo("100h"));

    }

    [Test]
    public async Task DeleteHowLongToPlay()
    {
        var repo = new Repository(context);
        howLongToBeatService = new HowLongToBeatService(repo);

        await repo.AddRangeAsync(new List<HowLongToBeat>()
        {
            new HowLongToBeat()
            {
                Id = 1,
                HundredPercentComplete = "54h",
                MainPlusSides = "",
                MainStory = "",
                SpeedRunAny = "",
                SpeedRunOneHundredPercent = "",
                GameId = 2
            },
            new HowLongToBeat()
            {
                Id = 2,
                HundredPercentComplete = "100h",
                MainPlusSides = "",
                MainStory = "",
                SpeedRunAny = "",
                SpeedRunOneHundredPercent = "",
                GameId = 2
            }
        });

        await repo.SaveChangesAsync();

        await howLongToBeatService.DeleteHowLongToBeat(2);

        var howLong = await repo.GetByIdAsync<HowLongToBeat>(2);

        Assert.That(howLong, Is.EqualTo(null));
        

    }

    [TearDown]
    public void TearDown()
    {
        context.Dispose();
    }
}