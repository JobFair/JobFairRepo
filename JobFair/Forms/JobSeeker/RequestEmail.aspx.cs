using BAL;
using System;
using System.Data;
using System.Net.Mail;

namespace JobFair.Forms.JobSeeker
{
    public partial class RequestEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["candidateId"] != null)
                {
                    if (Session["candidateId"].ToString() != "")
                    {
                        try
                        {
                            string candidateId = Convert.ToString(Session["candidateId"]);
                            BindRequestEmail(candidateId);
                        }
                        catch (Exception)
                        {
                            // throw;
                        }
                    }
                }
            }
        }

        private void BindRequestEmail(string candidateId)
        {
            try
            {
                DataSet ds = new DataSet();
                RequestEmailJSBAL requestEmailJSBAL = new RequestEmailJSBAL();
                ds = requestEmailJSBAL.GetEmailBAL(candidateId);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            txtFrom.Text = Convert.ToString(ds.Tables[0].Rows[0]["EmailId"]);
                            string firstName = Convert.ToString(ds.Tables[0].Rows[0]["FirstName"]);
                            string lastName = Convert.ToString(ds.Tables[0].Rows[0]["LastName"]);
                            txtName.Text = firstName + " " + lastName;
                            txtMobNo.Text = Convert.ToString(ds.Tables[0].Rows[0]["MobileNo"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string from = txtFrom.Text;
                string subject = ddlSubject.SelectedValue;
                string content = txtEmailContent.Text;
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(from);
                msg.To.Add("logos.expertadvice@gmail.com");
                msg.Subject = subject;
                if (ddlSubject.SelectedValue == "Other Help")
                {
                    msg.Body = "Name :" + txtName.Text + "\nEmail ID :" + from + "\nMobile Number :" + txtMobNo.Text + "\nSubject :" + txtSubject.Text + "\nEmail Content/Matter :" + content;
                }
                else
                {
                    msg.Body = "Name :" + txtName.Text + "\nEmail ID :" + from + "\nMobile Number :" + txtMobNo.Text + "\nEmail Content/Matter :" + content;
                }
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("logos.expertadvice@gmail.com", "logos@gmail");
                smtp.EnableSsl = true;
                smtp.Send(msg);
                msg = null;
                Response.Write("<script language='javascript'>alert('Emil Send ...');</script>");
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlSubject.SelectedValue == "Other Help")
                {
                    txtSubject.Visible = true;
                    return;
                }
                txtSubject.Visible = false;
            }
            catch (Exception)
            {
                // throw;
            }
        }
    }
}