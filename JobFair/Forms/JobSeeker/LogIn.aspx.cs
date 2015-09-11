using BAL;
using Entities;
using System;
using System.Data.SqlClient;

namespace JobFair.Forms.JobSeeker
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                LogInJobSeekerBAL logIn = new LogInJobSeekerBAL();
                LogInJobSeekerEnitity logjsEntity = new LogInJobSeekerEnitity();

                logjsEntity.UserName = txtUserName.Text;
                logjsEntity.Password = txtPassword.Text;
                SqlDataReader rd = logIn.JobSeekerLogIn(logjsEntity);

                if (rd.Read())
                {
                    Response.Redirect("UserDetails.aspx");
                }
                else
                {
                    Response.Write("Wrong username or password");
                }
            }
            catch (Exception ex)
            {
                lblmsg.Text = ex.Message.ToString();
            }
        }
    }
}