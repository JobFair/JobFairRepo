using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using BAL;
//using CommonUtil;
using System.Data;
using System.Data.SqlClient;
namespace JobFair.Forms.JobSeeker
{
    public partial class JobSeekerLogIn : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    JobSeekerLogInBAL jsloginBAL = new JobSeekerLogInBAL();
            //    JobSeekerLoginCommon jsloginCom = new JobSeekerLoginCommon();
            //    jsloginBAL.UserName = txtUserName.Text;
            //    jsloginBAL.Password = txtPassword.Text;
            //    SqlDataReader rd=jsloginCom.JobSeekerLogIn(jsloginBAL);

            //    if (rd.Read())
            //    {
            //        Response.Redirect("SearchJobs.aspx");
            //    }
            //    else
            //    {
            //        Response.Write("Wrong username or password");

            //    }
              
                
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }
    }
}