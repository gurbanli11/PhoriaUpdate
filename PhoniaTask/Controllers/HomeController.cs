using Microsoft.AspNetCore.Mvc;

namespace PhoniaTask.Controllers
{
    public class HomeController : Controller
    {
        public async Task< IActionResult> Index()
        {
            return View();
        }
    }
}
