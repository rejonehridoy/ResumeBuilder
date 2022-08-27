using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        public IActionResult Login()
        {
            return Content("This is login page");
        }

        [Route("logout")]
        public IActionResult Logout()
        {
            return Content("This is logout page");
        }

    }
}
