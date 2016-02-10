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
    public partial class ManageEmployer : System.Web.UI.Page
    {
         int HrId = 1;
         //int EmployerId = 1; int EmployerRequirementId = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["HrId"] != null)
            //{
            //    if (Session["HrId"].ToString() != "")
            //    {
            //        HrId = Convert.ToString(Session["HrId"]);
                    DataSet dsManageEmployer = new DataSet();
                    ManageEmployerHRBAL manageEmployerHRBAL = new ManageEmployerHRBAL();

                    dsManageEmployer = manageEmployerHRBAL.ManageEmployerDetailsBAL(HrId);
                    repEmployerDetails.DataSource = dsManageEmployer;
                    repEmployerDetails.DataBind();
            //    }
            //}
        }
        protected void lnkBtnNewEmployerDetails_Click(object sender, EventArgs e)
        {
            //LinkButton BtnHrId = (LinkButton)sender;
            //Label lblHrId = (Label)BtnHrId.NamingContainer.FindControl("lblHrId");
            //int HrId = Convert.ToInt32(lblHrId.Text);

            //Code for Redirecting to Next Page
            Response.Redirect("EmployerDetails.aspx?HrId=" + HrId);
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
        protected void lnkBtnViewEmployer_Click(object sender, EventArgs e)
        {
            LinkButton BtnHrId = (LinkButton)sender;
            Label lblHrId = (Label)BtnHrId.NamingContainer.FindControl("lblHrId");
            int HrId = Convert.ToInt32(lblHrId.Text);

            LinkButton BtnEmployerId = (LinkButton)sender;
            Label lblEmployerId = (Label)BtnEmployerId.NamingContainer.FindControl("lblEmployerId");
            int EmployerId = Convert.ToInt32(lblEmployerId.Text);

            //Code for Showing and Hiding Div
            bool isView = true;

            Response.Redirect("EmployerDetails.aspx?isView=" + isView + "&HrId=" + HrId + "&EmployerId=" + EmployerId);
        }
        protected void lnkBtnEditEmployer_Click(object sender, EventArgs e)
        {
            LinkButton BtnHrId = (LinkButton)sender;
            Label lblHrId = (Label)BtnHrId.NamingContainer.FindControl("lblHrId");
            int HrId = Convert.ToInt32(lblHrId.Text);

            LinkButton BtnEmployerId = (LinkButton)sender;
            Label lblEmployerId = (Label)BtnEmployerId.NamingContainer.FindControl("lblEmployerId");
            int EmployerId = Convert.ToInt32(lblEmployerId.Text);

            //Code for Showing and Hiding Div
            bool isEdit = true;
            Response.Redirect("EmployerDetails.aspx?isEdit=" + isEdit + "&HrId=" + HrId + "&EmployerId=" + EmployerId);
        }
        //protected void lnkBtnDeleteEmployer_Click(object sender, EventArgs e)
        //{
            //LinkButton button = (LinkButton)sender;
            //Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            //int JobId = Convert.ToInt32(label.Text);

            //Code for Showing and Hiding Div
            //bool isCheck = true;
        //    Response.Redirect("EmployerDetails.aspx");
        //}
        protected void lnkBtnEmployerRequirement_Click(object sender, EventArgs e)
        {
            //LinkButton button = (LinkButton)sender;
            //Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            //int JobId = Convert.ToInt32(label.Text);

            //Code for Showing and Hiding Div
            //bool isCheck = true;
            Response.Redirect("EmployerRequirements.aspx");
        }
        protected void lnkBtnViewEmployerRequirement_Click(object sender, EventArgs e)
        {
            LinkButton BtnHrId = (LinkButton)sender;
            Label lblHrId = (Label)BtnHrId.NamingContainer.FindControl("lblHrId");
            int HrId = Convert.ToInt32(lblHrId.Text);

            LinkButton BtnEmployerId = (LinkButton)sender;
            Label lblEmployerId = (Label)BtnEmployerId.NamingContainer.FindControl("lblEmployerId");
            int EmployerId = Convert.ToInt32(lblEmployerId.Text);

            //Code for Showing and Hiding Div
            bool isView = true;
            Response.Redirect("EmployerRequirements.aspx?isView=" + isView + "&HrId=" + HrId + "&EmployerId=" + EmployerId);
        }
    }
}