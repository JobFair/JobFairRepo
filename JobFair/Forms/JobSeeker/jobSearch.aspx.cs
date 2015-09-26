using BAL;
using System;
using System.Collections.Generic;
using System.Data;
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
            SqlCommand cmd = new SqlCommand("select  JobTitle,JobLocationCity,CompanyLevel,IndustryId,DepartmentId,FunctionalAreaId,JobDescription,WorkExprience,PostedDate from RE_JobPost", con);
  
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
            con.Close();
        }
    }
}