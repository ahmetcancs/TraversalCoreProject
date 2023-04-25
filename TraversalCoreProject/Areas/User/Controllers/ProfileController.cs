using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.User.Models;

namespace TraversalCoreProject.User.Member.Controllers
{
    [Area("User")]
    [Route("User/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var userEditViewModel = new UserEditViewModel
            {
                Name = values.Name,
                Surname = values.Surname,
                PhoneNumber = values.PhoneNumber,
                Mail = values.Email
            };
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (p.Image != null)
            {
                var extension = Path.GetExtension(p.Image.FileName);
                var imageName = $"{Guid.NewGuid()}{extension}";
                var saveLocation = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "userimages", imageName);

                using var stream = new FileStream(saveLocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);

                user.ImageUrl = imageName;
            }

            user.Name = p.Name;
            user.Surname = p.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }

            return View();
        }

    }
}
