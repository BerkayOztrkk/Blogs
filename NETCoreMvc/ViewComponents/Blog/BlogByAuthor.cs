using BusinessLayer.Concretes;
using DataAccessLayer.Concretes.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.ViewComponents.Blog
{
	public class BlogByAuthor:ViewComponent
	{
		AuthorManager authorManager = new AuthorManager(new AuthorRepository());
		public  IViewComponentResult Invoke()
		{
			var datas = authorManager.GetAuthorById(1);
			return View(datas);
		}
	}
}
