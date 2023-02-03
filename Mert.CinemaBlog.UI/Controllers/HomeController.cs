using Microsoft.AspNetCore.Mvc;

namespace Mert.CinemaBlog.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
