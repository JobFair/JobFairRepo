using BAL;
using Entities;
using System;
using System.Net.Mail;

namespace JobFair.Forms.Recruiter
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Handles the Click event of the btnLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginEnitity loginEntity = new LoginEnitity();
                LoginBAL loginBAL = new LoginBAL();
                loginEntity.UserName = txtLoginid.Text.Trim();
                loginEntity.Password = txtPassword.Text.Trim();
                string recruiterid = loginBAL.RecruiterLoginBAL(loginEntity);
                string from = txtLoginid.Text;
                string subject = "Logged In";
                string content = "Helllo....";
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(from);
                msg.To.Add("saurabh.logossolutions@gmail.com");
                msg.Subject = subject;
                msg.Body = "Hi,<br/>Your Username is: " + txtLoginid.Text + "<br/><br/>Your Password is: " + "Logged in Now" + "<br/>";
              
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("jyoti.logossolutions@gmail.com", "@jacksparow");
                smtp.EnableSsl = true;
                smtp.Send(msg);
                msg = null;
                Response.Write("<script language='javascript'>alert('Email Send to Super Admin ...');</script>");
                if (string.IsNullOrEmpty(recruiterid))
                {
                    Label1.Text = "Login id or password is wrong";
                }
                else
                {
                    Session["RecruiterId"] = recruiterid;
                    Response.Redirect("ViewAllJobsDetails.aspx");
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message.ToString();
            }
        }
    }
}