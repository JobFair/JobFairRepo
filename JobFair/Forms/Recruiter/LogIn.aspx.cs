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

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LogInEnitity lnEntity = new LogInEnitity();
                LoginBAL liBAL = new LoginBAL();
                lnEntity.UserName = txtLoginid.Text.Trim();
                lnEntity.Password = txtPassword.Text.Trim();
                string recruiterid = liBAL.RecruiterLoginBAL(lnEntity);
                if (string.IsNullOrEmpty(recruiterid))
                {
                    Session["RecruiterId"] = recruiterid.ToString();
                    Response.Redirect("PostNewJob.aspx");
                }
                else
                {
                    Label1.Text = "Login id or password is wrong";
                }
            }
            catch (Exception ex)
            {
                Label1.Text=ex.Message.ToString();
            }
        }
    }
}