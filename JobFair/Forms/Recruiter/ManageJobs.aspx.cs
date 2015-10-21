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
//using JobFair.Forms.Recruiter.PostNewJob;

namespace JobFair.Forms.Recruiter
{
    public partial class ManageJobs : System.Web.UI.Page
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        DataSet dataset = new DataSet();
        PostNewJob CloneJob = new PostNewJob();
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

            //manageJobsBAL.RePostJobBAL(JobId);
            //PostNewJob.btnPostJob_Click();
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

        protected void lnkBtnEditJob_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageJobs.aspx");
            divMain.Visible = false;
            divViewJob.Visible = true;
        }
        protected void EditCustomer(object sender, GridViewEditEventArgs e)
        {

            //int JobId = '3';
            //dataset = manageJobsBAL.ViewJobsDetailsBAL(JobId);
            divMain.Visible = false;
            divViewJob.Visible = true;
            gvViewJob.DataSource = dataset;
            gvViewJob.EditIndex = e.NewEditIndex;
            gvViewJob.DataBind();
        }
        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            gvViewJob.DataBind();
            gvViewJob.PageIndex = e.NewPageIndex;
            gvViewJob.DataBind();
        }

        protected void DeleteCustomer(object sender, EventArgs e)
        {
            
        }
        
        protected void CancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            divMain.Visible = false;
            divViewJob.Visible = true;
            gvViewJob.DataSource = dataset;
            gvViewJob.EditIndex = -1;
            gvViewJob.DataBind();
        }
        protected void UpdateCustomer(object sender, GridViewUpdateEventArgs e)
        {
           
        }
        private void ShowNotification()
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "strFadeOutNotification", "FadeOutNotification();", true);
        }

    }
}