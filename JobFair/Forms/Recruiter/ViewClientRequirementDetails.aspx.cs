using BAL;
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

        private void BindClientRequirementDetails(long clientId, long clientRequirementId, string status)
        {
            try
            {
                DataSet dsClientRequirement = new DataSet();
                ViewClientRequirementDetailsREBAL clientRequirementBAL = new ViewClientRequirementDetailsREBAL();
                dsClientRequirement = clientRequirementBAL.ViewClientRequirementDetailsBAL(clientId, clientRequirementId);
                if (status == "New")
                {
                    pnlNew.Visible = true;
                    pnlActive.Visible = false;
                    pnlInActive.Visible = false;

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

                        rptrContactPerson.DataSource = dsClientRequirement.Tables[1];
                        rptrContactPerson.DataBind();
                    }
                }
                else if (status == "Active")
                {
                    pnlActive.Visible = true;
                    pnlNew.Visible = false;
                    pnlInActive.Visible = false;
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

                        rptrActiveRequirement.DataSource = dsClientRequirement.Tables[1];
                        rptrActiveRequirement.DataBind();
                    }
                }
                else
                {
                    pnlActive.Visible = false;
                    pnlNew.Visible = false;
                    pnlInActive.Visible = true;
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

        protected void lnkbtnJobPost_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllJobPost.aspx?cId="+clientRequirementId);
        }
    }
}