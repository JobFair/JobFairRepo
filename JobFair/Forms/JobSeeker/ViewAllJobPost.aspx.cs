using BAL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class ViewAllJobPost : System.Web.UI.Page
    {
        private string email, jobtitle, candidateId, id;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string id = Request.QueryString["jid"];

                // Label1.Text = Session["jobid"].ToString();
                if (!IsPostBack)
                {
                    candidateId = Convert.ToString(Session["candidateId"]);

                    BindRequestEmail(candidateId);

                    GetData(id);
                }
                //BindReapetor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BindRequestEmail(string candidateId)
        {
            try
            {
                DataSet dsRequestEmail = new DataSet();
                RequestEmailJSBAL requestEmailJSBAL = new RequestEmailJSBAL();
                dsRequestEmail = requestEmailJSBAL.GetEmailBAL(candidateId);
                if (dsRequestEmail != null)
                {
                    email = Convert.ToString(dsRequestEmail.Tables[0].Rows[0]["EmailId"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GetData(string id)
        {
            try
            {
                DataSet dsviewalljobpost = new DataSet();
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
                SqlCommand cmd = new SqlCommand("select  RecruiterID,JobId ,JobTitle,JobDescription,OfferedAnnualSalaryMin,OfferedAnnualSalaryMax,KeywordsTechnical,CompanyName from RE_JobPost where JobId = @jid", connection);
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

        public void GetCandidateProfile()
        {
           
        }

        protected void btnapply_Click(object sender, EventArgs e)
        {
            try
            {
                string from = "jyoti.logossolutions@gmail.com";
                string subject = " You applied for " + jobtitle + "at Logos Job Fair on " + DateTime.Now.ToString();
                string content = "hello..";
                //string contentId = "image1";
                //string path = Server.MapPath(@"/Images");
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress(from);
                Msg.To.Add("saurabh.logossolutions@gmail.com");
                StreamReader reader = new StreamReader(Server.MapPath("~/SendMail.html"));
                string readFile = reader.ReadToEnd();
                string strContent = "";
                strContent = readFile;
                strContent = strContent.Replace("[CandidateID]", candidateId);
                Msg.Subject = subject;
                //LinkedResource logo = new LinkedResource(path);
                //logo.ContentId = "companylogo";
                //AlternateView av1 = AlternateView.CreateAlternateViewFromString("<html><body><img src=../../Images/logoitch.jpg/><br></body></html>" + strContent, null, MediaTypeNames.Text.Html);
                //av1.LinkedResources.Add(logo);
                //Msg.AlternateViews.Add(av1);
                Msg.Body = strContent.ToString();
                Msg.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("jyoti.logossolutions@gmail.com", "@jacksparow");
                smtp.EnableSsl = true;
                smtp.Send(Msg);
                Msg = null;
                Response.Write("<script language='javascript'>alert('Your Application Sent Sucessfully')</script>");

                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
                SqlCommand cmd = new SqlCommand("sp_InsertJobHistory", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JobId", id);
                cmd.Parameters.AddWithValue("@CandidateId", candidateId);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
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
                Label lbl = (Label)e.Item.FindControl("lbljobtitle");
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