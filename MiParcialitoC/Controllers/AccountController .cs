using Microsoft.AspNetCore.Mvc;
using LoginApp.Models;

namespace LoginApp.Controllers
{
    public class AccountController : Controller
    {
        // Acción para mostrar la vista de Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Acción para manejar el envío del formulario
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Simulación del proceso de login
                if (model.Email == "gerardo@gmail.com" && model.Password == "123")
                {
                    // Simula el inicio de sesión correcto
                    return RedirectToAction("Menu");
                }
                else
                {
                    ViewBag.Error = "Invalid email or password.";
                }
            }
            return View(model);
        }

        // Acción que simula mostrar el menú del aplicativo después de iniciar sesión
        public IActionResult Menu()
        {
            return View();
        }
    }
}
