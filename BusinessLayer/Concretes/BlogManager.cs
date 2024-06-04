using BusinessLayer.Abstractions;
using DataAccessLayer.Abstractions.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class BlogManager : IBlogService
	{
		readonly IBlogRepository _blogRepository;

		public BlogManager(IBlogRepository blogRepository)
		{
			_blogRepository=blogRepository;
		}

        public List<Blog> GetAll()
        {
            return _blogRepository.GetAll();
        }

        public Blog GetById(int id)
        {
            return _blogRepository.GetById(id);
        }

        public void TAdd(Blog t)
        {
            _blogRepository.Insert(t);
        }

        public void TDelete(Blog t)
        {
           _blogRepository.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogRepository.Update(t);
        }

        //public void BlogAdd(Blog blog)
        //{
        //	throw new NotImplementedException();
        //}

        //public void BlogDelete(Blog blog)
        //{
        //	throw new NotImplementedException();
        //}

        //public void BlogUpdate(Blog blog)
        //{
        //	throw new NotImplementedException();
        //}

        //public List<Blog> GetAll()
        //{
        //	return _blogRepository.GetAll();
        //}
        public List<Blog> GetLast3Blog()
        {
            return _blogRepository.GetAll().Take(3).ToList();
        }

        //public Blog GetById(int id)
        //{
        //	throw new NotImplementedException();
        //}
        public List<Blog> GetBlogById(int id)
        {
            return _blogRepository.GetAll(x => x.BlogId == id);
        }

        public List<Blog> GetBlogByAuthor(int id)
        {
            return _blogRepository.GetAll(x => x.AuthorId == id);

        }
    }
}
