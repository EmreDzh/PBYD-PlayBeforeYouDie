using PlayBeforeYouDie.Core.Models.Game;

namespace PBYD___PlayBeforeYouDie.Models;

public class AllGamesQueryModel
{
    public const int HousesPerPage = 3;

    public int CurrentPage { get; init; } = 1;

    public int TotalGamesCount { get; set; }

    public IEnumerable<GameServiceModel> Games { get; set; } = new List<GameServiceModel>();
}