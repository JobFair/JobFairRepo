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

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string id = Convert.ToString(e.CommandArgument);
            switch (e.CommandName)
            {
               
                case ("Insert"):
                    InsertRepeaterData(e);
                    break;
            }
        }
        private void InsertRepeaterData(RepeaterCommandEventArgs e)
        {
            TextBox JobTitle = (TextBox)e.Item.FindControl("TextBox1");
            TextBox JobLocationCity = (TextBox)e.Item.FindControl("TextBox2");
            TextBox JobLocationArea = (TextBox)e.Item.FindControl("TextBox3");
            TextBox CompanyLevel = (TextBox)e.Item.FindControl("TextBox4");
            TextBox Industry = (TextBox)e.Item.FindControl("TextBox5");
            TextBox Department = (TextBox)e.Item.FindControl("TextBox6");
            TextBox FunctionalArea = (TextBox)e.Item.FindControl("TextBox7");
            TextBox JobDescription = (TextBox)e.Item.FindControl("TextBox8");
            TextBox KeywordsRoles = (TextBox)e.Item.FindControl("TextBox9");
            TextBox KeywordsTechnical = (TextBox)e.Item.FindControl("TextBox10");
            TextBox WorkExprience = (TextBox)e.Item.FindControl("TextBox11");
            TextBox Gender = (TextBox)e.Item.FindControl("TextBox12");
            TextBox OfferedAnnualSalary = (TextBox)e.Item.FindControl("TextBox13");
            TextBox OtherSalaryDetails = (TextBox)e.Item.FindControl("TextBox14");
            TextBox NumberOfVacancies = (TextBox)e.Item.FindControl("TextBox15");
            string str = "insert into students (s_name,s_age,s_course,s_marks) values('" + JobTitle.Text + "'," + JobLocationCity.Text + ",'" + JobLocationArea.Text + "'," + CompanyLevel.Text + " ,'" + Industry + "','" + Department + "','" + FunctionalArea + "','" + JobDescription + "','" + KeywordsRoles + "','" + KeywordsTechnical + "','" + WorkExprience + "','" + Gender + "','" + OfferedAnnualSalary + "','" + OtherSalaryDetails + "','" + NumberOfVacancies + "')";
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection("Data Source=PC02;Initial Catalog=JobFairPortal;User ID=sa;Password=sa@123");
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("<script language='javascript'>alert('Contact Details Inserted')</script>");
            }
            catch (Exception )
            {
                Response.Write("<script language='javascript'>alert('Sorry')</script>");
            }
          
        }

    }
}