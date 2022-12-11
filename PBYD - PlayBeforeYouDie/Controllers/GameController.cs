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
            try
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
            catch (Exception)
            {
                ModelState.AddModelError("", "Database is down or games does not exists");

                return View(nameof(AllGames));
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> AddToCollection(int id)
        {
            if (await gameService.Exists(id) == false)
            {
                TempData["ErrorMessage"] = "Wrong game id!";
                return RedirectToAction(nameof(AllGames));
            }

            try
            {
                await gameService.AddGameToMyLibrary(id, User.Id());

                return RedirectToAction("MyGamesLibrary", "Game");
            }
            catch (Exception)
            {
                ModelState.AddModelError(nameof(id), "System Requirements does not exists");

                return RedirectToAction(nameof(AllGames));
            }

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
                TempData["ErrorMessage"] = "Wrong model!";
                
                model.Genres = await gameService.AllGenres();
                
                return View(model);
            }

            try
            {
                await gameService.AddGame(model);

                return RedirectToAction(nameof(AllGames));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Database is down or games does not exists");

                return View(nameof(AllGames));
            }
           
            
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> MyGamesLibrary()
        {
            try
            {
                var userId = User.Id();
                var model = await gameService.GetMyLibraryAsync(userId);

                return View("MyGamesLibrary", model);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Database is down or games does not exists");

                return View(nameof(AllGames));
            }
            
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> RemoveGameLibrary(int id)
        {
            if (await gameService.Exists(id) == false)
            {
                TempData["ErrorMessage"] = "Wrong game id!";

                return RedirectToAction(nameof(AllGames));
            }

            try
            {
                await gameService.RemoveGameFromLibrary(id, User.Id());

                return RedirectToAction(nameof(MyGamesLibrary));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Database is down or games does not exists");

                return View(nameof(AllGames));
            }
            
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int id)
        {
            if (await gameService.Exists(id) == false)
            {
                TempData["ErrorMessage"] = "Wrong game id!";

                return RedirectToAction(nameof(AllGames));
            }

            try
            {
                var game = await gameService.DeleteGameById(id);
                var model = new GameDeleteViewModel()
                {
                    GameTitle = game.GameTitle,
                    ImageUrl = game.ImageUrl,
                    Description = game.Summary,
                    Rating = game.Rating
                };

                return View(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Database is down or games does not exists");

                return View(nameof(AllGames));
            }

            
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int id, GameServiceModel model)
        {
            if (await gameService.Exists(id) == false)
            {
                TempData["ErrorMessage"] = "Wrong game id!";

                return RedirectToAction(nameof(AllGames));
            }

            try
            {
                await gameService.DeleteGame(id);

                return RedirectToAction(nameof(AllGames));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Database is down or games does not exists");

                return View(nameof(AllGames));
            }

            
        }
    }
}
