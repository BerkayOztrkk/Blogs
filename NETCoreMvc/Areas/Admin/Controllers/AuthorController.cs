using Microsoft.AspNetCore.Mvc;
using NETCoreMvc.Areas.Admin.Models;
using Newtonsoft.Json;

namespace NETCoreMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
   
        public IActionResult AuthorList()
        {
            var jsonAuthors = JsonConvert.SerializeObject(authors);
            return Json(jsonAuthors);
        }
		public IActionResult GetAuthorById(int authorid)
		{
			var findAuthor = authors.FirstOrDefault(a => a.Id == authorid);
			var jsonAuthors= JsonConvert.SerializeObject(findAuthor);

			return Json(jsonAuthors);
		}
        [HttpPost]
        public IActionResult AddAuthor(AuthorModel authorModel)
        {
            authors.Add(authorModel);
            var jsonAuthors=JsonConvert.SerializeObject(authorModel);
            return Json(jsonAuthors);   
        }
        [HttpDelete]
        public IActionResult DeleteAuthor(AuthorModel authorModel)
        {
            var author=authors.FirstOrDefault(a=>a.Id == authorModel.Id);
            authors.Remove(author);
            return Json(author);
        }
        public IActionResult UpdateAuthor(AuthorModel authorModel)
        {
            var author=authors.FirstOrDefault(x=>x.Id==authorModel.Id);
            author.Name= authorModel.Name;
            var jsonAuthor= JsonConvert.SerializeObject(author);
            return Json(jsonAuthor);
        }
		public static List<AuthorModel> authors = new List<AuthorModel>
        {
            new AuthorModel
            {
                Id = 1,
                Name="Mehmet",
            },

            new AuthorModel
            {
                Id = 2,
                Name="Berkay",
            },
            new AuthorModel
            {
                Id = 3,
                Name="Ozturk",
            }
        };
    }
}
