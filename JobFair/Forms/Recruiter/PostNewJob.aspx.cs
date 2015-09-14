using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.Recruiter;
using CommonUtil;
namespace JobFair.Forms.Recruiter
{
    public partial class PostNewJob1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDropDownIndustry();
            BindDropDownDepartment();
            BindDropDownFunctionalArea();
           


        }
        private void AddDatatosession()
        {
            Session.Add("JobPost", "txtJobtitle.Text");

        }
        private void BindDropDownIndustry()
        {

            ddlIndustry.DataSource = Utility.GetIndustryBAL();
            ddlIndustry.DataTextField = "IndustryName";
            ddlIndustry.DataValueField = "IndustryId";
            ddlIndustry.DataBind();
            ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));


        }
        private void BindDropDownDepartment()
        {
            ddlDepartment.DataSource = Utility.GetDepartmentBAL();
            ddlDepartment.DataTextField = "DepartmentName";
            ddlDepartment.DataValueField = "DepartmentId";
            ddlDepartment.DataBind();
            ddlDepartment.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        private void BindDropDownFunctionalArea()
        {
            ddlFunArea.DataSource = Utility.GetFunctionalAreaBAL();
            ddlFunArea.DataTextField = "FunctionalArea";
            ddlFunArea.DataBind();
            ddlFunArea.Items.Insert(0, new ListItem("--Select--", "0"));
        
        }
       

        protected void btnPostJob_Click(object sender, EventArgs e)
        {
           
            try
          {
              
              AddJobPostBAL JPBAL = new AddJobPostBAL();
              AddJobPostEntity JPentity = new AddJobPostEntity();
              
              JPentity.JobTitle = txtJobtitle.Text.Trim();
              JPentity.JobLocationCity = txtJobLocation.Text.Trim();
              JPentity.JobLocationArea = txtJobLocationArea.Text.Trim();
                JPentity.CompanyLevel = ddlCompanyLevel.SelectedItem.Text.Trim();
                JPentity.Industry = ddlIndustry.SelectedItem.Text.Trim();
                JPentity.Department = ddlDepartment.SelectedItem.Text.Trim();
                JPentity.FunctionalArea = ddlFunArea.SelectedItem.Text.Trim();
                JPentity.JobDescription = txtJobDescription.Text.Trim();
                JPentity.KeywordsRoles = txtKeyRoles.Text.Trim();
                JPentity.KeywordsTechnical = txtKeyTechnical.Text.Trim();
                JPentity.WorkExprience = txtWorkExp.Text.Trim();
                JPentity.Gender = rdbmale.Text.Trim();
                JPentity.OfferedAnnualSalary  = txtAnnualSalary.Text.Trim();
                JPentity.OtherSalaryDetails  = txtOtherSalary.Text.Trim();
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

       
    
