using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
	public class BlogValidator : AbstractValidator<Blog>
	{
		public BlogValidator()
		{
			RuleFor(x=>x.Name).NotEmpty().WithMessage(" Blog Name Required");
			RuleFor(x=>x.Content).NotEmpty().WithMessage(" Blog Content Required");
			RuleFor(x=>x.Content).MinimumLength(5).WithMessage(" Blog Content must be 5-150 character  ");
			RuleFor(x=>x.Content).MaximumLength(150).WithMessage(" Blog Content must be 5-150 character");

		}
	}
}
