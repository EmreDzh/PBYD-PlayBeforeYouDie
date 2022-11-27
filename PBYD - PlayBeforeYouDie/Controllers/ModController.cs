using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class ModController : Controller
    {
        private readonly ILogger logger;

        public ModController(ILogger<ModController> _logger)
        {
            logger = _logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
