using DAL.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EFCore
{
    public class EFCoreGenericRepository<TEntity, TContext> : IGenericRepository<TEntity>
        where TEntity : class
        where TContext : DbContext, new()
    {
        //private readonly TContext _context;
        //public EFCoreGenericRepository(TContext context)
        //{
        //    _context = context;
        //}
        public TEntity Create(TEntity t)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(t);
                context.SaveChanges();
                return t;
            }
        }

        public TEntity Delete(TEntity t)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(t);
                context.SaveChanges();
                return t;
            }
        }

        public List<TEntity> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetByID(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public TEntity Update(TEntity t)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Attach(t);
                context.Entry(t).State = EntityState.Modified;
                context.SaveChanges();
                return t;
            }
        }

        //TEntity IGenericRepository<TEntity>.Create(TEntity t)
        //{
        //    throw new NotImplementedException();
        //}

        //TEntity IGenericRepository<TEntity>.Delete(TEntity t)
        //{
        //    throw new NotImplementedException();
        //}

        //TEntity IGenericRepository<TEntity>.Update(TEntity t)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
