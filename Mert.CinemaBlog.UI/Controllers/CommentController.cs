using Microsoft.AspNetCore.Mvc;

namespace Mert.CinemaBlog.UI.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
