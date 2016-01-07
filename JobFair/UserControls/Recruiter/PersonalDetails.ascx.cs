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
        bool isEdit=true;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetCountryPresent();
                GetCountryPerm();
                GetMonths();
                GetYear();
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
                
                PersonalDetailsEntity personalDetailsEntity = new PersonalDetailsEntity();
                PersonalDetailsREBAL personalDetailsBAL = new PersonalDetailsREBAL();

                // Set value to PersonalDetails job seeker entity
                personalDetailsEntity.recruiterId = "1";
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
            catch (Exception)
            {
                throw;
            }
        }
    }
}