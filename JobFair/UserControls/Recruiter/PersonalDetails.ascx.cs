using BAL;
using Entities.Recruiter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.Recruiter
{
    public partial class PersonalDetails : System.Web.UI.UserControl
    {
        private DataSet dsCountry = null;
        private bool isEdit = true;
        private Int64 recruiterId = 12;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetCountryPresent();
                GetCountryPerm();
                GetMonths();
                GetYear();
                if (isEdit)
                {
                    BindPersonalDatails();
                }
            }
        }

        private void BindPersonalDatails()
        {
            try
            {
                string date, maritalStatus, format;
                int countryId, stateId, cityId, permCountryId, permStateId, permCityId, count = 0;
                DataSet dsPersonalDetails = new DataSet();
                PersonalDetailsREBAL personalDetailsREBAL = new PersonalDetailsREBAL();
                dsPersonalDetails = personalDetailsREBAL.ViewPersonalDetailsBAL(recruiterId);
                // Check dataset is not null
                if (dsPersonalDetails != null)
                {
                    // Check the count than zero
                    if (dsPersonalDetails.Tables.Count > 0)
                    {
                        // Check rows greater than zero
                        if (dsPersonalDetails.Tables[0].Rows.Count > 0)
                        {
                            pnlPresentAdd.Visible = true;
                            DataSet dsPersentState = new DataSet();
                            countryId = Convert.ToInt32(dsPersonalDetails.Tables[1].Rows[0]["PresentCountry"]);
                            dsPersentState = personalDetailsREBAL.GetState(countryId);
                            // Check dsPresentState is not null
                            if (dsPersentState != null)
                            {
                                ddlStatePresent.DataSource = dsPersentState;
                                ddlStatePresent.DataTextField = "StateName";
                                ddlStatePresent.DataValueField = "StateId";
                                ddlStatePresent.DataBind();
                            }

                            DataSet dsPersentCity = new DataSet();
                            stateId = Convert.ToInt32(dsPersonalDetails.Tables[1].Rows[0]["PresentState"]);
                            dsPersentCity = personalDetailsREBAL.GetCity(stateId);
                            // Check dsPresentCity is not null
                            if (dsPersentCity != null)
                            {
                                ddlCityPresent.DataSource = dsPersentCity;
                                ddlCityPresent.DataTextField = "CityName";
                                ddlCityPresent.DataValueField = "CityId";
                                ddlCityPresent.DataBind();
                            }

                            DataSet dsPersentArea = new DataSet();
                            cityId = Convert.ToInt32(dsPersonalDetails.Tables[1].Rows[0]["PresentCity"]);
                            dsPersentArea = personalDetailsREBAL.GetArea(cityId);
                            // Check dsPresentArea is not null
                            if (dsPersentArea != null)
                            {
                                ddlAreaPresent.DataSource = dsPersentArea;
                                ddlAreaPresent.DataTextField = "AreaName";
                                ddlAreaPresent.DataValueField = "AreaId";
                                ddlAreaPresent.DataBind();
                            }

                            DataSet dsPermanentState = new DataSet();
                            permCountryId = Convert.ToInt32(dsPersonalDetails.Tables[0].Rows[0]["PermantCountryId"]);
                            dsPermanentState = personalDetailsREBAL.GetState(permCountryId);
                            // Check dsPermanentState is not null
                            if (dsPermanentState != null)
                            {
                                ddlStatePerm.DataSource = dsPermanentState;
                                ddlStatePerm.DataTextField = "StateName";
                                ddlStatePerm.DataValueField = "StateId";
                                ddlStatePerm.DataBind();
                            }

                            DataSet dsPermanentCity = new DataSet();
                            permStateId = Convert.ToInt32(dsPersonalDetails.Tables[0].Rows[0]["PermantStateId"]);
                            dsPermanentCity = personalDetailsREBAL.GetCity(permStateId);
                            // Check dsPermanentCity is not null
                            if (dsPermanentCity != null)
                            {
                                ddlCityPerm.DataSource = dsPermanentCity;
                                ddlCityPerm.DataTextField = "CityName";
                                ddlCityPerm.DataValueField = "CityId";
                                ddlCityPerm.DataBind();
                            }

                            DataSet dsPermanentArea = new DataSet();
                            permCityId = Convert.ToInt32(dsPersonalDetails.Tables[0].Rows[0]["PermantCityId"]);
                            dsPermanentArea = personalDetailsREBAL.GetArea(permCityId);
                            // Check dsPermanentArea is not null
                            if (dsPermanentArea != null)
                            {
                                ddlAreaPerm.DataSource = dsPermanentArea;
                                ddlAreaPerm.DataTextField = "AreaName";
                                ddlAreaPerm.DataValueField = "AreaId";
                                ddlAreaPerm.DataBind();
                            }

                            txtPresentAddress.Text = Convert.ToString(dsPersonalDetails.Tables[1].Rows[0]["Address"]);
                            ddlCountryPresent.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[1].Rows[0]["PresentCountry"]);
                            ddlStatePresent.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[1].Rows[0]["PresentState"]);
                            ddlCityPresent.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[1].Rows[0]["PresentCity"]);
                            ddlAreaPresent.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[1].Rows[0]["PresentArea"]);
                            txtPincodePresent.Text = Convert.ToString(dsPersonalDetails.Tables[1].Rows[0]["PinCode"]);
                            txtAddressPerm.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantAddress"]);
                            ddlCountryPerm.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantCountryId"]);
                            ddlStatePerm.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantStateId"]);
                            ddlCityPerm.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantCityId"]);
                            ddlAreaPerm.SelectedValue = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantArea"]);
                            txtPincodePerm.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantPincode"]);

                            date = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["DateOfBirth"]);
                            txtDOB.Text = DateTime.Parse(date).ToShortDateString();

                            maritalStatus = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["MaritalStatus"]);
                            ddlMaritalStatus.Items.FindByValue(maritalStatus).Selected = true;
                            txtPassportNo.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PassportNumber"]);

                            format = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PassportValidity"]); ;
                            string[] Words = format.Split(new char[] { '/' });

                            foreach (string Word in Words)
                            {
                                count += 1;
                                if (count == 1)
                                { ddlMonth.SelectedValue = Word; }
                                if (count == 2)
                                { ddlYear.SelectedValue = Word; }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Bind Years
        /// </summary>
        private void GetYear()
        {
            try
            {
                List<string> yearList = GetYears();
                ddlYear.DataSource = yearList;
                ddlYear.DataBind();
                ddlYear.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Bind Months
        /// </summary>
        private void GetMonths()
        {
            try
            {
                List<string> monthList = CommonUtil.Utility.GetMonths();
                ddlMonth.DataSource = monthList;
                ddlMonth.DataBind();
                ddlMonth.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        /// <summary>
        /// Get years in List
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Bind Country to ddlCountryPresent list
        /// </summary>
        private void GetCountryPresent()
        {
            try
            {
                PersonalDetailsREBAL personalDetailsBAL = new PersonalDetailsREBAL();
                dsCountry = personalDetailsBAL.GetCountry();
                // Check dataset is not null
                if (dsCountry != null)
                {
                    ddlCountryPresent.DataSource = dsCountry;
                    ddlCountryPresent.DataTextField = "CountryName";
                    ddlCountryPresent.DataValueField = "CountryId";
                    ddlCountryPresent.DataBind();
                    ddlCountryPresent.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Bind country to ddlCountryPerm list
        /// </summary>
        private void GetCountryPerm()
        {
            try
            {
                PersonalDetailsREBAL personalDetailsBAL = new PersonalDetailsREBAL();
                dsCountry = personalDetailsBAL.GetCountry();
                // Check dataset is not null
                if (dsCountry != null)
                {
                    ddlCountryPerm.DataSource = dsCountry;
                    ddlCountryPerm.DataTextField = "CountryName";
                    ddlCountryPerm.DataValueField = "CountryId";
                    ddlCountryPerm.DataBind();
                    ddlCountryPerm.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
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
                PersonalDetailsREBAL personalDetailsBAL = new PersonalDetailsREBAL();
                int CountryId = Convert.ToInt32(ddlCountryPresent.SelectedValue);
                DataSet dsStatePresent = new DataSet();
                dsStatePresent = personalDetailsBAL.GetState(CountryId);
                // Check if dataset is not null
                if (dsStatePresent != null)
                {
                    ddlStatePresent.DataSource = dsStatePresent;
                    ddlStatePresent.DataTextField = "StateName";
                    ddlStatePresent.DataValueField = "StateId";
                    ddlStatePresent.DataBind();
                    ddlStatePresent.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
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
                PersonalDetailsREBAL personalDetailsBAL = new PersonalDetailsREBAL();
                int StateId = Convert.ToInt32(ddlStatePresent.SelectedValue);
                DataSet dsCityPresent = new DataSet();
                dsCityPresent = personalDetailsBAL.GetCity(StateId);
                // Check if dataset is not null
                if (dsCityPresent != null)
                {
                    ddlCityPresent.DataSource = dsCityPresent;
                    ddlCityPresent.DataTextField = "cityName";
                    ddlCityPresent.DataValueField = "cityID";
                    ddlCityPresent.DataBind();
                    ddlCityPresent.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                //  throw;
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
                PersonalDetailsREBAL personalDetailsBAL = new PersonalDetailsREBAL();
                int CountryId = Convert.ToInt32(ddlCountryPerm.SelectedValue);
                DataSet dsStatePerm = new DataSet();
                dsStatePerm = personalDetailsBAL.GetState(CountryId);
                // Check if dataset is not null
                if (dsStatePerm != null)
                {
                    ddlStatePerm.DataSource = dsStatePerm;
                    ddlStatePerm.DataTextField = "StateName";
                    ddlStatePerm.DataValueField = "StateId";
                    ddlStatePerm.DataBind();
                    ddlStatePerm.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
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
                PersonalDetailsREBAL personalDetailsBAL = new PersonalDetailsREBAL();
                int StateId = Convert.ToInt32(ddlStatePerm.SelectedValue);
                DataSet dsCityPerm = new DataSet();
                dsCityPerm = personalDetailsBAL.GetCity(StateId);
                // Check if dataset is not null
                if (dsCityPerm != null)
                {
                    ddlCityPerm.DataSource = dsCityPerm;
                    ddlCityPerm.DataTextField = "cityName";
                    ddlCityPerm.DataValueField = "cityID";
                    ddlCityPerm.DataBind();
                    ddlCityPerm.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
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
                // throw;
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
                //  throw;
            }
        }

        protected void ddlCityPresent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PersonalDetailsREBAL personalDetailsBAL = new PersonalDetailsREBAL();
                int cityId = Convert.ToInt32(ddlCityPresent.SelectedValue);
                DataSet dsAreaPresent = new DataSet();
                dsAreaPresent = personalDetailsBAL.GetArea(cityId);
                // Check if dataset is not null
                if (dsAreaPresent != null)
                {
                    ddlAreaPresent.DataSource = dsAreaPresent;
                    ddlAreaPresent.DataTextField = "AreaName";
                    ddlAreaPresent.DataValueField = "AreaID";
                    ddlAreaPresent.DataBind();
                    ddlAreaPresent.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        protected void ddlCityPerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PersonalDetailsREBAL personalDetailsBAL = new PersonalDetailsREBAL();
                int cityId = Convert.ToInt32(ddlCityPerm.SelectedValue);
                DataSet dsAreaPerm = new DataSet();
                dsAreaPerm = personalDetailsBAL.GetArea(cityId);
                // Check if dataset is not null
                if (dsAreaPerm != null)
                {
                    ddlAreaPerm.DataSource = dsAreaPerm;
                    ddlAreaPerm.DataTextField = "AreaName";
                    ddlAreaPerm.DataValueField = "AreaID";
                    ddlAreaPerm.DataBind();
                    ddlAreaPerm.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEdit)
                {
                    PersonalDetailsEntity objPersonalDetailsEntity = new PersonalDetailsEntity();
                    PersonalDetailsREBAL personalDetailsBAL = new PersonalDetailsREBAL();

                    // Set value to PersonalDetails job seeker entity
                    objPersonalDetailsEntity.recruiterId = recruiterId;
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

                   
                    // Check if radio button checked
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
                    // Check if result is greater than zero or not
                    if (result > 0)
                    {
                        Response.Write("<script language='javascript'>alert('Personal Details Updated')</script>");
                    }
                    else
                    {
                        Response.Write("<script language='javascript'>alert('Sorry')</script>");
                    }
                }
                else
                {
                    PersonalDetailsEntity personalDetailsEntity = new PersonalDetailsEntity();
                    PersonalDetailsREBAL personalDetailsBAL = new PersonalDetailsREBAL();

                    // Set value to PersonalDetails job seeker entity
                    personalDetailsEntity.recruiterId = recruiterId;
                    personalDetailsEntity.permantAddress = txtAddressPerm.Text.Trim();
                    personalDetailsEntity.permantCountryId = Convert.ToInt32(ddlCountryPerm.SelectedValue);
                    personalDetailsEntity.permantStateId = Convert.ToInt32(ddlStatePerm.SelectedValue);
                    personalDetailsEntity.permantCityId = Convert.ToInt32(ddlCityPerm.SelectedValue);
                    personalDetailsEntity.permantArea = Convert.ToInt32(ddlAreaPerm.SelectedValue);
                    personalDetailsEntity.permantPincode = Convert.ToInt32(txtPincodePerm.Text);
                    personalDetailsEntity.dateOfBirth = Convert.ToDateTime(txtDOB.Text);

                    // Check if radio button checked
                    if (rbtPassportYes.Checked)
                    {
                        string validity = ddlMonth.SelectedItem.Text + '/' + ddlYear.SelectedItem.Text;
                        personalDetailsEntity.passportNumber = Convert.ToInt32(txtPassportNo.Text);
                        personalDetailsEntity.passportValidity = validity;
                        personalDetailsEntity.passportIssue = "Yes";
                    }
                    else
                    {
                        personalDetailsEntity.passportNumber = Convert.ToInt32(null);
                        personalDetailsEntity.passportValidity = "null";
                        personalDetailsEntity.passportIssue = "No";
                    }
                    personalDetailsEntity.maritialStatus = ddlMaritalStatus.SelectedItem.Text;
                    int result = personalDetailsBAL.SavePersonalDetailsBAL(personalDetailsEntity);
                    // Check if result is greater than zero or not
                    if (result > 0)
                    {
                        Response.Write("<script language='javascript'>alert('Personal Details Inserted')</script>");
                    }
                    else
                    {
                        Response.Write("<script language='javascript'>alert('Sorry')</script>");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}