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
}