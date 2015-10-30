﻿using System;
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
               
                //Code for Showing and Hiding Div
                divMain.Visible = false;
                divViewJob.Visible = true;
                //code for hiding "showeditbutton" of gridview control
                //Button button1 = new Button();
                //button1 = (Button)button1.NamingContainer.FindControl("CommandField");
                //button1.Visible = false;
        }

        protected void lnkBtnEditJob_Click(object sender, EventArgs e)
        {
            LinkButton button = (LinkButton)sender;
            Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            int JobId = Convert.ToInt32(label.Text);
            dataset = manageJobsBAL.ViewJobsDetailsBAL(JobId);
            gvViewJob.DataSource = dataset;
            gvViewJob.AutoGenerateEditButton = true;
            gvViewJob.DataBind();
            
            //Code for Showing and Hiding Div
            divMain.Visible = false;
            divViewJob.Visible = true;
        }
        protected void gvViewJob_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //GridView gridView = (GridView)sender;
            //Label label = (Label)gridView.SelectedRow.FindControl("lbljobid");
            //string strUserID = ((Label)gridView.SelectedRow.FindControl("lblJobID")).Text;
            //GridViewRow row = gvViewJob.Rows[e.RowIndex];
            //Label MyLabel = (Label)row.FindControl("lblJobID");
            //int JobId = Convert.ToInt32(label.Text);
            int JobId = 1;
            dataset = manageJobsBAL.ViewJobsDetailsBAL(JobId);
            divMain.Visible = false;
            divViewJob.Visible = true;
            
        }
        protected void gvViewJob_EditJob(object sender, GridViewEditEventArgs e)
        {
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
        protected void lnkBtnDelete_Click(object sender, EventArgs e)
        {
            LinkButton button = (LinkButton)sender;
            Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            int JobId = Convert.ToInt32(label.Text);
            dataset = manageJobsBAL.ViewJobsDetailsBAL(JobId);
            gvViewJob.DataSource = dataset;
            gvViewJob.AutoGenerateDeleteButton = true;
            gvViewJob.DataBind();
            //Code for Showing and Hiding Div
            divMain.Visible = false;
            divViewJob.Visible = true;
        }
        protected void gvViewJob_DeleteJob(object sender, GridViewDeleteEventArgs e)
        {
            //Response.Write("<script language='javascript'>alert('Are you sure want to delete');</script>");
            //Response.Write("<script>alert('Hello');</script>");
            //string script = "<script type=\"text/javascript\">alert('Hello1');</script>";
            Response.Write("<script language='javascript'>alert('Project Details Inserted');</script>");
            //OnConfirm();
            //divMain.Visible = false;
            //divViewJob.Visible = true;
            //gvViewJob.DataSource = dataset;
            //gvViewJob.EditIndex = -1;
            //gvViewJob.DataBind();
        }
        protected void gvViewJob_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int categoryID = (int)gvViewJob.DataKeys[e.RowIndex].Value;
            //DeleteRecordByID(categoryID);
        }
        //private void OnConfirm()
        //{
        //    string confirmValue = Request.Form[confirmValue = '"Yes"'];
        //    if (confirmValue == "Yes")
        //    {
        //        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked YES!')", true);
        //    }
        //    else
        //    {
        //        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked NO!')", true);
        //    }
        //}

        protected void gvViewJob_CancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            divMain.Visible = false;
            divViewJob.Visible = true;
            gvViewJob.DataSource = dataset;
            gvViewJob.EditIndex = -1;
            gvViewJob.DataBind();
        }
        protected void gvViewJob_UpdateJob(object sender, GridViewUpdateEventArgs e)
        {
        }
        private void ShowNotification()
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "strFadeOutNotification", "FadeOutNotification();", true);
        }
    }
}