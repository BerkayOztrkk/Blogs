using BusinessLayer.Concretes;
using DataAccessLayer.Concretes.Repositories;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.Controllers
{
	[AllowAnonymous]
	public class NewsLetterController : Controller
	{
		NewsLetterManager newsLetterManager=new NewsLetterManager(new NewsLetterRepository()); 
		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult SubscribeMail(NewsLetter newsLetter)
		{
			newsLetter.EmaiLStatus=true;
			newsLetterManager.TAdd(newsLetter);
			return RedirectToAction("Index","Blog" );
			
		}
	}
}
