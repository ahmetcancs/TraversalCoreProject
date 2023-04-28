using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.User.Controllers
{
    [Area("User")]
    public class ReservationController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal());
        ReservationManager _reservationManager = new ReservationManager(new EfReservationDal());

        public async Task<IActionResult> MyCurrentReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationManager.GetListWithReservationByAccepted(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationManager.GetListWithReservationByPrevious(values.Id);
            return View(valuesList);
        }
        public async Task <IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationManager.GetListWithReservationByWaitApproval(values.Id);
            return View(valuesList);
        }
        [HttpGet]
        public IActionResult NewReservation()
        {      // Here will change
            List<SelectListItem> values = (from x in _destinationManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.Status = "Onay Bekliyor";
            reservation.AppUserId = 5;
            _reservationManager.TAdd(reservation);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}
