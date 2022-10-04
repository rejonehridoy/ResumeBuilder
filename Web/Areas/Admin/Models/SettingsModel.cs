using Core.Settings;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Areas.Admin.Models
{
    public class SettingsModel
    {
        public UserSettings UserSettings { get; set; }
        public PasswordAndSecuritySettings PasswordAndSecuritySettings { get; set; }
        public AccountSettings AccountSettings { get; set; }
        public CachingSettings CachingSettings { get; set; }
        public List<SelectListItem> AvailableTimeZones { get; set; }
    }
}
