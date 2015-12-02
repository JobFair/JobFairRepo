using DAL;
using Entities;

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
            FeedbackJSDAL feedbackDAL = new FeedbackJSDAL();
            return feedbackDAL.FeedbackDAL(feedbackEntity);
        }
    }
}