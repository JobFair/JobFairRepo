using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities;
using CommonUtil;
using System.Net.Mail;
using System.Net;
using System.Data;

namespace JobFair.Forms.Common
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();

                ForgetPasswordEntity fpEntity = new ForgetPasswordEntity();
                fpEntity.EmailId = txtEmailId.Text.ToString();
                ds = Utility.ForgetPasswordJobSeeker(fpEntity);




                if (ds.Tables[0].Rows.Count > 0)
                {
                    MailMessage email = new MailMessage();
                    email.From = new MailAddress(txtEmailId.Text); //Enter sender email address
                    email.To.Add(txtEmailId.Text); //Destination Recipient e-mail address.
                    email.Subject = "Your Forrget Password:";//Subject for your request
                    email.Body = "Hi,<br/>Your Username is: " + ds.Tables[0].Rows[0]["EmailId"] + "<br/><br/>Your Password is: " + ds.Tables[0].Rows[0]["Password"] + "<br/>";
                    email.IsBodyHtml = true;
                    //SMTP SERVER DETAILS
                    SmtpClient smtpc = new SmtpClient("smtp.gmail.com");
                    smtpc.Port = 587;
                    smtpc.UseDefaultCredentials = false;
                    smtpc.EnableSsl = true;

                    smtpc.Credentials = new NetworkCredential("jyoti.logossolutions@gmail.com", "@jacksparow");
                    smtpc.Send(email);
                    lblMsg.Text = txtEmailId.Text + "Your password has been sent to your email address";

                }
                else
                {
                    lblMsg.Text = "This email address is not exist in our Database try again";
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text=ex.Message.ToString();
            }
        }
    }
}