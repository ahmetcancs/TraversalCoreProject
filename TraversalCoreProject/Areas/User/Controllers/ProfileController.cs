using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.User.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
