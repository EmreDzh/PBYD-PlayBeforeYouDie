using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.HowLongToBeat;
using PlayBeforeYouDie.Core.Models.SystemRequirement;
using PlayBeforeYouDie.Infrastructure.Data.Common;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.Core.Service;

public class SystemRequirementsService : ISystemRequirementsService
{
    private readonly IRepository repo;

    public SystemRequirementsService(IRepository _repo)
    {
        repo = _repo;
    }

    public async Task<SystemRequirementsModel> SystemRequirementsGameById(int id)
    {
        return await repo.AllReadonly<Game>()
            .Where(g => g.IsGameActive)
            .Where(g => g.Id == id)
            .Include(g => g.SystemRequirement)
            .Select(s => new SystemRequirementsModel()
                {
                    Id = s.Id,
                    GamesTitle = s.GameTitle,
                    ImageUrl = s.ImageUrl,
                    Graphics = s.SystemRequirement.Graphics,
                    Memory = s.SystemRequirement.Memory,
                    Network = s.SystemRequirement.Network,
                    Os = s.SystemRequirement.Os,
                    Processor = s.SystemRequirement.Processor,
                    Storage = s.SystemRequirement.Storage,
                    AdditionalNotes = s.SystemRequirement.AdditionalNotes
                }
            )
            .FirstAsync();
    }

    public async Task<SystemRequirementsDetails> SystemRequirementsDetailsById(int id)
    {
        return await repo.AllReadonly<SystemRequirement>()
            .Where(g => g.Id == id)
            .Select(s => new SystemRequirementsDetails()
                {
                    Id = s.Id,
                    Graphics = s.Graphics,
                    Memory = s.Memory,
                    Network = s.Network,
                    Os = s.Os,
                    Processor = s.Processor,
                    Storage = s.Storage,
                    AdditionalNotes = s.AdditionalNotes
                }
            )
            .FirstAsync();
    }

    public async Task Edit(int systemRequirementsId, SystemRequirementsModel model)
    {
        var systemRequirement = await repo.GetByIdAsync<SystemRequirement>(systemRequirementsId);

        systemRequirement.Os = model.Os;
        systemRequirement.Graphics = model.Graphics;
        systemRequirement.Processor = model.Processor;
        systemRequirement.Storage = model.Storage;
        systemRequirement.Memory = model.Memory;
        systemRequirement.Network = model.Network;
        systemRequirement.AdditionalNotes = model.AdditionalNotes;
        

        try
        {
            await repo.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new ApplicationException("Database is down or failed to submit the info", e);
        }
    }

    public async Task<bool> Exists(int systemRequirementsId)
    {
        return await repo.AllReadonly<SystemRequirement>()
            .AnyAsync(h => h.Id == systemRequirementsId);
    }
}