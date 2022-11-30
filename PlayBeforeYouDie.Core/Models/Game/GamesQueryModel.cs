namespace PlayBeforeYouDie.Core.Models.Game;

public class GamesQueryModel
{
    public int TotalGamesCount { get; set; }

    public IEnumerable<GameServiceModel> Games { get; set; } = new List<GameServiceModel>();
}