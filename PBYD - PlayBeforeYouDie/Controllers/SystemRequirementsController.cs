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
                return RedirectToAction("AllGames", "Game");
            }

            var model = await systemRequirementsService.SystemRequirementsGameById(id);

            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Edit(int systemRequirementsId)
        {
            if (await systemRequirementsService.SystemRequirementsExists(systemRequirementsId) == false)
            {
                return RedirectToAction(nameof(SystemRequirementsGame));
            }
            
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

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Edit(SystemRequirementsModel model, int systemRequirementsId)
        {
            if (await systemRequirementsService.SystemRequirementsExists(systemRequirementsId) == false)
            {
                return RedirectToAction(nameof(SystemRequirementsGame));
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            

            await systemRequirementsService.Edit(model.Id = systemRequirementsId, model);

            return RedirectToAction(nameof(SystemRequirementsGame), new { id = model.Id });
        }
    }
}
