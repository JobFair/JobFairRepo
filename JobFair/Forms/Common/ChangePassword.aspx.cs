﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.Forms.Common
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            //try

            //{

            //    ChangePasswordEnitity cpentity = new ChangePasswordEnitity();
            //    RegisterJobSeekerBAL rjsBAL = new RegisterJobSeekerBAL();

            //    cpentity.OldPassword = txtOldpwd.Text;
            //    cpentity.NewPassword = txtNewpwd.Text;
            //    cpentity.UserName = Session["UserName"].ToString();

            //    //int result = rjsBAL.ChangePasswordBAL(cpentity);

            //    if (result > 0)
            //    {
            //        lblMsg.Text = "Your password is changed";
            //    }
            //    else
            //    {
            //        lblMsg.Text = "Please check your filled details again";
            //    }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
    }
}