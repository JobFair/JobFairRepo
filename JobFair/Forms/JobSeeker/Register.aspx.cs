using BAL;
using Entities;
using System;
using System.Data;
using System.IO;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    /// <summary>
    /// Class JobSeekerRegister.
    /// </summary>
    public partial class JobSeekerRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCountry();
            }
        }

        private void BindCountry()
        {
            try
            {
                RegisterJobSeekerBAL registerJobSeekerBAL = new RegisterJobSeekerBAL();
                DataSet datasetCountry = new DataSet();
                datasetCountry = registerJobSeekerBAL.GetCountry();
                // Check dataset is not null
                if (datasetCountry != null)
                {
                    ddlCountryPresent.DataSource = datasetCountry;
                    ddlCountryPresent.DataTextField = "CountryName";
                    ddlCountryPresent.DataValueField = "CountryId";
                    ddlCountryPresent.DataBind();
                    ddlCountryPresent.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSubmit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterJobSeekerBAL jobSeekerBAL = new RegisterJobSeekerBAL();
                string uploadFolder, result, path, extension;
                RegisterEntity jobSeekerEntity = new RegisterEntity();
                path = AppDomain.CurrentDomain.BaseDirectory + "UploadFiles\\" + this.FileUploadResume.FileName;

                // Set value to job seeker entity
                jobSeekerEntity.FirstName = txtFirstName.Text.Trim();
                jobSeekerEntity.LastName = txtLastName.Text.Trim();
                jobSeekerEntity.EmailId = txtEmailId.Text.Trim();

                jobSeekerEntity.Gender = rblGender.SelectedItem.Text;
                jobSeekerEntity.MobileNo = txtMobileNo.Text.Trim();
                jobSeekerEntity.Password = txtPassword.Text.Trim();
                jobSeekerEntity.Country = Convert.ToInt32(ddlCountryPresent.SelectedValue);
                jobSeekerEntity.State=Convert.ToInt32(ddlStatePresent.SelectedValue);
                jobSeekerEntity.CityId = Convert.ToInt32(ddlCityPresent.SelectedValue);
                jobSeekerEntity.CityArea = Convert.ToInt32(ddlAreaPresent.SelectedValue);
                jobSeekerEntity.Pincode = txtPincode.Text.Trim();
                jobSeekerEntity.CurrentAddress = txtCurrAddress.Text.Trim();
                jobSeekerEntity.RefCandidateId = txtRefCandidateId.Text;
                uploadFolder = Request.PhysicalApplicationPath + "UploadFiles\\";

                jobSeekerEntity.UploadResumepath = uploadFolder.ToString();
               

                result = jobSeekerBAL.SaveRegisterNewJobSeekerBAL(jobSeekerEntity);
                // Check if result not null
                if (result != null)
                {
                    // Check if fileupload control has a file.
                    if (FileUploadResume.HasFile)
                    {
                        extension = Path.GetExtension(FileUploadResume.PostedFile.FileName);
                        FileUploadResume.SaveAs(uploadFolder + result.ToString() + extension);
                        lblMessage.Text = "File uploaded successfully as: " + result.ToString() + extension;
                    }
                    else
                    {
                        lblMessage.Text = "First select a file.";
                    }
                    Response.Redirect("LogIn.aspx");
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        protected void ddlCountryPresent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                 RegisterJobSeekerBAL registerJobSeekerBAL = new RegisterJobSeekerBAL();
                DataSet datasetState = new DataSet();
                int CountryId = Convert.ToInt32(ddlCountryPresent.SelectedValue);
                datasetState = registerJobSeekerBAL.GetState(CountryId);
                // Check if dataset is not null
                if (datasetState != null)
                {
                    ddlStatePresent.DataSource = datasetState;
                    ddlStatePresent.DataTextField = "StateName";
                    ddlStatePresent.DataValueField = "StateId";
                    ddlStatePresent.DataBind();
                    ddlStatePresent.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void ddlStatePresent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                 RegisterJobSeekerBAL registerJobSeekerBAL = new RegisterJobSeekerBAL();
                DataSet datasetCity = new DataSet();
                int StateId = Convert.ToInt32(ddlStatePresent.SelectedValue);
                datasetCity = registerJobSeekerBAL.GetCity(StateId);
                // Check if dataset is not null
                if (datasetCity != null)
                {
                    ddlCityPresent.DataSource = datasetCity;
                    ddlCityPresent.DataTextField = "cityName";
                    ddlCityPresent.DataValueField = "cityID";
                    ddlCityPresent.DataBind();
                    ddlCityPresent.Items.Insert(0, new ListItem("--Select--", "0"));
                }
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
                RegisterJobSeekerBAL registerJobSeekerBAL = new RegisterJobSeekerBAL();
                DataSet datasetCityArea = new DataSet();
                int cityId = Convert.ToInt32(ddlCityPresent.SelectedValue);
                datasetCityArea = registerJobSeekerBAL.GetArea(cityId);
                // Check if dataset is not null
                if (datasetCityArea != null)
                {
                    ddlAreaPresent.DataSource = datasetCityArea;
                    ddlAreaPresent.DataTextField = "AreaName";
                    ddlAreaPresent.DataValueField = "AreaID";
                    ddlAreaPresent.DataBind();
                    ddlAreaPresent.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}