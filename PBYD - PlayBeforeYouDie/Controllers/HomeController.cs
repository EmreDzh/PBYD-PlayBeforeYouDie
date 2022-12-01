using Microsoft.AspNetCore.Mvc;
using PBYD___PlayBeforeYouDie.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using PlayBeforeYouDie.Core.Constants.Core.AdminAreaConstants;

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
            if (User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction("Index", "Admin", new { area = "Admin" });
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}