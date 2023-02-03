using Microsoft.AspNetCore.Mvc;

namespace Mert.CinemaBlog.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
