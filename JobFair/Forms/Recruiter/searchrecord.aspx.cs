using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
namespace JobFair.Forms.Recruiter
{
    public partial class searchrecord : System.Web.UI.Page
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void txtkeywords_TextChanged(object sender, EventArgs e)
        {
           
            connection.Open();
            DataSet ds = new DataSet();
          
            SqlDataAdapter da = new SqlDataAdapter("select * from JS_ResumeFormatting  where [Objective] like '"+txtkeywords.Text+"%'", connection);
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
                Label1.Text ="No Record Found";
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
        

    }
}