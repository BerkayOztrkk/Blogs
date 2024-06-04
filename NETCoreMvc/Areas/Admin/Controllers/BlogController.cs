using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using NETCoreMvc.Areas.Admin.Models;

namespace NETCoreMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog List");
                worksheet.Cell(1, 1).Value="BlogId";
                worksheet.Cell(1, 2).Value="Blog Name";

                int BlogRowCount = 2;
                foreach(var item in GetBlogList() )
                {
                    worksheet.Cell(BlogRowCount,1).Value=item.Id;
                    worksheet.Cell(BlogRowCount,2).Value=item.BlogName;
                    BlogRowCount++;
                }
                using(var stream=new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Work1example.xlsx");
                }
            }
        
        }
      public  List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>
            {
                new BlogModel{Id=1,BlogName="C#"},
                new BlogModel{Id=2,BlogName="Angular"},
            };
            return bm;
        }
        public IActionResult BlogListExcel()
        {
            return View();
        }
    }
}
