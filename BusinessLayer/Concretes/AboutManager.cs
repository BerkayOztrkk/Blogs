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
	public class AboutManager : IAboutService
	{
		IAboutRepository _aboutRepository;

		public AboutManager(IAboutRepository aboutRepository)
		{
			_aboutRepository=aboutRepository;
		}

        public List<About> GetAll()
        {
           return _aboutRepository.GetAll();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(About t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            throw new NotImplementedException();
        }

        //public List<About> GetAboutList()
        //{
        //	return _aboutRepository.GetAll();

        //}
    }
}
