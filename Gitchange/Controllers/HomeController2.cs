using Microsoft.AspNetCore.Mvc;

namespace Gitchange.Controllers
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
