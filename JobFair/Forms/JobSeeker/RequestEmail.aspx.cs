using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using BAL;
using System.Data;


namespace JobFair.Forms.JobSeeker
{
    public partial class RequestEmail : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string candidateId = Convert.ToString(Session["candidateId"]);
            DataSet ds = new DataSet();
            RequestEmailJSBAL requestEmailJSBAL = new RequestEmailJSBAL();
            ds= requestEmailJSBAL.GetEmailBAL(candidateId);
            txtFrom.Text = Convert.ToString(ds.Tables[0].Rows[0]["EmailId"]);
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            //MailMessage msg = new MailMessage();
            //msg.From = new MailAddress("anketchopade@gmail.com");
            //msg.To.Add(em);
            //msg.Subject = "Your new password ";
            //msg.Body = "Hi " + usnm + " Your new password is : " + nps;
            //SmtpClient smtp = new SmtpClient();
            //smtp.Host = "smtp.gmail.com";
            //smtp.Port = 587;
            //smtp.Credentials = new System.Net.NetworkCredential("anketchopade@gmail.com", "Password");
            //smtp.EnableSsl = true;
            //smtp.Send(msg);
            //msg = null;
            //Response.Write("<script language='javascript'>alert('New password send on your Email...');</script>");
        }
    }
}