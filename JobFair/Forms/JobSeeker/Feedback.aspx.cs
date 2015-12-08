using BAL;
using Entities;
using System;

namespace JobFair.Forms.JobSeeker
{
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// save feedback data in database in click event
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSubmit_Click(object sender, System.EventArgs e)
        {
            try
            {
                FeedbackEntity feedbackEntity = new FeedbackEntity();
                FeedbackBAL feedbackBAL = new FeedbackBAL();
                feedbackEntity.Name = txtName.Text.Trim();
                feedbackEntity.Subject = ddlSubject.SelectedItem.Text;
                feedbackEntity.Feedback = txtMessage.Text.Trim();

                int result = feedbackBAL.FeedbackNewJobseekerBAL(feedbackEntity);
                // Check if result is greater than zero
                if (result > 0)
                {
                    lblResult.Text = "Your details saved successfully";
                }
                else
                {
                    lblResult.Text = "Your details are not saved";
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }
    }
}