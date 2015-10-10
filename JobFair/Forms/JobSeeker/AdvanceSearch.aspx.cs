using BAL;
using Entities.JobSeeker;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class AdvanceSearch : System.Web.UI.Page
    {
        private object ds;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            BindIndustry();
            BindDepartment();
        }
        /// <summary>
        /// bind industry to dropdown and stored in database
        /// </summary>
        private void BindIndustry()
        {
            ds = AdvanceJobSearchBAL.GetIndustry();
            ddlIndustry.DataSource = ds;
            ddlIndustry.DataTextField = "IndustryName";
            ddlIndustry.DataValueField = "IndustryId";
            ddlIndustry.DataBind();
            ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));

        }
        private void BindDepartment()
        {
            ds = AdvanceJobSearchBAL.GetDepartment();
            ddlJobCategory.DataSource = ds;
            ddlJobCategory.DataTextField = "DepartmentName";
            ddlJobCategory.DataValueField = "DepartmentId";
            ddlJobCategory.DataBind();
            ddlJobCategory.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            AdvanceSearchEntity JobSearchentity = new AdvanceSearchEntity();
            AdvanceJobSearchBAL AdvancesearchBAL = new AdvanceJobSearchBAL();
            JobSearchentity.KeySkill = txtkeyskill.Text.Trim();
            
            JobSearchentity.WorkExprienceYear = txtTill.Text.Trim();
            
        }
    }
}