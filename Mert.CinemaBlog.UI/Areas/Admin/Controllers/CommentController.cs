using Microsoft.AspNetCore.Mvc;

namespace Mert.CinemaBlog.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
