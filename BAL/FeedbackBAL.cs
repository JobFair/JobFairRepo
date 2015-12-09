using DAL;
using Entities;

namespace BAL
{
    public class FeedbackBAL
    {
        /// <summary>
        /// create method in BAL for feedback
        /// </summary>
        /// <param name="feedbackEntity">FeedbackEntity</param>
        /// <returns>System.Int32</returns>

        public int FeedbackNewJobseekerBAL(FeedbackEntity feedbackEntity)
        {
            FeedbackJSDAL feedbackDAL = new FeedbackJSDAL();
            return feedbackDAL.FeedbackDAL(feedbackEntity);
        }
    }
}