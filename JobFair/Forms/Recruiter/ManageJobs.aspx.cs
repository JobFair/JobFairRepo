using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.Recruiter;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace JobFair.Forms.Recruiter
{
    public partial class ManageJobs : System.Web.UI.Page
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

         DataSet dataset = new DataSet();
         ManageJobsBAL manageJobsBAL = new ManageJobsBAL();

        /// <summary>
        /// Class ManageJobs
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            //Bind repeater control
            dataset = manageJobsBAL.ManageJobsDetailsBAL();
            repJobsDetails.DataSource = dataset;
            repJobsDetails.DataBind();
        }

        protected void lnkBtnViewJob_Click(object sender, EventArgs e)
        {
            LinkButton button = (LinkButton)sender;
            Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            int JobId = Convert.ToInt32(label.Text);
            dataset = manageJobsBAL.ViewJobsDetailsBAL(JobId);
            repViewJob.DataSource = dataset;
            repViewJob.DataBind();
               
                //Code for Showing and Hiding Div
                divMain.Visible = false;
                divViewJob.Visible = true;
        }

        protected void lnkBtnEditJob_Click(object sender, EventArgs e)
        {
            LinkButton button = (LinkButton)sender;
            Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            int JobId = Convert.ToInt32(label.Text);

            //Code for Showing and Hiding Div
            bool isCheck = true;
            Response.Redirect("PostNewJob.aspx?isCheck=" + isCheck + "&JobId=" + JobId);
        }
        protected void lnkBtnDelete_Click(object sender, EventArgs e)
        {
            LinkButton button = (LinkButton)sender;
            Label lblJobHistroryId = (Label)button.NamingContainer.FindControl("lblJobHistoryID");
            int JobHistroryId = Convert.ToInt32(lblJobHistroryId.Text);

            LinkButton buttonJobId = (LinkButton)sender;
            Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            int JobId = Convert.ToInt32(label.Text);

            LinkButton buttonRecruiterId = (LinkButton)sender;
            Label labelRecruiter = (Label)buttonRecruiterId.NamingContainer.FindControl("lblRecruiterID");
            int RecruiterId = Convert.ToInt32(labelRecruiter.Text);
            //String IsActive = "InActive";

            
            //int JobHistroryId = true;
            ManageJobsBAL deleteJobBAL = new ManageJobsBAL();
            deleteJobBAL.DeletePostJobBAL(JobHistroryId, JobId, RecruiterId);
            ManageJobEntity deleteJob = new ManageJobEntity();

            deleteJob.JobHistoryId = Convert.ToString(JobHistroryId).Trim();
            deleteJob.JobId = Convert.ToString(JobId).Trim();
            deleteJob.RecruiterID = Convert.ToString(RecruiterId).Trim();
            Response.Write("<script language='javascript'>alert('Delete Job Successfully');</script>");
        }
        protected void lnkBtnRepost_Click(object sender, EventArgs e)
        {
            LinkButton buttonJob = (LinkButton)sender;
            Label labelJob = (Label)buttonJob.NamingContainer.FindControl("lblJobID");
            int JobId = Convert.ToInt32(labelJob.Text);

            LinkButton buttonRecruiter = (LinkButton)sender;
            Label labelRecruiter = (Label)buttonRecruiter.NamingContainer.FindControl("lblRecruiterID");
            int  RecruiterID = Convert.ToInt32(labelRecruiter.Text);
            String IsActive = "Active";

            manageJobsBAL.ClonePostJobBAL(JobId, RecruiterID,IsActive);
            ManageJobEntity cloneJob = new ManageJobEntity();

            cloneJob.JobId = Convert.ToString(JobId).Trim();
            cloneJob.RecruiterID = Convert.ToString(RecruiterID).Trim();
            Response.Write("<script language='javascript'>alert('Clone Job Successfully');</script>");
        }
    }
}