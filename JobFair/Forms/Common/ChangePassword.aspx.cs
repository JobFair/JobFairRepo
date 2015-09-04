using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using BAL;
using CommonUtil;
namespace JobFair.Forms.Common
{
    public partial class ChangePassword : System.Web.UI.Page
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
                //cpentity.UserId = Session["userid"].ToString();
                cpentity.UserId = "sau";

                //int result = rjsBAL.ChangePasswordBAL(cpentity);
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