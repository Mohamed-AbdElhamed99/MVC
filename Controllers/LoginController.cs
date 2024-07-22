using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult Add(string username , string email , bool remember_me)
        {
            HttpContext.Session.SetString("username" , username);
            HttpContext.Session.SetString("email", email);

            return RedirectToAction("Index" , "Home");
        }
    }
}
