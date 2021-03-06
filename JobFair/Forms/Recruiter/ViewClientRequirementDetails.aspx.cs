﻿using BAL;
using System;
using System.Data;

namespace JobFair.Forms.Recruiter
{
    public partial class ViewClientRequirementDetails : System.Web.UI.Page
    {
        private long clientId = 0, clientRequirementId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            clientId = Convert.ToInt64(Request.QueryString["cId"]);
            clientRequirementId = Convert.ToInt64(Request.QueryString["rId"]);
            string status = Convert.ToString(Request.QueryString["status"]);
            BindClientRequirementDetails(clientId, clientRequirementId, status);
        }

        /// <summary>
        /// Bind client requirement details.
        /// </summary>
        /// <param name="clientId">clientId</param>
        /// <param name="clientRequirementId">clientRequirementId</param>
        /// <param name="status">status</param>
        private void BindClientRequirementDetails(long clientId, long clientRequirementId, string status)
        {
            try
            {
                DataSet dsClientRequirement = new DataSet();
                ViewClientRequirementDetailsREBAL clientRequirementBAL = new ViewClientRequirementDetailsREBAL();
                dsClientRequirement = clientRequirementBAL.ViewClientRequirementDetailsBAL(clientId, clientRequirementId);
                // Check if status is new
                if (status == "New")
                {
                    pnlNew.Visible = true;
                    pnlActive.Visible = false;
                    pnlInActive.Visible = false;
                    // Check if dataset is not null
                    if (dsClientRequirement != null)
                    {
                        lblClientName.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["ClientName"]);
                        lblClientProfile.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["ClientProfile"]);
                        lblPositionName.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Position"]);
                        lblIndustry.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["IndustryName"]);
                        lblFunctionalArea.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["FunctionalArea"]);
                        lblAddress.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Address"]);
                        lblCountry.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["CountryName"]);
                        lblState.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["StateName"]);
                        lblCity.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["CityName"]);
                        lblArea.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["AreaName"]);
                        lblPincode.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Pincode"]);
                        lblSkills.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Skillsets"]);
                        lblContent.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Contents"]);
                        lblDateOfRequirement.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["DateOfRequirementSent"]);
                        lblDueDate.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["DueDate"]);
                        // Bind rptrContactPerson to datasource
                        rptrContactPerson.DataSource = dsClientRequirement.Tables[1];
                        rptrContactPerson.DataBind();
                    }
                }
                // Check if status is active
                else if (status == "Active")
                {
                    pnlActive.Visible = true;
                    pnlNew.Visible = false;
                    pnlInActive.Visible = false;
                    // Check if dataset is not null
                    if (dsClientRequirement != null)
                    {
                        lblActiveClientName.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["ClientName"]);
                        lblActiveClientProfile.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["ClientProfile"]);
                        lblActivePosition.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Position"]);
                        lblRequirementId.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["ClientRequirementId"]);
                        lblActiveIndustry.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["IndustryName"]);
                        lblActiveFunctionalArea.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["FunctionalArea"]);
                        lblActiveAddress.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Address"]);
                        lblActiveCountry.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["CountryName"]);
                        lblActiveState.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["StateName"]);
                        lblActiveCity.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["CityName"]);
                        lblActiveArea.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["AreaName"]);
                        lblActivePincode.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Pincode"]);
                        lblActiveSkills.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Skillsets"]);
                        lblActiveContent.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Contents"]);
                        lblActiveRequirementDate.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["DateOfRequirementSent"]);
                        lblActiveDueDate.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["DueDate"]);
                        lblJobPost.Text = Convert.ToString(dsClientRequirement.Tables[2].Rows[0]["PageLink"]);
                        // Bind datasource to rptrActiveRequirement control
                        rptrActiveRequirement.DataSource = dsClientRequirement.Tables[1];
                        rptrActiveRequirement.DataBind();
                    }
                }
                else
                {
                    pnlActive.Visible = false;
                    pnlNew.Visible = false;
                    pnlInActive.Visible = true;
                    // Check if datasource is not null
                    if (dsClientRequirement != null)
                    {
                        lblInActiveClientName.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["ClientName"]);
                        lblInActiveClientProfile.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["ClientProfile"]);
                        lblInActivePositon.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Position"]);
                        lblInActiveIndustry.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["IndustryName"]);
                        lblInActiveFunctionalArea.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["FunctionalArea"]);
                        lblInActiveAddress.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Address"]);
                        lblInActiveCountry.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["CountryName"]);
                        lblInActiveState.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["StateName"]);
                        lblInActiveCity.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["CityName"]);
                        lblInActiveArea.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["AreaName"]);
                        lblInActivePincode.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Pincode"]);
                        lblInActiveSkills.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Skillsets"]);
                        lblInActiveContent.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["Contents"]);
                        lblInActiveRequirementSent.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["DateOfRequirementSent"]);
                        lblInActiveDueDate.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["DueDate"]);
                        lblInActiveRequirementId.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["ClientRequirementId"]);
                        lblDateOfClosure.Text = Convert.ToString(dsClientRequirement.Tables[0].Rows[0]["StatusModifiedDate"]);
                        lblInActiveJobPostLink.Text = Convert.ToString(dsClientRequirement.Tables[2].Rows[0]["PageLink"]);
                        // Bind datasorce to rptrInActiveRequirement control
                        rptrInActiveRequirement.DataSource = dsClientRequirement.Tables[1];
                        rptrInActiveRequirement.DataBind();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnPositionClosed control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnPositionClosed_Click1(object sender, EventArgs e)
        {
            try
            {
                ViewClientRequirementDetailsREBAL clientRequirementBAL = new ViewClientRequirementDetailsREBAL();
                clientRequirementBAL.UpdateRequirementStatus(clientRequirementId);
                Response.Write("<script language='javascript'>alert('Requirement Closed Sucessfully...')</script>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the lnkbtnJobPost control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void lnkbtnJobPost_Click(object sender, EventArgs e)
        {
            Response.Redirect(lblJobPost.Text);
        }

        /// <summary>
        /// Handles the Click event of the lnkbtnInActiveJobPost control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void lnkbtnInActiveJobPost_Click(object sender, EventArgs e)
        {
            Response.Redirect(lblInActiveJobPostLink.Text);
        }
    }
}