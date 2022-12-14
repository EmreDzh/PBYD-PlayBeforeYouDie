using Microsoft.AspNetCore.Mvc;
using PBYD___PlayBeforeYouDie.Areas.Admin.Models.HowLongToBeat;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.HowLongToBeat;

namespace PBYD___PlayBeforeYouDie.Areas.Admin.Controllers
{
    public class HowLongToBeatController : BaseController
    {
        private readonly ILogger logger;
        private readonly IHowLongToBeatService howLongToBeat;
        

        public HowLongToBeatController(
            ILogger<HowLongToBeatController> _logger, IHowLongToBeatService _howLongToBeat)
        {
            logger = _logger;
            howLongToBeat = _howLongToBeat;
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (await howLongToBeat.Exists(id) == false)
            {
                TempData["ErrorMessage"] = "Wrong how long to beat id";

                return RedirectToAction();
            }

            try
            {
                var howLongToBeat = await this.howLongToBeat.DeleteHowLongToBeatById(id);

                var model = new HowLongToBeatDeleteViewModel()
                {
                    MainStory = howLongToBeat.MainStory,
                    HundredPercentComplete = howLongToBeat.HundredPercentComplete,
                    MainPlusSides = howLongToBeat.MainPlusSides
                };

                return View(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Database is down or mods does not exists");

                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, HowLongToBeatModel model)
        {
            if (await howLongToBeat.Exists(id) == false)
            {
                TempData["ErrorMessage"] = "Wrong how long to beat id";

                return RedirectToAction();
            }

            try
            {
                await howLongToBeat.DeleteHowLongToBeat(id);

                return RedirectToAction("HowLongGame");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Database is down or mods does not exists");

                return View();
            }
        }
    }
}
