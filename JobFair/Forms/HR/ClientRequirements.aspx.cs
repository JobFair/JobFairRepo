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
        private ClientDetailsBAL clientDetailsBAL = new ClientDetailsBAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    BindFunctionalArea();
                    BindIndustry();
                    BindCountry();
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }

        /// <summary>
        /// Method for binding DropDown with FunctionalArea_Table of Database
        /// </summary>
        private void BindFunctionalArea()
        {
            dsClientDetails = clientDetailsBAL.GetFunctionalArea();
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
            dsClientDetails = clientDetailsBAL.GetIndustry();
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
            dsClientDetails = clientDetailsBAL.GetCountry();
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
            dsClientDetails = clientDetailsBAL.GetState(countryId);
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
            dsClientDetails = clientDetailsBAL.GetCity(stateId);
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
            dsClientDetails = clientDetailsBAL.GetArea(cityId);
            ddlArea.DataSource = dsClientDetails;
            ddlArea.DataValueField = "areaID";
            ddlArea.DataTextField = "areaName";
            ddlArea.DataBind();
            ddlArea.Items.Insert(0, new ListItem("--Select--", "0"));
        }

    }
}