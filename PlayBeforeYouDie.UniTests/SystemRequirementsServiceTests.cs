using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.SystemRequirement;
using PlayBeforeYouDie.Core.Service;
using PlayBeforeYouDie.Infrastructure.Data.Common;
using PlayBeforeYouDie.Infrastructure.Data;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.UniTests;

public class SystemRequirementsServiceTests
{
    private IRepository repo;
    private ApplicationDbContext context;
    private ISystemRequirementsService systemRequirementService;

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
    public async Task SystemRequirementsGameById()
    {
        var repo = new Repository(context);
        systemRequirementService = new SystemRequirementsService(repo);

        await repo.AddRangeAsync(new List<SystemRequirement>()
        {
            new SystemRequirement(){Id= 1, Graphics = "Titan RTX", Memory = "", AdditionalNotes = "", Network = "", Processor = "", Os = "", Storage = ""},
            new SystemRequirement(){Id= 2, Graphics = "RTX 3080", Memory = "", AdditionalNotes = "", Network = "", Processor = "", Os = "", Storage = ""},
            new SystemRequirement(){Id= 3, Graphics = "", Memory = "", AdditionalNotes = "", Network = "", Processor = "", Os = "", Storage = ""},
            new SystemRequirement(){Id= 4, Graphics = "", Memory = "", AdditionalNotes = "", Network = "", Processor = "", Os = "", Storage = ""},
        });

        
        await repo.AddAsync(new Game()
        {
            Id = 1,
            GameTitle = "Witcher 3",
            ImageUrl = "",
            Summary = "",
            IsGameActive = true,
            SystemRequirementId = 2
        });

        
        await repo.SaveChangesAsync();

        var systemReq = await systemRequirementService.SystemRequirementsGameById(1);
        var system = await repo.GetByIdAsync<SystemRequirement>(2);
        
        Assert.That(systemReq.systemRequirementsId, Is.EqualTo(2));
        Assert.That(system.Graphics, Is.EqualTo("RTX 3080"));
        
    }

    [Test]
    public async Task SystemRequirementsDetailsById()
    {
        var repo = new Repository(context);
        systemRequirementService = new SystemRequirementsService(repo);

        await repo.AddRangeAsync(new List<SystemRequirement>()
        {
            new SystemRequirement(){Id= 1, Graphics = "Titan RTX", Memory = "", AdditionalNotes = "", Network = "", Processor = "", Os = "", Storage = ""},
            new SystemRequirement(){Id= 2, Graphics = "RTX 3080", Memory = "", AdditionalNotes = "", Network = "", Processor = "", Os = "", Storage = ""},
            new SystemRequirement(){Id= 3, Graphics = "", Memory = "", AdditionalNotes = "", Network = "", Processor = "", Os = "", Storage = ""},
            new SystemRequirement(){Id= 4, Graphics = "", Memory = "", AdditionalNotes = "", Network = "", Processor = "", Os = "", Storage = ""},
        });

        await repo.SaveChangesAsync();

        var system = await systemRequirementService.SystemRequirementsDetailsById(2);

        Assert.That(system.Graphics, Is.EqualTo("RTX 3080"));
        Assert.That(system.Id, Is.EqualTo(2));

    }

    [Test]
    public async Task Edit()
    {
        var repo = new Repository(context);
        systemRequirementService = new SystemRequirementsService(repo);

        await repo.AddAsync(new SystemRequirement()
        {
            Id = 1,
            Graphics = "Titan RTX",
            Memory = "",
            AdditionalNotes = "",
            Network = "",
            Processor = "",
            Os = "",
            Storage = ""
        });

        await repo.SaveChangesAsync();

        await systemRequirementService.Edit(1, new SystemRequirementsModel()
        {
            Id = 1,
            Graphics = "Titan RTX is Edited",
            Memory = "",
            AdditionalNotes = "",
            Network = "",
            Processor = "",
            Os = "",
            Storage = ""
        });

        var system = await repo.GetByIdAsync<SystemRequirement>(1);

        Assert.That(system.Graphics, Is.EqualTo("Titan RTX is Edited"));
    }

    [Test]
    public async Task SystemRequirementsExist()
    {
        var repo = new Repository(context);
        systemRequirementService = new SystemRequirementsService(repo);

        await repo.AddAsync(new SystemRequirement()
        {
            Id = 1,
            Graphics = "Titan RTX",
            Memory = "",
            AdditionalNotes = "",
            Network = "",
            Processor = "",
            Os = "",
            Storage = ""
        });

        await repo.SaveChangesAsync();

        var exists = await systemRequirementService.SystemRequirementsExists(1);

        Assert.That(exists, Is.True);
    }

    [Test]
    public async Task AllSystemRequirements()
    {
        var repo = new Repository(context);
        systemRequirementService = new SystemRequirementsService(repo);

        await repo.AddAsync(new SystemRequirement()
        {
            Id = 1,
            Graphics = "Titan RTX",
            Memory = "",
            AdditionalNotes = "",
            Network = "",
            Processor = "",
            Os = "",
            Storage = ""
        });

        await repo.SaveChangesAsync();

        var system = await systemRequirementService.AllSystemRequirements();

        Assert.That(system.Any(s => s.Graphics == "Titan RTX"), Is.True);
    }

    [TearDown]
    public void TearDown()
    {
        context.Dispose();
    }
}