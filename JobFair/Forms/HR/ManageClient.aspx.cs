using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.Forms.HR
{
    public partial class ManageClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lnkBtnClientDetails_Click(object sender, EventArgs e)
        {
            //LinkButton button = (LinkButton)sender;
            //Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            //int JobId = Convert.ToInt32(label.Text);

            //Code for Showing and Hiding Div
            //bool isCheck = true;
            Response.Redirect("ClientDetails.aspx");
        }
        protected void lnkBtnViewClient_Click(object sender, EventArgs e)
        {
            //LinkButton button = (LinkButton)sender;
            //Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            //int JobId = Convert.ToInt32(label.Text);

            //Code for Showing and Hiding Div
            //bool isCheck = true;
            Response.Redirect("ClientDetails.aspx");
        }
        protected void lnkBtnEditClient_Click(object sender, EventArgs e)
        {
            //LinkButton button = (LinkButton)sender;
            //Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            //int JobId = Convert.ToInt32(label.Text);

            //Code for Showing and Hiding Div
            //bool isCheck = true;
            Response.Redirect("ClientDetails.aspx");
        }
        protected void lnkBtnDeleteClient_Click(object sender, EventArgs e)
        {
            //LinkButton button = (LinkButton)sender;
            //Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            //int JobId = Convert.ToInt32(label.Text);

            //Code for Showing and Hiding Div
            //bool isCheck = true;
            Response.Redirect("ClientDetails.aspx");
        }
        protected void lnkBtnClientContactPerson_Click(object sender, EventArgs e)
        {
            //LinkButton button = (LinkButton)sender;
            //Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            //int JobId = Convert.ToInt32(label.Text);

            //Code for Showing and Hiding Div
            //bool isCheck = true;
            Response.Redirect("ClientContactPersonDetails.aspx");
        }
        protected void lnkBtnClientRequirement_Click(object sender, EventArgs e)
        {
            //LinkButton button = (LinkButton)sender;
            //Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            //int JobId = Convert.ToInt32(label.Text);

            //Code for Showing and Hiding Div
            //bool isCheck = true;
            Response.Redirect("ClientRequirements.aspx");
        }
        protected void lnkBtnEditClientRequirement_Click(object sender, EventArgs e)
        {
            //LinkButton button = (LinkButton)sender;
            //Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            //int JobId = Convert.ToInt32(label.Text);

            //Code for Showing and Hiding Div
            //bool isCheck = true;
            Response.Redirect("ClientRequirements.aspx");
        }
    }
}