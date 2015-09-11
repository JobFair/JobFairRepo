using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace JobFair.Forms.JobSeeker
{
    public partial class AdvanceSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                FillIndustryCheckBoxList();
                FillcityCheckBoxList();
                FillFreshersCheckBoxList();
                FillRolesCheckBoxList();
                FillJobTypeCheckBoxList();
            }
        }

        private void FillJobTypeCheckBoxList()
        {

            SqlConnection con = new SqlConnection("Data Source=PC02;Initial Catalog=JobFairPortal;User ID=sa;Password=sa@123");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select JobType from JS_AdvanceSerach", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            chkJobType.DataSource = dt;
            chkJobType.DataTextField = "JobType";
            chkJobType.DataBind();
            con.Close();
        }

        private void FillRolesCheckBoxList()
        {
            SqlConnection con = new SqlConnection("Data Source=PC02;Initial Catalog=JobFairPortal;User ID=sa;Password=sa@123");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select roleName  from JS_Roles", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            chkRole.DataSource = dt;
            chkRole.DataTextField = "roleName";
            chkRole.DataBind();
            con.Close();
        }

        private void FillFreshersCheckBoxList()
        {

            SqlConnection con = new SqlConnection("Data Source=PC02;Initial Catalog=JobFairPortal;User ID=sa;Password=sa@123");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Freshers  from JS_AdvanceSerach", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            chkFreshers.DataSource = dt;
            chkFreshers.DataTextField = "Freshers";
            chkFreshers.DataBind();
            con.Close();
        }
        private void FillIndustryCheckBoxList()
        {
            SqlConnection con = new SqlConnection("Data Source=PC02;Initial Catalog=JobFairPortal;User ID=sa;Password=sa@123");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Industry", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            chkIndustry.DataSource = dt;
            chkIndustry.DataTextField = "IndustryName";
            chkIndustry.DataBind();
            con.Close();
        }
        private void FillcityCheckBoxList()
        {

            SqlConnection con = new SqlConnection("Data Source=PC02;Initial Catalog=JobFairPortal;User ID=sa;Password=sa@123");
            con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from City", con);
            SqlDataAdapter adp = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            chkLocation.DataSource = dt;
            chkLocation.DataTextField = "CityName";
            chkLocation.DataBind();
            con.Close();

        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {

        }
        protected void lnks_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("JobType", typeof(string));

            dt.Rows.Add("Link 1");
            dt.Rows.Add("Link 2");
            dt.Rows.Add("Link 3");
            dt.Rows.Add("Link 4");

            //bind data source here
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        //private void BindGrid()
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["JobPortalCon"].ConnectionString;
        //    string query = "Select Freshers  from JS_AdvanceSerach";

        //    string condition = string.Empty;
        //    foreach (ListItem item in chkFreshers.Items)
        //    {
        //        condition += item.Selected ? string.Format("'{0}',", item.Value) : string.Empty;
        //    }

        //    if (!string.IsNullOrEmpty(condition))
        //    {
        //        condition = string.Format(" WHERE  IN ({0})", condition.Substring(0, condition.Length - 1));
        //    }

        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(query + condition))
        //        {
        //            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
        //            {
        //                cmd.Connection = con;
        //                using (DataTable dt = new DataTable())
        //                {
        //                    sda.Fill(dt);
        //                    GridView2.DataSource = dt;
        //                    GridView2.DataBind();
        //                }
        //            }
        //        }
        //    }
        
        
        //}
        //protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        //{
        //    GridView2.PageIndex = e.NewPageIndex;
        //    // this.BindGrid();
        //}

        //protected void cblFreshness_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    GridView2.DataBind();
        //}
   
    }

}