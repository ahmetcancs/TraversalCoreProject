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
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			var userEditViewModel = new UserEditViewModel
			{
				Name = user.Name,
				Surname = user.Surname,
				PhoneNumber = user.PhoneNumber,
				Mail = user.Email
			};
			return View(userEditViewModel);
		}

		[HttpPost]
		public async Task<IActionResult> Index(UserEditViewModel model)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);

			if (model.Image != null)
			{
				var extension = Path.GetExtension(model.Image.FileName);
				var imageName = $"{Guid.NewGuid()}{extension}";
				var saveLocation = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "userimages", imageName);

				using var stream = new FileStream(saveLocation, FileMode.Create);
				await model.Image.CopyToAsync(stream);

				user.ImageUrl = imageName;
			}
			user.Name = model.Name;
			user.Surname = model.Surname;
			user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);

			var result = await _userManager.UpdateAsync(user);

			if (result.Succeeded)
			{
				return RedirectToAction("SignIn", "Login");
			}

			return View();
		}
	}
}
