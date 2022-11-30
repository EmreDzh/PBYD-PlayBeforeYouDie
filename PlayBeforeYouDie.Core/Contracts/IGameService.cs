using PlayBeforeYouDie.Core.Models.Game;

namespace PlayBeforeYouDie.Core.Contracts;

public interface IGameService
{
    Task<IEnumerable<GameServiceModel>> GetAll();

    Task<GamesQueryModel> All(int currentPage = 1,
        int gamePerPage = 1);
}