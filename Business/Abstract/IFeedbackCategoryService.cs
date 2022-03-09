using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFeedbackCategoryService
    {
        List<FeedbackCategories> GetFeedbackCategories();
        FeedbackCategories GetCategory(int id);
        List<FeedbackCategories> GetCategories();

        FeedbackCategories Create(FeedbackCategories category);
        FeedbackCategories Update(FeedbackCategories category);
        FeedbackCategories Delete(FeedbackCategories category);
    }
}
