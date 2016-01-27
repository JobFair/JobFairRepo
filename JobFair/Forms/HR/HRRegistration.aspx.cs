using BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities.Common;
using System.IO;
using System.Configuration;
using System.Net.Mail;

namespace JobFair.Forms.Admin
{
    public partial class HRRegistration : System.Web.UI.Page
    {
        bool isMailSent;
        Int64 AdminId = 1;
        private string HrPrefix = ConfigurationManager.AppSettings["HrPrefix"];
        RegisterEntity registerEntity = new RegisterEntity();
        
        /// <summary>
        /// Handles Load event of Page            
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCountry();
                BindCountryCode();
            }
        }
        /// <summary>
        /// Bind Country code for Mobile Number to ddlCountryCode control
        /// </summary>
        private void BindCountryCode()
        {
            try
            {
                RegisterHrADBAL registerHrADBAL = new RegisterHrADBAL();
                DataSet datasetCountryCode = new DataSet();
                datasetCountryCode = registerHrADBAL.GetCountryCode();
                if (datasetCountryCode != null)
                {
                    ddlCountryCode.DataSource = datasetCountryCode;
                    ddlCountryCode.DataTextField = "CountryCode";
                    ddlCountryCode.DataValueField = "ID";
                    ddlCountryCode.DataBind();
                    ddlCountryCode.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Bind Country to ddlCountryPresent control
        /// </summary>
        private void BindCountry()
        {
            try
            {
                RegisterHrADBAL registerHrADBAL = new RegisterHrADBAL();
                DataSet datasetCountry = new DataSet();
                datasetCountry = registerHrADBAL.GetCountry();
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
        /// Handles Click event of btnRegister control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
               
                RegisterHrADBAL registerHrADBAL = new RegisterHrADBAL();
                registerEntity.FullName = txtFullName.Text.Trim();
                registerEntity.Company = txtCompany.Text.Trim();

                registerEntity.MobileNo += "+";
                string format = ddlCountryCode.SelectedItem.Text.Trim();
                string[] Words = format.Split(new char[] { '+' });
                int count1 = 0;
                foreach (string Word in Words)
                {
                    count1 += 1;
                    if (count1 == 2)
                    {
                        registerEntity.MobileNo += Word.Trim();
                    }
                }
                registerEntity.MobileNo += txtMobNo.Text.Trim();
                registerEntity.OfficialEmailId = txtOffEmailid.Text.Trim();
                registerEntity.Password = txtPassword.Text.Trim();
                registerEntity.PresentCountry = Convert.ToInt32(ddlCountryPresent.SelectedValue);
                registerEntity.PresentState = Convert.ToInt32(ddlStatePresent.SelectedValue);
                registerEntity.PresentCity = Convert.ToInt32(ddlCityPresent.SelectedValue);
                registerEntity.PresentArea = Convert.ToInt32(ddlAreaPresent.SelectedValue);
                registerEntity.Pincode = txtPincode.Text.Trim();
                registerEntity.PANCardNo = txtPANCard.Text.Trim();
                registerEntity.JobType = rbtlJobType.SelectedValue;
                registerEntity.OfficialContactNo = txtOfficialContact.Text.Trim();
                registerEntity.AlternateNo = txtAlternateContactNo.Text.Trim();
                registerEntity.PersonalMailId = txtPersonalMailid.Text.Trim();
                registerEntity.EmploymentStatus = rbtlEmploymentStatus.SelectedValue;
                if (rbtFreelance.Checked)
                {
                    registerEntity.FreelanceOrEmployee = rbtFreelance.Text.Trim();

                }
                else if (rbtEmployee.Checked)
                {
                    registerEntity.FreelanceOrEmployee = rbtEmployee.Text.Trim();

                }
                registerEntity.AmountPerMonth = txtAmount.Text.Trim();
                registerEntity.PercentPerClosure = txtPercentagePerClosure.Text.Trim();
                registerEntity.EmployeeSalary = txtSalary.Text.Trim();
                registerEntity.ClientName = txtClientName.Text.Trim();
                registerEntity.ClientSite = txtClientSite.Text.Trim();
                registerEntity.Address = txtAddress.Text.Trim();
                registerEntity.AdminId = AdminId;

                //get path of photos
                string path = AppDomain.CurrentDomain.BaseDirectory + "Images\\" + this.FileUploadRecruiterPhoto.FileName;
                string uploadphoto = Request.PhysicalApplicationPath + "Images\\";
                registerEntity.PhotoPath = uploadphoto.ToString();
                string result = registerHrADBAL.SaveNewHrBAL(registerEntity);
                HrPrefix = HrPrefix + result;
                if (result != null)
                {
                    if (FileUploadRecruiterPhoto.HasFile)
                    {
                        string extension = Path.GetExtension(FileUploadRecruiterPhoto.PostedFile.FileName);
                        FileUploadRecruiterPhoto.SaveAs(uploadphoto + HrPrefix.ToString() + extension);
                    }
                    isMailSent = SendHTMLMail(result);
                    if (isMailSent == true)
                    {
                        registerEntity.IsMailSent = true;
                        registerHrADBAL.UpdateMailsentBAL(registerEntity);
                        Label1.Text = "Welcome. Registerd successfully";

                    }
                    else
                    {

                    }
                    
                }
                else
                {
                    Label1.Text = "Not registerd";
                }
               
                
                

            }
            catch (Exception ex)
            {
                 throw ex;
            }
        }

        private bool SendHTMLMail(string result)
        {
            string from = "jyoti.logossolutions@gmail.com";
            string subject1 = "Welcome In Logos Solutions";
            string subject = " Joining Receipt of the Recruiter " + DateTime.Now.ToString();
            string content = "New Recruiter Registered";
            string content1 = "Hello,<br/> Logos Solutions welcomes you";

            MailMessage Msg = new MailMessage();
            Msg.From = new MailAddress(from);
            Msg.To.Add(txtPersonalMailid.Text.Trim());
            StreamReader reader = new StreamReader(Server.MapPath("~/Email Templates/RegistrationConfirmation.html"));
            string readFile = reader.ReadToEnd();
            string strContent = "";
            strContent = readFile;
            strContent = strContent.Replace("$$Candidate Name$$", txtFullName.Text.Trim());
            strContent = strContent.Replace("$$Candidate ID$$", HrPrefix);
            strContent = strContent.Replace("$$Candidate Mail ID$$", txtOffEmailid.Text.Trim());
            // "http://www.logossolutions.co.in/");
            strContent = strContent.Replace("$$Mobile Number$$", registerEntity.MobileNo.Trim());
            strContent = strContent.Replace("$$Present Address$$", "Present Address" + txtAddress.Text.Trim() + "<br/>Country" + ddlCountryCode.SelectedItem.Text.Trim() + "<br/>State" + ddlStatePresent.SelectedItem.Text.Trim() + "<br/>City" + ddlCityPresent.SelectedItem.Text.Trim() + "<br/>City Area" + ddlAreaPresent.SelectedItem.Text.Trim() + "<br/>Pincode:" + txtPincode.Text.Trim());

            Msg.Subject = subject;

            Msg.Body = strContent.ToString();
            Msg.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("jyoti.logossolutions@gmail.com", "@jacksparow");
            smtp.EnableSsl = true;
            smtp.Send(Msg);
            Msg = null;
            return true;     
        }
        /// <summary>
        /// Handles SelectedIndexChanged event of rbtlJobType control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void rbtlJobType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtlJobType.SelectedValue == "Temporary")
            {
                PanelTemporary.Visible = true;
            }
            else
            {
                PanelTemporary.Visible = false;
            }
        }
        /// <summary>
        /// Handles SelectedIndexChanged event of ddlCountryPresent control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void ddlCountryPresent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RegisterHrADBAL registerHrADBAL = new RegisterHrADBAL();
                DataSet datasetState = new DataSet();
                int CountryId = Convert.ToInt32(ddlCountryPresent.SelectedValue);
                datasetState = registerHrADBAL.GetState(CountryId);
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
        /// <summary>
        /// Handles SelectedIndexChanged event of ddlStatePresent control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void ddlStatePresent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RegisterHrADBAL registerHrADBAL = new RegisterHrADBAL();
                DataSet datasetCity = new DataSet();
                int StateId = Convert.ToInt32(ddlStatePresent.SelectedValue);
                datasetCity = registerHrADBAL.GetCity(StateId);
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
        /// <summary>
        /// Handles SelectedIndexChanged event of ddlCityPresent control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void ddlCityPresent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RegisterHrADBAL registerHrADBAL = new RegisterHrADBAL();
                DataSet datasetCityArea = new DataSet();
                int cityId = Convert.ToInt32(ddlCityPresent.SelectedValue);
                datasetCityArea = registerHrADBAL.GetArea(cityId);
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
        /// <summary>
        /// Handles CheckedChanged event of rbtFreelance control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void rbtFreelance_CheckedChanged(object sender, EventArgs e)
        {
            PanelFreelance.Visible = true;
            PanelEmployee.Visible = false;
        }
        /// <summary>
        /// Handles CheckedChanged event of rbtEmployee control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void rbtEmployee_CheckedChanged(object sender, EventArgs e)
        {
            PanelEmployee.Visible = true;
            PanelFreelance.Visible = false;
        }
        /// <summary>
        /// Handles CheckedChanged event of rbtAmount control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void rbtAmount_CheckedChanged(object sender, EventArgs e)
        {
            txtAmount.Visible = true;
            txtPercentagePerClosure.Visible = false;
        }
        /// <summary>
        /// Handles CheckedChanged event rbtPercentagePerClosure control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void rbtPercentagePerClosure_CheckedChanged(object sender, EventArgs e)
        {
            txtPercentagePerClosure.Visible = true;
            txtAmount.Visible = false;
        }
    }
}