using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace PBYD___PlayBeforeYouDie.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[Action]/{id?}")]
    [Authorize(Roles = "Administrator")]
    public class BaseController : Controller
    {
        
    }
}
