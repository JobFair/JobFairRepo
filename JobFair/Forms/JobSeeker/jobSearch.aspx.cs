using BAL;
using Entities.JobSeeker;
using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace JobFair.Forms.JobSeeker
{
    public partial class jobSearch : System.Web.UI.Page
    {
        private DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            //GetDataFromSession();
            if (!Page.IsPostBack)
            {
                FillIndustryCheckBoxList();
                FillcityCheckBoxList();
                BindRepeaterData();
            }
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
            chkIndustry.DataValueField = "IndustryId";
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
            chkLocation.DataValueField = "CityId";
            chkLocation.DataBind();
            con.Close();
        }

        protected void BindRepeaterData()
        {
            SqlConnection con = new SqlConnection("Data Source=PC02;Initial Catalog=JobFairPortal;User ID=sa;Password=sa@123");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from RE_JobPost", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
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

        protected void btnsend_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM RS_JobPost", new SqlConnection("Data Source=PC02;Initial Catalog=JobFairPortal;User ID=sa;Password=sa@123"));

            cmd.Connection.Open();
            Repeater1.DataSource = cmd.ExecuteReader();
            Repeater1.DataBind();
            if (Repeater1.Items.Count > 0)
            {
                //lblTotalCount.Text = Repeater1.Items.Count.ToString();
            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();
        }
    }
}