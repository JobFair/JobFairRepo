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
using System.Configuration;

namespace JobFair.Forms.JobSeeker
{
    public partial class ChangePassword : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {

            try
            {
                
                ChangePasswordEnitity cpentity = new ChangePasswordEnitity();
                cpentity.OldPassword = txtOldpwd.Text;
                cpentity.NewPassword = txtNewpwd.Text;
                cpentity.UserName = txtUsername.Text;


                RegisterJobSeekerBAL rjsBAL = new RegisterJobSeekerBAL();

                int result = rjsBAL.ChangePasswordBAL(cpentity);
               
                    if (result > 0)
                    {
                        lblMsg.Text = "Your password is changed";
                    }
                    else
                    {
                        lblMsg.Text = "Please check your filled details again";
                    }

                }
                catch (Exception)
                {

                    throw;
                }


            }
        
    }
}