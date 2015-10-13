using BAL;
using Entities.JobSeeker;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class AdvanceSearch : System.Web.UI.Page
    {
        private object ds;
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
       
        protected void Page_Load(object sender, EventArgs e)
        {
            BindIndustry();
            BindDepartment();
            BindCity();
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
            ds = AdvanceJobSearchBAL.GetFunctionalArea();
            ddlJobCategory.DataSource = ds;
            ddlJobCategory.DataTextField = "FunctionalArea";
            ddlJobCategory.DataValueField = "FunctionalAreaId";
            ddlJobCategory.DataBind();
            ddlJobCategory.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        private void rep_bind()
        {
            string query = "select * from RE_JobPost where KeywordsTechnical like '" + txtkeyskill.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query,connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }
        private void BindCity()
        {
            string query = "select * from City";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            ddlCity.DataSource = ds;
            ddlCity.DataBind();
        }
        protected void btnsearch_Click(object sender, EventArgs e)
        {
           // AdvanceSearchEntity JobSearchentity = new AdvanceSearchEntity();
            //AdvanceJobSearchBAL AdvancesearchBAL = new AdvanceJobSearchBAL();
            //JobSearchentity.KeySkill = txtkeyskill.Text.Trim();
           // JobSearchentity.WorkExprienceYear = txtTill.Text.Trim();
          
                rep_bind();
                Repeater1.Visible = true;
                txtkeyskill.Text = "";
          
        }
    }
}