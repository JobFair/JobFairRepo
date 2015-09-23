using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entities;
using BAL;

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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, System.EventArgs e)
        {
            try
                {
                    FeedbackEntity  feedbackEntity= new FeedbackEntity();
                    FeedbackBAL FeedbackBAL = new FeedbackBAL();
                    feedbackEntity.Name = txtName.Text.Trim();
                    feedbackEntity.Subject = ddlSubject.SelectedItem.Text;
                    feedbackEntity.Feedback = txtMessage.Text.Trim();


                    int result = FeedbackBAL.feedbackNewJobseekerBAL(feedbackEntity);
                    if (result > 0)
                    {
                        lblResult.Text = "Your details saved successfully";
                    }
                    else
                    {
                        lblResult.Text = "Your details are not saved";
                    }

                }
                catch (Exception ex)
                {

                    throw ex;
                }
        }
	}
}








             
      
        
  
