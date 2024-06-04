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
	public class NewsLetterManager : INewsLetterService
	{
		readonly INewsLetterRepository _newsLetterRepository;

		public NewsLetterManager(INewsLetterRepository newsLetterRepository)
		{
			_newsLetterRepository=newsLetterRepository;
		}

        public List<NewsLetter> GetAll()
        {
            throw new NotImplementedException();
        }

        public NewsLetter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(NewsLetter t)
        {
           _newsLetterRepository.Insert(t);
        }

        public void TDelete(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        //public void AddNewsLetter(NewsLetter newsLetter)
        //{
        //	_newsLetterRepository.Insert(newsLetter);
        //}
    }
}
