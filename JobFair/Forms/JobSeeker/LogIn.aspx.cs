using BAL;
using Entities;
using System;

namespace JobFair.Forms.JobSeeker
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
        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginBAL liBAL = new LoginBAL();
                LoginEnitity logjsEntity = new LoginEnitity();

                logjsEntity.UserName = txtUserName.Text.Trim();
                logjsEntity.Password = txtPassword.Text.Trim();
                string candidateID = liBAL.JobSeekerLogIn(logjsEntity);
                if (string.IsNullOrEmpty(candidateID))
                {
                    lblmsg.Text = "Wrong username or password";
                    return;
                }
                Session["Candidateid"] = candidateID;
                Response.Redirect("JSViewProfile.aspx");
            }
            catch (Exception ex)
            {
                lblmsg.Text = ex.Message.ToString();
            }
        }
    }
}