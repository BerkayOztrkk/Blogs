using BusinessLayer.Concretes;
using BusinessLayer.Validations;
using DataAccessLayer;
using DataAccessLayer.Concretes.Repositories;
using EntityLayer.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.Controllers
{
   
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new BlogRepository());
        [AllowAnonymous]
        public IActionResult Index()
        {
            var datas = blogManager.GetAll();
            return View(datas);
        }
        [AllowAnonymous]
        public IActionResult BlogDetails(int id)
        {

            ViewBag.Id = id;
            var datas = blogManager.GetBlogById(id);
            return View(datas);
        }

        public IActionResult BlogListByAuthor(int id)
        {
            Context context = new Context();
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var authorId = context.Authors.Where(x => x.Email==username).Select(y => y.AuthorId).FirstOrDefault();

            
            var values = blogManager.GetBlogByAuthor(authorId);
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {

            Context context = new Context();
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var authorId = context.Authors.Where(x => x.Email==username).Select(y => y.AuthorId).FirstOrDefault();
            BlogValidator blogValidator = new BlogValidator();
            ValidationResult result = blogValidator.Validate(blog);
            if (result.IsValid)
            {
                blog.Status=true;
                blog.CreatedDate=DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.AuthorId=authorId;
                blogManager.TAdd(blog);
                return RedirectToAction("BlogListByAuthor", "Blog");
            }
            else
                return View();
        }
        public IActionResult DeleteBlog(int id)
        {
            var blogvalue = blogManager.GetById(id);
            blogManager.TDelete(blogvalue);
            return RedirectToAction("BlogListByAuthor");
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogvalue = blogManager.GetById(id);
            return View(blogvalue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {

            Context context = new Context();
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var authorId = context.Authors.Where(x => x.Email==username).Select(y => y.AuthorId).FirstOrDefault();
            blog.AuthorId=authorId;
            blog.CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.Status = true;
            blogManager.TUpdate(blog);
            return RedirectToAction("BlogListByAuthor", "Blog");
        }
    }
}
