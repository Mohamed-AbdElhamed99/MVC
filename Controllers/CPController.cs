using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class CPController : Controller
    {
        public IActionResult Index()
        {
            return View("Home");
        }

        public IActionResult blank()
        {
            return View("Blank");
        }


    }
}
