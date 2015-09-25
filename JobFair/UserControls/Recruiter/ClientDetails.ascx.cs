using BAL;
using Entities.Recruiter;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.Forms.Recruiter
{
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

        private void BindDropDownFunctionalArea()
        {
            ds = clientDetailsBAL.GetFunctionalArea();
            ddlFunctionalArea.DataSource = ds;
            ddlFunctionalArea.DataValueField = "FunctionalAreaId";
            ddlFunctionalArea.DataTextField = "FunctionalArea";
            ddlFunctionalArea.DataBind();
            ddlFunctionalArea.Items.Insert(0, new ListItem("--Select--", "0"));
        }

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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            try
            {
                ClientDetailsBAL clientDetailsBAL = new ClientDetailsBAL();
                ClientDetailsEntity clientDetailsEntity = new ClientDetailsEntity();
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

        protected void ddlFunctionalArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            // for (int i = 0; i = ddlFunctionalArea.Items.Count - 1;i++ )
            // for (int i = 0; i = ddlFunctionalArea.Items[ddlFunctionalArea.Items.Count - 1].Value; i++ )
           
            if (ddlFunctionalArea.SelectedItem.ToString() == "Other")
            {
                txtAddfunctionalarea.Visible = true;
                btnAdd.Visible = true;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ddlFunctionalArea.Items.Add(new ListItem(txtAddress.Text, "Convert.ToInt32(ddlFunctionalArea.SelectedValue)+1"));
        }

        protected void ddlIndustry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlIndustry.SelectedItem.ToString() == "	Real Estate / Property")
            {
                txtAddfunctionalarea.Visible = true;
                btnAdd.Visible = true;
 
            }
        }
    }
}