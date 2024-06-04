using BusinessLayer.Concretes;
using DataAccessLayer.Concretes.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new CommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.Id = id;
            var datas = commentManager.GetComments(id);
            return View(datas);
        }
    }
}
