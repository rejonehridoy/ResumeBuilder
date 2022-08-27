using Microsoft.AspNetCore.Mvc;
using Nop.Core.Infrastructure;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{Controller}/{action}")]
    public class UserController : Controller
    {
        public IActionResult List()
        {
            return Content("Admin user index page");
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
    }
}
