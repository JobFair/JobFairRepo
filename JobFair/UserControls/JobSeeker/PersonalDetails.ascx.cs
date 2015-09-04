using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities;
using System.IO;

namespace JobFair.UserControls.JobSeeker
{
    public partial class PersonalDetails : System.Web.UI.UserControl
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
                ddlCountryPresent.Items.Insert(0, new ListItem("--Select--", "0"));

                ddlCountryPerm.DataSource = pdBAL.LoadCountryAll();
                ddlCountryPerm.DataTextField = "CountryName";
                ddlCountryPerm.DataValueField = "CountryId";
                ddlCountryPerm.DataBind();
                ddlCountryPerm.Items.Insert(0, new ListItem("--Select--", "0"));
  
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            PersonalDetailsJSBAL pdBAL = new PersonalDetailsJSBAL();
            PersonalDetailsJSEntity pdEntity = new PersonalDetailsJSEntity();
            pdEntity.photo = FileUploadPhoto.FileName;
            pdEntity.presentAddress=txtPresentAddress.Text;
            pdEntity.presentCountry=ddlCountryPresent.SelectedItem.Text;
            pdEntity.presentState=ddlStatePresent.SelectedItem.Text;
            pdEntity.presentCity=ddlCityPresent.SelectedItem.Text;
            pdEntity.presentArea=txtAreaPresent.Text;
            pdEntity.presentPincode=Convert.ToInt32( txtPincodePresent.Text);
            pdEntity.permantAddress=txtAddressPerm.Text;
            pdEntity.permantCountry=ddlCountryPerm.SelectedItem.Text;
            pdEntity.permantState=ddlStatePerm.SelectedItem.Text;
            pdEntity.permantCity=ddlCityPerm.SelectedItem.Text;
            pdEntity.permantArea=txtAreaPerm.Text;
            pdEntity.permantPincode=Convert.ToInt32( txtPincodePerm.Text);
            pdEntity.dateOfBirth=Convert.ToDateTime( txtDOB.Text);

            // upload img
            Stream fs = FileUploadPhoto.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(fs);
            Byte[] bytes = br.ReadBytes((Int32)fs.Length);

          string gender = string.Empty;
    if (rbtMale.Checked)
    {
        gender = "Male";
    }
    else if (rbtFemale.Checked)
    {
        gender = "Female";
    }
            pdEntity.workStatus=ddlWorkStatus.SelectedItem.Text;

        }

        protected void ddlCountryPresent_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonalDetailsJSBAL pdBAL = new PersonalDetailsJSBAL();
            int CountryId = Convert.ToInt32(ddlCountryPresent.SelectedValue);
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



        protected void rbtPassportYes_CheckedChanged(object sender, EventArgs e)
        {
            lblpass.Visible = true;
            lblPassportValidity.Visible = true;
            txtPassportNo.Visible = true;
            txtValidity.Visible = true;
        }

        protected void rbtPassportNo_CheckedChanged(object sender, EventArgs e)
        {
            lblpass.Visible = false;
            lblPassportValidity.Visible = false;
            txtPassportNo.Visible = false;
            txtValidity.Visible = false;
        }

        

        
    }
}