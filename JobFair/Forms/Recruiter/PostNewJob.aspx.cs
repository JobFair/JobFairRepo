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
            ds = AddJobPostBAL.GetIndustry();
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
            ds = AddJobPostBAL.GetDepartment();
            ddlDepartment.DataSource = ds;
            ddlDepartment.DataTextField = "DepartmentName";
            ddlDepartment.DataValueField = "DepartmentId";
            ddlDepartment.DataBind();
            ddlDepartment.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        private void BindDropDownFunctionalArea()
        {
            ddlFunArea.DataSource = AddJobPostBAL.FunctionalArea();
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
                AddJobPostBAL JPBAL = new AddJobPostBAL();
                AddJobPostEntity JPentity = new AddJobPostEntity();
                JPentity.JobId = "1";
                JPentity.JobTitle = txtJobtitle.Text.Trim();
                JPentity.JobLocationCity = txtJobLocation.Text.Trim();
                JPentity.JobLocationArea = txtJobLocationArea.Text.Trim();
                JPentity.CompanyLevel = ddlCompanyLevel.SelectedItem.Text.Trim();
                JPentity.Industry = ddlIndustry.SelectedItem.Value;
                JPentity.Department = ddlDepartment.SelectedItem.Value;
                JPentity.FunctionalArea = ddlFunArea.SelectedItem.Value;
                JPentity.JobDescription = txtJobDescription.Text.Trim();
                JPentity.KeywordsRoles = txtKeyRoles.Text.Trim();
                JPentity.KeywordsTechnical = txtKeyTechnical.Text.Trim();
                JPentity.WorkExprience = txtWorkExp.Text.Trim();
                JPentity.Gender = rdbmale.Text.Trim();
                JPentity.OfferedAnnualSalary = txtAnnualSalary.Text.Trim();
                JPentity.OtherSalaryDetails = txtOtherSalary.Text.Trim();
                JPentity.NumberOfVacancies = txtVacancies.Text.Trim();
                int result = JPBAL.JobPostBAL(JPentity);
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