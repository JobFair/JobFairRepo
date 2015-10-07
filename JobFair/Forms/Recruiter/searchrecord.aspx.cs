using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace JobFair.Forms.Recruiter
{
    public partial class searchrecord : System.Web.UI.Page
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (txtkeywords.Text.Length > 0)
                SqlDataSource1.SelectCommand = "SELECT * FROM dbo.JS_ResumeFormatting WHERE Desc LIKE N'%" + txtkeywords.Text + "%'";
            else


                SqlDataSource1.SelectCommand = "SELECT * FROM dbo.JS_ResumeFormatting ";

            griddata();
            //DataTable dt = new DataTable();
            //dt.Columns.AddRange(new DataColumn[] {new DataColumn("RecruiterID",typeof(int)),
            //new DataColumn("PresentAddress",typeof(string)),
            //new DataColumn("TotalExpriance",typeof(string))});
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
        }
        private void griddata()
        {
           
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string query;
            if (txtkeywords.Text == "")
            {

                query = "select Objective,ProfileSummary,KeyResultArea,RolesAndResponsiblity,CompanyName,ExtraCircular,Hobbies";

            }
            else
            {
                query = "select Objective,ProfileSummary,KeyResultArea,RolesAndResponsiblity where Objective Like '" + txtkeywords.Text + "',ProfileSummary Like '" + txtkeywords.Text + "'RolesAndResponsiblity Like '" + txtkeywords.Text + "',KeyResultArea Like '" + txtkeywords.Text + "',";
            }
            command = new SqlCommand(query, connection);
            connection.Open();
            da = new SqlDataAdapter(command);
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataBind();
                Label1.Text = "No Records Found";
            }
            connection.Close();
        }




        protected void btnsearch_Click(object sender, EventArgs e)
        {
            txtkeywords.Text = "";
            griddata();
        }


    }
}