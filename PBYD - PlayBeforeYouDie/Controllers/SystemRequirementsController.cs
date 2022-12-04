using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlayBeforeYouDie.Core.Contracts;
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
    }
}
