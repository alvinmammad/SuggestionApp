using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFeedbackService
    {
        Feedback GetByID(int id);
       
        void Create(Feedback t);
       
        void Delete(Feedback t);
        AppUser GetHRRole(int id);

        Feedback GetFeedbackWithCategory(int id);

        List<Feedback> GetFeedbacksWithCategory();
        UserFeedback GetCustomer(int id);

        UserFeedback GetHRFeedback(int id,int userID);

        UserFeedback CheckFeedbackNote(int id);

        UserFeedback HRFeedbackDetails(string HRNote, int FeedbackID, int currentUserID);
        List<UserFeedback> HRFeedbackList(int currentUserID);
        UserFeedback CheckFeedbackNotePost(int FeedbackID, string secretaryNote);


    }
}
