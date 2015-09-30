using BAL;
using Entities.Recruiter;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.Forms.Recruiter
{
    /// <summary>
    /// User Control Client Details
    /// </summary>
    public partial class ClientDetails : System.Web.UI.UserControl
    {
        private DataSet ds = new DataSet();
        private ClientDetailsBAL clientDetailsBAL = new ClientDetailsBAL();
        private ClientDetailsEntity clientDetailsEntity = new ClientDetailsEntity();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDropDownIndustry();
                BindDropDownFunctionalArea();
                BindDropDownCountry();
            }
        }

        /// <summary>
        /// Method for binding DropDown with FunctionalArea_Table of Database
        /// </summary>
        private void BindDropDownFunctionalArea()
        {
            ds = clientDetailsBAL.GetFunctionalArea();
            ddlFunctionalArea.DataSource = ds;
            ddlFunctionalArea.DataValueField = "FunctionalAreaId";
            ddlFunctionalArea.DataTextField = "FunctionalArea";
            ddlFunctionalArea.DataBind();

            ddlFunctionalArea.Items.Insert(Convert.ToInt32(ddlFunctionalArea.Items[ddlFunctionalArea.Items.Count - 1].Value), new ListItem("----Other----", ""));
            ddlFunctionalArea.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Method for binding DropDown with Industry_table of database
        /// </summary>
        private void BindDropDownIndustry()
        {
            ds = clientDetailsBAL.GetIndustry();
            ddlIndustry.DataSource = ds;
            ddlIndustry.DataTextField = "IndustryName";
            ddlIndustry.DataValueField = "IndustryId";
            ddlIndustry.DataBind();
            ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Method for binding Dropdown with Country_table of database
        /// </summary>
        private void BindDropDownCountry()
        {
            ds = clientDetailsBAL.GetCountry();
            ddlCountry.DataSource = ds;
            ddlCountry.DataTextField = "CountryName";
            ddlCountry.DataValueField = "CountryId";
            ddlCountry.DataBind();
            ddlCountry.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// ddlState_SelectedIndexChanged for selection of city on basis of stateid
        /// </summary>
        /// <param name="sender">The soure of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stateId = Convert.ToInt32(ddlState.SelectedValue);
            ds = clientDetailsBAL.GetCity(stateId);
            ddlCity.DataSource = ds;
            ddlCity.DataValueField = "cityID";
            ddlCity.DataTextField = "cityName";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        ///ddlCountry_SelectedIndexChanged for selection of state on basis of Countryid
        /// </summary>
        /// <param name="sender">The soure of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int countryId = Convert.ToInt32(ddlCountry.SelectedValue);
            ds = clientDetailsBAL.GetState(countryId);
            ddlState.DataSource = ds;
            ddlState.DataValueField = "StateId";
            ddlState.DataTextField = "StateName";
            ddlState.DataBind();
            ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender">The soure of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Saving the ClientDetails information by handling event btnSubmit_Click1
        /// </summary>
        /// <param name="sender">The soure of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            try
            {
                ClientDetailsBAL clientDetailsBAL = new ClientDetailsBAL();
                ClientDetailsEntity clientDetailsEntity = new ClientDetailsEntity();
                // Assign values to the entities
                clientDetailsEntity.ClientName = txtClientName.Text.Trim();
                clientDetailsEntity.Industry = Convert.ToInt32(ddlIndustry.SelectedValue);
                clientDetailsEntity.FunctionalArea = Convert.ToInt32(ddlFunctionalArea.SelectedValue);
                clientDetailsEntity.Country = Convert.ToInt32(ddlCountry.SelectedValue);
                clientDetailsEntity.State = Convert.ToInt32(ddlState.SelectedValue);
                clientDetailsEntity.City = Convert.ToInt32(ddlCity.SelectedValue);
                clientDetailsEntity.OfficialEmailId = txtEmailId.Text.Trim();
                clientDetailsEntity.Website = txtWebsite.Text.Trim();
                clientDetailsEntity.OfficialAddress = txtAddress.Text.Trim();
                clientDetailsEntity.ContactDetails = txtOfficialContact.Text.Trim();
                clientDetailsEntity.AgreementDate = Convert.ToDateTime(txtAgreementdate.Text);
                clientDetailsEntity.DueDate = Convert.ToDateTime(txtDueDate.Text);
                clientDetailsEntity.PaymentDetails = chklistPaymentDetails.SelectedItem.Value;
                clientDetailsEntity.PaymentTerms = txtPaymentTerms.Text.Trim();
                //Saving data to the database
                int result = clientDetailsBAL.SaveClientDetailsBAL(clientDetailsEntity);
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
                throw;
            }
        }

        /// <summary>
        ///ddlFunctionalArea_SelectedIndexChanged for checking the index of DropDown
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlFunctionalArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checking item of dropdown
            if (ddlFunctionalArea.SelectedItem.ToString() == "----Other----")
            {
                txtAddfunctionalarea.Visible = true;
                btnAdd.Visible = true;
            }
        }

        /// <summary>
        ///Adding new Functional Area in database
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">the<see cref="EventArgs"/>containing event data</param>
        protected void btnAdd_Click(object sender, EventArgs e)
        { // Assign values to entity
            clientDetailsEntity.AddFunctionalArea = txtAddfunctionalarea.Text;
            // Add data to the database 
            clientDetailsBAL.AddFunctionalAreaBAL(clientDetailsEntity);
            lblmsg2.Text = "Your data is added now";
        }
    }
}