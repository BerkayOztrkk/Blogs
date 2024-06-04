using BusinessLayer.Concretes;
using DataAccessLayer.Concretes.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.ViewComponents.Blog
{
	public class BlogLast3Post:ViewComponent
	{
		BlogManager blogManager=new BlogManager(new BlogRepository());
		public IViewComponentResult Invoke()
		{
			var values= blogManager.GetLast3Blog();
			return View(values);
		}
	}
}
