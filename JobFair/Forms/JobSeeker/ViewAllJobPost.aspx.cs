using BAL;
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
        string email,jobtitle;
        protected void Page_Load(object sender, EventArgs e)
        {
       
            int id =Convert.ToInt32(Request.QueryString["jid"]);
           // Label1.Text = Session["jobid"].ToString();
            if (!IsPostBack)
            {
                if (Session["candidateId"] != null)
                {
                    if (Session["candidateId"].ToString() !="")
                    {
                    try
                    {
                        string candidateId  = Convert.ToString(Session["candidateId"]);
                        BindRequestEmail(candidateId);
                    }
                    catch (Exception)
                    {
                        
                        throw;
                    }
                    
                    }
                    
                }



                GetData(id);
            
            }
             //BindReapetor();
          
        }

        private void BindRequestEmail(string candidateId)
        {
            DataSet ds = new DataSet();
            RequestEmailJSBAL requestEmailJSBAL = new RequestEmailJSBAL();
            ds = requestEmailJSBAL.GetEmailBAL(candidateId);
            email = Convert.ToString(ds.Tables[0].Rows[0]["EmailId"]);
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

        protected void btnapply_Click(object sender, EventArgs e)
        {
            string from = email;
            string subject =" You applied for"+jobtitle+"at Logos Job Fair on"+DateTime.Now.ToString();
           
        }

        protected void rptrviewpost_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "apply")
            {

                Label lbl = (Label)e.Item.FindControl("Label2");
                jobtitle = lbl.Text;
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