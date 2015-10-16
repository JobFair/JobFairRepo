using BAL;
using System;
using System.Configuration;
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
            if (!IsPostBack)
            {
                BindIndustry();
                BindDepartment();
                BindState();
            }
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

        private void BindState()
        {
            AdvanceJobSearchBAL advaceJobSearchBAL = new AdvanceJobSearchBAL();
            ds = advaceJobSearchBAL.GetState();
            ddlState.DataSource = ds;
            ddlState.DataTextField = "StateName";
            ddlState.DataValueField = "StateId";
            ddlState.DataBind();
            ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            // AdvanceSearchEntity JobSearchentity = new AdvanceSearchEntity();
            //AdvanceJobSearchBAL AdvancesearchBAL = new AdvanceJobSearchBAL();
            //JobSearchentity.KeySkill = txtkeyskill.Text.Trim();
            // JobSearchentity.WorkExprienceYear = txtTill.Text.Trim();

            Response.Redirect("jobSearch.aspx?keySkills=" + this.txtkeyskill.Text + "&city=" + ddlCity.SelectedItem.Text + "&experience=" + ddlWorkExperience.SelectedItem.Text);
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cityId = Convert.ToInt32(ddlCity.SelectedValue);
            ds = AdvanceJobSearchBAL.GetArea(cityId);
            ddlLocation.DataSource = ds;
            ddlLocation.DataTextField = "AreaName";
            ddlLocation.DataValueField = "AreaId";
            ddlLocation.DataBind();
            ddlLocation.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stateId = Convert.ToInt32(ddlState.SelectedValue);
            ds = AdvanceJobSearchBAL.GetCity(stateId);
            ddlCity.DataSource = ds;
            ddlCity.DataTextField = "cityName";
            ddlCity.DataValueField = "cityID";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, new ListItem("--Select--", "0"));
        }
    }
}