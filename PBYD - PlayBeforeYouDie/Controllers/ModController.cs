using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Mod;
using PlayBeforeYouDie.Infrastructure.Data.Models;


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
        public async Task<IActionResult> ModsGame(int id)
        {
            if (await gameService.Exists(id) == false)
            {
                TempData["ErrorMessage"] = "Wrong game id!";
                
                return RedirectToAction("AllGames", "Game");
            }

            try
            {
                var model = await modService.ModsByGameById(id);

                return View(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(nameof(id), "Game id does not exists");

                return View(nameof(ModsView));
            }

            
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Create(int gameId)
        {
            if (await gameService.Exists(gameId) == false)
            {
                TempData["ErrorMessage"] = "Wrong game id!";
                return RedirectToAction("AllGames", "Game");
            }

            try
            {
                var model = new ModModel();

                model.GameId = gameId;

                return View(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(nameof(gameId), "Game id does not exists");

                return View(nameof(ModsView));
            }

            
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create(ModModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Wrong model!";
                return View(model);
            }

            try
            {
                await modService.SubmitMod(model);

                return RedirectToAction(nameof(ModsGame), new { id = model.GameId });
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Game model does not exists");

                return View(nameof(ModsView));
            }
            
        }
    }
}
