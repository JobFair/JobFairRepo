using BAL;
using Entities;
using System;

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
                LogInEnitity lnEntity = new LogInEnitity();
                LoginBAL loginBAL = new LoginBAL();
                lnEntity.UserName = txtLoginid.Text.Trim();
                lnEntity.Password = txtPassword.Text.Trim();
                string recruiterid = loginBAL.RecruiterLoginBAL(lnEntity);
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