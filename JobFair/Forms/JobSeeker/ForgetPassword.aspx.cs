//using BAL;
//using CommonUtil;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace JobFair.Forms.JobSeeker
{
    public partial class ForgetPassword1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataSet ds = new DataSet();

            //    ForgetPassowrdJobSeeker objUserBAL = new ForgetPassowrdJobSeeker();

            //    objUserBAL.Email = txtUidMail.Text.ToString();

            //    ForgetPasswordCommon objUserCom = new ForgetPasswordCommon();
            //    ds = objUserCom.GetEmailDetails(objUserBAL);

            //    if (ds.Tables[0].Rows.Count > 0)
            //    {
            //        MailMessage email = new MailMessage();
            //        email.From = new MailAddress(txtUidMail.Text); //Enter sender email address
            //        email.To.Add(txtUidMail.Text); //Destination Recipient e-mail address.
            //        email.Subject = "Your Forrget Password:";//Subject for your request
            //        email.Body = "Hi,<br/>Your Username is: " + ds.Tables[0].Rows[0]["DesirdUserName"] + "<br/><br/>Your Password is: " + ds.Tables[0].Rows[0]["Password"] + "<br/>";
            //        email.IsBodyHtml = true;
            //        //SMTP SERVER DETAILS
            //        SmtpClient smtpc = new SmtpClient("smtp.gmail.com");
            //        smtpc.Port = 587;
            //        smtpc.UseDefaultCredentials = false;
            //        smtpc.EnableSsl = true;

            //        smtpc.Credentials = new NetworkCredential("jyoti.logossolutions@gmail.com", "@jacksparow");
            //        smtpc.Send(email);
            //        lblmsg.Text = txtUidMail.Text;
            //        Label2.Text = "Your password has been sent to your email address";
            //    }
            //    else
            //    {
            //        Label3.Text = "This email address is not exist in our Database try again";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }
    }
}