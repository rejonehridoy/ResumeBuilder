using Core;
using Core.Enums;
using Data.Files;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Areas.Admin.ViewModels
{
    public class UserViewModel : BaseModel
    {
        public string? Uid { get; set; }
        public string? Guid { get; set; }

        public string Name { get; set; }

        public string? Username { get; set; }

        public string Email { get; set; }

        public bool Active { get; set; }

        public bool Deleted { get; set; }

        public bool ExternalLogin { get; set; }

        public string? LastIpAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastActivityDate { get; set; }
        public int? UserRole { get; set; }
        public int? PictureId { get; set; }
        public List<SelectListItem> AvailableActiveTypes { get; set; } = new List<SelectListItem> {
                new SelectListItem()
                {
                    Text = "",
                    Value = "0",
                    Selected = true
                },
                new SelectListItem()
                {
                    Text = "Registerd",
                    Value = "1"
                },
                new SelectListItem()
                {
                    Text = "Admin",
                    Value = "2"
                }
         };
    }
}
