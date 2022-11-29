using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlayBeforeYouDie.Core.Contracts;

namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private readonly IGameService gameService;
        private readonly ILogger logger;


        public GameController
            (
            ILogger<GameController> _logger,
            IGameService _gameService
            )
        {
            logger = _logger;
            gameService = _gameService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var result = await gameService.GetAll();

            return View(result);
        }
    }
}
