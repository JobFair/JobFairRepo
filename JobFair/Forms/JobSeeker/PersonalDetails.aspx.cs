using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities;

namespace JobFair.Forms.JobSeeker
{
    public partial class PersonalDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PersonalDetailsJSBAL pdBAL = new PersonalDetailsJSBAL();
                ddlCountryPresent.DataSource = pdBAL.LoadCountryAll();
                ddlCountryPresent.DataTextField = "CountryName";
                ddlCountryPresent.DataValueField = "CountryId";
                ddlCountryPresent.DataBind();
                ddlCountryPresent.Items.Insert(0,new ListItem("--Select--","0"));

                ddlCountryPerm.DataSource = pdBAL.LoadCountryAll();
                ddlCountryPerm.DataTextField = "CountryName";
                ddlCountryPerm.DataValueField = "CountryId";
                ddlCountryPerm.DataBind();
                ddlCountryPerm.Items.Insert(0, new ListItem("--Select--", "0"));
            }
        }

       

        protected void ddlCountryPresent_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonalDetailsJSBAL pdBAL = new PersonalDetailsJSBAL();
            int CountryId =Convert.ToInt32( ddlCountryPresent.SelectedValue);
            ddlStatePresent.DataSource = pdBAL.LoadStateAll(CountryId);
            ddlStatePresent.DataTextField = "StateName";
            ddlStatePresent.DataValueField = "StateId";
            ddlStatePresent.DataBind();
            ddlStatePresent.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void ddlStatePresent_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonalDetailsJSBAL pdBAL = new PersonalDetailsJSBAL();
            int StateId = Convert.ToInt32(ddlStatePresent.SelectedValue);
            ddlCityPresent.DataSource = pdBAL.LoadCityAll(StateId);
            ddlCityPresent.DataTextField = "cityName";
            ddlCityPresent.DataValueField = "cityID";
            ddlCityPresent.DataBind();
            ddlCityPresent.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void ddlCountryPerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonalDetailsJSBAL pdBAL = new PersonalDetailsJSBAL();
            int CountryId = Convert.ToInt32(ddlCountryPerm.SelectedValue);
            ddlStatePerm.DataSource = pdBAL.LoadStateAll(CountryId);
            ddlStatePerm.DataTextField = "StateName";
            ddlStatePerm.DataValueField = "StateId";
            ddlStatePerm.DataBind();
            ddlStatePerm.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void ddlStatePerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonalDetailsJSBAL pdBAL = new PersonalDetailsJSBAL();
            int StateId = Convert.ToInt32(ddlStatePerm.SelectedValue);
            ddlCityPerm.DataSource = pdBAL.LoadCityAll(StateId);
            ddlCityPerm.DataTextField = "cityName";
            ddlCityPerm.DataValueField = "cityID";
            ddlCityPerm.DataBind();
            ddlCityPerm.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            
                PersonalDetailsJSBAL pdBAL = new PersonalDetailsJSBAL();
                PersonalDetailsJSEntity pdEntity = new PersonalDetailsJSEntity();
                pdEntity.userID = "";
                pdEntity.PressentAddress = txtPresentAddress.Text;
                pdEntity.PressentCountry = ddlCountryPresent.SelectedItem.Text;
                pdEntity.PressentState = ddlStatePresent.SelectedItem.Text;
                pdEntity.PressentCity = ddlCityPresent.SelectedItem.Text;
                pdEntity.PresentArea = TextBox1.Text;
                pdEntity.PresentPincode =Convert.ToInt32(txtPincodePresent.Text);
                pdEntity.PermantAddress = txtAddressPerm.Text;
                pdEntity.PermantCountry = ddlCountryPerm.SelectedItem.Text;
                pdEntity.PermantState = ddlStatePerm.SelectedItem.Text;
                pdEntity.PermantCity = ddlCityPerm.SelectedItem.Text;
                pdEntity.PermantArea = TextBox2.Text;
                pdEntity.PermantPincode = Convert.ToInt32(txtPincodePerm.Text);
                pdEntity.DateOfBirth = Convert.ToDateTime(txtDOB.Text);
                //pdEntity.Gender = RadioButtonList1.SelectedItem.Value.ToString();
               
               
                
        }

        
        }
    }
