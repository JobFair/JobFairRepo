using BAL;
using Entities.Recruiter;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.Forms.Recruiter
{
    public partial class PostNewJob1 : System.Web.UI.Page
    {
        private DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            BindDropDownIndustry();
            BindDropDownDepartment();
            BindDropDownFunctionalArea();
        }
        /// <summary>
        /// Method for binding Dropdown with Industry_table of database
        /// </summary>
       

        private void BindDropDownIndustry()
        {
            ds = NewJobPostBAL.GetIndustry();
            ddlIndustry.DataSource = ds;
            ddlIndustry.DataTextField = "IndustryName";
            ddlIndustry.DataValueField = "IndustryId";
            ddlIndustry.DataBind();
            ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));
            
        }
        /// <summary>
        /// Method for binding Dropdown with Department_table of database
        /// </summary>
        private void BindDropDownDepartment()
        {
            ds = NewJobPostBAL.GetDepartment();
            ddlDepartment.DataSource = ds;
            ddlDepartment.DataTextField = "DepartmentName";
            ddlDepartment.DataValueField = "DepartmentId";
            ddlDepartment.DataBind();
            ddlDepartment.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        private void BindDropDownFunctionalArea()
        {
            ddlFunArea.DataSource = NewJobPostBAL.FunctionalArea();
            ddlFunArea.DataTextField = "FunctionalArea";
            ddlFunArea.DataBind();
            ddlFunArea.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        /// <summary>
        /// Method for binding Dropdown with functionalarea_table of database
        /// </summary>
        /// 
        /// <summary>
        /// Handles the Click event of the btnPostjob control of current job details
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <cref="EventArgs">instance containing event data</param>
        protected void btnPostJob_Click(object sender, EventArgs e)
        {
            try
            {
                NewJobPostBAL addJobPostBAL = new NewJobPostBAL();
                AddJobPostEntity addJobPostEntity = new AddJobPostEntity();
                addJobPostEntity.JobId = "1";
                addJobPostEntity.JobTitle = txtJobtitle.Text.Trim();
                addJobPostEntity.JobLocationCity = txtJobLocation.Text.Trim();
                addJobPostEntity.JobLocationArea = txtJobLocationArea.Text.Trim();
                addJobPostEntity.CompanyLevel = ddlCompanyLevel.SelectedItem.Text.Trim();
                addJobPostEntity.Industry = Convert.ToString(ddlIndustry.SelectedItem.Value);
                addJobPostEntity.Department = Convert.ToString(ddlDepartment.SelectedItem.Value);
                addJobPostEntity.FunctionalArea =Convert.ToString(ddlFunArea.SelectedItem.Value);
                addJobPostEntity.JobDescription = txtJobDescription.Text.Trim();
                addJobPostEntity.KeywordsRoles = txtKeyRoles.Text.Trim();
                addJobPostEntity.KeywordsTechnical = txtKeyTechnical.Text.Trim();
                addJobPostEntity.WorkExprience = txtWorkExp.Text.Trim();
                addJobPostEntity.Gender = rdbmale.Text.Trim();
                addJobPostEntity.OfferedAnnualSalary = txtAnnualSalary.Text.Trim();
                addJobPostEntity.OtherSalaryDetails = txtOtherSalary.Text.Trim();
                addJobPostEntity.NumberOfVacancies = txtVacancies.Text.Trim();
                int result = addJobPostBAL.JobPostBAL(addJobPostEntity);
                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('JobPost')</script>");
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