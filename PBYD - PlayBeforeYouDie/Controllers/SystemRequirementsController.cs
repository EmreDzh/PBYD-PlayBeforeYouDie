using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.SystemRequirement;
using PlayBeforeYouDie.Core.Service;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class SystemRequirementsController : Controller
    {
        private readonly ILogger logger;
        private readonly ISystemRequirementsService systemRequirementsService;
        private readonly IGameService gameService;

        public SystemRequirementsController(ILogger<SystemRequirementsController> _logger,
            ISystemRequirementsService _systemRequirementsService,
            IGameService _gameService)
        {
            logger = _logger;
            systemRequirementsService = _systemRequirementsService;
            gameService = _gameService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> SystemRequirementsGame(int id)
        {
            if (await gameService.Exists(id) == false)
            {
                TempData["ErrorMessage"] = "Wrong game id!";
                
                return RedirectToAction("AllGames", "Game");
            }

            try
            {
                var model = await systemRequirementsService.SystemRequirementsGameById(id);

                return View(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(nameof(id), "game id does not exists");

                return View("_Layout");
            }

            
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Edit(int systemRequirementsId)
        {
            if (await systemRequirementsService.SystemRequirementsExists(systemRequirementsId) == false)
            {
                TempData["ErrorMessage"] = "Wrong systemRequirements id!";

                return RedirectToAction(nameof(SystemRequirementsGame));
            }

            try
            {
                var game = await systemRequirementsService.SystemRequirementsDetailsById(systemRequirementsId);

                var model = new SystemRequirementsModel()
                {
                    Os = game.Os,
                    Graphics = game.Os,
                    Memory = game.Memory,
                    Processor = game.Processor,
                    Network = game.Network,
                    Storage = game.Storage,
                    AdditionalNotes = game.AdditionalNotes
                };

                return View(model);
            }
            catch (Exception e)
            {
                ModelState.AddModelError(nameof(systemRequirementsId), "System Requirements id does not exists or game is empty");

                return View(nameof(SystemRequirementsGame));
            }
            
            
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Edit(SystemRequirementsModel model, int systemRequirementsId)
        {
            if (await systemRequirementsService.SystemRequirementsExists(systemRequirementsId) == false)
            {
                TempData["ErrorMessage"] = "Wrong systemRequirements id!";
                
                return RedirectToAction(nameof(SystemRequirementsGame));
            }

            if (ModelState.IsValid == false)
            {
                TempData["ErrorMessage"] = "Wrong model!";
                
                return View(model);
            }

            try
            {
                await systemRequirementsService.Edit(model.Id = systemRequirementsId, model);

                return RedirectToAction(nameof(SystemRequirementsGame));
            }
            catch (Exception)
            {
                ModelState.AddModelError(nameof(systemRequirementsId), "System Requirements id does not exists");

                return View(nameof(SystemRequirementsGame));
            }

        }
    }
}
