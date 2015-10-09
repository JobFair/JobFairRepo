﻿using BAL;
using Entities.JobSeeker;
using System;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    /// <summary>
    /// Class ResumeFormating
    /// </summary>
    public partial class ResumeFormating : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ResumeFormatingBAL resumeFormatingBAL = new ResumeFormatingBAL();
                ddlCompanyName.DataSource = resumeFormatingBAL.BindCompanyBAL();
                ddlCompanyName.DataTextField = "CurrentEmployer";
                ddlCompanyName.DataBind();
                ddlCompanyName.Items.Insert(0, new ListItem("--Select--", "0"));
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSubmit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/>instance containing the event data.</param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ResumeFormatingBAL resumeFormatingBAL = new ResumeFormatingBAL();
                ResumeFormatingEntity resumeFormatingEntity = new ResumeFormatingEntity();
                //set the value of ResumeFormatingEntity
                resumeFormatingEntity.CandidateId = "JS00001";
                resumeFormatingEntity.Objective = txtObjective.Text.Trim();
                resumeFormatingEntity.ProfileSummary = txtSummary.Text.Trim();
                resumeFormatingEntity.KeyResultArea = txtKeyArea.Text.Trim();
                resumeFormatingEntity.RolesAndResponsiblity = txtRoles.Text.Trim();
                resumeFormatingEntity.CompanyName = ddlCompanyName.SelectedItem.Text;
                resumeFormatingEntity.Awards = txtAwards.Text.Trim();
                resumeFormatingEntity.ExtraCircular = txtExtraActivities.Text.Trim();
                resumeFormatingEntity.Hobbies = txtHobbies.Text.Trim();
                int result = resumeFormatingBAL.SaveResumeFormateBAL(resumeFormatingEntity);
                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('Resume Formating Done')</script>");
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message.ToString();
            }
        }
    }
}