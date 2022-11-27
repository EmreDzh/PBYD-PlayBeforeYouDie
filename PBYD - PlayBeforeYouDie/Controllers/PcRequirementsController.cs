using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class PcRequirementsController : Controller
    {
        private readonly ILogger logger;

        public PcRequirementsController(ILogger<PcRequirementsController> _logger)
        {
            logger = _logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
