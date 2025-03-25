using ExploreSV.BusinessLogic.UseCases.Users.Queries.UserAuthentication;
using Microsoft.AspNetCore.Mvc;

namespace ExploreSV.WebApplication.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserAuthentication _userAuthentication;

        public LoginController(UserAuthentication userAuthentication)
        {
            _userAuthentication = userAuthentication;
        }

        [HttpGet]
        public IActionResult LoginView()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginView(string name, string password)
        {
            var user = await _userAuthentication.AuthenticateAsync(name, password);

            if (user != null)
            {
                // Iniciar sesión (esto puede mejorar con cookies o autenticación de identidad)
                HttpContext.Session.SetString("UserName", user.UserName);
                return RedirectToAction("Index", "Home"); // Redirige al home después del login
            }

            ViewBag.Error = "Usuario o contraseña incorrectos.";
            return View();
        }
    }
}
