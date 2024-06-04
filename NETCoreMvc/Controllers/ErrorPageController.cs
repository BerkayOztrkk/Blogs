using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Error(int code)
		{
			return View();
		}
	}
}
