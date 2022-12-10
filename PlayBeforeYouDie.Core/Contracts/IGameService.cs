using PlayBeforeYouDie.Core.Models.Game;
using PlayBeforeYouDie.Core.Models.Genre;

namespace PlayBeforeYouDie.Core.Contracts;

public interface IGameService
{
    Task<IEnumerable<GameHomeModel>> GetInitialGames();

    Task<IEnumerable<GameServiceModel>> GetAll();

    Task<GamesQueryModel> All(string? genre, string? searchTerm = null, int currentPage = 1,
        int gamePerPage = 1);

    Task<IEnumerable<string>> AllGenreNames();

    Task<IEnumerable<GenreModel>> AllGenres();

    Task<bool> Exists(int id);


    Task AddGameToMyLibrary(int gameId, string userId);

    Task AddGame(AddGameModel model);

    Task<IEnumerable<GameModel>> GetMyLibraryAsync(string userId);

    Task RemoveGameFromLibrary(int gameId, string userId);

    Task<GameServiceModel> DeleteGameById(int id);

    Task DeleteGame(int gameId);


}