using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IFeedbackRepository: IGenericRepository<Feedback>
    {
        AppUser GetHRRole(int id);
        Feedback GetFeedbackWithCategory(int id);
        List<Feedback> GetFeedbacksWithCategory();
        UserFeedback GetCustomer(int id);
        UserFeedback GetHRFeedback(int id,int userID);
        UserFeedback CheckFeedbackNote(int id);
        UserFeedback CheckFeedbackNotePost(int FeedbackID, string secretaryNote);

        UserFeedback HRFeedbackDetails(string HRNote, int FeedbackID,int currentUserID);

        List<UserFeedback> HRFeedbackList(int currentUserID);


    }
}
