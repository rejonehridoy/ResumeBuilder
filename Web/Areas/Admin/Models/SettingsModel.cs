using Core;
using Core.Settings;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Areas.Admin.Models
{
    public class SettingsModel : BaseModel
    {
        public UserSettings UserSettings { get; set; }
        public PasswordAndSecuritySettings PasswordAndSecuritySettings { get; set; }
        public AccountSettings AccountSettings { get; set; }
        public CachingSettings CachingSettings { get; set; }
        public CommonSettings CommonSettings { get; set; }
        public List<SelectListItem> AvailableTimeZones { get; set; }
        public List<SelectListItem> AvailablePasswordFormats { get; set; }
        public List<SelectListItem> AvailableCachingPriority { get; set; }
    }
}
