using CommonUtil;
using Entities;
using System;

namespace JobFair.Forms.Common
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Handles the click event of btnOk of change password page
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePasswordEnitity cpentity = new ChangePasswordEnitity();

                cpentity.OldPassword = txtOldpwd.Text;
                cpentity.NewPassword = txtNewpwd.Text;

                cpentity.UserId = "JS9";

                int result = Utility.ChangePassword(cpentity);
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