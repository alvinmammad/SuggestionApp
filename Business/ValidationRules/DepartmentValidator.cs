using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class DepartmentValidator:AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(d => d.DepName).NotEmpty().WithMessage("Zəhmət olmasa şöbə adını boş qoymayın.");

        }
    }
}
