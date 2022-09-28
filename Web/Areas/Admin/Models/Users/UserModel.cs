using Core;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Web.Areas.Admin.Models.Users
{
    public class UserModel : BaseModel
    {
        public string? Uid { get; set; }
        public string? Guid { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Username { get; set; }
        [Required]
        public string Email { get; set; }
        public string? Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth{ get; set; }

        public bool Active { get; set; }

        public bool Deleted { get; set; }

        public bool ExternalLogin { get; set; }

        public string? LastIpAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastActivityDate { get; set; }
        [Required]
        public int UserRole { get; set; }
        public string SelectRole { get; set; }
        public int? PictureId { get; set; }
        public IFormFile PictureFile { get; set; }
        public UserPasswordModel PasswordModel { get; set; } = new UserPasswordModel();
        public List<SelectListItem> AvailableActiveTypes { get; set; } = new List<SelectListItem> {
                new SelectListItem()
                {
                    Text = "",
                    Value = "0",
                    Selected = true
                },
                new SelectListItem()
                {
                    Text = "Active",
                    Value = "1"
                },
                new SelectListItem()
                {
                    Text = "Inactive",
                    Value = "2"
                }
         };
        public List<SelectListItem> AvailableUserRoles { get; set; } = new List<SelectListItem> {
                new SelectListItem()
                {
                    Text = "",
                    Value = "",
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

        public List<SelectListItem> AvailableGender { get; set; } = new List<SelectListItem> {
                new SelectListItem()
                {
                    Text = "",
                    Value = "",
                    Selected = true
                },
                new SelectListItem()
                {
                    Text = "Male",
                    Value = "Male"
                },
                new SelectListItem()
                {
                    Text = "Female",
                    Value = "Female"
                },
                new SelectListItem()
                {
                    Text = "Other",
                    Value = "Other"
                }
         };
    }
}
