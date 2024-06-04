using BusinessLayer.Concretes;
using DataAccessLayer.Concretes.Repositories;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.Controllers
{
	[AllowAnonymous]
	public class CommentController : Controller
	{
		CommentManager commentManager=new CommentManager(new CommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return new PartialViewResult();
		}
		[HttpPost]
		public PartialViewResult PartialAddComment(Comment comment)
		{
			comment.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			comment.Status=true;
			comment.BlogId=1;
			commentManager.TAdd(comment);
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int id) 
		{
		var datas=	commentManager.GetComments(id);
			return   PartialView(datas);
		}
	}
}
