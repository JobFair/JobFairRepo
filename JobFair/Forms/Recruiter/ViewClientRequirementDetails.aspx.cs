using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BAL;

namespace JobFair.Forms.Recruiter
{
    public partial class ViewClientRequirementDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            long clientId=0, clientRequirementId=0;
            clientId =Convert.ToInt64( Request.QueryString["cId"]);
            clientRequirementId = Convert.ToInt64(Request.QueryString["rId"]);
            BindClientRequirementDetails(clientId,clientRequirementId);
        }

        private void BindClientRequirementDetails(long clientId, long clientRequirementId)
        {
            try
            {
                DataSet dsClientRequirement = new DataSet();
                ViewClientRequirementDetailsREBAL clientRequirementBAL = new ViewClientRequirementDetailsREBAL();
                dsClientRequirement = clientRequirementBAL.ViewClientRequirementDetailsBAL(clientId, clientRequirementId);
                if(dsClientRequirement!=null)
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
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}