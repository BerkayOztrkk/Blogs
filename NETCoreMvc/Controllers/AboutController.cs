using BusinessLayer.Concretes;
using DataAccessLayer.Concretes.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.Controllers
{
	public class AboutController : Controller
	{
		AboutManager aboutManager=new AboutManager(new AboutRepository());
		public IActionResult Index()
		{
			var datas= aboutManager.GetAll();
			return View(datas);
		}
	}
}
