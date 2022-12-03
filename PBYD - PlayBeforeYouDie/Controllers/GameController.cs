using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PBYD___PlayBeforeYouDie.Models;
using PlayBeforeYouDie.Core.Contracts;

namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private readonly IGameService gameService;
        private readonly ILogger logger;


        public GameController
            (
            ILogger<GameController> _logger,
            IGameService _gameService
            )
        {
            logger = _logger;
            gameService = _gameService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> AllGames([FromQuery]AllGamesQueryModel query)
        {
            var result = await gameService.All(
                query.SearchGame,
                query.CurrentPage,
                AllGamesQueryModel.HousesPerPage);

            query.TotalGamesCount = result.TotalGamesCount;
            query.Games = result.Games;

            return View(query);
        }
    }
}
