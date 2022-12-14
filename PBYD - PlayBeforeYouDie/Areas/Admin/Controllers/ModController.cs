using Microsoft.AspNetCore.Mvc;
using PBYD___PlayBeforeYouDie.Areas.Admin.Models.Mod;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Mod;

namespace PBYD___PlayBeforeYouDie.Areas.Admin.Controllers
{
    public class ModController : BaseController
    {
        private readonly ILogger logger;
        private readonly IModService modService;
        

        public ModController(ILogger<ModController> _logger, IModService _modService)
        {
            logger = _logger;
            modService = _modService;
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (await modService.Exists(id) == false)
            {
                TempData["ErrorMessage"] = "Wrong mod id!";

                return RedirectToAction();
            }

            try
            {
                var mod = await modService.DeleteModById(id);

                var model = new ModDeleteViewModel()
                {
                    ModName = mod.ModName,
                    Description = mod.Description,
                    DownloadModLink = mod.DownloadModLink
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
        public async Task<IActionResult> Delete(int id, ModModel model)
        {
            if (await modService.Exists(id) == false)
            {
                TempData["ErrorMessage"] = "Wrong mod id!";

                return RedirectToAction();
            }

            try
            {
                await modService.DeleteMod(id);

                return RedirectToAction("ModsGame");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Database is down or mods does not exists");

                return View();
            }

            
        }
    }
}
