using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities;
using System;

namespace JobFair.Forms.Employer
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the btnLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {

                LogInEmployerBAL logInEmployerBAL = new LogInEmployerBAL();
                LoginEnitity logjsEntity = new LoginEnitity();

                logjsEntity.UserName = txtUserName.Text.Trim();
                logjsEntity.Password = txtPassword.Text.Trim();
                string candidateID = logInEmployerBAL.EmployerLogIn(logjsEntity);

                if (string.IsNullOrEmpty(candidateID) || !string.IsNullOrEmpty(Request.QueryString["redirect"]))
                {
                    Session["Employerid"] = candidateID;
                    if (string.IsNullOrEmpty(candidateID))
                    {
                        lblmsg.Text = "Wrong username or password";
                        return;
                    }
                    Response.Redirect(Request.QueryString["redirect"].ToString() + "&ssid=" + Session["Employerid"]);

                    return;
                }
                Session["Employerid"] = candidateID;
                //string isreffered = liBAL.JobSeekerLogIn(logjsEntity);
                //if (string.IsNullOrEmpty(isreffered) || !string.IsNullOrEmpty(Request.QueryString["redirect"]))
                //{
                //    Session["Isreffered"] = isreffered;
                //    if (string.IsNullOrEmpty(isreffered))
                //    {
                //        lblmsg.Text = "Wrong username or password";
                //        return;

                //    }
                //    Response.Redirect(Request.QueryString["redirect"].ToString() + "&ssreffered=" + Session["Isreffered"]);
                //    return;


                //}
                //Session["Isreffered"] = isreffered;
                //Session["UserType"] = 1;
                Response.Redirect("ManageEmployer.aspx");
                //Response.Redirect("~/UserControls/JobSeeker/DemoEducationalDetails.aspx");
            }
            catch (Exception ex)
            {
                lblmsg.Text = ex.Message.ToString();
            }
        }
    }
}