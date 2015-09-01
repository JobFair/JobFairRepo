using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities;
using System.Data;
using System.Data.SqlClient;
namespace JobFair.Forms.JobSeeker
{
    public partial class JobSeekerLogIn1 : System.Web.UI.Page
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
                

                RegisterJobSeekerBAL rjsBAL = new RegisterJobSeekerBAL();
                LogInJobSeekerEnitity logjsEntity = new LogInJobSeekerEnitity();
                HttpCookie user = new HttpCookie("userinfo");

                logjsEntity.UserName = txtUserName.Text;
                logjsEntity.Password = txtPassword.Text;
                SqlDataReader rd = rjsBAL.JobSeekerLogIn(logjsEntity);

                if (rd.Read())
                {
                   user["username"]= txtUserName.Text;
                   Response.Cookies.Add(user);


                    Response.Redirect("Feedback Us.aspx");
                }
                else
                {
                    Response.Write("Wrong username or password");

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}