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

        /// <summary>
        /// Bind inactive requirements
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        private void BindInActiveRequirements(long recruiterId)
        {
            try
            {
                DataSet dsInActiveRequirements = new DataSet();
                ViewClientRequirementDetailsREBAL viewClientRequirement = new ViewClientRequirementDetailsREBAL();
                dsInActiveRequirements = viewClientRequirement.ViewInActiveRequirementsBAL(recruiterId);
                // Check if dataset is not null
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

        /// <summary>
        /// Bind active requirements
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        private void BindActiveRequirements(long recruiterId)
        {
            try
            {
                DataSet dsActiveRequirements = new DataSet();
                ViewClientRequirementDetailsREBAL viewClientRequirement = new ViewClientRequirementDetailsREBAL();
                dsActiveRequirements = viewClientRequirement.ViewActiveRequirementBAL(recruiterId);
                // Check if dataset is not null
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

        /// <summary>
        /// Bind new requirements
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        private void BindNewRequirements(long recruiterId)
        {
            try
            {
                DataSet dsNewRequirement = new DataSet();
                ViewClientRequirementDetailsREBAL viewClientRequirement = new ViewClientRequirementDetailsREBAL();
                dsNewRequirement = viewClientRequirement.ViewClientRequirementBAL(recruiterId);
                // Check if dataset is not null
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

        /// <summary>
        /// Handles the Click event of the btnSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string clientName, position;
            DateTime? fromDate, toDate;

            if (txtClientName.Text.Trim() == "")
            {
                clientName = null;
            }
            else
            {
                clientName = txtClientName.Text.Trim();
            }

            if (txtClientRequirement.Text.Trim() == "")
            {
                position = null;
            }
            else
            {
                position = txtClientRequirement.Text.Trim();
            }

            if (txtActiveFromDate.Text.Trim() == "")
            {
                fromDate = null;
            }
            else
            {
                fromDate = Convert.ToDateTime(txtActiveFromDate.Text.Trim());
            }
            if (txtActiveToDate.Text.Trim() == "")
            {
                toDate = null;
            }
            else
            {
                toDate = Convert.ToDateTime(txtActiveToDate.Text.Trim());
            }
            DataSet dsActiveRequirements = new DataSet();
            ViewClientRequirementDetailsREBAL viewClientRequirement = new ViewClientRequirementDetailsREBAL();
            dsActiveRequirements = viewClientRequirement.ViewActiveRequirementSearchBAL(recruiterId, clientName, position, toDate, fromDate);
            // Check if dataset is not null
            if (dsActiveRequirements != null)
            {
                grdActiveRequirement.DataSource = dsActiveRequirements;
                grdActiveRequirement.DataBind();
            }
        }

        /// <summary>
        /// Handles the Click event of the btnInActiveSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnInActiveSearch_Click(object sender, EventArgs e)
        {
            string clientName, position;
            DateTime? fromDate, toDate;
            if (txtClient.Text.Trim() == "")
            {
                clientName = null;
            }
            else
            {
                clientName = txtClient.Text.Trim();
            }

            if (txtRequirement.Text.Trim() == "")
            {
                position = null;
            }
            else
            {
                position = txtRequirement.Text.Trim();
            }
            if (txtFrom.Text.Trim() == "")
            {
                fromDate = null;
            }
            else
            {
                fromDate = Convert.ToDateTime(txtFrom.Text.Trim());
            }

            if (txtTo.Text.Trim() == "")
            {
                toDate = null;
            }
            else
            {
                toDate = Convert.ToDateTime(txtTo.Text.Trim());
            }

            DataSet dsInActiveRequirements = new DataSet();
            ViewClientRequirementDetailsREBAL viewClientRequirement = new ViewClientRequirementDetailsREBAL();
            dsInActiveRequirements = viewClientRequirement.ViewInActiveRequirementSearchBAL(recruiterId, clientName, position, fromDate, toDate);
            // Check if dataset is not null
            if (dsInActiveRequirements != null)
            {
                grdInActiveRequirements.DataSource = dsInActiveRequirements;
                grdInActiveRequirements.DataBind();
            }
        }
    }
}