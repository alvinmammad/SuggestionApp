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
    public class FeedbackCategoryManager : IFeedbackCategoryService
    {
        private readonly IFeedbackCategoryRepository _feedbackCategoryRepository;
        public FeedbackCategoryManager(IFeedbackCategoryRepository feedbackCategoryRepository)
        {
            _feedbackCategoryRepository = feedbackCategoryRepository;
        }
        public List<FeedbackCategories> GetFeedbackCategories()
        {
            return _feedbackCategoryRepository.GetAll();
        }
    }
}
