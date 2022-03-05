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
        public void Create(TEntity t)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(t);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity t)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(t);
                context.SaveChanges();
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

        public void Update(TEntity t)
        {
            using (var context = new TContext())
            {
                context.Entry(t).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
