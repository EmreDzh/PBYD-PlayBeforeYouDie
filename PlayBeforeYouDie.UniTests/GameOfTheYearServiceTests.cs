using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Service;
using PlayBeforeYouDie.Infrastructure.Data.Common;
using PlayBeforeYouDie.Infrastructure.Data;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.UniTests;

public class GameOfTheYearServiceTests
{
    private IRepository repo;
    private ApplicationDbContext context;
    private IGameOfTheYearService gameOfTheYearService;

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
    public async Task GetAllGoty()
    {
        var repo = new Repository(context);
        gameOfTheYearService = new GameOfTheYearService(repo);

        await repo.AddAsync(new GameOfTheYear()
        {
            Id = 1,
            Developers = "Blizzard",
            GameTitle = "",
            ImageUrl = "",
            Year = 2014
        });

        await repo.SaveChangesAsync();

        var goty = await gameOfTheYearService.GetAllGotyAsync();

        Assert.That(goty.Any(g => g.Developers == "Blizzard"), Is.True);
    }


    [TearDown]
    public void TearDown()
    {
        context.Dispose();
    }
}