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
    public class ContactManager : IContactService
	{
		IContactRepository _contactRepository;

		public ContactManager(IContactRepository contactRepository)
		{
			_contactRepository=contactRepository;
		}

        public List<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Contact t)
        {
            _contactRepository.Insert(t);
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }

        //public void ContactAddMessage(Contact contact)
        //{
        //	_contactRepository.Insert(contact);
        //}
    }
}
