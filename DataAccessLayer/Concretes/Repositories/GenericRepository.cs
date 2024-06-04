using DataAccessLayer.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concretes.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        Context context = new Context();
        public void Delete(T t)
        {
            context.Remove(t);
            context.SaveChanges();
        }

		public List<T> GetAll(Expression<Func<T, bool>> filter)
		{
			return context.Set<T>().Where(filter).ToList();
		}

		public List<T> GetAll()
        {
           return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            context.Update(t);
            context.SaveChanges();
        }
    }
}
