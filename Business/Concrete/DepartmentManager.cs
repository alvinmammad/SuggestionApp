using Business.Abstract;
using DAL.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private IDepartmentRepository _departmentRepository;
        public DepartmentManager(IDepartmentRepository departmentRepository)
        {
            this._departmentRepository = departmentRepository;
        }
        public void Create(Department t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Department t)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
            throw new NotImplementedException();
        }

        public Department GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Department t)
        {
            throw new NotImplementedException();
        }
    }
}
