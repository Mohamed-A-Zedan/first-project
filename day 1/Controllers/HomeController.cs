using Microsoft.AspNetCore.Mvc;

namespace day_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
