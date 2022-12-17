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

    

    public async Task<List<ModModel>> ModsByGameById(int id)
    {
        
        try
        {
            var game = await repo.AllReadonly<Game>()
                .Include(g => g.Mods)
                .ThenInclude(g => g.ModPicture)
                .FirstOrDefaultAsync(g => g.Id == id);

            var modsCollection = game!.Mods
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
        catch (Exception e)
        {
            throw new ApplicationException("Database is down or game returned incorrect data", e);
        }
       
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

    public async Task<bool> Exists(int id)
    {
        try
        {
            return await repo.AllReadonly<Mod>()
                .AnyAsync(m => m.Id == id);
        }
        catch (Exception e)
        {
            throw new ApplicationException("Database is down or failed to get the mod", e);
        }
    }

    public async Task<ModModel> DeleteModById(int id)
    {
        try
        {
            return await repo.AllReadonly<Mod>()
                .Where(m => m.Id == id)
                .Select(m => new ModModel()
                {
                    Id = m.Id,
                    Description = m.Description,
                    ModName = m.ModName,
                    DownloadModLink = m.DownloadModLink!
                })
                .FirstAsync();
        }
        catch (Exception e)
        {
            throw new ApplicationException("Database is down or failed to get the mod", e);
        }
    }

    public async Task DeleteMod(int id)
    {

        try
        {
            var mod = await repo.GetByIdAsync<Mod>(id);

            repo.Delete(mod);

            await repo.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new ApplicationException("Database is down or failed to get the mod", e);
        }
        
    }
}   

