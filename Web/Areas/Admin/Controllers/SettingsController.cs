using Core.Settings;
using Data.Settings;
using Microsoft.AspNetCore.Mvc;
using Service.Common.Interfaces;
using Web.Areas.Admin.Factory;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Settings")]
    public class SettingsController : Controller
    {
        #region Fields
        private readonly ISettingsModelFactory settingsModelFactory;
        private readonly IWorkContext workContext;
        private readonly ISettingService settingService;
        #endregion

        #region Ctor
        public SettingsController(ISettingsModelFactory settingsModelFactory,
            IWorkContext workContext,
            ISettingService settingService)
        {
            this.settingsModelFactory = settingsModelFactory;
            this.workContext = workContext;
            this.settingService = settingService;
        }
        #endregion

        #region Methods
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var settingsModel = new SettingsModel();
            settingsModel.UserSettings = await settingService.LoadSettingAsync<UserSettings>();
            settingsModel.AccountSettings = await settingService.LoadSettingAsync<AccountSettings>();
            settingsModel.PasswordAndSecuritySettings = await settingService.LoadSettingAsync<PasswordAndSecuritySettings>();
            settingsModel.CachingSettings = await settingService.LoadSettingAsync<CachingSettings>();
            settingsModel.CommonSettings = await settingService.LoadSettingAsync<CommonSettings>();
            settingsModel.AvailableTimeZones = workContext.GetAllTimeZones();
            settingsModel.AvailablePasswordFormats = await settingsModelFactory.PreparePassowrdFormatTypeItemsAsync();
            settingsModel.AvailableCachingPriority = await settingsModelFactory.PrepareCachingPriorityItemsAsync();
            return View(settingsModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(SettingsModel model)
        {
            var userSettings = model.UserSettings;
            var accountSettings = model.AccountSettings;
            var passowrdSecuritySettings = model.PasswordAndSecuritySettings;
            var cacheSettings = model.CachingSettings;
            model.CommonSettings = await settingService.LoadSettingAsync<CommonSettings>();
            await settingService.SaveSettingAsync(userSettings);
            await settingService.SaveSettingAsync(accountSettings);
            await settingService.SaveSettingAsync(passowrdSecuritySettings);
            await settingService.SaveSettingAsync(cacheSettings);
            model.SuccessMessage = new List<string> { "Successfully Saved" };
            model.AvailableTimeZones = workContext.GetAllTimeZones();
            model.AvailablePasswordFormats = await settingsModelFactory.PreparePassowrdFormatTypeItemsAsync();
            model.AvailableCachingPriority = await settingsModelFactory.PrepareCachingPriorityItemsAsync();
            return View(model);
        }

        [HttpGet("SaveTabSetting")]
        public async Task<IActionResult> SaveTabSettings(string key, string oldValue)
        {
            if(!string.IsNullOrEmpty(oldValue) && oldValue.ToLower().Equals("true"))
            {
                await settingService.CreateOrUpdateSettingsByKeyAsync(key, "False");
                return Ok("False");
            }
            else if (!string.IsNullOrEmpty(oldValue) && oldValue.ToLower().Equals("false"))
            {
                await settingService.CreateOrUpdateSettingsByKeyAsync(key, "True");
                return Ok("True");
            }
            return BadRequest();
        }
        #endregion
    }
}
