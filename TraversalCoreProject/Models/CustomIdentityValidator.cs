﻿using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProject.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = nameof(PasswordTooShort),
				Description = $"Şifre en az {length} karakter olmalıdır."
		};
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = nameof(PasswordRequiresUpper),
				Description = "Şifre en az 1 büyük harf içermelidir."
			};
		}
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = nameof(PasswordRequiresLower),
				Description = "Şifre en az 1 küçük harf içermelidir."
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = nameof(PasswordRequiresNonAlphanumeric),
				Description = "Şifre en az 1 sembol içermelidir."
			};
		}
		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError
			{
				Code = nameof(PasswordRequiresDigit),
				Description = "Şifre en az bir rakam ('0'-'9') içermelidir."
			};
		}
	}
}
