using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
   public interface IGenericRepository<T>
    {
        T GetByID(int id);
        List<T> GetAll();
        void Create(T t);
        void Update(T t);
        void Delete(T t);
    }
}
