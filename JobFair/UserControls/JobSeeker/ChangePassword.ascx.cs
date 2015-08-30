using BAL;
using Entities;
using System;

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
                ChangePasswordJSBAL rjsBAL = new ChangePasswordJSBAL();

                cpentity.OldPassword = txtOldpwd.Text;
                cpentity.NewPassword = txtNewpwd.Text;
                cpentity.UserName = Session["UserName"].ToString();

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