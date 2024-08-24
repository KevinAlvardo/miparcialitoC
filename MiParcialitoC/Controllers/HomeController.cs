using Microsoft.AspNetCore.Mvc;

namespace AM101820Login.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Index()
        {
            return RedirectToAction("Login");
        }
    }
}
