using Microsoft.AspNetCore.Mvc;
using Web.Areas.Admin.Factory;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Settings")]
    public class SettingsController : Controller
    {
        private readonly ISettingsModelFactory settingsModelFactory;

        public SettingsController(ISettingsModelFactory settingsModelFactory)
        {
            this.settingsModelFactory = settingsModelFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var settingsModel = new SettingsModel();
            settingsModel.AvailableTimeZones = await settingsModelFactory.PrepareTimeZonesList();
            return View(settingsModel);
        }

        [HttpPost]
        public IActionResult Index(SettingsModel model)
        {
            return View(model);
        }
    }
}
