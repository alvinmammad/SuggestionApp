using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        Department GetByID(int id);
        List<Department> GetAll();
        Department Create(Department department);
        Department Update(Department department);
        Department Delete(Department department);
    }
}
