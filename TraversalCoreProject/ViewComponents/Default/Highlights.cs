using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class Highlights : ViewComponent
    {
        HighlightManager highlightManager = new HighlightManager (new EfHighlightDal());
        public IViewComponentResult Invoke()
        {
            var values = highlightManager.TGetList().Take(5).ToList(); ;
            
            return View(values);
        }
    }
}
