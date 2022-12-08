using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Mod;


namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class ModController : Controller
    {
        private readonly ILogger logger;
        private readonly IModService modService;
        private readonly IGameService gameService;

        public ModController(ILogger<ModController> _logger, IModService _modService, IGameService _gameService)
        {
            logger = _logger;
            modService = _modService;
            gameService = _gameService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> ModsView()
        {
            var model = await gameService.GetInitialGames();

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ModsGame(int id, ModModel modModel)
        {
            if (await gameService.Exists(id) == false)
            {
                return RedirectToAction("AllGames", "Game");
            }

            var model = await modService.ModsByGameById(id);

            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Create(int gameId)
        {
            var model = new ModModel();

            model.GameId = gameId;

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create(ModModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await modService.SubmitMod(model);

            return RedirectToAction(nameof(ModsGame), new { id = model.Id });
        }
    }
}
