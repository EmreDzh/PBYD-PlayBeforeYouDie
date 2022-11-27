using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PlayBeforeYouDie.Core.Constants.Core;

namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        public string UserName
        {
            get
            {
                string firstName = string.Empty;

                if (User?.Identity?.IsAuthenticated ?? false && User.HasClaim(c => c.Type == UserConstants.UserName))
                {
                    firstName = User.Claims
                        .FirstOrDefault(c => c.Type == UserConstants.UserName)
                        ?.Value ?? firstName;
                }

                return firstName;
            }
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                ViewBag.UserName = UserName;
            }

            base.OnActionExecuted(context);
        }
    }
}
