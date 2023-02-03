using Microsoft.AspNetCore.Mvc;

namespace Mert.CinemaBlog.UI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
