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
using System.Net.Mail;
using System.IO;
using System.Net;

namespace JobFair.Forms.JobSeeker
{
    public partial class ViewAllJobPost : System.Web.UI.Page
    {
        
        string email,jobtitle, candidateId;
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
                        candidateId  = Convert.ToString(Session["candidateId"]);
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
            
            try
            {

                string from = ("harshal.logossolutions@gmail.com");
                string subject = " You applied for" + jobtitle + "at Logos Job Fair on" + DateTime.Now.ToString();
                string content = "hello..";
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress(from);
                Msg.To.Add("saurabh.logossolutions@gmail.com");
                //StreamReader reader = new StreamReader(Server.MapPath("~/SendMail.html"));
                //string readFile = reader.ReadToEnd();
                //string strContent = "Welcome";
                //strContent = readFile;
                //strContent = strContent.Replace("[CandidateID]",candidateId);
                Msg.Subject = subject;
                Msg.Body = content.ToString();
                //Msg.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new System.Net.NetworkCredential("harshal.logossolutions@gmail.com", "7758892808");
                smtp.UseDefaultCredentials = true;
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(Msg);
                Msg =null;
                Response.Write("<script language='javascript'>alert('Your Application Sent Sucessfully')</script>");
            }
            catch (Exception)
            {
                
                throw;
            }
           
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