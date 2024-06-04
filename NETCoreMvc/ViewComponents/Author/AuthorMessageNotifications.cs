using BusinessLayer.Concretes;
using DataAccessLayer.Concretes.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.ViewComponents.Author
{
    public class AuthorMessageNotifications:ViewComponent
    {
        AuthorManager authorManager=new AuthorManager(new AuthorRepository());
        public IViewComponentResult Invoke()
        {
            //var values = authorManager.GetAuthors(id);
            return View();

        }
    }
}
