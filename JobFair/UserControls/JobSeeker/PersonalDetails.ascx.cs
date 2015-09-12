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
        /// <summary>
        /// Class PersonalDetails
        /// </summary>
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
        /// <summary>
        /// Handles the Click event of the btnSubmit control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
             bool validated = false;
            try
            {
                PersonalDetailsJSBAL pdBAL = new PersonalDetailsJSBAL();
                PersonalDetailsJSEntity pdEntity = new PersonalDetailsJSEntity();

                validated = ValidatePersonalDetails();
                if (validated)
                {
                    // Set value to PersonalDetails job seeker entity
                    pdEntity.candidateId = "JS00001";//static data used because session value not set
                    pdEntity.presentAddress = txtPresentAddress.Text;
                    pdEntity.presentCountry = ddlCountryPresent.SelectedItem.Text;
                    pdEntity.presentState = ddlStatePresent.SelectedItem.Text;
                    pdEntity.presentCity = ddlCityPresent.SelectedItem.Text;
                    pdEntity.presentArea = txtAreaPresent.Text;
                    pdEntity.presentPincode = Convert.ToInt32(txtPincodePresent.Text);
                    pdEntity.permantAddress = txtAddressPerm.Text;
                    pdEntity.permantCountry = ddlCountryPerm.SelectedItem.Text;
                    pdEntity.permantState = ddlStatePerm.SelectedItem.Text;
                    pdEntity.permantCity = ddlCityPerm.SelectedItem.Text;
                    pdEntity.permantArea = txtAreaPerm.Text;
                    pdEntity.permantPincode = Convert.ToInt32(txtPincodePerm.Text);
                    pdEntity.dateOfBirth = Convert.ToDateTime(txtDOB.Text);

                    // Check if fileupload control has a file.
                    if (FileUploadPhoto.PostedFile != null)
                    {
                        pdEntity.photo = Path.GetFileName(FileUploadPhoto.PostedFile.FileName);
                        FileUploadPhoto.SaveAs(Server.MapPath("~/UploadImages/" + pdEntity.photo));

                    }

                    // Check if radio button check.
                    pdEntity.gender = string.Empty;
                    if (rbtMale.Checked)
                    {
                        pdEntity.gender = "Male";
                    }
                    else if (rbtFemale.Checked)
                    {
                        pdEntity.gender = "Female";
                    }

                    pdEntity.passportNumber = Convert.ToInt32(txtPassportNo.Text);
                    pdEntity.passportValidity = Convert.ToDateTime(txtValidity.Text);
                    pdEntity.workStatus = ddlWorkStatus.SelectedItem.Text;
                    pdEntity.maritialStatus = ddlMaritalStatus.SelectedItem.Text;
                    int result = pdBAL.PersonalDetailsBAL(pdEntity);
                    if (result > 0)
                    {
                        Response.Write("<script language='javascript'>alert('Personal Details Inserted')</script>");
                    }
                    else
                    {
                        Response.Write("<script language='javascript'>alert('Sorry')</script>");
                    }
                }
                else
                {
                    //Error message to user

                }
            }
            catch (Exception ex)
            {
                Label18.Text = ex.Message.ToString();
            }
        }
        /// <summary>
        /// For Chake Validation
        /// </summary>
        /// <returns></returns>
        private bool ValidatePersonalDetails()
        {
            bool validated = true;
            try
            {
                if (txtDOB.Text.Equals(String.Empty))
                {
                    validated = false;
                    return validated;
                }
            }
            catch (Exception)
            {
                //   throw;
            }
            return validated;
        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of the ddlCountryPresent control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Handles the SelectedIndexChanged event of the ddlStatePresent control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Handles the SelectedIndexChanged event of the ddlCountryPerm control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        ///  Handles the SelectedIndexChanged event of the ddlStatePerm control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        ///  Handles the CheckedChanged event of the rbtPassportYes control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void rbtPassportYes_CheckedChanged(object sender, EventArgs e)
        {
            lblpass.Visible = true;
            lblPassportValidity.Visible = true;
            txtPassportNo.Visible = true;
            txtValidity.Visible = true;
        }
        /// <summary>
        ///  Handles the CheckedChanged event of the rbtPassportNo control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void rbtPassportNo_CheckedChanged(object sender, EventArgs e)
        {
            lblpass.Visible = false;
            lblPassportValidity.Visible = false;
            txtPassportNo.Visible = false;
            txtValidity.Visible = false;
        }
    }
}