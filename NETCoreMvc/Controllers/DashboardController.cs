using DataAccessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
      
        public IActionResult Index()
        {
            Context context = new Context();
            var username = User.Identity.Name;
        
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var authorid=context.Authors.Where(x => x.Email==usermail).Select(y => y.AuthorId).FirstOrDefault();
            ViewBag.v1=context.Blogs.Count().ToString();
            ViewBag.v2=context.Blogs.Where(x => x.AuthorId==authorid).Count();
            ViewBag.v3=context.Comments.Count().ToString(); 
            return View();
        }
    }
}
