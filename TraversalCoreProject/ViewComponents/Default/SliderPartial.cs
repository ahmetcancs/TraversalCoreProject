using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
        
            return View(); 
        }
    }
}
