using Microsoft.AspNetCore.Mvc;

namespace Mert.CinemaBlog.UI.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
