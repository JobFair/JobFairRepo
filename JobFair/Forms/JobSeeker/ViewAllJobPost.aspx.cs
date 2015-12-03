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

            int id =Convert.ToInt32(Request.QueryString["jid"]);
           // Label1.Text = Session["jobid"].ToString();
            if (!IsPostBack)
            {
                //if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
                //{

                //    int JobId = 0;
                //    int.TryParse(Request.QueryString["id"], out JobId);
                //    if(!JobId.Equals(0))
                //    {

                //       
                //    }
                //}
                GetData(id);
            
            }
             //BindReapetor();
          
        }

        private void GetData(int id)
        {
            try
            {
                DataSet dsviewalljobpost = new DataSet();
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
                SqlCommand cmd = new SqlCommand("select  JobId ,JobTitle,JobDescription,OfferedAnnualSalaryMin,OfferedAnnualSalaryMax,KeywordsTechnical,CompanyName from RE_JobPost where JobId = @jid", connection);
                cmd.Parameters.AddWithValue("@jid", id);
                //SqlCommand cmd = new SqlCommand("sp_JS_SelectJobpost", connection);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@JobId", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsviewalljobpost);
                rptrviewpost.DataSource = dsviewalljobpost;
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