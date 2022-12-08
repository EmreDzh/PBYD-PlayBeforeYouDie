using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Game;
using PlayBeforeYouDie.Core.Models.HowLongToBeat;
using PlayBeforeYouDie.Infrastructure.Data;
using PlayBeforeYouDie.Infrastructure.Data.Common;
using PlayBeforeYouDie.Infrastructure.Data.Models;
using PlayBeforeYouDie.Infrastructure.Data.Models.Users;

namespace PlayBeforeYouDie.Core.Service;

public class HowLongToBeatService : IHowLongToBeatService
{
    private readonly IRepository repo;
    

    public HowLongToBeatService(IRepository _repo)
    {
        repo = _repo;
        
    }
    
    public async Task<List<HowLongToBeatModel>> GameHowLongToBeatById(int id)
    {
        
        var game = await repo.AllReadonly<Game>()
            .Include(g => g.HowLongToBeat)
            .FirstOrDefaultAsync(g => g.Id == id);

        var howLongToBeatCollection = game.HowLongToBeat
            .Select(h => new HowLongToBeatModel()
            {
                Id = h.Id,
                GamesTitle = h.Game.GameTitle,
                ImageUrl = h.Game.ImageUrl,
                HundredPercentComplete = h.HundredPercentComplete,
                MainPlusSides = h.MainPlusSides,
                MainStory = h.MainStory,
                SpeedRunAny = h.SpeedRunAny,
                SpeedRunOneHundredPercent = h.SpeedRunOneHundredPercent,
                GameId = h.GameId
            })
            .ToList();

        return howLongToBeatCollection;


    }

    public async Task SubmitPlayTime(HowLongToBeatModel model)
    {
        
        var howLongToBeat = new HowLongToBeat()
        {
            Id = model.Id,
            HundredPercentComplete = model.HundredPercentComplete,
            MainPlusSides = model.MainPlusSides,
            MainStory = model.MainStory,
            SpeedRunAny = model.SpeedRunAny,
            SpeedRunOneHundredPercent = model.SpeedRunOneHundredPercent,
            GameId = model.GameId

        };
        
        try
        {
            await repo.AddAsync(howLongToBeat);
            await repo.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new ApplicationException("Database is down or failed to submit the info", e);
        }

    }

    public async Task<int> GetHowLongToBeatId(string userId)
    {
        return (await repo.AllReadonly<ApplicationUserGame>()
            .FirstOrDefaultAsync(x => x.ApplicationUserId == userId))?.GameId ?? 0;
    }
    
}
