using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.Recruiter;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

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
            Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            int JobId = Convert.ToInt32(label.Text);
            dataset = manageJobsBAL.ViewJobsDetailsBAL(JobId);
            
            //Code for Showing and Hiding Div
            divMain.Visible = false;
            divViewJob.Visible = true;
        }
        protected void lnkBtnRepost_Click(object sender, EventArgs e)
        {
            LinkButton buttonJob = (LinkButton)sender;
            Label labelJob = (Label)buttonJob.NamingContainer.FindControl("lblJobID");
            int JobId = Convert.ToInt32(labelJob.Text);

            LinkButton buttonRecruiter = (LinkButton)sender;
            Label labelRecruiter = (Label)buttonRecruiter.NamingContainer.FindControl("lblRecruiterID");
            string RecruiterID = labelRecruiter.Text;

            manageJobsBAL.ClonePostJobBAL(JobId, RecruiterID);
            CloneJobPostEntity cloneJob = new CloneJobPostEntity();

            cloneJob.JobId = Convert.ToString(JobId).Trim();
            cloneJob.RecruiterID =RecruiterID.Trim();
            Response.Write("<script language='javascript'>alert('Clone Job Successfully');</script>");
        }
    }
}