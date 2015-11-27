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
        private bool isCheck = true;

        // isCheck = Convert.ToBoolean(Request.QueryString["isCheck"]);
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

                if (isCheck)
                {
                    try
                    {
                        DataSet dsPersonalDetails = new DataSet();
                        PersonalDetailsJSBAL personalDetailsJSBAL = new PersonalDetailsJSBAL();
                        dsPersonalDetails = personalDetailsJSBAL.ViewPersonalDetailsBAL(candidateId);
                        FileUploadPhoto.Visible = false;
                        DataSet dsPersentState = new DataSet();
                        int countryId = Convert.ToInt32(dsPersonalDetails.Tables[0].Rows[0]["PresentCountryId"]);
                        dsPersentState = personalDetailsJSBAL.GetState(countryId);
                        ddlStatePresent.DataSource = dsPersentState;
                        ddlStatePresent.DataTextField = "StateName";
                        ddlStatePresent.DataValueField = "StateId";
                        ddlStatePresent.DataBind();

                        DataSet dsPersentCity = new DataSet();
                        int stateId = Convert.ToInt32(dsPersonalDetails.Tables[0].Rows[0]["PresentStateId"]);
                        dsPersentCity = personalDetailsJSBAL.GetCity(stateId);
                        ddlCityPresent.DataSource = dsPersentCity;
                        ddlCityPresent.DataTextField = "CityName";
                        ddlCityPresent.DataValueField = "CityId";
                        ddlCityPresent.DataBind();

                        DataSet dsPersentArea = new DataSet();
                        int cityId = Convert.ToInt32(dsPersonalDetails.Tables[0].Rows[0]["PresentCityId"]);
                        dsPersentArea = personalDetailsJSBAL.GetArea(cityId);
                        ddlAreaPresent.DataSource = dsPersentArea;
                        ddlAreaPresent.DataTextField = "AreaName";
                        ddlAreaPresent.DataValueField = "AreaId";
                        ddlAreaPresent.DataBind();

                        DataSet dsPermanentState = new DataSet();
                        int permCountryId = Convert.ToInt32(dsPersonalDetails.Tables[0].Rows[0]["PermantCountryId"]);
                        dsPermanentState = personalDetailsJSBAL.GetState(permCountryId);
                        ddlStatePerm.DataSource = dsPermanentState;
                        ddlStatePerm.DataTextField = "StateName";
                        ddlStatePerm.DataValueField = "StateId";
                        ddlStatePerm.DataBind();

                        DataSet dsPermanentCity = new DataSet();
                        int permStateId = Convert.ToInt32(dsPersonalDetails.Tables[0].Rows[0]["PermantStateId"]);
                        dsPermanentCity = personalDetailsJSBAL.GetCity(permStateId);
                        ddlCityPerm.DataSource = dsPermanentCity;
                        ddlCityPerm.DataTextField = "CityName";
                        ddlCityPerm.DataValueField = "CityId";
                        ddlCityPerm.DataBind();

                        DataSet dsPermanentArea = new DataSet();
                        int permCityId = Convert.ToInt32(dsPersonalDetails.Tables[0].Rows[0]["PermantCityId"]);
                        dsPermanentArea = personalDetailsJSBAL.GetArea(permCityId);
                        ddlAreaPerm.DataSource = dsPermanentArea;
                        ddlAreaPerm.DataTextField = "AreaName";
                        ddlAreaPerm.DataValueField = "AreaId";
                        ddlAreaPerm.DataBind();

                        imgPersonalPhoto.ImageUrl = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["photo"]);
                        txtPresentAddress.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PresentAddress"]);
                        ddlCountryPresent.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PresentCountryId"]);
                        ddlStatePresent.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PresentStateId"]);
                        ddlCityPresent.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PresentCityId"]);
                        ddlAreaPresent.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PresentArea"]);
                        txtPincodePresent.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PresentPincode"]);
                        txtAddressPerm.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantAddress"]);
                        ddlCountryPerm.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantCountryId"]);
                        ddlStatePerm.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantStateId"]);
                        ddlCityPerm.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantCityId"]);
                        ddlAreaPerm.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantArea"]);
                        txtPincodePerm.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantPincode"]);
                        string date = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["DateOfBirth"]);
                        txtDOB.Text = DateTime.Parse(date).ToShortDateString();
                        string gender = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["Gender"]);
                        rbtGender.Items.FindByValue(gender).Selected = true;
                        string maritalStatus = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["MaritalStatus"]);
                        ddlMaritalStatus.Items.FindByValue(maritalStatus).Selected = true;
                        txtPassportNo.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PassportNumber"]);
                        string format = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PassportValidity"]); ;
                        string[] Words = format.Split(new char[] { '/' });
                        int count = 0;
                        foreach (string Word in Words)
                        {
                            count += 1;
                            if (count == 1)
                            { ddlMonth.SelectedValue = Word; }
                            if (count == 2)
                            { ddlYear.SelectedValue = Word; }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
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
            if (isCheck)
            {
                try
                {
                    PersonalDetailsJSEntity objPersonalDetailsEntity = new PersonalDetailsJSEntity();
                    PersonalDetailsJSBAL personalDetailsBAL = new PersonalDetailsJSBAL();

                    // Set value to PersonalDetails job seeker entity
                    objPersonalDetailsEntity.candidateId = candidateId;
                    objPersonalDetailsEntity.presentAddress = txtPresentAddress.Text.Trim();
                    objPersonalDetailsEntity.presentCountryId = Convert.ToInt32(ddlCountryPresent.SelectedValue);
                    objPersonalDetailsEntity.presentStateId = Convert.ToInt32(ddlStatePresent.SelectedValue);
                    objPersonalDetailsEntity.presentCityId = Convert.ToInt32(ddlCityPresent.SelectedValue);
                    objPersonalDetailsEntity.presentArea = Convert.ToInt32(ddlAreaPresent.SelectedValue);
                    objPersonalDetailsEntity.presentPincode = Convert.ToInt32(txtPincodePresent.Text);
                    objPersonalDetailsEntity.permantAddress = txtAddressPerm.Text.Trim();
                    objPersonalDetailsEntity.permantCountryId = Convert.ToInt32(ddlCountryPerm.SelectedValue);
                    objPersonalDetailsEntity.permantStateId = Convert.ToInt32(ddlStatePerm.SelectedValue);
                    objPersonalDetailsEntity.permantCityId = Convert.ToInt32(ddlCityPerm.SelectedValue);
                    objPersonalDetailsEntity.permantArea = Convert.ToInt32(ddlAreaPerm.SelectedValue);
                    objPersonalDetailsEntity.permantPincode = Convert.ToInt32(txtPincodePerm.Text);
                    objPersonalDetailsEntity.dateOfBirth = Convert.ToDateTime(txtDOB.Text);

                    // Check if fileupload control has a file.
                    if (FileUploadPhoto.PostedFile != null)
                    {
                        objPersonalDetailsEntity.photo = Path.GetFileName(FileUploadPhoto.PostedFile.FileName);
                        FileUploadPhoto.SaveAs(Server.MapPath("~/UploadImages/" + objPersonalDetailsEntity.photo));
                    }
                    else
                    {
                        objPersonalDetailsEntity.photo = Path.GetFileName(imgPersonalPhoto.ImageUrl);
                    }

                    // Check if radio button check.
                    objPersonalDetailsEntity.gender = rbtGender.SelectedItem.Text;

                    if (rbtPassportYes.Checked)
                    {
                        string validity = ddlMonth.SelectedItem.Text + '/' + ddlYear.SelectedItem.Text;
                        objPersonalDetailsEntity.passportNumber = Convert.ToInt32(txtPassportNo.Text);
                        objPersonalDetailsEntity.passportValidity = validity;
                    }
                    else
                    {
                        objPersonalDetailsEntity.passportNumber = Convert.ToInt32(null);
                        objPersonalDetailsEntity.passportValidity = "null";
                    }
                    objPersonalDetailsEntity.maritialStatus = ddlMaritalStatus.SelectedItem.Text;
                    int result = personalDetailsBAL.UpdatePersonalDetailsBAL(objPersonalDetailsEntity);
                    if (result > 0)
                    {
                        Response.Write("<script language='javascript'>alert('Personal Details Updated')</script>");
                    }
                    else
                    {
                        Response.Write("<script language='javascript'>alert('Sorry')</script>");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                //bool validated = false;
                try
                {
                    PersonalDetailsJSEntity personalDetailsEntity = new PersonalDetailsJSEntity();
                    PersonalDetailsJSBAL personalDetailsBAL = new PersonalDetailsJSBAL();

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
                    personalDetailsEntity.gender = rbtGender.SelectedItem.Text;

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
                }
                catch (Exception ex)
                {
                    Label18.Text = ex.Message.ToString();
                }
            }
        }

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

        protected void lnkbtnEdit_Click(object sender, EventArgs e)
        {
            lnkbtnCancel.Visible = true;
            FileUploadPhoto.Visible = true;
            lnkbtnEdit.Visible = false;
            imgPersonalPhoto.Visible = false;
        }

        protected void lnkbtnCancel_Click(object sender, EventArgs e)
        {
            FileUploadPhoto.Visible = false;
            lnkbtnEdit.Visible = true;
            imgPersonalPhoto.Visible = true;
            lnkbtnCancel.Visible = false;
        }
    }
}