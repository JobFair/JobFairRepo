using BAL;
using Entities.HR;
using System;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Web.UI.WebControls;

namespace JobFair.Forms.HR
{
    public partial class RecruiterRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCountry();
                BindCountryCode();
            }
        }

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

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                RecruiterRegisterEntity registerRecruiterEntity = new RecruiterRegisterEntity();
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
                registerRecruiterEntity.EmploymentStatus = rbtlEmploymentStatus.SelectedValue;
                
                //get path of photos
                string path = AppDomain.CurrentDomain.BaseDirectory + "Images\\" + this.FileUploadRecruiterPhoto.FileName;
                string uploadphoto = Request.PhysicalApplicationPath + "Images\\";
                registerRecruiterEntity.PhotoPath = uploadphoto.ToString();
                string result = registerRecruiterHRBAL.SaveNewRecruiterBAL(registerRecruiterEntity);

                if (result != null)
                {
                    if (FileUploadRecruiterPhoto.HasFile)
                    {
                        string extension = Path.GetExtension(FileUploadRecruiterPhoto.PostedFile.FileName);
                        FileUploadRecruiterPhoto.SaveAs(uploadphoto + result.ToString() + extension);
                    }
                    Label1.Text = "Welcome. Registerd successfully";
                }
                else
                {
                    Label1.Text = "Not registerd";
                }
                string from = txtFullName.Text;
                string subject = "Logged In";
                string content = "Helllo....";
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(from);
                msg.To.Add("saurabh.logossolutions@gmail.com");
                msg.Subject = subject;
                msg.Body = "Hi,<br/>New Recruiter is: " + txtFullName.Text + "<br/><br/> " + "Registered Now" + "<br/>";

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("jyoti.logossolutions@gmail.com", "@jacksparow");
                smtp.EnableSsl = true;
                smtp.Send(msg);
                msg = null;
                Response.Write("<script language='javascript'>alert('Email Send to Super Admin ...');</script>");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void rbtFreelance_CheckedChanged(object sender, EventArgs e)
        {
            PanelFreelance.Visible = true;
            PanelEmployee.Visible = false;
        }

        protected void rbtEmployee_CheckedChanged(object sender, EventArgs e)
        {
            PanelEmployee.Visible = true;
            PanelFreelance.Visible = false;
        }

        protected void rbtAmount_CheckedChanged(object sender, EventArgs e)
        {
            txtAmount.Visible = true;
            txtPercentagePerClosure.Visible = false;
        }

        protected void rbtPercentagePerClosure_CheckedChanged(object sender, EventArgs e)
        {
            txtPercentagePerClosure.Visible = true;
            txtAmount.Visible = false;
        }

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