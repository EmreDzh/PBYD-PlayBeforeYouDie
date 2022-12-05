using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Mod;
using PlayBeforeYouDie.Infrastructure.Data.Common;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.Core.Service;

public class ModService : IModService
{
    private readonly IRepository repo;

    public ModService(IRepository _repo)
    {
        repo = _repo;
    }

    public async Task<ModModel> ModsByGameById(int id)
    {
        return await repo.AllReadonly<Game>()
            .Where(g => g.IsGameActive)
            .Where(g => g.Id == id)
            .Include(g => g.Mod)
            .Select(m => new ModModel()
                {
                    Id = m.Id,
                    GamesTitle = m.GameTitle,
                    ModName = m.Mod.ModName,
                    Description = m.Mod.Description,
                    ModImage = m.Mod.ModImage,
                    DownloadModLink = m.Mod.DownloadModLink,
                    YoutubeVideoModComparison = m.Mod.YoutubeVideoModComparison
            }
            )
            .FirstAsync();
    }
}