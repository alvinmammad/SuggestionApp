using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class FeedbackDetailVM
    {
        public UserFeedback userFeedback { get; set; }
        public Feedback feedback { get; set; }
    }
}
