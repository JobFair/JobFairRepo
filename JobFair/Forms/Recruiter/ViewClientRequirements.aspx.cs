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
                if(dsInActiveRequirements!=null)
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
                DataSet dsActiveequirements = new DataSet();
                ViewClientRequirementDetailsREBAL viewClientRequirement = new ViewClientRequirementDetailsREBAL();
                dsActiveequirements = viewClientRequirement.ViewActiveRequirementBAL(recruiterId);
                if (dsActiveequirements != null)
                {
                    grdActiveRequirement.DataSource = dsActiveequirements;
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
            Response.Redirect("ViewClientRequirementDetails.aspx?cId=" + cId + "&rId=" + rId);
        }
    }
}