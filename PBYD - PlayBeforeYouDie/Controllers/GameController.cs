using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PBYD___PlayBeforeYouDie.Extensions;
using PBYD___PlayBeforeYouDie.Models;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Game;
using PlayBeforeYouDie.Core.Models.SystemRequirement;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private readonly IGameService gameService;
        private readonly ISystemRequirementsService systemRequirementsService;
        private readonly ILogger logger;



        public GameController
            (
            ILogger<GameController> _logger,
            IGameService _gameService,
            ISystemRequirementsService _systemRequirementsService
            )
        {
            logger = _logger;
            gameService = _gameService;
            systemRequirementsService = _systemRequirementsService;
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

            return RedirectToAction("MyGamesLibrary", "Game");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Add()
        {
            var model = new AddGameModel()
            {
                Genres = await gameService.AllGenres(),
                
            };
            
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Add(AddGameModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Genres = await gameService.AllGenres();
                

                return View(model);
            }

            if (await systemRequirementsService.SystemRequirementsExists(model.SystemRequirementId) == false)
            {
                ModelState.AddModelError(nameof(model.SystemRequirementId), "System Requirements does not exists");
            }

            await gameService.AddGame(model);

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

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int id)
        {
            if (await gameService.Exists(id) == false)
            {
                return RedirectToAction(nameof(AllGames));
            }

            var game = await gameService.DeleteGameById(id);
            var model = new GameDeleteViewModel()
            {
                GameTitle = game.GameTitle,
                ImageUrl = game.ImageUrl,
                Description = game.Summary
            };
            
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int id, GameServiceModel model)
        {
            if (await gameService.Exists(id) == false)
            {
                return RedirectToAction(nameof(AllGames));
            }

            await gameService.DeleteGame(id);

            return RedirectToAction(nameof(AllGames));
        }
    }
}
