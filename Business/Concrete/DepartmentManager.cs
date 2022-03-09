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
        public Department Create(Department t)
        {
            return _departmentRepository.Create(t);
        }

        public Department Delete(Department t)
        {
            return _departmentRepository.Delete(t);
        }

        public List<Department> GetAll()
        {
            return _departmentRepository.GetAll();
        }

        public Department GetByID(int id)
        {
            return _departmentRepository.GetByID(id);
        }

        public Department Update(Department t)
        {
            return _departmentRepository.Update(t);
        }

      
    }
}
