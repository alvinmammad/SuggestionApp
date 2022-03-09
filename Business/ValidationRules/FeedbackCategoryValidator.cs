using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class FeedbackCategoryValidator : AbstractValidator<FeedbackCategories>
    {
        public FeedbackCategoryValidator()
        {
            RuleFor(fc => fc.CategoryName).NotEmpty().WithMessage("Zəhmət olmasa kateqoriya adını boş qoymayın.");
            RuleFor(fc => fc.DepartmentID).NotEmpty().WithMessage("Zəhmət olmasa şöbə adını seçin.");

        }
    }
}
