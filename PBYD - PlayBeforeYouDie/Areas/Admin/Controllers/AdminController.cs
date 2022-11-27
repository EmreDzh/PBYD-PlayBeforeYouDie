using Microsoft.AspNetCore.Mvc;

namespace PBYD___PlayBeforeYouDie.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
