using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Infrastructure.Data;
using PlayBeforeYouDie.Infrastructure.Data.Common;

namespace PlayBeforeYouDie.UniTests;

[TestFixture]
public class GameServiceTests
{
    private IRepository repo;
    private ApplicationDbContext context;

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
    public async Task GetInitialGamesInMemory()
    {
        var repo = new Repository(context);


    }
}