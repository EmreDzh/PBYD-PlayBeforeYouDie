using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PBYD___PlayBeforeYouDie.Models;
using PlayBeforeYouDie.Core.Models;
using PlayBeforeYouDie.Core.Models.Users;
using PlayBeforeYouDie.Infrastructure.Data.Models.Users;

namespace PBYD___PlayBeforeYouDie.Controllers
{
    [Authorize]
    public class UserController : Controller
    {

        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly ILogger logger;

        public UserController(
            UserManager<ApplicationUser> _userManager,
            SignInManager<ApplicationUser> _signInManager,
            ILogger<UserController> _logger
            )
        {
            userManager = _userManager;
            signInManager = _signInManager;
            logger = _logger;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new RegisterModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new ApplicationUser()
            {
                Email = model.Email,
                UserName = model.UserName
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {

                return RedirectToAction("Login", "User");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new LoginModel();

            return View(model);
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Invalid login");

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }


        //TODO: IMPLEMENT LATER IF YOU STILL GOT TIME LEFT!
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return View("Error");
            }

            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }

            var result = await userManager.ConfirmEmailAsync(user, token);
            return View(result.Succeeded ? "ConfirmEmail" : "Error");

        }
    }
}
