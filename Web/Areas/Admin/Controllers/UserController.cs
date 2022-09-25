using Microsoft.AspNetCore.Mvc;
using Nop.Core.Infrastructure;
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

        public UserController(IUserService userService,
            IUserModelFactory userModelFactory,
            IFileService fileService)
        {
            this.userService = userService;
            this.userModelFactory = userModelFactory;
            this.fileService = fileService;
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
        public async Task<IActionResult> Create(UserModel model)
        {
            int pictureId = 0;
            if(model != null && model.PictureFile != null)
            {
                pictureId = await fileService.SavePictureFileAsync(model.PictureFile);
            }
            return Content("User id:" + pictureId.ToString());
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
