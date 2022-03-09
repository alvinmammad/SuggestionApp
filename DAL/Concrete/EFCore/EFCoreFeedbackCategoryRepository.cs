using DAL.Abstract;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EFCore
{
    public class EFCoreFeedbackCategoryRepository : EFCoreGenericRepository<FeedbackCategories, BankDBContext>, IFeedbackCategoryRepository
    {
        public List<FeedbackCategories> GetCategories()
        {
            using var c = new BankDBContext();
            List<FeedbackCategories> feedbackCategories = c.FeedbackCategories.Include(fc => fc.Department).ToList();
            return feedbackCategories;
        }

        public FeedbackCategories GetCategory(int id)
        {
            using var c = new BankDBContext();
            FeedbackCategories feedbackCategory = c.FeedbackCategories.Include(fc => fc.Department).Where(fc => fc.ID == id).FirstOrDefault();
            return feedbackCategory;
        }
    }
}
