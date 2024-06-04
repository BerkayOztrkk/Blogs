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
	public class CommentManager : ICommentService
	{
		ICommentRepository _commentRepository;

		public CommentManager(ICommentRepository commentRepository)
		{
			_commentRepository=commentRepository;
		}

        public List<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Comment t)
        {
           _commentRepository.Insert(t);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        //public void CommentAdd(Comment comment)
        //{
        //	_commentRepository.Insert(comment);

        //}

        public List<Comment> GetComments(int id)
        {
            //return _commentrepository.getall();
            return _commentRepository.GetAll(x => x.BlogId==id);
        }
    }
}
