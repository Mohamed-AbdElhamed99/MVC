using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            return View("Home");
        }

        public IActionResult Shop()
        {
            return View("Shop");
        }

        public IActionResult Details()
        {
            return View("Details");
        }
        public IActionResult Cart()
        {
            return View("Cart");
        }

        public IActionResult Checkout()
        {
            return View("Checkout");
        }
    }
}
