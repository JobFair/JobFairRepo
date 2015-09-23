using BAL;
using Entities.JobSeeker;
using System;
using System.Globalization;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    public partial class LiveProjectDetails : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LiveProjectDetailsBAL liveProjectDtailsBAL = new LiveProjectDetailsBAL();
                ddlRole.DataSource = liveProjectDtailsBAL.GetRole();
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
                LiveProjectDetailsBAL liveProjectDetailsBAL = new LiveProjectDetailsBAL();
                LiveProjectDetailsEntity liveProjectDetailsEntity = new LiveProjectDetailsEntity();
                TimeSpan i = new TimeSpan(0, 0, 0);
                DateTime startDate = Convert.ToDateTime(this.txtFromDate.Text.Trim(), new CultureInfo("en-Gb"));
                DateTime endDate = Convert.ToDateTime(this.txtTodate.Text.Trim(), new CultureInfo("en-Gb"));
                i += endDate.Subtract(startDate);
                int days = i.Days;
                liveProjectDetailsEntity.CandidateId = "JS00001";
                liveProjectDetailsEntity.CompanyName = txtCompanyName.Text;
                liveProjectDetailsEntity.ProjectTitle = txtProjectTitle.Text;
                liveProjectDetailsEntity.RoleId = Convert.ToInt32(ddlRole.SelectedValue);
                liveProjectDetailsEntity.ClientName = txtClientName.Text;
                liveProjectDetailsEntity.ProjectLink = txtLink.Text;
                liveProjectDetailsEntity.Duration = days.ToString();
                liveProjectDetailsEntity.ProjectLocation = txtLocation.Text;
                liveProjectDetailsEntity.EmplymentType = string.Empty;
                if (rbtFullTime.Checked)
                {
                    liveProjectDetailsEntity.EmplymentType = "FullTime";
                }
                else if (rbtPartTime.Checked)
                {
                    liveProjectDetailsEntity.EmplymentType = "PartTime";
                }
                liveProjectDetailsEntity.ProjectDetails = txtProjectDetails.Text;
                liveProjectDetailsEntity.RolesResponsibility = txtRolesAndResponsibility.Text;
                liveProjectDetailsEntity.TeamSize = ddlTeamSize.SelectedItem.Text;
                liveProjectDetailsEntity.SkillUsed = txtSkillUsed.Text;
                int result = liveProjectDetailsBAL.SaveLiveProjectBAL(liveProjectDetailsEntity);
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