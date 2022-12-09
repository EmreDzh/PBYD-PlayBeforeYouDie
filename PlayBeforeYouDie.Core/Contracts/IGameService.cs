using PlayBeforeYouDie.Core.Models.Game;

namespace PlayBeforeYouDie.Core.Contracts;

public interface IGameService
{
    Task<IEnumerable<GameHomeModel>> GetInitialGames();

    Task<IEnumerable<GameServiceModel>> GetAll();

    Task<GamesQueryModel> All(string? genre, string? searchTerm = null, int currentPage = 1,
        int gamePerPage = 1);

    Task<IEnumerable<string>> AllGenreNames();

    Task<bool> Exists(int id);

    Task<int> GetGameId(int gameId);

    Task AddGameToMyLibrary(int gameId, string userId);

    Task<IEnumerable<GameServiceModel>> GetMyLibraryAsync(string userId);

    Task RemoveGameFromLibrary(int gameId, string userId);
}