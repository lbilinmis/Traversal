using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccess.Abstract.Base;
using Traversal.Entities.Abstract;

namespace Traversal.DataAccess.Concrete.Repositories.Base
{
    public class GenericRepositoryBase<T, TContext> : IGenericBaseRepository<T>
        where T : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(T entity)
        {
            using var context = new TContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var context = new TContext();
            context.Remove(entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new TContext();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var context = new TContext();
            return context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            using var context = new TContext();
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
