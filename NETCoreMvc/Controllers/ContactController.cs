using BusinessLayer.Concretes;
using DataAccessLayer.Concretes.Repositories;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.Controllers
{
	[AllowAnonymous]
	public class ContactController : Controller
	{
		ContactManager _contactManager=new ContactManager(new ContactRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			contact.Date = DateTime.Parse( DateTime.Now.ToShortDateString());
			contact.Status =true;
			
			_contactManager.TAdd(contact);
			return RedirectToAction("Index","Blog");
		}
	}
}
