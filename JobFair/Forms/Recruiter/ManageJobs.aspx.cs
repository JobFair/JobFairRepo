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

        protected void lnkBtnRepost_Click(object sender, EventArgs e)
        {
            LinkButton button = (LinkButton)sender;
            Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            int JobId = Convert.ToInt32(label.Text);

            manageJobsBAL.RePostJobBAL(JobId);
            Response.Redirect("ManageJobs.aspx");
        }
        protected void lnkBtnViewJob_Click(object sender, EventArgs e)
        {
            LinkButton button = (LinkButton)sender;
            Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            int JobId = Convert.ToInt32(label.Text);
            dataset = manageJobsBAL.ViewJobsDetailsBAL(JobId);
            gvViewJob.DataSource = dataset;
            gvViewJob.DataBind();

            divMain.Visible = false;
            divViewJob.Visible = true;
        }
    }
}