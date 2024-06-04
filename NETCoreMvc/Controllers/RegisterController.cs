using BusinessLayer.Concretes;
using BusinessLayer.Validations;
using DataAccessLayer.Concretes.Repositories;
using EntityLayer.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.Controllers
{
	public class RegisterController : Controller
	{
		AuthorManager authorManager=new AuthorManager(new AuthorRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Author author)
		{
			AuthorValidator validationRules = new AuthorValidator();
			ValidationResult validationResult = validationRules.Validate(author);
			if(validationResult.IsValid)
			{
				author.Status=true;
				authorManager.TAdd(author);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach(var item in validationResult.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
