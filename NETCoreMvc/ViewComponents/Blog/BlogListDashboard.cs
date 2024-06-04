using BusinessLayer.Concretes;
using DataAccessLayer.Concretes.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {
        BlogManager blogManager = new BlogManager(new BlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = blogManager.GetAll();
            return View(values);
        }
    }
}
