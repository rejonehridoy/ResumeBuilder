using Microsoft.AspNetCore.Mvc;
using Nop.Core.Infrastructure;
using Service.Users.Interfaces;
using Web.Areas.Admin.ViewModels;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{Controller}/{action}")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult List()
        {
            var model = new UserViewModel();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int id)
        {
            return Content("User id: " + id);
        }
        public async Task<IActionResult> GetUsers()
        {
            var users = await userService.GetAllUsersAsync();
            return Ok(users);
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
