using Microsoft.AspNetCore.Mvc;

namespace Gitchange.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
