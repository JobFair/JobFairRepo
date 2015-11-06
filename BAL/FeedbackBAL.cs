using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BAL
{
    public class FeedbackBAL
    {
   /// <summary>
   /// create method in BAl for 
   /// </summary>
        /// <param name="feedbackEntity"></param>
   /// <returns></returns>

        public int feedbackNewJobseekerBAL(FeedbackEntity feedbackEntity)
        {
            try
            {
                FeedbackJSDAL feedbackDAL = new FeedbackJSDAL();
                return feedbackDAL.FeedbackDAL(feedbackEntity);
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}
