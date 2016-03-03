using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.HR;
using System.Data;
using System.IO;

namespace JobFair.Forms.HR
{
    public partial class EmployerDetails : System.Web.UI.Page
    {
        private DataSet dsEmployerDetails = new DataSet();
        private EmployerDetailsHRBAL employerDetailsHRBAL = new EmployerDetailsHRBAL();
        private EmployerDetailsHREntity employerDetailsHREntity = new EmployerDetailsHREntity();
        bool isView, isEdit;
        int HrId, EmployerId;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["HrId"] != null)
            //{
            //    if (Session["HrId"].ToString() != "")
            //    {
            //        HrId = Convert.ToString(Session["HrId"]);

            if (!IsPostBack)  
            {
                try
                {
                    BindCountry();
                    divView.Visible = false;
                }
                catch (Exception)
                {
                    //throw;
                }
                isEdit = Convert.ToBoolean(Request.QueryString["isEdit"]);
                if (isEdit)
                {
                    try
                    {
                        EmployerId = Convert.ToInt32(Request.QueryString["EmployerId"]);
                        HrId = Convert.ToInt32(Request.QueryString["HrId"]);
                        BindEditEmployer();
                        btnSubmit.Visible = false;
                        btnUpdate.Visible = true;
                    }
                    catch (Exception)
                    {
                        //throw;
                    }
                }
            }
            isView = Convert.ToBoolean(Request.QueryString["isView"]);
            if (isView)
            {
                try
                {
                    EmployerId = Convert.ToInt32(Request.QueryString["EmployerId"]);
                    HrId = Convert.ToInt32(Request.QueryString["HrId"]);
                    BindViewEmployer();
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
                EmployerDetailsHRBAL employerDetailsHRBAL = new EmployerDetailsHRBAL();
                EmployerDetailsHREntity employerDetailsHREntity = new EmployerDetailsHREntity();
                // Assign values to the entities
                employerDetailsHREntity.HrId = 1;
                employerDetailsHREntity.CompanyName = txtCompanyName.Text.Trim();
                employerDetailsHREntity.CompanyProfile = txtCompanyProfile.Text.Trim();
                employerDetailsHREntity.EmployerHRFullName = txtEmployerHRFullName.Text.Trim();
                employerDetailsHREntity.CompanyContactNumber = txtCompanyContactNo.Text.Trim();
                employerDetailsHREntity.MobileNumber = txtMobileNumber.Text.Trim();
                employerDetailsHREntity.Address = txtAddress.Text.Trim();
                employerDetailsHREntity.CountryId = Convert.ToInt32(ddlCountry.SelectedValue);
                employerDetailsHREntity.StateId = Convert.ToInt32(ddlState.SelectedValue);
                employerDetailsHREntity.CityId = Convert.ToInt32(ddlCity.SelectedValue);
                employerDetailsHREntity.AreaId = Convert.ToInt32(ddlArea.SelectedValue);
                employerDetailsHREntity.Pincode = Convert.ToInt32(txtPincode.Text.Trim());
                employerDetailsHREntity.OfficialEmailId = txtOfficialEMailId.Text.Trim();
                employerDetailsHREntity.Password = txtPassword.Text.Trim();
                employerDetailsHREntity.Status = rbtlistStatus.SelectedItem.Text;
                // Check if fileupload control has a file.
                if (FileUploadPhoto.PostedFile != null)
                {
                    employerDetailsHREntity.Photo = Path.GetFileName(FileUploadPhoto.PostedFile.FileName);
                    FileUploadPhoto.SaveAs(Server.MapPath("~/UploadImages/" + employerDetailsHREntity.Photo));
                }
                // Saving data to the database
                int result = employerDetailsHRBAL.SaveEmployerDetailsBAL(employerDetailsHREntity);
                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('Save Employer Details Successfully')</script>");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Employer Details won't saved')</script>");
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                EmployerDetailsHRBAL employerDetailsHRBAL = new EmployerDetailsHRBAL();
                EmployerDetailsHREntity employerDetailsHREntity = new EmployerDetailsHREntity();
                // Assign values to the entities
                employerDetailsHREntity.HrId = 1;
                EmployerId = Convert.ToInt32(Request.QueryString["EmployerId"]);
                employerDetailsHREntity.EmployerId = EmployerId;
                employerDetailsHREntity.CompanyName = txtCompanyName.Text.Trim();
                employerDetailsHREntity.CompanyProfile = txtCompanyProfile.Text.Trim();
                employerDetailsHREntity.EmployerHRFullName = txtEmployerHRFullName.Text.Trim();
                employerDetailsHREntity.CompanyContactNumber = txtCompanyContactNo.Text.Trim();
                employerDetailsHREntity.MobileNumber = txtMobileNumber.Text.Trim();
                employerDetailsHREntity.Address = txtAddress.Text.Trim();
                employerDetailsHREntity.CountryId = Convert.ToInt32(ddlCountry.SelectedValue);
                employerDetailsHREntity.StateId = Convert.ToInt32(ddlState.SelectedValue);
                employerDetailsHREntity.CityId = Convert.ToInt32(ddlCity.SelectedValue);
                employerDetailsHREntity.AreaId = Convert.ToInt32(ddlArea.SelectedValue);
                employerDetailsHREntity.Pincode = Convert.ToInt32(txtPincode.Text.Trim());
                employerDetailsHREntity.OfficialEmailId = txtOfficialEMailId.Text.Trim();
                employerDetailsHREntity.Password = txtPassword.Text.Trim();
                employerDetailsHREntity.Status = rbtlistStatus.SelectedItem.Text;
                 //Check if fileupload control has a file.
                if (FileUploadPhoto.PostedFile != null)
                {
                    employerDetailsHREntity.Photo = Path.GetFileName(FileUploadPhoto.PostedFile.FileName);
                    FileUploadPhoto.SaveAs(Server.MapPath("~/UploadImages/" + employerDetailsHREntity.Photo));
                }
                else
                {
                    employerDetailsHREntity.Photo = Path.GetFileName(imgPersonalPhoto.ImageUrl);
                }
                // Saving data to the database
                int result = employerDetailsHRBAL.UpdateEmployerDetailsBAL(employerDetailsHREntity);
                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('Update Employer Details Successfully')</script>");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Employer Details won't saved')</script>");
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }

        /// <summary>
        /// Method for binding Employer Details for Viewing Purpose
        /// </summary>
        private void BindViewEmployer()
        {
            try
            {
                DataSet dsViewEmployer = new DataSet();
                dsViewEmployer = employerDetailsHRBAL.ViewEmployerDetailsBAL(EmployerId, HrId);
                  
                lblEmployerId.Text = dsViewEmployer.Tables[0].Rows[0]["EmployerId"].ToString();
                lblHrId.Text = dsViewEmployer.Tables[0].Rows[0]["HrId"].ToString();
                lblViewCompanyName.Text = dsViewEmployer.Tables[0].Rows[0]["CompanyName"].ToString();
                lblviewCompanyProfile.Text = dsViewEmployer.Tables[0].Rows[0]["CompanyProfile"].ToString();
                lblViewEmployerHRFullName.Text = dsViewEmployer.Tables[0].Rows[0]["EmployerHRFullName"].ToString();
                lblViewCompanyContactNo.Text = dsViewEmployer.Tables[0].Rows[0]["CompanyContactNumber"].ToString();
                lblViewMobileNumber.Text = dsViewEmployer.Tables[0].Rows[0]["MobileNumber"].ToString();
                lblViewAddress.Text = dsViewEmployer.Tables[0].Rows[0]["Address"].ToString();
                lblViewCountry.Text = dsViewEmployer.Tables[0].Rows[0]["CountryName"].ToString();
                lblViewState.Text = dsViewEmployer.Tables[0].Rows[0]["StateName"].ToString();
                lblViewCity.Text = dsViewEmployer.Tables[0].Rows[0]["CityName"].ToString();
                lblViewArea.Text = dsViewEmployer.Tables[0].Rows[0]["AreaName"].ToString();
                lblViewPincode.Text = dsViewEmployer.Tables[0].Rows[0]["Pincode"].ToString();
                lblViewOfficialEMail.Text = dsViewEmployer.Tables[0].Rows[0]["OfficialEmailId"].ToString();
                lblViewStatus.Text = dsViewEmployer.Tables[0].Rows[0]["Status"].ToString();
                lblViewPhoto.Text = dsViewEmployer.Tables[0].Rows[0]["Photo"].ToString();
                lblViewCreatedDate.Text = dsViewEmployer.Tables[0].Rows[0]["CreatedDate"].ToString();
                lblViewModifiedDate.Text = dsViewEmployer.Tables[0].Rows[0]["ModifiedDate"].ToString();
            }
            catch (Exception)
            {
                //throw;
            }
            divMain.Visible = false;
            divView.Visible = true;
        }
        /// <summary>
        /// Method for binding Employer Details for Editing Purpose
        /// </summary>
        private void BindEditEmployer()
        {
            try
            {
                DataSet dsViewEmployer = new DataSet();
                dsViewEmployer = employerDetailsHRBAL.ViewEmployerDetailsBAL(EmployerId, HrId);
                // Check dataset is not null
                if (dsViewEmployer != null)
                {
                    // Check the count than zero
                    if (dsViewEmployer.Tables.Count > 0)
                    {
                        // Check rows greater than zero
                        if (dsViewEmployer.Tables[0].Rows.Count > 0)
                        {
                            FileUploadPhoto.Visible = false;
                            imgPersonalPhoto.Visible = true;
                            lnkbtnEdit.Visible = true;
                            //pnlPresentAdd.Visible = true;
                            lblEmployerId.Text = dsViewEmployer.Tables[0].Rows[0]["EmployerId"].ToString();
                            lblHrId.Text = dsViewEmployer.Tables[0].Rows[0]["HrId"].ToString();
                            txtCompanyName.Text = dsViewEmployer.Tables[0].Rows[0]["CompanyName"].ToString();
                            txtCompanyProfile.Text = dsViewEmployer.Tables[0].Rows[0]["CompanyProfile"].ToString();
                            txtEmployerHRFullName.Text = dsViewEmployer.Tables[0].Rows[0]["EmployerHRFullName"].ToString();
                            txtCompanyContactNo.Text = dsViewEmployer.Tables[0].Rows[0]["CompanyContactNumber"].ToString();
                            txtMobileNumber.Text = dsViewEmployer.Tables[0].Rows[0]["MobileNumber"].ToString();
                            txtAddress.Text = dsViewEmployer.Tables[0].Rows[0]["Address"].ToString();
                            ddlCountry.SelectedValue = dsViewEmployer.Tables[0].Rows[0]["CountryName"].ToString();
                            ddlState.SelectedValue = dsViewEmployer.Tables[0].Rows[0]["StateName"].ToString();
                            ddlCity.SelectedValue = dsViewEmployer.Tables[0].Rows[0]["CityName"].ToString();
                            ddlArea.SelectedValue = dsViewEmployer.Tables[0].Rows[0]["AreaName"].ToString();
                            txtPincode.Text = dsViewEmployer.Tables[0].Rows[0]["Pincode"].ToString();
                            txtOfficialEMailId.Text = dsViewEmployer.Tables[0].Rows[0]["OfficialEmailId"].ToString();
                            rbtlistStatus.SelectedValue = dsViewEmployer.Tables[0].Rows[0]["Status"].ToString();
                            imgPersonalPhoto.ImageUrl = Convert.ToString(dsViewEmployer.Tables[0].Rows[0]["photo"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
            divMain.Visible = true;
            divView.Visible = false;
        }
        protected void lnkbtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                lnkbtnCancel.Visible = true;
                FileUploadPhoto.Visible = true;
                lnkbtnEdit.Visible = false;
                imgPersonalPhoto.Visible = false;
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        protected void lnkbtnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                FileUploadPhoto.Visible = false;
                lnkbtnEdit.Visible = true;
                imgPersonalPhoto.Visible = true;
                lnkbtnCancel.Visible = false;
            }
            catch (Exception)
            {
                // throw;
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


        /// <summary>
        /// Method for binding Dropdown with Country_table of database
        /// </summary>
        private void BindCountry()
        {
            dsEmployerDetails = employerDetailsHRBAL.GetCountry();
            ddlCountry.DataSource = dsEmployerDetails;
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
            dsEmployerDetails = employerDetailsHRBAL.GetState(countryId);
            ddlState.DataSource = dsEmployerDetails;
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
            dsEmployerDetails = employerDetailsHRBAL.GetCity(stateId);
            ddlCity.DataSource = dsEmployerDetails;
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
            dsEmployerDetails = employerDetailsHRBAL.GetArea(cityId);
            ddlArea.DataSource = dsEmployerDetails;
            ddlArea.DataValueField = "areaID";
            ddlArea.DataTextField = "areaName";
            ddlArea.DataBind();
            ddlArea.Items.Insert(0, new ListItem("--Select--", "0"));
        }
    }
}