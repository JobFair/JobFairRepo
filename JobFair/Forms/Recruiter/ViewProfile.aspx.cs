using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace JobFair.Forms.Recruiter
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
       
        protected void Page_Load(object sender, EventArgs e)
        {
            BindReapeter();
        }

        private void BindReapeter()
        {
            DataTable dt = new DataTable();


            SqlDataAdapter adp = new SqlDataAdapter("select * from RE_RegisterDetails where RecruiterID='RE10'",connection);
            try
            {
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[i]["PhotoPath"])))
                        {
                            Image img = (Image)Repeater1.Controls[i].FindControl("Image1");
                            img.ImageUrl = Convert.ToString(dt.Rows[i]["PhotoPath"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                //lblStatus.Text = "Book record could not be retrieved";
                //lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                connection.Close();
                dt.Clear();
                dt.Dispose();
                
            }
        }
    }
}