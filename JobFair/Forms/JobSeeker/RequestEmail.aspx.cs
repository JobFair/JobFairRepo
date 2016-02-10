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
            try
            {
                // Check if page not is postback
                if (!IsPostBack)
                {
                    string candidateId = Convert.ToString(Session["candidateId"]);
                    // Check if session is not null
                    if (string.IsNullOrEmpty(candidateId))
                    {
                        Response.Redirect("LogIn.aspx");
                    }
                    else
                    {
                        BindRequestEmail(candidateId);
                    }
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Bind name, email,mobile number to textbox
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        private void BindRequestEmail(string candidateId)
        {
            try
            {
                DataSet dsRequestEmail = new DataSet();
                RequestEmailJSBAL requestEmailJSBAL = new RequestEmailJSBAL();
                dsRequestEmail = requestEmailJSBAL.GetEmailBAL(candidateId);
                string firstName, lastName;
                // Check if dataset is not null
                if (dsRequestEmail != null)
                {
                    if (dsRequestEmail.Tables.Count > 0)
                    {
                        if (dsRequestEmail.Tables[0].Rows.Count > 0)
                        {
                            txtFrom.Text = Convert.ToString(dsRequestEmail.Tables[0].Rows[0]["EmailId"]);
                            firstName = Convert.ToString(dsRequestEmail.Tables[0].Rows[0]["FirstName"]);
                            lastName = Convert.ToString(dsRequestEmail.Tables[0].Rows[0]["LastName"]);
                            txtName.Text = firstName + " " + lastName;
                            txtMobNo.Text = Convert.ToString(dsRequestEmail.Tables[0].Rows[0]["MobileNo"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Handles Click event of btnSend Control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSend_Click(object sender, EventArgs e)
        {
            string from, subject, content;
            try
            {
                from = txtFrom.Text;
                subject = ddlSubject.SelectedValue;
                content = txtEmailContent.Text;
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(from);
                msg.To.Add("logos.expertadvice@gmail.com");
                msg.Subject = subject;
                // Check if selected value equal to Other Help
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

        /// <summary>
        /// Handles index change event of ddlSubject Control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if selected value equal to Other Help
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