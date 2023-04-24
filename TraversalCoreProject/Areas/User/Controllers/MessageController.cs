using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.User.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
