using BAL;
using Entities;
using System;

namespace JobFair.Forms.JobSeeker
{
    public partial class LogIn : System.Web.UI.Page
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
                
                LoginBAL liBAL = new LoginBAL();
                LoginEnitity logjsEntity = new LoginEnitity();

                logjsEntity.UserName = txtUserName.Text.Trim();
                logjsEntity.Password = txtPassword.Text.Trim();
                string candidateID = liBAL.JobSeekerLogIn(logjsEntity);

                string isreffered = liBAL.JobSeekerLogIn(logjsEntity);



               // string format = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PassportValidity"]); ;
                string[] Words = candidateID.Split(new char[] { '/' });
                int count = 0;

                foreach (string Word in Words)
                {
                    count += 1;
                    if (count == 1)
                    {
                        candidateID = Word;
                        if (string.IsNullOrEmpty(candidateID) || !string.IsNullOrEmpty(Request.QueryString["redirect"]))
                        {
                            Session["Candidateid"] = candidateID;
                            if (string.IsNullOrEmpty(candidateID))
                            {
                                lblmsg.Text = "Wrong username or password";
                                return;
                            }
                            Response.Redirect(Request.QueryString["redirect"].ToString() + "&ssid=" + Session["Candidateid"]);

                            return;
                    }
                     Session["Candidateid"] = candidateID;
                    
                  }
                    if (count == 2)
                    {
                        isreffered = Word;
                       
                        if (string.IsNullOrEmpty(isreffered) || !string.IsNullOrEmpty(Request.QueryString["redirect"]))
                        {
                            Session["Isreffered"] = isreffered;
                            if (string.IsNullOrEmpty(isreffered))
                            {
                                lblmsg.Text = "Wrong username or password";
                                return;

                            }
                            Response.Redirect(Request.QueryString["redirect"].ToString() + "&ssreffered=" + Session["Isreffered"]);
                            return;


                        }
                        Session["Isreffered"] = isreffered;


                    }
                   
               


                    
                }


              
               

                
                //Session["UserType"] = 1;
                Response.Redirect("AdvanceSearch.aspx");
                //Response.Redirect("~/UserControls/JobSeeker/DemoEducationalDetails.aspx");
            }
            catch (Exception ex)
            {
                lblmsg.Text = ex.Message.ToString();
            }
        }
    }
}