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
    public class FeedbackManager : IFeedbackService
    {
        private readonly IFeedbackRepository _feedbackRepository;
        public FeedbackManager(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        public UserFeedback CheckFeedbackNote(int id)
        {
            return _feedbackRepository.CheckFeedbackNote(id);
        }

        public UserFeedback CheckFeedbackNotePost(int FeedbackID, string secretaryNote)
        {
            return _feedbackRepository.CheckFeedbackNotePost(FeedbackID, secretaryNote);
        }

        public void Create(Feedback t)
        {
            _feedbackRepository.Create(t);
        }

        public void Delete(Feedback t)
        {
            _feedbackRepository.Delete(t);

        }

        public Feedback GetByID(int id)
        {
            return _feedbackRepository.GetByID(id);
        }

        public UserFeedback GetCustomer(int id)
        {
            return _feedbackRepository.GetCustomer(id);
        }

        public List<Feedback> GetFeedbacksWithCategory()
        {
            return _feedbackRepository.GetFeedbacksWithCategory();
        }

        public Feedback GetFeedbackWithCategory(int id)
        {
            return _feedbackRepository.GetFeedbackWithCategory(id);
        }

        public UserFeedback GetHRFeedback(int id,int userID)
        {
            return _feedbackRepository.GetHRFeedback(id,userID);
        }

        public AppUser GetHRRole(int id)
        {
            return _feedbackRepository.GetHRRole(id);
        }

        public UserFeedback HRFeedbackDetails(string HRNote, int FeedbackID, int currentUserID)
        {
            return _feedbackRepository.HRFeedbackDetails(HRNote, FeedbackID, currentUserID);
        }

        public List<UserFeedback> HRFeedbackList(int currentUserID)
        {
            return _feedbackRepository.HRFeedbackList(currentUserID);
        }

        public void Update(Feedback t)
        {
            _feedbackRepository.Update(t);
        }
    }
}
