using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}