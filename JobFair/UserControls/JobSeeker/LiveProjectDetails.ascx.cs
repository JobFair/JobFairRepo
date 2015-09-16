using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.JobSeeker;
using System.Globalization;

namespace JobFair.UserControls.JobSeeker
{
    public partial class LiveProjectDetails : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LiveProjectDetailsBAL liveBAL = new LiveProjectDetailsBAL();
                ddlRole.DataSource = liveBAL.GetRole();
                ddlRole.DataTextField = "roleName";
                ddlRole.DataValueField = "roleId";
                ddlRole.DataBind();
                ddlRole.Items.Insert(0, new ListItem("--Select--", "0"));
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                LiveProjectDetailsBAL liveBAL = new LiveProjectDetailsBAL();
                LiveProjectDetailsEntity liveEntity = new LiveProjectDetailsEntity();
                 TimeSpan i = new TimeSpan(0, 0, 0);
                 DateTime startDate = Convert.ToDateTime(this.txtFromDate.Text.Trim(), new CultureInfo("en-Gb"));
                 DateTime endDate = Convert.ToDateTime(this.txtTodate.Text.Trim(), new CultureInfo("en-Gb"));
                 i += endDate.Subtract(startDate);
                 int days = i.Days;
                 liveEntity.CandidateId = "JS00001";
                 liveEntity.CompanyName = txtCompanyName.Text;
                 liveEntity.ProjectTitle = txtProjectTitle.Text;
                 liveEntity.roleId =Convert.ToInt32(ddlRole.SelectedValue);
                 liveEntity.ClientName = txtClientName.Text;
                 liveEntity.ProjectLink = txtLink.Text;
                 liveEntity.Duration = days.ToString();
                 liveEntity.ProjectLocation = txtLocation.Text;
                 liveEntity.EmplymentType = string.Empty;
                 if (rbtFullTime.Checked)
                 {
                     liveEntity.EmplymentType = "FullTime";
                 }
                 else if (rbtPartTime.Checked)
                 {
                     liveEntity.EmplymentType = "PartTime";
                 }
                 liveEntity.ProjectDetails = txtProjectDetails.Text;
                 liveEntity.RolesResponsibility = txtRolesAndResponsibility.Text;
                 liveEntity.TeamSize = ddlTeamSize.SelectedItem.Text;
                 liveEntity.SkillUsed = txtSkillUsed.Text;
                 int result = liveBAL.LiveProjectBAL(liveEntity);
                 if (result > 0)
                 {
                     Response.Write("<script language='javascript'>alert('Done')</script>");
                 }
                 else
                 {
                     Response.Write("Sorry");
                 }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}