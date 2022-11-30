using PlayBeforeYouDie.Core.Models.Game;

namespace PlayBeforeYouDie.Core.Contracts;

public interface IGameService
{
    Task<IEnumerable<GameServiceModel>> GetAll();

    Task<GamesQueryModel> All(string? searchTerm = null, int currentPage = 1,
        int gamePerPage = 1);
}