using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PBYD___PlayBeforeYouDie.Extensions;
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
            var result = await gameService.All(query.Genre,
                query.SearchGame,
                query.CurrentPage,
                AllGamesQueryModel.HousesPerPage);

            query.TotalGamesCount = result.TotalGamesCount;
            query.Genres = await gameService.AllGenreNames();
            query.Games = result.Games;

            return View(query);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> AddToCollection(int id)
        {
            if (await gameService.Exists(id) == false)
            {
                return RedirectToAction(nameof(AllGames));
            }

            await gameService.AddGameToMyLibrary(id, User.Id());

            return RedirectToAction(nameof(AllGames));
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> MyGamesLibrary()
        {
            var userId = User.Id();
            var model = await gameService.GetMyLibraryAsync(userId);

            return View("MyGamesLibrary", model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> RemoveGameLibrary(int id)
        {
            if (await gameService.Exists(id) == false)
            {
                return RedirectToAction(nameof(AllGames));
            }

            await gameService.RemoveGameFromLibrary(id, User.Id());

            return RedirectToAction(nameof(MyGamesLibrary));
        }
    }
}
