using System.ComponentModel.DataAnnotations;

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

		[Required(ErrorMessage = "Lütfen şifreyi giriniz.")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz.")]
		[Compare("Password",ErrorMessage = "Şifreler eşleşmiyor.")]
		public string ConfirmPassword { get; set; }
	}
}
