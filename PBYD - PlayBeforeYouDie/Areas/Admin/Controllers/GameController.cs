using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PBYD___PlayBeforeYouDie.Areas.Admin.Models;
using PBYD___PlayBeforeYouDie.Areas.Admin.Models.Game;
using PBYD___PlayBeforeYouDie.Models;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Game;

namespace PBYD___PlayBeforeYouDie.Areas.Admin.Controllers
{
    public class GameController : BaseController
    {
        private readonly IGameService gameService;

        public GameController(IGameService _gameService)
        {
            gameService = _gameService;
        }

        [HttpGet]
        public async Task<IActionResult> AllGames([FromQuery] AdminGamesViewModel query)
        {
            try
            {
                var result = await gameService.All(query.Genre,
                    query.SearchGame,
                    query.CurrentPage,
                    AdminGamesViewModel.HousesPerPage);

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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (await gameService.Exists(id) == false)
            {
                TempData["ErrorMessage"] = "Wrong game id!";

                return RedirectToAction(nameof(AllGames));
            }

            var game = await gameService.GameEditModelById(id);
            var genreId = await gameService.GetGameGenreById(id);

            var model = new GameModel()
            {
                Id = game.Id,
                GameTitle = game.GameTitle,
                Rating = game.Rating,
                Summary = game.Summary,
                ImageUrl = game.ImageUrl,
                GenreId = genreId,
                Genres = await gameService.AllGenres()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, GameModel model)
        {
            if (id != model.Id)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if (await gameService.Exists(model.Id) == false)
            {
                ModelState.AddModelError("", "Database is down or games does not exists");
                model.Genres = await gameService.AllGenres();

                return View(model);
            }

            if (await gameService.GenreExists(model.GenreId) == false)
            {
                ModelState.AddModelError("", "Database is down or genre does not exists");

                model.Genres = await gameService.AllGenres();

                return View(model);
            }

            if (ModelState.IsValid == false)
            {
                TempData["ErrorMessage"] = "Wrong model!";
                model.Genres = await gameService.AllGenres();

                return View(model);
            }

            await gameService.EditGame(model, model.Id);

            return RedirectToAction(nameof(AllGames), new { id = model.Id });
        }

        [HttpGet]
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
