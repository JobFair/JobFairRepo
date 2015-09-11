using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BAL
{
    public class FeedbackJSBAL
    {
   
     
        public int  feedbackNewJobseekerBAL(FeedbackEntity fdentity)
        {
            FeedbackJSDAL fdDAL = new FeedbackJSDAL();
            return fdDAL.FeedbackDAL(fdentity);
        }
    }
}
