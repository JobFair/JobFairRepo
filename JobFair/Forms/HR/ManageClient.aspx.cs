using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.Recruiter;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace JobFair.Forms.HR
{
    public partial class ManageClient : System.Web.UI.Page
    {
        int HrId = 1; int ClientId = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dsManageClient = new DataSet();
            ManageClientHRBAL manageClientHRBAL = new ManageClientHRBAL();

            dsManageClient = manageClientHRBAL.ManageClientDetailsBAL(HrId);
            repClientDetails.DataSource = dsManageClient;
            repClientDetails.DataBind();
        }
        protected void lnkBtnNewClientDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClientDetails.aspx?HrId=" + HrId);
        }
        //protected void lnkBtnClientDetails_Click(object sender, EventArgs e)
        //{
        //    //LinkButton button = (LinkButton)sender;
        //    //Label label = (Label)button.NamingContainer.FindControl("lblJobID");
        //    //int JobId = Convert.ToInt32(label.Text);

        //    //Code for Showing and Hiding Div
        //    //bool isCheck = true;
        //   
        //}
        protected void lnkBtnViewClient_Click(object sender, EventArgs e)
        {
            //LinkButton btnHrId = (LinkButton)sender;
            //Label lblHrId = (Label)btnHrId.NamingContainer.FindControl("lblHrId");
            //int HrId = Convert.ToInt32(lblHrId.Text);

            //LinkButton btnClientId = (LinkButton)sender;
            //Label lblClientId = (Label)btnClientId.NamingContainer.FindControl("lblClientId");
            //int ClientId = Convert.ToInt32(lblClientId.Text);

            //Code for Showing and Hiding Div
            bool isView = true;

            Response.Redirect("ClientDetails.aspx?isView=" + isView + "&HrId=" + HrId + "&ClientId=" + ClientId);
        }
        protected void lnkBtnEditClient_Click(object sender, EventArgs e)
        {
            //LinkButton button = (LinkButton)sender;
            //Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            //int JobId = Convert.ToInt32(label.Text);

            //Code for Showing and Hiding Div
            bool isEdit = true;
            Response.Redirect("ClientDetails.aspx?isEdit=" + isEdit + "&HrId=" + HrId + "&ClientId=" + ClientId);
        }
        //protected void lnkBtnDeleteClient_Click(object sender, EventArgs e)
        //{
            //LinkButton button = (LinkButton)sender;
            //Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            //int JobId = Convert.ToInt32(label.Text);

            //Code for Showing and Hiding Div
            //bool isCheck = true;
        //    Response.Redirect("ClientDetails.aspx");
        //}
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