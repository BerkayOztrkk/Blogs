using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
	public class AuthorValidator : AbstractValidator<Author>
	{
		public AuthorValidator()
		{
			RuleFor(x=>x.Username).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez.");
			RuleFor(x=>x.Username).MinimumLength(3).WithMessage("Kullanıcı Adı 3 karakterden az olamaz.");
			RuleFor(x=>x.Username).MaximumLength(20).WithMessage("Kullanıcı Adı 20 karakterden fazla olamaz.");
		

			RuleFor(x=>x.Email).NotEmpty().WithMessage("Email boş geçilemez.");
			RuleFor(x=>x.Email).EmailAddress().WithMessage("Email adresinizi kontrol ediniz.");
			RuleFor(x=>x.Password).NotEmpty().WithMessage("Şifre boş geçilemez.");
			
		}
	}
}
