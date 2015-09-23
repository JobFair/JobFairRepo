using BAL;
using Entities.JobSeeker;
using System;
using System.Globalization;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    public partial class AddProjectDetails : System.Web.UI.UserControl
    {
        /// <summary>
        /// class AddProjectDetails
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProjectDetailsBAL addProjectDetailsBAL = new ProjectDetailsBAL();
                ddlRole.DataSource = addProjectDetailsBAL.GetRole();
                ddlRole.DataTextField = "roleName";
                ddlRole.DataValueField = "roleId";
                ddlRole.DataBind();
                ddlRole.Items.Insert(0, new ListItem("--Select--", "0"));
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSubmit control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan i = new TimeSpan(0, 0, 0);
                DateTime startDate = Convert.ToDateTime(this.txtFormDate.Text.Trim(), new CultureInfo("en-Gb"));
                DateTime endDate = Convert.ToDateTime(this.txtToDate.Text.Trim(), new CultureInfo("en-Gb"));
                i += endDate.Subtract(startDate);
                int days = i.Days;
                // Set value to AddProjectDetails job seeker entity
                ProjectDetailsBAL addProjectDetailsBAL = new ProjectDetailsBAL();
                ProjectDetailsEntity addProjectDetailsEntity = new ProjectDetailsEntity();
                addProjectDetailsEntity.CandidateId = "JS00001";
                addProjectDetailsEntity.CompanyName = txtCompanyName.Text;
                addProjectDetailsEntity.ClientName = txtClientName.Text;
                addProjectDetailsEntity.ProjectTitle = txtProjectTitle.Text;
                addProjectDetailsEntity.Duration = days.ToString();
                addProjectDetailsEntity.ProjectLocation = txtProjectLocation.Text;
                // Check if radio button check.
                addProjectDetailsEntity.EmployeeType = string.Empty;
                if (rbtFulTime.Checked)
                {
                    addProjectDetailsEntity.EmployeeType = "FullTime";
                }
                else if (rbtPartTme.Checked)
                {
                    addProjectDetailsEntity.EmployeeType = "PartTime";
                }
                addProjectDetailsEntity.ProjectDescription = txtProjectDescription.Text;
                addProjectDetailsEntity.YourRole = ddlRole.SelectedItem.Text;
                addProjectDetailsEntity.TeamSize = ddlRole.SelectedItem.Text;
                addProjectDetailsEntity.SkillUsed = txtSkill.Text;
                int result = addProjectDetailsBAL.SaveProjectDetailsBAL(addProjectDetailsEntity);
                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('Project Details Inserted')</script>");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Sorry')</script>");
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message.ToString();
            }
        }
    }
}