using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.HR;
using System.Data;

namespace JobFair.Forms.HR
{
    public partial class ClientRequirements : System.Web.UI.Page
    {
        private DataSet dsClientDetails = new DataSet();
        private ClientRequirementsHRBAL clientRequirementsHRBAL = new ClientRequirementsHRBAL();
        int HrId = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    BindFunctionalArea();
                    BindIndustry();
                    BindCountry();
                    BindClient();
                    BindRecruiter(HrId);
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //ClientRequirementsHRBAL clientRequirementsHRBAL = new ClientRequirementsHRBAL();
                ClientRequirementsHREntity clientRequirementsHREntity = new ClientRequirementsHREntity();
                // Assign values to the entities
                clientRequirementsHREntity.HrId = 1;
                clientRequirementsHREntity.ClientId = 1;
                clientRequirementsHREntity.ClientName = ddlClientName.SelectedValue.Trim();
                clientRequirementsHREntity.ClientProfile = txtClientProfile.Text.Trim();
                clientRequirementsHREntity.Position = txtPosition.Text.Trim();
                clientRequirementsHREntity.Industry = Convert.ToInt32(ddlIndustry.SelectedValue);
                clientRequirementsHREntity.FunctionalArea = Convert.ToInt32(ddlFunctionalArea.SelectedValue);
                clientRequirementsHREntity.Address = txtAddress.Text.Trim();
                clientRequirementsHREntity.CountryId = Convert.ToInt32(ddlCountry.SelectedValue);
                clientRequirementsHREntity.StateId = Convert.ToInt32(ddlState.SelectedValue);
                clientRequirementsHREntity.CityId = Convert.ToInt32(ddlCity.SelectedValue);
                clientRequirementsHREntity.AreaId = Convert.ToInt32(ddlArea.SelectedValue);
                clientRequirementsHREntity.Pincode = Convert.ToInt32(txtPincode.Text.Trim());
                clientRequirementsHREntity.Skillsets = txtSkillsets.Text.Trim();
                clientRequirementsHREntity.Contents = txtContents.Text.Trim();
                clientRequirementsHREntity.DateOfRequirementSent = Convert.ToDateTime(txtDateofRequirementSent.Text);
                clientRequirementsHREntity.DueDate = Convert.ToDateTime(txtDueDate.Text);
                clientRequirementsHREntity.Status = rbtlistStatus.SelectedItem.Value;
                clientRequirementsHREntity.RecruiterID = Convert.ToInt32(ddlRecruiter.SelectedValue);

                // Saving data to the database
                int result = clientRequirementsHRBAL.SaveClientRequirementsBAL(clientRequirementsHREntity);
                if (result > 0)
                {
                    lblmsg.Text = "Saved Data Successfully";
                }
                else
                {
                    lblmsg.Text = "Data is not saved";
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }

      //  [System.Web.Script.Services.ScriptMethod()]
      //  [System.Web.Services.WebMethod]
      //  public static List<KeyValuePair<int, string>> GetRecruiter(string prefixText, int count)
      //{
      //      DataTable dtRecruiter = new DataTable();

      //      ClientRequirementsHRBAL clientRequirementsHRBAL = new ClientRequirementsHRBAL();
      //      dtRecruiter = clientRequirementsHRBAL.GetRecruiterBAL(prefixText, count);
      //      //List<string> recruitername = new List<string>();
      //      //List<int> recruiterId = new List<int>();

            
      //      var RecruiterList = new List<KeyValuePair<int, string>>();
      //      //RecruiterList.Add(new KeyValuePair<int, string>(1, "One");


      //      int recruiterId; string recruitername;


      //      try
      //      {
      //          // Check datatable is not null
      //          if (dtRecruiter != null)
      //          {
      //              foreach (var item in RecruiterList)
      //              {
      //                  recruiterId = Convert.ToInt16(dtRecruiter.Rows[0]["@RecruiterID"]);
      //                  recruitername = Convert.ToString(dtRecruiter.Rows[0]["@RecruiterfullName"]); ;
      //              }
                    
      //              //for (int i = 0; i < dtRecruiter.Rows.Count; i++)
      //              //{
      //              //    recruitername.Add(dtRecruiter.Rows[i][1].ToString());
      //              //}
      //          }
      //      }
      //      catch (Exception) 
      //      {
      //          //  throw;
      //      }
      //      return RecruiterList;
      //  }

        /// <summary>
        /// Method for binding DropDown with Client_table of database
        /// </summary>
        private void BindClient()
        {
            dsClientDetails = clientRequirementsHRBAL.GetClientNameBAL();
            ddlClientName.DataSource = dsClientDetails;
            ddlClientName.DataTextField = "ClientName";
            ddlIndustry.DataValueField = "ClientId";
            ddlClientName.DataBind();

            //txtClientProfile. = "ClientName";
            //ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Method for binding DropDown with Recruiter_table of database
        /// </summary>
        private void BindRecruiter(int HrId)
        {
            dsClientDetails = clientRequirementsHRBAL.GetRecruiterBAL(HrId);
            ddlRecruiter.DataSource = dsClientDetails;
            ddlRecruiter.DataTextField = "RecruiterfullName";
            ddlRecruiter.DataValueField = "RecruiterID";
            ddlRecruiter.DataBind();
        }
        /// <summary>
        /// Method for binding DropDown with FunctionalArea_Table of Database
        /// </summary>
        private void BindFunctionalArea()
        {
            dsClientDetails = clientRequirementsHRBAL.GetFunctionalArea();
            ddlFunctionalArea.DataSource = dsClientDetails;
            ddlFunctionalArea.DataValueField = "FunctionalAreaId";
            ddlFunctionalArea.DataTextField = "FunctionalArea";
            ddlFunctionalArea.DataBind();
            ddlFunctionalArea.Items.Insert(0, new ListItem("--Select--", "0"));

        }

        /// <summary>
        /// Method for binding DropDown with Industry_table of database
        /// </summary>
        private void BindIndustry()
        {
            dsClientDetails = clientRequirementsHRBAL.GetIndustry();
            ddlIndustry.DataSource = dsClientDetails;
            ddlIndustry.DataTextField = "IndustryName";
            ddlIndustry.DataValueField = "IndustryId";
            ddlIndustry.DataBind();
            ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Method for binding Dropdown with Country_table of database
        /// </summary>
        private void BindCountry()
        {
            dsClientDetails = clientRequirementsHRBAL.GetCountry();
            ddlCountry.DataSource = dsClientDetails;
            ddlCountry.DataTextField = "CountryName";
            ddlCountry.DataValueField = "CountryId";
            ddlCountry.DataBind();
            ddlCountry.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        /// <summary>
        /// ddlCountry_SelectedIndexChanged for selection of state on basis of Countryid
        /// </summary>
        /// <param name="sender">The soure of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int countryId = Convert.ToInt32(ddlCountry.SelectedValue);
            dsClientDetails = clientRequirementsHRBAL.GetState(countryId);
            ddlState.DataSource = dsClientDetails;
            ddlState.DataValueField = "StateId";
            ddlState.DataTextField = "StateName";
            ddlState.DataBind();
            ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        /// <summary>
        /// ddlState_SelectedIndexChanged for selection of city on basis of stateid
        /// </summary>
        /// <param name="sender">The soure of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stateId = Convert.ToInt32(ddlState.SelectedValue);
            dsClientDetails = clientRequirementsHRBAL.GetCity(stateId);
            ddlCity.DataSource = dsClientDetails;
            ddlCity.DataValueField = "cityID";
            ddlCity.DataTextField = "cityName";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        /// <summary>
        /// ddlCity_SelectedIndexChanged for selection of city on basis of stateid
        /// </summary>
        /// <param name="sender">The soure of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cityId = Convert.ToInt32(ddlCity.SelectedValue);
            dsClientDetails = clientRequirementsHRBAL.GetArea(cityId);
            ddlArea.DataSource = dsClientDetails;
            ddlArea.DataValueField = "areaID";
            ddlArea.DataTextField = "areaName";
            ddlArea.DataBind();
            ddlArea.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void ddlRecruiter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}