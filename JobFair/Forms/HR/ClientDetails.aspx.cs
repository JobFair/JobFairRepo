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
    public partial class ClientDetails : System.Web.UI.Page
    {
        private DataSet dsClientDetails = new DataSet();
        private ClientDetailsBAL clientDetailsBAL = new ClientDetailsBAL();
        private ClientDetailsEntity clientDetailsEntity = new ClientDetailsEntity();
        bool isView,isEdit;
        int HrId = 1; int ClientId = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    BindFunctionalArea();
                    BindIndustry();
                    BindCountry();
                    divView.Visible = false;
                }
                catch (Exception)
                {
                    //throw;
                }
            }
            isView = Convert.ToBoolean(Request.QueryString["isView"]);
            if (isView)
            {
                try
                {
                    BindViewClient();
                }
                catch (Exception)
                {
                    //throw;
                }
            }
            isEdit = Convert.ToBoolean(Request.QueryString["isEdit"]);
            if (isEdit)
            {
                try
                {
                    BindEditClient();
                    btnSubmit.Visible = false;
                    btnUpdate.Visible=true;

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
                ClientDetailsBAL clientDetailsBAL = new ClientDetailsBAL();
                ClientDetailsEntity clientDetailsEntity = new ClientDetailsEntity();
                // Assign values to the entities
                clientDetailsEntity.HrId = 1;
                clientDetailsEntity.ClientName = txtClientName.Text.Trim();
                clientDetailsEntity.ClientProfile = txtClientProfile.Text.Trim();
                clientDetailsEntity.Industry = Convert.ToInt32(ddlIndustry.SelectedValue);
                clientDetailsEntity.FunctionalArea = Convert.ToInt32(ddlFunctionalArea.SelectedValue);
                clientDetailsEntity.Address = txtAddress.Text.Trim();
                clientDetailsEntity.CountryId = Convert.ToInt32(ddlCountry.SelectedValue);
                clientDetailsEntity.StateId = Convert.ToInt32(ddlState.SelectedValue);
                clientDetailsEntity.CityId = Convert.ToInt32(ddlCity.SelectedValue);
                clientDetailsEntity.AreaId = Convert.ToInt32(ddlArea.SelectedValue);
                clientDetailsEntity.Pincode = Convert.ToInt32(txtPincode.Text.Trim());
                clientDetailsEntity.OfficialEmailId = txtOfficialEMailId.Text.Trim();
                clientDetailsEntity.Website = txtWebsite.Text.Trim();
                clientDetailsEntity.OfficialContact = txtOfficialContact.Text.Trim();
                clientDetailsEntity.Status = rbtlistStatus.SelectedItem.Text;
                clientDetailsEntity.AgreementDate = Convert.ToDateTime(txtAgreementDate.Text);
                clientDetailsEntity.DueDate = Convert.ToDateTime(txtDueDate.Text);


                var paymentdetails = chklistPaymentDetails.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                string payment =  string.Join(",", paymentdetails.Select(x => x.Text)) + ",";

                //List<string> payment = new List<string>();
                //foreach (ListItem item in chklistPaymentDetails.Items)
                //   {
                //       if (item.Selected)
                //       {
                //           payment.Add(item.Value);
                //       }
                //       lblPayment.Text = string.Join(",", payment.ToArray());
                //   }
                clientDetailsEntity.PaymentDetails = Convert.ToString(payment);
                clientDetailsEntity.PaymentTerms = txtPaymentTerms.Text.Trim();
                clientDetailsEntity.PercentageAmount = Convert.ToInt32(txtPercentageAmount.Text.Trim());
                // Saving data to the database
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
                //throw;
            }
        }

        /// <summary>
        /// Click event of btnCancel control
        /// </summary>
        /// <param name="sender">The soure of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }

        //private void BindClientName()
        //{
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        PostNewJobBAL postnewjobBAL = new PostNewJobBAL();
        //        ds = postnewjobBAL.GetClientName();
        //        if (ds != null)
        //        {
        //            ddlClientName.DataSource = ds;
        //            ddlClientName.DataTextField = "ClientName";
        //            ddlClientName.DataValueField = "ClientId";
        //            ddlClientName.DataBind();
        //            ddlClientName.Items.Insert(0, new ListItem("-----select--------", "0"));
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        //throw;
        //    }
        //}

        /// <summary>
        /// Method for binding Client Details for Viewing Purpose
        /// </summary>
        private void BindViewClient()
        {
            try
            {
                DataSet dsViewClient = new DataSet();
                dsViewClient = clientDetailsBAL.ViewClientDetailsBAL(ClientId, HrId);

                lblClientId.Text = dsViewClient.Tables[0].Rows[0]["ClientId"].ToString();
                lblHrId.Text = dsViewClient.Tables[0].Rows[0]["HrId"].ToString();
                lblViewClientName.Text = dsViewClient.Tables[0].Rows[0]["ClientName"].ToString();
                lblViewClientProfile.Text = dsViewClient.Tables[0].Rows[0]["ClientProfile"].ToString();
                lblViewIndustry.Text = dsViewClient.Tables[0].Rows[0]["IndustryName"].ToString();
                lblViewFunctionalArea.Text = dsViewClient.Tables[0].Rows[0]["FunctionalArea"].ToString();
                lblViewAddress.Text = dsViewClient.Tables[0].Rows[0]["Address"].ToString();
                lblViewCountry.Text = dsViewClient.Tables[0].Rows[0]["CountryName"].ToString();
                lblViewState.Text = dsViewClient.Tables[0].Rows[0]["StateName"].ToString();
                lblViewCity.Text = dsViewClient.Tables[0].Rows[0]["CityName"].ToString();
                lblViewArea.Text = dsViewClient.Tables[0].Rows[0]["AreaName"].ToString();
                lblViewPincode.Text = dsViewClient.Tables[0].Rows[0]["Pincode"].ToString();
                lblViewOfficialEMail.Text = dsViewClient.Tables[0].Rows[0]["OfficialEmailId"].ToString();
                lblViewWebsite.Text = dsViewClient.Tables[0].Rows[0]["Website"].ToString();
                lblViewOfficialContact.Text = dsViewClient.Tables[0].Rows[0]["OfficialContact"].ToString();
                lblViewStatus.Text = dsViewClient.Tables[0].Rows[0]["Status"].ToString();
                lblViewAgreementDate.Text = dsViewClient.Tables[0].Rows[0]["AgreementDate"].ToString();
                lblViewDueDate.Text = dsViewClient.Tables[0].Rows[0]["DueDate"].ToString();
                lblViewPaymentDetails.Text = dsViewClient.Tables[0].Rows[0]["PaymentDetails"].ToString();
                lblViewPaymentTerms.Text = dsViewClient.Tables[0].Rows[0]["PaymentTerms"].ToString();
                lblViewPercentageAmount.Text = dsViewClient.Tables[0].Rows[0]["PercentageAmount"].ToString();
            }
            catch (Exception)
            {
                throw;
            }
            divMain.Visible = false;
            divView.Visible = true;
        }
        /// <summary>
        /// Method for binding Client Details for Editing Purpose
        /// </summary>
        private void BindEditClient()
        {
            try
            {
                DataSet dsViewClient = new DataSet();
                dsViewClient = clientDetailsBAL.ViewClientDetailsBAL(ClientId, HrId);

                lblClientId.Text = dsViewClient.Tables[0].Rows[0]["ClientId"].ToString();
                lblHrId.Text = dsViewClient.Tables[0].Rows[0]["HrId"].ToString();
                txtClientName.Text = dsViewClient.Tables[0].Rows[0]["ClientName"].ToString();
                txtClientProfile.Text = dsViewClient.Tables[0].Rows[0]["ClientProfile"].ToString();
                ddlIndustry.SelectedValue = dsViewClient.Tables[0].Rows[0]["IndustryId"].ToString();
                ddlFunctionalArea.SelectedValue = dsViewClient.Tables[0].Rows[0]["FunctionalAreaId"].ToString();
                txtAddress.Text = dsViewClient.Tables[0].Rows[0]["Address"].ToString();
                ddlCountry.SelectedValue = dsViewClient.Tables[0].Rows[0]["CountryName"].ToString();
                ddlState.SelectedValue = dsViewClient.Tables[0].Rows[0]["StateName"].ToString();
                ddlCity.SelectedValue = dsViewClient.Tables[0].Rows[0]["CityName"].ToString();
                ddlArea.SelectedValue = dsViewClient.Tables[0].Rows[0]["AreaName"].ToString();
                txtPincode.Text = dsViewClient.Tables[0].Rows[0]["Pincode"].ToString();
                txtOfficialEMailId.Text = dsViewClient.Tables[0].Rows[0]["OfficialEmailId"].ToString();
                txtWebsite.Text = dsViewClient.Tables[0].Rows[0]["Website"].ToString();
                txtOfficialContact.Text = dsViewClient.Tables[0].Rows[0]["OfficialContact"].ToString();
                rbtlistStatus.SelectedValue = dsViewClient.Tables[0].Rows[0]["Status"].ToString();
                //txtAgreementDate.Text = dsViewClient.Tables[0].Rows[0]["AgreementDate"].ToString();

                string AgreementDate = Convert.ToString(dsViewClient.Tables[0].Rows[0]["AgreementDate"]); ;
                string[] AgreementDateSplit = AgreementDate.Split(new char[] { '-' });
                int Count = 0;
                foreach (string Word in AgreementDateSplit)
                {
                    Count += 1;
                    if (Count == 1)
                    { txtAgreementDate.Text = Word; }
                    if (Count == 2)
                    { txtAgreementDate.Text = Word; }
                    if (Count == 3)
                    { txtAgreementDate.Text = Word; }
                }

                //txtDueDate.Text = dsViewClient.Tables[0].Rows[0]["DueDate"].ToString();

                string DueDate = Convert.ToString(dsViewClient.Tables[0].Rows[0]["DueDate"]); ;
                string[] DueDateSplit = DueDate.Split(new char[] { '-' });
                Count = 0;
                foreach (string Word in DueDateSplit)
                {
                    Count += 1;
                    if (Count == 1)
                    { txtDueDate.Text = Word; }
                    if (Count == 2)
                    { txtDueDate.Text = Word; }
                    if (Count == 3)
                    { txtDueDate.Text = Word; }
                }

                chklistPaymentDetails.SelectedValue = dsViewClient.Tables[0].Rows[0]["PaymentDetails"].ToString();
                txtPaymentTerms.Text = dsViewClient.Tables[0].Rows[0]["PaymentTerms"].ToString();
                txtPercentageAmount.Text = dsViewClient.Tables[0].Rows[0]["PercentageAmount"].ToString();
            }
            catch (Exception)
            {
                throw;
            }
            divMain.Visible = true;
            divView.Visible = false;
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
        /// Adding new Functional Area in database
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

    }
}