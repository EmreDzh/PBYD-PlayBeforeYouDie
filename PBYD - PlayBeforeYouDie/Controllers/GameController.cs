using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private readonly ILogger logger;

        public GameController(ILogger<GameController> _logger)
        {
            logger = _logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
