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
	public class AuthorManager : IAuthorService
	{
		readonly IAuthorRepository _authorRepository;

		public AuthorManager(IAuthorRepository authorRepository)
		{
			_authorRepository=authorRepository;
		}

        public List<Author> GetAll()
        {
           return _authorRepository.GetAll();
        }

        public List<Author> GetAuthorById(int id)
        {
            return _authorRepository.GetAll(x=>x.AuthorId == id);
        }

        public Author GetById(int id)
        {
           return _authorRepository.GetById(id);
        }

        public void TAdd(Author t)
        {
           _authorRepository.Insert(t);
        }

        public void TDelete(Author t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Author t)
        {
           _authorRepository.Update(t);
        }

        //public void AuthorAdd(Author author)
        //{
        //	_authorRepository.Insert(author);

        //}

        //public List<Author> GetAuthors(int id)
        //{
        //	return _authorRepository.GetAll();
        //}
    }
}
