using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlayBeforeYouDie.Core.Contracts;

namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class GameOfTheYearController : Controller
    {
        private readonly IGameOfTheYearService gameOfTheYearService;

        public GameOfTheYearController(IGameOfTheYearService _gameOfTheYearService)
        {
            gameOfTheYearService = _gameOfTheYearService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GotyAllView()
        {
            try
            {
                var model = await gameOfTheYearService.GetAllGotyAsync();

                return View(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Database is down or game of the year does not exists");
                
                return View("_Layout", "Index");
            }
            
        }
    }
}
