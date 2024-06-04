using BusinessLayer.Concretes;
using DataAccessLayer;
using DataAccessLayer.Concretes.Repositories;
using DocumentFormat.OpenXml.Spreadsheet;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.ViewComponents.Author
{
   
    public class AuthorAboutOnDashboard:ViewComponent
    {
        AuthorManager authorManager = new AuthorManager(new AuthorRepository());


       

        Context context = new Context();
        public  IViewComponentResult Invoke()
        {
          
            var username = User.Identity.Name;
            ViewBag.n=username;
            var usermail=context.Users.Where(x=>x.UserName == username).Select(y=>y.Email).FirstOrDefault();
            var authorId=context.Authors.Where(x=>x.Email==username).Select(y=>y.AuthorId).FirstOrDefault();
           var values= authorManager.GetAuthorById(authorId);
            return View(values);
        }
    }
}
