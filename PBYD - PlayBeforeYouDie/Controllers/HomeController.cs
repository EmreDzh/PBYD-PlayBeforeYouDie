using Microsoft.AspNetCore.Mvc;
using PBYD___PlayBeforeYouDie.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private readonly ILogger logger;

        public HomeController(ILogger<HomeController> _logger)
        {
            logger = _logger;
        }
        
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

    }
}