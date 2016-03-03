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
        int HrId = 1; 
        //int ClientId = 1; int ClientRequirementId = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["HrId"] != null)
            //{
            //    if (Session["HrId"].ToString() != "")
            //    {
            //        HrId = Convert.ToString(Session["HrId"]);
                    DataSet dsManageClient = new DataSet();
                    ManageClientHRBAL manageClientHRBAL = new ManageClientHRBAL();

                    dsManageClient = manageClientHRBAL.ManageClientDetailsBAL(HrId);
                    repClientDetails.DataSource = dsManageClient;
                    repClientDetails.DataBind();
            //    }
            //}
        }
        protected void lnkBtnNewClientDetails_Click(object sender, EventArgs e)
        {
            //LinkButton BtnHrId = (LinkButton)sender;
            //Label lblHrId = (Label)BtnHrId.NamingContainer.FindControl("lblHrId");
            //int HrId = Convert.ToInt32(lblHrId.Text);

            //Code for Redirecting to Next Page
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
            LinkButton BtnHrId = (LinkButton)sender;
            Label lblHrId = (Label)BtnHrId.NamingContainer.FindControl("lblHrId");
            int HrId = Convert.ToInt32(lblHrId.Text);

            LinkButton BtnClientId = (LinkButton)sender;
            Label lblClientId = (Label)BtnClientId.NamingContainer.FindControl("lblClientId");
            int ClientId = Convert.ToInt32(lblClientId.Text);

            //Code for Showing and Hiding Div
            bool isView = true;

            Response.Redirect("ClientDetails.aspx?isView=" + isView + "&HrId=" + HrId + "&ClientId=" + ClientId);
        }
        protected void lnkBtnEditClient_Click(object sender, EventArgs e)
        {
            LinkButton BtnHrId = (LinkButton)sender;
            Label lblHrId = (Label)BtnHrId.NamingContainer.FindControl("lblHrId");
            int HrId = Convert.ToInt32(lblHrId.Text);

            LinkButton BtnClientId = (LinkButton)sender;
            Label lblClientId = (Label)BtnClientId.NamingContainer.FindControl("lblClientId");
            int ClientId = Convert.ToInt32(lblClientId.Text);

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
            LinkButton BtnHrId = (LinkButton)sender;
            Label lblHrId = (Label)BtnHrId.NamingContainer.FindControl("lblHrId");
            int HrId = Convert.ToInt32(lblHrId.Text);

            LinkButton BtnClientId = (LinkButton)sender;
            Label lblClientId = (Label)BtnClientId.NamingContainer.FindControl("lblClientId");
            int ClientId = Convert.ToInt32(lblClientId.Text);

            //Code for Redirecting to Next Page
            Response.Redirect("ClientContactPersonDetails.aspx?&HrId=" + HrId + "&ClientId=" + ClientId);
        }
        protected void lnkBtnClientRequirement_Click(object sender, EventArgs e)
        {
            LinkButton BtnHrId = (LinkButton)sender;
            Label lblHrId = (Label)BtnHrId.NamingContainer.FindControl("lblHrId");
            int HrId = Convert.ToInt32(lblHrId.Text);

            LinkButton BtnClientId = (LinkButton)sender;
            Label lblClientId = (Label)BtnClientId.NamingContainer.FindControl("lblClientId");
            int ClientId = Convert.ToInt32(lblClientId.Text);

            //Code for Redirecting to Next Page
            Response.Redirect("ClientRequirements.aspx?&HrId=" + HrId + "&ClientId=" + ClientId);
        }
        //protected void lnkBtnEditClientRequirement_Click(object sender, EventArgs e)
        //{
        //    //LinkButton button = (LinkButton)sender;
        //    //Label label = (Label)button.NamingContainer.FindControl("lblJobID");
        //    //int JobId = Convert.ToInt32(label.Text);

        //    //Code for Showing and Hiding Div
        //    //bool isCheck = true;
        //    Response.Redirect("ClientRequirements.aspx");
        //}
        protected void lnkBtnViewClientRequirement_Click(object sender, EventArgs e)
        {
            LinkButton BtnHrId = (LinkButton)sender;
            Label lblHrId = (Label)BtnHrId.NamingContainer.FindControl("lblHrId");
            int HrId = Convert.ToInt32(lblHrId.Text);

            LinkButton BtnClientId = (LinkButton)sender;
            Label lblClientId = (Label)BtnClientId.NamingContainer.FindControl("lblClientId");
            int ClientId = Convert.ToInt32(lblClientId.Text);

            //Code for Showing and Hiding Div
            bool isView = true;
            Response.Redirect("ClientRequirements.aspx?isView=" + isView + "&HrId=" + HrId + "&ClientId=" + ClientId);
        }
    }
}