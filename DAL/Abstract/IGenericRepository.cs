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
        T Create(T t);
        T Update(T t);
        T Delete(T t);
    }
}
