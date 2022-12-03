using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Game;
using PlayBeforeYouDie.Core.Models.HowLongToBeat;
using PlayBeforeYouDie.Infrastructure.Data;
using PlayBeforeYouDie.Infrastructure.Data.Common;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.Core.Service;

public class HowLongToBeatService : IHowLongToBeatService
{
    private readonly IRepository repo;
    private readonly ApplicationDbContext context;


    public HowLongToBeatService(IRepository _repo, ApplicationDbContext _context)
    {
        repo = _repo;
        context = _context;
    }

    public async Task<HowLongToBeatModel> GameHowLongToBeatById(int id)
    {
        return await repo.AllReadonly<Game>()
            .Where(g => g.IsGameActive)
            .Where(g => g.Id == id)
            .Include(g => g.HowLongToBeat)
            .Select(h => new HowLongToBeatModel()
            {
                Id = h.HowLongToBeat.Id,
                GamesTitle = h.GameTitle,
                ImageUrl = h.ImageUrl,
                HundredPercentComplete = h.HowLongToBeat.HundredPercentComplete,
                MainPlusSides = h.HowLongToBeat.MainPlusSides,
                MainStory = h.HowLongToBeat.MainStory,
                SpeedRunAny = h.HowLongToBeat.SpeedRunAny,
                SpeedRunOneHundredPercent = h.HowLongToBeat.SpeedRunOneHundredPercent,
            })
            .FirstAsync();
    }

    public async Task<int> SubmitPlayTime(HowLongToBeatModel model, int gameId)
    {

        var howLongToBeat = new Game()
        {
            Id = gameId,
            HowLongToBeat = new HowLongToBeat()
            {
                HundredPercentComplete = model.HundredPercentComplete,
                MainPlusSides = model.MainPlusSides,
                MainStory = model.MainStory,
                SpeedRunAny = model.SpeedRunAny,
                SpeedRunOneHundredPercent = model.SpeedRunOneHundredPercent
            }
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

        return howLongToBeat.Id;

    }

    public async Task<int> GetHowLongToBeatId(int id)
    {
        return (await repo.AllReadonly<HowLongToBeat>()
            .FirstOrDefaultAsync(g => g.Id == id))?.Id ?? 0;
    }
}