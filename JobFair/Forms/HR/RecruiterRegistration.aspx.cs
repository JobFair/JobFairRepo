using BAL;
using Entities.HR;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Web.UI.WebControls;

namespace JobFair.Forms.HR
{
    public partial class RecruiterRegistration : System.Web.UI.Page
    {
        bool isMailSent;
        Int64 HrID=2;
        private string RecruiterPrefix = ConfigurationManager.AppSettings["RecruiterPrefix"];
        RecruiterRegisterEntity registerRecruiterEntity = new RecruiterRegisterEntity();
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
        /// Method to Bind Country code of Mobile Number to ddlCountryCode control
        /// </summary>
        private void BindCountryCode()
        {
            try
            {
                RegisterRecruiterHRBAL registerRecruiterHRBAL = new RegisterRecruiterHRBAL();
                DataSet datasetCountryCode = new DataSet();
                datasetCountryCode = registerRecruiterHRBAL.GetCountryCode();
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
        /// Method for Binding Country to ddlCountryPresent control
        /// </summary>
        private void BindCountry()
        {
            try
            {
                RegisterRecruiterHRBAL registerRecruiterHRBAL = new RegisterRecruiterHRBAL();
                DataSet datasetCountry = new DataSet();
                datasetCountry = registerRecruiterHRBAL.GetCountry();
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
               
                RegisterRecruiterHRBAL registerRecruiterHRBAL = new RegisterRecruiterHRBAL();
                registerRecruiterEntity.FullName = txtFullName.Text.Trim();
                registerRecruiterEntity.Company = txtCompany.Text.Trim();

                registerRecruiterEntity.MobileNo += "+";
                string format = ddlCountryCode.SelectedItem.Text.Trim();
                string[] Words = format.Split(new char[] { '+' });
                int count1 = 0;
                foreach (string Word in Words)
                {
                    count1 += 1;
                    if (count1 == 2)
                    {
                        registerRecruiterEntity.MobileNo += Word.Trim();
                    }
                }
                registerRecruiterEntity.MobileNo += txtMobNo.Text.Trim();               
                registerRecruiterEntity.OfficialEmailId = txtOffEmailid.Text.Trim();
                registerRecruiterEntity.Password = txtPassword.Text.Trim();
                registerRecruiterEntity.PresentCountry = Convert.ToInt32(ddlCountryPresent.SelectedValue);
                registerRecruiterEntity.PresentState = Convert.ToInt32(ddlStatePresent.SelectedValue);
                registerRecruiterEntity.PresentCity = Convert.ToInt32(ddlCityPresent.SelectedValue);
                registerRecruiterEntity.PresentArea = Convert.ToInt32(ddlAreaPresent.SelectedValue);
                registerRecruiterEntity.Pincode = txtPincode.Text.Trim();
                registerRecruiterEntity.PANCardNo = txtPANCard.Text.Trim();
                registerRecruiterEntity.JobType = rbtlJobType.SelectedValue;
                registerRecruiterEntity.OfficialContactNo = txtOfficialContact.Text.Trim();
                registerRecruiterEntity.AlternateNo = txtAlternateContactNo.Text.Trim();
                registerRecruiterEntity.PersonalMailId = txtPersonalMailid.Text.Trim();
                registerRecruiterEntity.HrId = HrID;
                registerRecruiterEntity.EmploymentStatus = rbtlEmploymentStatus.SelectedValue;
                if (rbtFreelance.Checked)
                {
                    registerRecruiterEntity.FreelanceOrEmployee = rbtFreelance.Text.Trim();
                   
                }
                else if(rbtEmployee.Checked)
                {
                    registerRecruiterEntity.FreelanceOrEmployee = rbtEmployee.Text.Trim();
                   
                }
                registerRecruiterEntity.AmountPerMonth = txtAmount.Text.Trim();
                registerRecruiterEntity.PercentPerClosure = txtPercentagePerClosure.Text.Trim();
                registerRecruiterEntity.EmployeeSalary = txtSalary.Text.Trim();
                registerRecruiterEntity.ClientName = txtClientName.Text.Trim();
                registerRecruiterEntity.ClientSite = txtClientSite.Text.Trim();
                registerRecruiterEntity.Address = txtAddress.Text.Trim();
                
                //get path of photos
                string path = AppDomain.CurrentDomain.BaseDirectory + "Images\\" + this.FileUploadRecruiterPhoto.FileName;
                string uploadphoto = Request.PhysicalApplicationPath + "Images\\";
                registerRecruiterEntity.PhotoPath = uploadphoto.ToString();
                string result = registerRecruiterHRBAL.SaveNewRecruiterBAL(registerRecruiterEntity);
                registerRecruiterEntity.Recruiterid = result;
                RecruiterPrefix = RecruiterPrefix + result;
                if (result != null)
                {
                    if (FileUploadRecruiterPhoto.HasFile)
                    {
                        string extension = Path.GetExtension(FileUploadRecruiterPhoto.PostedFile.FileName);
                        FileUploadRecruiterPhoto.SaveAs(uploadphoto + RecruiterPrefix.ToString() + extension);
                    }
                    isMailSent = SendHTMLMail(result);
                    if (isMailSent == true)
                    {
                        registerRecruiterEntity.IsMailSent = true;
                        registerRecruiterHRBAL.UpdateMailsentBAL(registerRecruiterEntity);
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
        /// <summary>
        /// Method to send mail template
        /// </summary>
        /// <param name="result">String Parameter</param>
        /// <returns>System.Data.Boolean</returns>
        private bool SendHTMLMail(string result)
        {
            try
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
            strContent = strContent.Replace("$$Candidate ID$$", RecruiterPrefix);
            strContent = strContent.Replace("$$Candidate Mail ID$$", txtOffEmailid.Text.Trim());
            // "http://www.logossolutions.co.in/");
            strContent = strContent.Replace("$$Mobile Number$$", registerRecruiterEntity.MobileNo.Trim());
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
                RegisterRecruiterHRBAL registerRecruiterHRBAL = new RegisterRecruiterHRBAL();
                DataSet datasetState = new DataSet();
                int CountryId = Convert.ToInt32(ddlCountryPresent.SelectedValue);
                datasetState = registerRecruiterHRBAL.GetState(CountryId);
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
                RegisterRecruiterHRBAL registerRecruiterHRBAL = new RegisterRecruiterHRBAL();
                DataSet datasetCity = new DataSet();
                int StateId = Convert.ToInt32(ddlStatePresent.SelectedValue);
                datasetCity = registerRecruiterHRBAL.GetCity(StateId);
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
                RegisterRecruiterHRBAL registerRecruiterHRBAL = new RegisterRecruiterHRBAL();
                DataSet datasetCityArea = new DataSet();
                int cityId = Convert.ToInt32(ddlCityPresent.SelectedValue);
                datasetCityArea = registerRecruiterHRBAL.GetArea(cityId);
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