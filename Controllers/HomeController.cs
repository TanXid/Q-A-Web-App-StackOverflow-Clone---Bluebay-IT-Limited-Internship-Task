using Microsoft.AspNetCore.Mvc;

namespace StackOverflowClone.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
