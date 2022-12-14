using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PBYD___PlayBeforeYouDie.Extensions;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Game;
using PlayBeforeYouDie.Core.Models.HowLongToBeat;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class HowLongToBeatController : Controller
    {

        private readonly ILogger logger;
        private readonly IHowLongToBeatService howLongToBeat;
        private readonly IGameService gameService;

        public HowLongToBeatController(
            ILogger<HowLongToBeatController> _logger, IHowLongToBeatService _howLongToBeat, IGameService _gameService)
        {
            logger = _logger;
            howLongToBeat = _howLongToBeat;
            gameService = _gameService;
        }

        [AllowAnonymous]
        public async  Task<IActionResult> HowLongToBeatView()
        {

            var model = await gameService.GetInitialGames();

            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> HowLongGame(int id)
        {
            if (await gameService.Exists(id) == false)
            {
                TempData["ErrorMessage"] = "Wrong game id!";
                return RedirectToAction("AllGames", "Game");
            }

            try
            {
                var model = await howLongToBeat.GameHowLongToBeatById(id);

                return View(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(nameof(id), "Game id does not exists");

                return View(nameof(HowLongToBeatView));
            }

            
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Submit(int gameId)
        {
            if (await gameService.Exists(gameId) == false)
            {
                TempData["ErrorMessage"] = "Wrong game id!";

                return RedirectToAction("AllGames", "Game");
            }

            try
            {
                var model = new HowLongToBeatModel();

                model.GameId = gameId;

                return View(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(nameof(gameId), "Game id does not exists");

                return View(nameof(HowLongGame));
            }

            
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Submit(HowLongToBeatModel model)
        {
            
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Wrong model";
                return View(model);
            }

            try
            {
                await howLongToBeat.SubmitPlayTime(model);

                return RedirectToAction(nameof(HowLongGame), new { id = model.GameId });
            }

            catch (Exception)
            {
                ModelState.AddModelError("", "Game model does not exists");

                return View(nameof(HowLongGame));
            }

            

        }
    }
}
