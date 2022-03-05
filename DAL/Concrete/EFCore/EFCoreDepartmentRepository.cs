using DAL.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EFCore
{
    public class EFCoreDepartmentRepository:EFCoreGenericRepository<Department,BankDBContext>,IDepartmentRepository
    {
        //private readonly BankDBContext _context;
        //public EFCoreDepartmentRepository(BankDBContext context)
        //    :base(context)
        //{
        //    this._context = context;
        //}
    }
}
