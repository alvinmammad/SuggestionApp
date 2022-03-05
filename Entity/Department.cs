using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Department:BaseEntity
    {
        public Department()
        {
            FeedbackCategories = new HashSet<FeedbackCategories>();
            //DepartmentFeedbacks = new HashSet<DepartmentFeedback>();
            this.CreatedDate = DateTime.Now;
        }
        
        public string DepName { get; set; }
        public virtual ICollection<FeedbackCategories> FeedbackCategories { get; set; }
        //public virtual ICollection<DepartmentFeedback> DepartmentFeedbacks { get; set; }

    }
}
