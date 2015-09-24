using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.Recruiter;
using System.Data;

namespace JobFair.Forms.Recruiter
{
    public partial class ClientDetails : System.Web.UI.UserControl
    {
        DataSet ds = new DataSet();
        ClientDetailsBAL clientDetailsBAL = new ClientDetailsBAL();
        ClientDetailsEntity clientDetailsEntity = new ClientDetailsEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //BindDropDownIndustry();
                //BindDropDownDepartment();
                //BindDropDownCountry();
            }

        }
        /// <summary>
        /// Method for binding Dropdown with Country_table of database
        /// </summary>
        //private void BindDropDownCountry()
        //{
        //    ds = clientDetailsBAL.GetCountry();
        //    ddlCountry.DataSource = ds;
        //    ddlCountry.DataTextField = "CountryName";
        //    ddlCountry.DataValueField = "CountryId";
        //    ddlCountry.DataBind();
        //    ddlCountry.Items.Insert(0, new ListItem("--Select--", "0"));
        //}


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ClientDetailsBAL clientDetailsBAL = new ClientDetailsBAL();
            ClientDetailsEntity clientDetailsEntity = new ClientDetailsEntity();
            clientDetailsEntity.ClientName = txtClientName.Text.Trim();
            clientDetailsEntity.Industry = ddlIndustry.SelectedIndex;
            clientDetailsEntity.FunctionalArea = ddlFunctionalArea.SelectedIndex;
            clientDetailsEntity.Country = ddlCountry.SelectedIndex;
            clientDetailsEntity.State = ddlState.SelectedIndex;
            clientDetailsEntity.City = ddlCity.SelectedIndex;
            clientDetailsEntity.OfficialEmailId = txtEmailId.Text.Trim();
            clientDetailsEntity.Website = txtWebsite.Text.Trim();
            clientDetailsEntity.OfficialAddress = txtAddress.Text.Trim();
            clientDetailsEntity.ContactDetails = txtOfficialContact.Text.Trim();
            clientDetailsEntity.PaymentDetails = chklistPaymentDetails.SelectedItem.Value;
            clientDetailsEntity.PaymentTerms = txtPaymentTerms.Text.Trim();



        }

       

      
      
    }
}