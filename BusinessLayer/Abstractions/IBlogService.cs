using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstractions
{
	public interface IBlogService:IGenericService<Blog>
	{

		List<Blog> GetBlogByAuthor(int id);
		List<Blog> GetBlogById(int id);

	}
}
