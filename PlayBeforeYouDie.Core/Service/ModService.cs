
using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Game;
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

    public async Task<IEnumerable<ModImageModel>> AllImages()
    {
        return await repo.AllReadonly<ModPicture>()
            .Select(c => new ModImageModel()
            {
                Id = c.Id,
                ModImageOne = c.ModImageOne,
                ModImageTwo = c.ModImageTwo,
                ModImageThree = c.ModImageThree,
                ModImageFour = c.ModImageFour,
            })
            .ToListAsync();

    }

    public async Task<ModModel> ModsByGameById(int id)
    {
        return await repo.AllReadonly<Game>()
            .Where(g => g.IsGameActive)
            .Where(g => g.Id == id)
            .Include(g => g.Mod)
            .Include(p => p.Mod.ModPicture)
            .Select(m => new ModModel()
                {
                    Id = m.Id,
                    GamesTitle = m.GameTitle,
                    ModName = m.Mod.ModName,
                    Description = m.Mod.Description,
                    DownloadModLink = m.Mod.DownloadModLink,
                    YoutubeVideoModComparison = m.Mod.YoutubeVideoModComparison,
                    ModImageOne = m.Mod.ModPicture.ModImageOne,
                    ModImageTwo = m.Mod.ModPicture.ModImageTwo,
                    ModImageThree = m.Mod.ModPicture.ModImageThree,
                    ModImageFour = m.Mod.ModPicture.ModImageFour
                }
            )
            .FirstAsync();
    }
}   

