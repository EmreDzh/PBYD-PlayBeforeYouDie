using PlayBeforeYouDie.Core.Models.GameOfTheYear;

namespace PlayBeforeYouDie.Core.Contracts;

public interface IGameOfTheYearService
{
    Task<IEnumerable<GameOfTheYearModel>> GetAllGotyAsync();
}