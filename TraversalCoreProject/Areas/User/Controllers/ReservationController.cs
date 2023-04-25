using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.User.Controllers
{
    [Area("User")]
    public class ReservationController : Controller
    {
        public IActionResult MyCurrentReservation()
        {
            return View();
        }
        public IActionResult MyOldReservation()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NewReservation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            return View();
        }
    }
}
