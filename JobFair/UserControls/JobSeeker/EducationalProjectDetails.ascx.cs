using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.JobSeeker;

namespace JobFair.UserControls.JobSeeker
{
    public partial class EducationalProjectDetails : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan i = new TimeSpan(0, 0, 0);
                DateTime startDate = Convert.ToDateTime(this.txtFrom.Text.Trim(), new CultureInfo("en-Gb"));
                DateTime endDate = Convert.ToDateTime(this.txtTo.Text.Trim(), new CultureInfo("en-Gb"));
                i += endDate.Subtract(startDate);
                int days = i.Days;
            
                AcademicProjectDetailsBAL academicProjectDetailsBAL = new AcademicProjectDetailsBAL();
                AcademicProjectDetailsEntity academicProjectDetailsEntity = new AcademicProjectDetailsEntity();
                academicProjectDetailsEntity.CandidateId = "JS00001";
                academicProjectDetailsEntity.ProjectName = txtProjectTitle.Text;
                academicProjectDetailsEntity.Duration = days.ToString();
                academicProjectDetailsEntity.ProjectDetails = txtProjectDetails.Text;
                academicProjectDetailsEntity.RolesAndResponsibility = txtResponsibility.Text;
                academicProjectDetailsEntity.TeamSize = ddlTeamSize.SelectedItem.Text;
                academicProjectDetailsEntity.SkillUsed = txtSkillUsed.Text;
                // Check if radio button check.
                academicProjectDetailsEntity.LiveProject = string.Empty;
                if (rbtYes.Checked)
                {
                    academicProjectDetailsEntity.LiveProject = "Yes";
                }
                else if (rbtNo.Checked)
                {
                    academicProjectDetailsEntity.LiveProject = "No";
                }
                academicProjectDetailsEntity.ProjectURL = txtProjectURL.Text;
               
                int result = academicProjectDetailsBAL.SaveAcademicProjectBAL(academicProjectDetailsEntity);
                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('Academic Project Details Inserted')</script>");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Sorry')</script>");
                }
            }
            catch (Exception )
            {
              
            }
        }
    }
}