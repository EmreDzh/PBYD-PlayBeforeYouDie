using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.GameOfTheYear;
using PlayBeforeYouDie.Infrastructure.Data.Common;
using PlayBeforeYouDie.Infrastructure.Data;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.Core.Service;

public class GameOfTheYearService : IGameOfTheYearService
{
    private readonly IRepository repo;
    
    public GameOfTheYearService(IRepository _repo)
    {
        repo = _repo;
        
    }

    public async Task<IEnumerable<GameOfTheYearModel>> GetAllGotyAsync()
    {
        return await repo.AllReadonly<GameOfTheYear>()
            .OrderBy(g => g.Id)
            .Select(g => new GameOfTheYearModel()
            {
                Id = g.Id,
                Developers = g.Developers,
                GameTitle = g.GameTitle,
                ImageUrl = g.ImageUrl,
                Year = g.Year
            })
            .ToListAsync();
    }
}