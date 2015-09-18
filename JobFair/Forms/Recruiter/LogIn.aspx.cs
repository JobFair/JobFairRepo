using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using BAL;
using System.Data;
using System.Data.SqlClient;

namespace JobFair.Forms.Recruiter
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            LogInEnitity lnEntity = new LogInEnitity();
            LoginBAL liBAL = new LoginBAL();
            lnEntity.UserName = txtLoginid.Text.Trim();
            lnEntity.Password = txtPassword.Text.Trim();
            string recruiterid = liBAL.RecruiterLoginBAL(lnEntity);
            if (string.IsNullOrEmpty(recruiterid))
            {
                Session["RecruiterId"] = recruiterid.ToString();
            }
        }
    }
}