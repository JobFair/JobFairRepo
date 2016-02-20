using BAL;
using Entities;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Web.UI.WebControls;


namespace JobFair.Forms.JobSeeker
{
    /// <summary>
    /// Class JobSeekerRegister.
    /// </summary>
    public partial class JobSeekerRegister : System.Web.UI.Page
    {
        RegisterEntity jobSeekerEntity = new RegisterEntity();
        private string JobSeekerPrefix = ConfigurationManager.AppSettings["JobSeekerPrefix"];
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                BindCountryCode();
                BindCountry();
            }
        }
        /// <summary>
        /// Bind Country code to ddlCountryCode control
        /// </summary>
        private void BindCountryCode()
        {
            try
            {
                RegisterJobSeekerBAL registerJobSeekerBAL = new RegisterJobSeekerBAL();
                DataSet datasetCountryCode = new DataSet();
                datasetCountryCode = registerJobSeekerBAL.GetCountryCode();
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
        /// Method to Bind Country to ddlCountryPresent control
        /// </summary>
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
               
                path = AppDomain.CurrentDomain.BaseDirectory + "UploadFiles\\" + this.FileUploadResume.FileName;

                // Set value to job seeker entity
                jobSeekerEntity.FirstName = txtFirstName.Text.Trim();
                jobSeekerEntity.LastName = txtLastName.Text.Trim();
                jobSeekerEntity.EmailId = txtEmailId.Text.Trim();

                jobSeekerEntity.Gender = rblGender.SelectedItem.Text;
                jobSeekerEntity.MobileNo += "+";
                 string format = ddlCountryCode.SelectedItem.Text.Trim();
                                string[] Words = format.Split(new char[] { '+' });
                                int count1 = 0;
                 foreach (string Word in Words)
                                {
                                    count1 += 1;
                                    if (count1 == 2)
                                    {
                                        jobSeekerEntity.MobileNo += Word.Trim();
                                    }
                                }

               

                jobSeekerEntity.MobileNo +=  txtMobileNo.Text.Trim();
                
                jobSeekerEntity.Password = txtPassword.Text.Trim();
                jobSeekerEntity.Country = Convert.ToInt32(ddlCountryPresent.SelectedValue);
                jobSeekerEntity.State = Convert.ToInt32(ddlStatePresent.SelectedValue);
                jobSeekerEntity.CityId = Convert.ToInt32(ddlCityPresent.SelectedValue);
                jobSeekerEntity.CityArea = Convert.ToInt32(ddlAreaPresent.SelectedValue);
                jobSeekerEntity.Pincode = txtPincode.Text.Trim();
                jobSeekerEntity.CurrentAddress = txtCurrAddress.Text.Trim();
                jobSeekerEntity.RefCandidateId = txtRefCandidateId.Text;
                uploadFolder = Request.PhysicalApplicationPath + "UploadFiles\\";

                jobSeekerEntity.UploadResumepath = uploadFolder.ToString();

                jobSeekerEntity.IsReffered = false;
                result = jobSeekerBAL.SaveRegisterNewJobSeekerBAL(jobSeekerEntity);
                result = JobSeekerPrefix + result;
               
                
              
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
                   
                }
               bool isMailSent= SendHTMLMail(result);
                
               if (isMailSent == true)
               {
                   jobSeekerEntity.IsMailSent = isMailSent;
                   Response.Redirect("LogIn.aspx");

               }
               else
               {
                   Response.Write("<script language='javascript'>alert('Registerd Sucessfully but reciept not generated')</script>");
               }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        private bool SendHTMLMail(string result)
        {
            string from = "jyoti.logossolutions@gmail.com";
            string subject1 = "Welcome In Logos Solutions";
            string subject = " Joining Receipt of the candidate " + DateTime.Now.ToString();
            string content = "New Candidate Registered";
            string content1 = "Hello,<br/> Logos Solutions welcomes you";
           
            MailMessage Msg = new MailMessage();
            Msg.From = new MailAddress(from);
            Msg.To.Add("saurabh.logossolutions@gmail.com");
            StreamReader reader = new StreamReader(Server.MapPath("~/Email Templates/RegistrationConfirmation.html"));
            string readFile = reader.ReadToEnd();
            string strContent = "";
            strContent = readFile;
            strContent = strContent.Replace("$$Candidate Name$$", txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim());
            strContent = strContent.Replace("$$Candidate ID$$",result.Trim() );
            strContent = strContent.Replace("$$Candidate Mail ID$$", txtEmailId.Text.Trim());
            // "http://www.logossolutions.co.in/");
            strContent = strContent.Replace("$$Mobile Number$$",jobSeekerEntity.MobileNo.Trim());
            strContent = strContent.Replace("$$Present Address$$","Present Address"+ txtCurrAddress.Text.Trim()+"<br/>Country"+ddlCountryCode.SelectedItem.Text.Trim()+"<br/>State"+ddlStatePresent.SelectedItem.Text.Trim() + "<br/>City" + ddlCityPresent.SelectedItem.Text.Trim() + "<br/>City Area" + ddlAreaPresent.SelectedItem.Text.Trim() + "<br/>Pincode:" + txtPincode.Text.Trim());
            strContent = strContent.Replace("$$Reference ID$$", txtRefCandidateId.Text.Trim());
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
        /// Handles SelectedIndexChanged event of ddlCountryPresent control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles SelectedIndexChanged event of ddlStatePresent control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles SelectedIndexChanged event of ddlCityPresent control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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