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
            if (!IsPostBack)
            {
                if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
                {

                    int JobId = 0;
                    int.TryParse(Request.QueryString["id"], out JobId);
                    if(!JobId.Equals(0))
                    {

                        GetData(JobId);
                    }
                }
            
            }
             //BindReapetor();

        }

        private void GetData(int JobId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
                string sql = "select  JobId JobTitle,JobDescription,OfferedAnnualSalaryMin,OfferedAnnualSalaryMax,KeywordsTechnical,CompanyName from RE_JobPost where JobId =  JobId order by id";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlParameter prm = new SqlParameter("JobId", SqlDbType.Int);
                prm.Value = ("id");
                cmd.Parameters.Add(prm);
                da.Fill(dt);
                rptrviewpost.DataSource = dt;
                rptrviewpost.DataBind();
            }
            catch (Exception)
            {
                
                throw;
            }

           

        }

        //private void BindReapetor()
        //{
        //    try
        //    {
        //        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        //        SqlDataAdapter da = new SqlDataAdapter("",connection);
        //        da.SelectCommand = new SqlCommand("select JobTitle,JobDescription,OfferedAnnualSalaryMin,OfferedAnnualSalaryMax,KeywordsTechnical,CompanyName from RE_JobPost", connection);
        //        DataSet ds = new DataSet();
        //        da.Fill(ds, "data");
        //       rptrviewpost.DataSource  = ds.Tables[0].DefaultView;
        //        rptrviewpost.DataBind();
                
        //    }
        //    catch (Exception)
        //    {
                
        //        throw;
        //    }
        //}

      
    }
}