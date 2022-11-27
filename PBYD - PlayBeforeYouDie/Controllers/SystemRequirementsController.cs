using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class SystemRequirementsController : Controller
    {
        private readonly ILogger logger;

        public SystemRequirementsController(ILogger<SystemRequirementsController> _logger)
        {
            logger = _logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
