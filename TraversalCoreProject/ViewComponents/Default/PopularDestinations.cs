using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class PopularDestinations : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
