using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class ViewAllJobPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             BindReapetor();

        }

        private void BindReapetor()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
                SqlDataAdapter da = new SqlDataAdapter("",connection);
                da.SelectCommand = new SqlCommand("select JobTitle,JobDescription,OfferedAnnualSalaryMin,OfferedAnnualSalaryMax,KeywordsTechnical,CompanyName from RE_JobPost", connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "data");
               rptrviewpost.DataSource  = ds.Tables[0].DefaultView;
                rptrviewpost.DataBind();
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

      
    }
}