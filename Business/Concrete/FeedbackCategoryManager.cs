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

        public FeedbackCategories Create(FeedbackCategories category)
        {
            return _feedbackCategoryRepository.Create(category);

        }

        public FeedbackCategories Delete(FeedbackCategories category)
        {
            return _feedbackCategoryRepository.Delete(category);

        }

        public List<FeedbackCategories> GetCategories()
        {
            return _feedbackCategoryRepository.GetCategories();
        }

        public FeedbackCategories GetCategory(int id)
        {
            return _feedbackCategoryRepository.GetCategory(id);
        }

        public List<FeedbackCategories> GetFeedbackCategories()
        {
            return _feedbackCategoryRepository.GetAll();
        }

        public FeedbackCategories Update(FeedbackCategories category)
        {
            return _feedbackCategoryRepository.Update(category);
        }
    }
}
