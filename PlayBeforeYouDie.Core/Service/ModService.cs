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

    public async Task<List<ModModel>> ModsByGameById(int id)
    {
        var game = await repo.AllReadonly<Game>()
            .Include(g => g.Mods)
            .ThenInclude(g => g.ModPicture)
            .FirstOrDefaultAsync(g => g.Id == id);

        var modsCollection = game.Mods
            .Select(g => new ModModel()
            {
                Id = g.Id,
                GamesTitle = g.Game.GameTitle,
                ModName = g.ModName,
                Description = g.Description,
                DownloadModLink = g.DownloadModLink!,
                YoutubeVideoModComparison = g.YoutubeVideoModComparison,
                ModImageOne = g.ModPicture.ModImageOne,
                ModImageTwo = g.ModPicture.ModImageTwo,
                ModImageThree = g.ModPicture.ModImageThree,
                ModImageFour = g.ModPicture.ModImageFour,
                GameId = g.GameId
            })
            .ToList();

        return modsCollection;
    }

    public async Task SubmitMod(ModModel model)
    {
        var mods = new Mod()
        {
            Id = model.Id,
            Description = model.Description,
            DownloadModLink = model.DownloadModLink,
            ModName = model.ModName,
            YoutubeVideoModComparison = model.YoutubeVideoModComparison,
            GameId = model.GameId,
            ModPicture = new ModPicture()
            {
                Id = model.ModImageId,
                ModImageOne = model.ModImageOne,
                ModImageTwo = model.ModImageTwo,
                ModImageThree = model.ModImageThree,
                ModImageFour = model.ModImageFour
            }
        };

        try
        {
            await repo.AddAsync(mods);
            await repo.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new ApplicationException("Database is down or failed to submit the info!", e);
        }
    }
}   

