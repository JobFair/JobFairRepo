using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;
using BAL;
using System.Data;

namespace JobFair.Forms.Recruiter
{
    public partial class ForwordResume : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindClientName();


            }

        }
        /// <summary>
        /// Bind Client Name to  dropdownist
        /// </summary>
        /// 

        private void BindClientName()
        {
            DataSet dsclientname = new DataSet();
            ForwordResumeBAL forwardResume = new ForwordResumeBAL();
            dsclientname = forwardResume.GetClientName();
            ddlclientlist.DataSource = dsclientname;
            ddlclientlist.DataTextField = "ClientName";
            ddlclientlist.DataValueField = "ClientId";
            ddlclientlist.DataBind();
            ddlclientlist.Items.Insert(0, new ListItem("-----select--------", "0"));


        }
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void SendEmail(object sender, EventArgs e)
        {
            string from, subject, content;
            //using (MailMessage msg = new MailMessage(txtEmail.Text, txtTo.Text))
            {

                from = txtfrom.Text;
               subject = txtSubject.Text;
               content = txtBody.Text;
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("harshal.logossolutions@gmail.com");
                DataSet dsemailid = new DataSet();
                Int32 clientid = Convert.ToInt32(ddlclientlist.SelectedValue);
                ForwordResumeBAL forwardResumeBAL = new ForwordResumeBAL();
                dsemailid = forwardResumeBAL.GetEmailId(clientid);
                string EmailIdJoin = null, EmailId, toemail;
                foreach (DataTable table in dsemailid.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        EmailId = Convert.ToString(dr["EmailId"]); ;
                        if (EmailIdJoin == null)
                        {
                            EmailIdJoin = string.Concat(EmailId + ",");
                        }
                        else
                            EmailIdJoin = string.Concat(EmailIdJoin + EmailId + ",");
                    }
                }

                //msg.To = new MailAddress(EmailIdJoin);
                //toemail = EmailIdJoin;
                string[] Multi = EmailIdJoin.Split(','); //spiliting input Email id string with comma(,)
                foreach (string Multiemailid in Multi)
                {
                    if (Multiemailid != "")
                    {
                        msg.To.Add(new MailAddress(Multiemailid)); //adding multi reciver's Email Id
                    }
                    else
                        break;
                }

                if (fuAttachment.HasFile)
                {
                    string FileName = Path.GetFileName(fuAttachment.PostedFile.FileName);
                    msg.Attachments.Add(new Attachment(fuAttachment.PostedFile.InputStream, FileName));
                }
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("harshal.logossolutions@gmail.com", "7758892808");
                smtp.EnableSsl = true;
                smtp.Send(msg);
                msg = null;
                Response.Write("<script language='javascript'>alert('Emil Send ...');</script>");
            }


               

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlclientlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                DataSet dsemailid = new DataSet();
               Int32 clientid =Convert.ToInt32(ddlclientlist.SelectedValue);
               ForwordResumeBAL forwardResumeBAL = new ForwordResumeBAL();
               dsemailid= forwardResumeBAL.GetEmailId(clientid);
               txtTo.Text = Convert.ToString(dsemailid.Tables[0].Rows[0]["ClientName"]);
             
               
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
    
}