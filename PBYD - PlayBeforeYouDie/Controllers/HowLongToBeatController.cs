using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PBYD___PlayBeforeYouDie.Extensions;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Game;
using PlayBeforeYouDie.Core.Models.HowLongToBeat;

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
                return RedirectToAction("AllGames", "Game");
            }

            var model = await howLongToBeat.GameHowLongToBeatById(id);

            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Submit()
        {
            var model = new HowLongToBeatModel();

            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Submit(HowLongToBeatModel model, int ids)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
           // int howLongToBeatId = await howLongToBeat.GetHowLongToBeatId();

            int id = await howLongToBeat.SubmitPlayTime(model, 0);

            return RedirectToAction(nameof(HowLongGame), new
            {
                id
            });
        }
    }
}
