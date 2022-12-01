using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using PlayBeforeYouDie.Core.Constants.Core.AdminAreaConstants;

namespace PBYD___PlayBeforeYouDie.Areas.Admin.Controllers
{
    [Area(AdminConstants.AreaName)]
    [Route("Admin/[controller]/[Action]/{id?}")]
    [Authorize(Roles = AdminConstants.AdminRoleName)]
    public class BaseController : Controller
    {
        
    }
}
