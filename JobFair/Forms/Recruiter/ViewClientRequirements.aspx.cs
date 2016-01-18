using BAL;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.Forms.Recruiter
{
    public partial class ViewClientRequirements : System.Web.UI.Page
    {
        private Int64 recruiterId = 12;

        protected void Page_Load(object sender, EventArgs e)
        {
            BindNewRequirements(recruiterId);
            BindActiveRequirements(recruiterId);
            BindInActiveRequirements(recruiterId);
        }

        private void BindInActiveRequirements(long recruiterId)
        {
            try
            {
                DataSet dsInActiveRequirements = new DataSet();
                ViewClientRequirementDetailsREBAL viewClientRequirement = new ViewClientRequirementDetailsREBAL();
                dsInActiveRequirements = viewClientRequirement.ViewInActiveRequirementsBAL(recruiterId);
                if (dsInActiveRequirements != null)
                {
                    grdInActiveRequirements.DataSource = dsInActiveRequirements;
                    grdInActiveRequirements.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BindActiveRequirements(long recruiterId)
        {
            try
            {
                DataSet dsActiveRequirements = new DataSet();
                ViewClientRequirementDetailsREBAL viewClientRequirement = new ViewClientRequirementDetailsREBAL();
                dsActiveRequirements = viewClientRequirement.ViewActiveRequirementBAL(recruiterId);
                if (dsActiveRequirements != null)
                {
                    grdActiveRequirement.DataSource = dsActiveRequirements;
                    grdActiveRequirement.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BindNewRequirements(long recruiterId)
        {
            try
            {
                DataSet dsNewRequirement = new DataSet();
                ViewClientRequirementDetailsREBAL viewClientRequirement = new ViewClientRequirementDetailsREBAL();
                dsNewRequirement = viewClientRequirement.ViewClientRequirementBAL(recruiterId);
                if (dsNewRequirement != null)
                {
                    grdViewRequirements.DataSource = dsNewRequirement;
                    grdViewRequirements.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void lnkView_Click(object sender, EventArgs e)
        {
            GridViewRow gvRow = (GridViewRow)(sender as Control).Parent.Parent;
            int cId = Convert.ToInt32(((Label)gvRow.FindControl("lblClientId")).Text);
            int rId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            Response.Redirect("ViewClientRequirementDetails.aspx?cId=" + cId + "&rId=" + rId + "&status=New");
        }

        protected void lnkInActiveView_Click(object sender, EventArgs e)
        {
            GridViewRow gvRow = (GridViewRow)(sender as Control).Parent.Parent;
            int cId = Convert.ToInt32(((Label)gvRow.FindControl("lblClientId")).Text);
            int rId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            Response.Redirect("ViewClientRequirementDetails.aspx?cId=" + cId + "&rId=" + rId + "&status=InActive");
        }

        protected void lnkActiveView_Click(object sender, EventArgs e)
        {
            GridViewRow gvRow = (GridViewRow)(sender as Control).Parent.Parent;
            int cId = Convert.ToInt32(((Label)gvRow.FindControl("lblClientId")).Text);
            int rId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            Response.Redirect("ViewClientRequirementDetails.aspx?cId=" + cId + "&rId=" + rId + "&status=Active");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string clientName, position;

            if (txtClientName.Text == "")
            {
                clientName = null;
            }
            else
            {
                clientName = txtClientName.Text.Trim();
            }

            if (txtClientRequirement.Text == "")
            {
                position = null;
            }
            else
            {
                position = txtClientRequirement.Text.Trim();
            }
            DataSet dsActiveRequirements = new DataSet();
            ViewClientRequirementDetailsREBAL viewClientRequirement = new ViewClientRequirementDetailsREBAL();
            dsActiveRequirements = viewClientRequirement.ViewActiveRequirementSearchBAL(recruiterId, clientName, position);
            if (dsActiveRequirements != null)
            {
                grdActiveRequirement.DataSource = dsActiveRequirements;
                grdActiveRequirement.DataBind();
            }
        }

        protected void btnInActiveSearch_Click(object sender, EventArgs e)
        {
            string clientName, position;

            if (txtClient.Text == "")
            {
                clientName = null;
            }
            else
            {
                clientName = txtClient.Text.Trim();
            }

            if (txtRequirement.Text == "")
            {
                position = null;
            }
            else
            {
                position = txtRequirement.Text.Trim();
            }
            DataSet dsInActiveRequirements = new DataSet();
            ViewClientRequirementDetailsREBAL viewClientRequirement = new ViewClientRequirementDetailsREBAL();
            dsInActiveRequirements = viewClientRequirement.ViewInActiveRequirementSearchBAL(recruiterId, clientName, position);
            if (dsInActiveRequirements != null)
            {
                grdInActiveRequirements.DataSource = dsInActiveRequirements;
                grdInActiveRequirements.DataBind();
            }
        }
    }
}