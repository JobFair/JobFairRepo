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

        protected void btnSubmit_Click(object sender, System.EventArgs e)
        {
            try
                {
                    FeedbackEntity fdentity = new FeedbackEntity();
                    FeedbackJSBAL FeedbackBAL = new FeedbackJSBAL();
                    fdentity.Name = txtName.Text.Trim();
                    fdentity.Subject = ddlSubject.SelectedItem.Text;
                    fdentity.Feedback = txtMessage.Text.Trim();

                    
                    int result = FeedbackBAL.feedbackNewJobseekerBAL(fdentity);
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








             
      
        
  
