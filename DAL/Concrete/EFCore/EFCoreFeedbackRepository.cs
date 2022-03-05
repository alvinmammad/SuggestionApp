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
    public class EFCoreFeedbackRepository : EFCoreGenericRepository<Feedback, BankDBContext>, IFeedbackRepository
    {
        public UserFeedback CheckFeedbackNote(int id)
        {
            using var c = new BankDBContext();
            var feedback = c.UserFeedbacks.Include(uf => uf.Feedback)
                .ThenInclude(uf => uf.FeedbackCategory)
                .ThenInclude(uf=>uf.Department)
                .Where(uf => uf.FeedbackID == id).FirstOrDefault();
            return feedback;
        }

        public UserFeedback CheckFeedbackNotePost(int FeedbackID, string secretaryNote)
        {
            using var c = new BankDBContext();
            var secretaryFeedback = c.UserFeedbacks
                .Include(sf => sf.Feedback)
                .Where(sf => sf.FeedbackID == FeedbackID)
                .FirstOrDefault();
            secretaryFeedback.Feedback.FeedbackStatus = Entity.Enums.FeedbackStatus.Rejected;
            secretaryFeedback.SecretaryNote = secretaryNote;
            secretaryFeedback.HRNote = secretaryFeedback.HRNote;
            secretaryFeedback.Feedback.CreatedDate = DateTime.Now;
            //c.Feedbacks.Update(secretaryFeedback.Feedback);
            //c.SaveChanges();
            return secretaryFeedback;
        }

        public UserFeedback GetCustomer(int id)
        {
            using var c = new BankDBContext();
            var customer = c.UserFeedbacks.Include(f => f.Feedback).Where(f => f.Feedback.ID == id).AsNoTracking().FirstOrDefault();
            return customer;
        }

        public List<Feedback> GetFeedbacksWithCategory()
        {
            using var c = new BankDBContext();

            return c.Feedbacks.Include(f => f.FeedbackCategory).OrderByDescending(f => f.FeedbackStatus).ToList();
        }

        public Feedback GetFeedbackWithCategory(int id)
        {
            using var c = new BankDBContext();
            var feedback = c.Feedbacks
               .Include(f => f.FeedbackCategory)
               .Where(f => f.ID == id)
               .FirstOrDefault();
            return feedback;
        }

        public UserFeedback GetHRFeedback(int id,int userID)
        {
            using var c = new BankDBContext();
            var feedback = c.UserFeedbacks
                .Include(uf => uf.Feedback)
                .ThenInclude(uf => uf.FeedbackCategory)
                .Where(uf => uf.AppUserID == userID && uf.ID==id && (uf.Feedback.FeedbackStatus == Entity.Enums.FeedbackStatus.Pending ||uf.Feedback.FeedbackStatus == Entity.Enums.FeedbackStatus.Rejected))
                .FirstOrDefault();
            return feedback;
        }

        public AppUser GetHRRole(int id)
        {
            using var c = new BankDBContext();
            var user = c.Users
                 .Include(u => u.UserRoles)
                 .Include(u => u.Department)
                 .Where(u => u.DepartmentID == id && u.UserRoles
                 .Any(ur => ur.RoleId == 3))
                 .FirstOrDefault();
            return user;
        }

        public UserFeedback HRFeedbackDetails(string HRNote, int FeedbackID,int currentUserID)
        {
            using var c = new BankDBContext();
            var userFeedback = c.UserFeedbacks.Include(uf => uf.Feedback).Where(uf => uf.FeedbackID == FeedbackID && uf.AppUserID == currentUserID).FirstOrDefault();
            userFeedback.Feedback.FeedbackStatus = Entity.Enums.FeedbackStatus.inProgress;
            userFeedback.HRNote = HRNote;
            userFeedback.Feedback.CreatedDate = DateTime.Now;
            if (userFeedback.SecretaryNote == null)
            {
                userFeedback.SecretaryNote = null;
            }
            else
            {
                userFeedback.SecretaryNote = userFeedback.SecretaryNote;
            }

            c.SaveChanges();
            return userFeedback;
        }

        public List<UserFeedback> HRFeedbackList(int currentUserID)
        {
            using var c = new BankDBContext();
            var feedback = c.UserFeedbacks
               .Include(uf => uf.Feedback)
               .ThenInclude(uf => uf.FeedbackCategory)
               .ThenInclude(uf => uf.Department)
               .Where(uf => uf.AppUserID == currentUserID && (uf.Feedback.FeedbackStatus == Entity.Enums.FeedbackStatus.Pending || uf.Feedback.FeedbackStatus == Entity.Enums.FeedbackStatus.Rejected))
               .ToList();
            return feedback;
        }

        public UserFeedback SendHRNoteToSecretary(int FeedbackID, string secretaryNote)
        {
            using var c = new BankDBContext();
            var secretaryFeedback = c.UserFeedbacks
                .Include(sf => sf.Feedback)
                .Where(sf => sf.FeedbackID == FeedbackID)
                .FirstOrDefault();
            secretaryFeedback.Feedback.FeedbackStatus = Entity.Enums.FeedbackStatus.Rejected;
            secretaryFeedback.SecretaryNote = secretaryNote;
            secretaryFeedback.HRNote = secretaryFeedback.HRNote;
            secretaryFeedback.Feedback.CreatedDate = DateTime.Now;
            c.SaveChanges();
            return secretaryFeedback;
           
        }

    }
}
