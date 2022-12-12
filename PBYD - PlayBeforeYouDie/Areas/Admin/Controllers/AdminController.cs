using Microsoft.AspNetCore.Mvc;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Service;

namespace PBYD___PlayBeforeYouDie.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IGameService gameService;

        public AdminController(IGameService _gameService)
        {
            gameService = _gameService;
        }

        public async Task<ActionResult> Index()
        {
            var model = await gameService.GetInitialGames();

            return View(model);
        }
    }
}
