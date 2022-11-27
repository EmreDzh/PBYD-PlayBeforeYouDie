using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class HowLongToBeatController : Controller
    {

        private readonly ILogger logger;

        public HowLongToBeatController(ILogger<HowLongToBeatController> _logger)
        {
            logger = _logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
