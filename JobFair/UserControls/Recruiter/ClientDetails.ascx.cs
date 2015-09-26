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
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlFunctionalArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlFunctionalArea.SelectedItem.ToString() == "----Other----")
            {
                txtAddfunctionalarea.Visible = true;
                btnAdd.Visible = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //Label1.Text = ddlFunctionalArea.Items[ddlFunctionalArea.Items.Count - 2].Value;
            //ddlFunctionalArea.Items.Insert(Convert.ToInt32(ddlFunctionalArea.Items[ddlFunctionalArea.Items.Count - 2].Value), txtAddfunctionalarea.Text);
            clientDetailsEntity.AddFunctionalArea = txtAddfunctionalarea.Text;
            clientDetailsEntity.FunctionalAreaId = Convert.ToInt32(ddlFunctionalArea.Items[ddlFunctionalArea.Items.Count - 1].Value) + 1;
            clientDetailsBAL.AddFunctionalAreaBAL(clientDetailsEntity);
        }
    }
}