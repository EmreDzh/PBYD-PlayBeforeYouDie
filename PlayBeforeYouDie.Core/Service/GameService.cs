using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Game;
using PlayBeforeYouDie.Infrastructure.Data.Common;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.Core.Service;

public class GameService : IGameService
{
    private readonly IRepository repo;

    public GameService(IRepository _repo)
    {
        repo = _repo;

    }

    public async Task<IEnumerable<GameServiceModel>> GetAll()
    {
        return await repo.AllReadonly<Game>()
            .Where(g => g.IsGameActive)
            .Select(g => new GameServiceModel()
            {
                GameTitle = g.GameTitle,
                Summary = g.Summary,
                Id = g.Id,
                ImageUrl = g.ImageUrl,
                Rating = g.Rating
            })
            .ToListAsync();
    }
}