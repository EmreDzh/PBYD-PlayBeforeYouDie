using PlayBeforeYouDie.Core.Models.Game;
using System.ComponentModel.DataAnnotations;

namespace PBYD___PlayBeforeYouDie.Areas.Admin.Models.Game;

public class AdminGamesViewModel
{
    public const int HousesPerPage = 6;

    public int CurrentPage { get; init; } = 1;

    public int TotalGamesCount { get; set; }

    [Display(Name = "Search games by names or rating!")]
    public string? SearchGame { get; init; }

    public IEnumerable<GameServiceModel> Games { get; set; } = new List<GameServiceModel>();

    public string? Genre { get; set; }

    public IEnumerable<string> Genres { get; set; } = Enumerable.Empty<string>();
}