using Microsoft.AspNetCore.Mvc;
using NETCoreMvc.Models;

namespace NETCoreMvc.ViewComponents.Comment
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentdatas = new List<UserComment>
            {
                new UserComment
                {
                        Id="1",
                        Username="Jay"
                },
                new UserComment
                {
                        Id="2",
                        Username="KQLAU"
                },
            };
            return View(commentdatas);
        }
    }
}
