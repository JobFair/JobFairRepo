using BAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    public partial class PersonalDetails : System.Web.UI.UserControl
    {
        private string candidateId;

        /// <summary>
        /// Class PersonalDetails
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            candidateId = Convert.ToString(Session["candidateId"]);

            if (!IsPostBack)
            {
                GetCountryPresent();
                GetCountryPerm();

                // Bind Month List
                List<string> monthList = CommonUtil.Utility.GetMonths();
                ddlMonth.DataSource = monthList;
                ddlMonth.DataBind();
                ddlMonth.Items.Insert(0, new ListItem("--Select--", "0"));

                // Bind Year List
                List<string> yearList = GetYears();
                ddlYear.DataSource = yearList;
                ddlYear.DataBind();
                ddlYear.Items.Insert(0, new ListItem("--Select--", "0"));
            }
             bool isCheck=true;
           
           // isCheck = Convert.ToBoolean(Request.QueryString["isCheck"]);
            if(isCheck)
            {
                try
                {
                    DataSet ds = new DataSet();
                    PersonalDetailsJSBAL personalDetailsJSBAL = new PersonalDetailsJSBAL();
                    ds = personalDetailsJSBAL.ViewPersonalDetailsBAL(candidateId);
                    txtPresentAddress.Text =Convert.ToString(ds.Tables[0].Rows[0]["PresentAddress"]);
                    ddlCountryPresent.SelectedItem.Text = Convert.ToString(ds.Tables[0].Rows[0]["PresentCountryId"]);
                   // ddlStatePresent.SelectedItem.Text = Convert.ToString(ds.Tables[0].Rows[0]["PresentStateId"]);
                   // ddlCityPresent.SelectedItem.Text = Convert.ToString(ds.Tables[0].Rows[0]["PresentCityId"]);
                  //  ddlAreaPresent.SelectedItem.Text = Convert.ToString(ds.Tables[0].Rows[0]["PresentArea"]);
                    txtPincodePresent.Text = Convert.ToString(ds.Tables[0].Rows[0]["PresentPincode"]);
                    txtAddressPerm.Text = Convert.ToString(ds.Tables[0].Rows[0]["PermantAddress"]);
                    ddlCountryPerm.SelectedItem.Text = Convert.ToString(ds.Tables[0].Rows[0]["PermantCountryId"]);
                   // ddlStatePerm.SelectedItem.Text = Convert.ToString(ds.Tables[0].Rows[0]["PermantStateId"]);
                   // ddlCityPerm.SelectedItem.Text = Convert.ToString(ds.Tables[0].Rows[0]["PermantCityId"]);
                  //  ddlAreaPerm.SelectedItem.Text = Convert.ToString(ds.Tables[0].Rows[0]["PermantArea"]);
                    txtPincodePerm.Text = Convert.ToString(ds.Tables[0].Rows[0]["PermantPincode"]);
                    txtDOB.Text = Convert.ToString(ds.Tables[0].Rows[0]["DateOfBirth"]);
                    string maritalStatus = Convert.ToString(ds.Tables[0].Rows[0]["MaritalStatus"]);
                    ddlMaritalStatus.Items.FindByValue(maritalStatus).Selected = true;
                    //ddlMaritalStatus.Items.FindByValue(asch);
                    txtPassportNo.Text = Convert.ToString(ds.Tables[0].Rows[0]["PassportNumber"]);
                    ddlMonth.SelectedItem.Text = Convert.ToString(ds.Tables[0].Rows[0]["PassportValidity"]);
                    ddlYear.SelectedItem.Text = Convert.ToString(ds.Tables[0].Rows[0]["PassportValidity"]);
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
        }
         
        private static List<string> GetYears()
        {
            try
            {
                List<string> yearList = new List<string>();
                int i = DateTime.Now.Year;
                for (i = i - 60; i <= DateTime.Now.Year + 30; i++)
                    yearList.Add(Convert.ToString(i));
                return yearList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GetCountryPresent()
        {
            try
            {
                PersonalDetailsJSBAL personalDetailsBAL = new PersonalDetailsJSBAL();
                DataSet ds = new DataSet();
                ds = personalDetailsBAL.GetCountry();
                ddlCountryPresent.DataSource = ds;
                ddlCountryPresent.DataTextField = "CountryName";
                ddlCountryPresent.DataValueField = "CountryId";
                ddlCountryPresent.DataBind();
                ddlCountryPresent.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GetCountryPerm()
        {
            try
            {
                PersonalDetailsJSBAL personalDetailsBAL = new PersonalDetailsJSBAL();
                DataSet ds = new DataSet();
                ds = personalDetailsBAL.GetCountry();
                ddlCountryPerm.DataSource = ds;
                ddlCountryPerm.DataTextField = "CountryName";
                ddlCountryPerm.DataValueField = "CountryId";
                ddlCountryPerm.DataBind();
                ddlCountryPerm.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSubmit control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //bool validated = false;
            try
            {
                PersonalDetailsJSEntity personalDetailsEntity = new PersonalDetailsJSEntity();
                PersonalDetailsJSBAL personalDetailsBAL = new PersonalDetailsJSBAL();
                //validated = ValidatePersonalDetails();
                //if (validated)
                //{
                // Set value to PersonalDetails job seeker entity
                personalDetailsEntity.candidateId = candidateId;
                personalDetailsEntity.presentAddress = txtPresentAddress.Text.Trim();
                personalDetailsEntity.presentCountryId = Convert.ToInt32(ddlCountryPresent.SelectedValue);
                personalDetailsEntity.presentStateId = Convert.ToInt32(ddlStatePresent.SelectedValue);
                personalDetailsEntity.presentCityId = Convert.ToInt32(ddlCityPresent.SelectedValue);
                personalDetailsEntity.presentArea = Convert.ToInt32(ddlAreaPresent.SelectedValue);
                personalDetailsEntity.presentPincode = Convert.ToInt32(txtPincodePresent.Text);
                personalDetailsEntity.permantAddress = txtAddressPerm.Text.Trim();
                personalDetailsEntity.permantCountryId = Convert.ToInt32(ddlCountryPerm.SelectedValue);
                personalDetailsEntity.permantStateId = Convert.ToInt32(ddlStatePerm.SelectedValue);
                personalDetailsEntity.permantCityId = Convert.ToInt32(ddlCityPerm.SelectedValue);
                personalDetailsEntity.permantArea = Convert.ToInt32(ddlAreaPerm.SelectedValue);
                personalDetailsEntity.permantPincode = Convert.ToInt32(txtPincodePerm.Text);
                personalDetailsEntity.dateOfBirth = Convert.ToDateTime(txtDOB.Text);

                // Check if fileupload control has a file.
                if (FileUploadPhoto.PostedFile != null)
                {
                    personalDetailsEntity.photo = Path.GetFileName(FileUploadPhoto.PostedFile.FileName);
                    FileUploadPhoto.SaveAs(Server.MapPath("~/UploadImages/" + personalDetailsEntity.photo));
                }

                // Check if radio button check.
                personalDetailsEntity.gender = string.Empty;
                if (rbtMale.Checked)
                {
                    personalDetailsEntity.gender = "Male";
                }
                else if (rbtFemale.Checked)
                {
                    personalDetailsEntity.gender = "Female";
                }
                if (rbtPassportYes.Checked)
                {
                    string validity = ddlMonth.SelectedItem.Text + '/' + ddlYear.SelectedItem.Text;
                    personalDetailsEntity.passportNumber = Convert.ToInt32(txtPassportNo.Text);
                    personalDetailsEntity.passportValidity = validity;
                }
                else
                {
                    personalDetailsEntity.passportNumber = Convert.ToInt32(null);
                    personalDetailsEntity.passportValidity = "null";
                }
                personalDetailsEntity.maritialStatus = ddlMaritalStatus.SelectedItem.Text;
                int result = personalDetailsBAL.SavePersonalDetailsBAL(personalDetailsEntity);
                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('Personal Details Inserted')</script>");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Sorry')</script>");
                }
                //}
                //else
                //{
                //    //Error message to user
                //}
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
        //private bool ValidatePersonalDetails()
        //{
        //    bool validated = true;
        //    try
        //    {
        //        if (txtDOB.Text.Equals(String.Empty))
        //        {
        //            validated = false;
        //            return validated;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        //   throw;
        //    }
        //    return validated;
        //}

        /// <summary>
        /// Handles the SelectedIndexChanged event of the ddlCountryPresent control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlCountryPresent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PersonalDetailsJSBAL personalDetailsBAL = new PersonalDetailsJSBAL();
                int CountryId = Convert.ToInt32(ddlCountryPresent.SelectedValue);
                DataSet ds = new DataSet();
                ds = personalDetailsBAL.GetState(CountryId);
                ddlStatePresent.DataSource = ds;

                ddlStatePresent.DataTextField = "StateName";
                ddlStatePresent.DataValueField = "StateId";
                ddlStatePresent.DataBind();
                ddlStatePresent.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the ddlStatePresent control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlStatePresent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PersonalDetailsJSBAL personalDetailsBAL = new PersonalDetailsJSBAL();
                int StateId = Convert.ToInt32(ddlStatePresent.SelectedValue);
                DataSet ds = new DataSet();
                ds = personalDetailsBAL.GetCity(StateId);
                ddlCityPresent.DataSource = ds;
                ddlCityPresent.DataTextField = "cityName";
                ddlCityPresent.DataValueField = "cityID";
                ddlCityPresent.DataBind();
                ddlCityPresent.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the ddlCountryPerm control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlCountryPerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PersonalDetailsJSBAL personalDetailsBAL = new PersonalDetailsJSBAL();
                int CountryId = Convert.ToInt32(ddlCountryPerm.SelectedValue);
                DataSet ds = new DataSet();
                ds = personalDetailsBAL.GetState(CountryId);
                ddlStatePerm.DataSource = ds;
                ddlStatePerm.DataTextField = "StateName";
                ddlStatePerm.DataValueField = "StateId";
                ddlStatePerm.DataBind();
                ddlStatePerm.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///  Handles the SelectedIndexChanged event of the ddlStatePerm control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlStatePerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PersonalDetailsJSBAL personalDetailsBAL = new PersonalDetailsJSBAL();
                int StateId = Convert.ToInt32(ddlStatePerm.SelectedValue);
                DataSet ds = new DataSet();
                ds = personalDetailsBAL.GetCity(StateId);
                ddlCityPerm.DataSource = ds;
                ddlCityPerm.DataTextField = "cityName";
                ddlCityPerm.DataValueField = "cityID";
                ddlCityPerm.DataBind();
                ddlCityPerm.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///  Handles the CheckedChanged event of the rbtPassportYes control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void rbtPassportYes_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                lblpass.Visible = true;
                lblPassportValidity.Visible = true;
                txtPassportNo.Visible = true;
                ddlMonth.Visible = true;
                ddlYear.Visible = true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///  Handles the CheckedChanged event of the rbtPassportNo control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void rbtPassportNo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                lblpass.Visible = false;
                lblPassportValidity.Visible = false;
                txtPassportNo.Visible = false;
                ddlMonth.Visible = false;
                ddlYear.Visible = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void ddlCityPresent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PersonalDetailsJSBAL personalDetailsBAL = new PersonalDetailsJSBAL();
                int cityId = Convert.ToInt32(ddlCityPresent.SelectedValue);
                DataSet ds = new DataSet();
                ds = personalDetailsBAL.GetArea(cityId);
                ddlAreaPresent.DataSource = ds;
                ddlAreaPresent.DataTextField = "AreaName";
                ddlAreaPresent.DataValueField = "AreaID";
                ddlAreaPresent.DataBind();
                ddlAreaPresent.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void ddlCityPerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PersonalDetailsJSBAL personalDetailsBAL = new PersonalDetailsJSBAL();
                int cityId = Convert.ToInt32(ddlCityPerm.SelectedValue);
                DataSet ds = new DataSet();
                ds = personalDetailsBAL.GetArea(cityId);
                ddlAreaPerm.DataSource = ds;
                ddlAreaPerm.DataTextField = "AreaName";
                ddlAreaPerm.DataValueField = "AreaID";
                ddlAreaPerm.DataBind();
                ddlAreaPerm.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}