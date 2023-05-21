using Microsoft.VisualStudio.Web.CodeGeneration.Utils;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace TraversalCoreProject.Models
{
	public class UserRegisterViewModel
	{
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        public string Name { get; set; }
		
		[Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]				
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen kullanıcı adınızı Giriniz.")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Lütfen mail adresinizi Giriniz.")]
		public string Mail { get; set; }

		//Here are the default password requirements in ASP.NET Core Identity
		//Minimum length of 6 characters
		//Requires at least one non-alphanumeric character
		//Requires at least one uppercase letter
		//Requires at least one lowercase letter
		//Requires at least one digit
		[Required(ErrorMessage = "Lütfen şifreyi giriniz.")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz.")]
		[Compare("Password",ErrorMessage = "Şifreler eşleşmiyor.")]
		public string ConfirmPassword { get; set; }
	}
}



