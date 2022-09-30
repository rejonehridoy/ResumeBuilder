using Data.Users;
using Microsoft.AspNetCore.Mvc;
using Nop.Core.Infrastructure;
using Service.Common.Interfaces;
using Service.Files.Interfaces;
using Service.Users.Interfaces;
using Web.Areas.Admin.Factory;
using Web.Areas.Admin.Models.Users;
using Web.Areas.Admin.ViewModels;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{Controller}/{action}")]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly IUserModelFactory userModelFactory;
        private readonly IFileService fileService;
        private readonly IWorkContext workContext;

        public UserController(IUserService userService,
            IUserModelFactory userModelFactory,
            IFileService fileService,
            IWorkContext workContext)
        {
            this.userService = userService;
            this.userModelFactory = userModelFactory;
            this.fileService = fileService;
            this.workContext = workContext;
        }
        public IActionResult List()
        {
            var model = new UserSearchModel();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var model = new UserModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(UserModel model,string save)
        {
            if(model != null)
            {
                model.ModelError = new List<string>();

                if (await userService.IsUserExistByEmailAsync(model.Email))
                {
                    model.ModelError.Add("Email already exist");
                    return View(model);
                }
                try
                {
                    Guid id = Guid.NewGuid();
                    User user = new User
                    {
                        Name = model.Name,
                        Email = model.Email,
                        Username = model.Username,
                        Guid = id.ToString(),
                        Active = model.Active,
                        UserRole = model.UserRole,
                        Gender = model.Gender,
                        DateOfBirth = model.DateOfBirth,
                        Deleted = false,
                        LastIpAddress = workContext.GetCurrentClientIpAddress(),
                        PictureId = model.PictureFile != null ? await fileService.SavePictureFileAsync(model.PictureFile) : null,
                    };
                    var userId = await userService.CreateNewUserAsync(user);
                    if(userId <= 0)
                    {
                        model.ModelError.Add("Account can't be created");
                        return View(model);
                    }
                    if(await userService.CreateUserHashedPasswordAsync(userId, model.Password))
                        return save.Equals("save") ? RedirectToAction("List") : RedirectToAction("Edit", new { id = userId });
                    else
                    {
                        model.ModelError.Add("Couldn't create password");
                        return View(model);
                    }
                }
                catch(Exception ex)
                {
                    model.ModelError.Add(ex.Message);
                    return View(model);
                }
                
            }
            else
            {
                model = new UserModel();
                model.ModelError = new List<string>();
                model.ModelError.Add("Invalid Action Occured. Please try again");
                return View(model);
            }
        }
        public async Task<IActionResult> GetUsers(UserSearchModel searchModel)
        {
            var model = await userModelFactory.PrepareUserViewModelAsync(searchModel);
            
            return Ok(model);
        }
        public async Task<IActionResult> EditUser(int id)
        {
            return Content("Edit User");
        }
        public async Task<IActionResult> DeleteUser(int id)
        {
            return Content("Delete User");
        }
    }
}
