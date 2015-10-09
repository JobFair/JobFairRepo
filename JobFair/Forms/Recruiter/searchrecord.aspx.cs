using BAL;
using Saplin.Controls;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace JobFair.Forms.Recruiter
{
    public partial class searchrecord : System.Web.UI.Page
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            BindFunctionalArea();
            BindIndustryType();
            BindMasterDegree();
            BindUnderGraduateDiploma();
            BindMasterDegree();
        }

        private void BindUnderGraduateDiploma()
        {
            ddlugqualification.DataSource = SearchRecordBAL.GetUnderGraduateDiplomaBAL();
            ddlugqualification.DataTextField = "UGDName";
            ddlugqualification.DataValueField = "UGDID";
            ddlugqualification.DataBind();
            ddlugqualification.Items.Insert(0, new ListItem("----select-----", "0"));
        }

        private void BindMasterDegree()
        {
            ddlpgqualification.DataSource = SearchRecordBAL.GetMasterDegreeBAL();
            ddlpgqualification.DataTextField = "MDName";
            ddlpgqualification.DataValueField = "MDId";
            ddlpgqualification.DataBind();
            ddlpgqualification.Items.Insert(0, new ListItem("--------select------", "0"));
        }

        private void BindIndustryType()
        {
            ddlindustrytype.DataSource = SearchRecordBAL.industrytype();
            ddlindustrytype.DataTextField = "IndustryName";
            ddlindustrytype.DataValueField = "IndustryId";
            ddlindustrytype.DataBind();
            ddlindustrytype.Items.Insert(0, new ListItem("---select----", "0"));
        }

        private void BindFunctionalArea()
        {
            ddlfunctionalarea.DataSource = SearchRecordBAL.Functionalarea();
            ddlfunctionalarea.DataTextField = "FunctionalArea";
            ddlfunctionalarea.DataValueField = "FunctionalAreaId";
            ddlfunctionalarea.DataBind();
            ddlfunctionalarea.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void txtkeywords_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter("select * from JS_ResumeFormatting  where [Objective] like '" + txtkeywords.Text + "%'", connection);
            string text = ((TextBox)sender).Text;
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                Label1.Visible = false;
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "No Record Found";
                connection.Close();
            }
        }

        protected void txtallkeywords_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from JS_ResumeFormatting where[KeyResultArea] like '" + txtallkeywords.Text + "%'", connection);
            string text = ((TextBox)sender).Text;
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                Label1.Visible = false;
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "No Record Found";
            }
        }

        protected void txtexcludingkeywords_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from JS_ResumeFormatting where[RolesAndResponsiblity] like '" + txtallkeywords.Text + "%'", connection);
            string text = ((TextBox)sender).Text;
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                Label1.Visible = false;
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "No Record Found";
            }
        }

        protected void ddlfunctionalarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem item in ddlfunctionalarea.Items)
            {
                if (item.Selected)
                {
                    Label2.Text = item.Text;
                }
            }
        }

        protected void ddlindustrytype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //protected void ddlfunctionalarea_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    foreach (ListItem item in ddlfunctionalarea.item)
        //    {
        //        if (item.Selected)
        //        {
        //            Label2.Text = item.Text;

        //        }
        //    }
    }
}