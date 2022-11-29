using PlayBeforeYouDie.Core.Models.Game;

namespace PlayBeforeYouDie.Core.Contracts;

public interface IGameService
{
    Task<IEnumerable<GameServiceModel>> GetAll();
}