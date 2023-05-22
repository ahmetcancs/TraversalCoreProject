using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.AdminDashboard
{
    public class TotalRevenue : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
