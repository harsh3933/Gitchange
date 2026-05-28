using Microsoft.AspNetCore.Mvc;

namespace Gitchange.Controllers
{
    public class HomeController3 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
