using BAL;
using Entities.Recruiter;
using System;
using System.IO;
using System.Net.Mail;

namespace JobFair.UserControls.Recruiter
{
    public partial class RecruiterRegistration : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Save New Recruiter's Details
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/>instance containing the event data.</param>
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterRecruiterEntity registerRecruiterEntity = new RegisterRecruiterEntity();
                RegisterRecruiterBAL registerRecruiterBAL = new RegisterRecruiterBAL();
                registerRecruiterEntity.FullName = txtFullName.Text.Trim();
                registerRecruiterEntity.Company = txtCompany.Text.Trim();
                registerRecruiterEntity.MobileNo = txtMobNo.Text.Trim();
                registerRecruiterEntity.OficialEmailId = txtOffEmailid.Text.Trim();
                registerRecruiterEntity.Password = txtPassword.Text.Trim();
                registerRecruiterEntity.City = txtCity.Text.Trim();
                //get path of photos
                string path = AppDomain.CurrentDomain.BaseDirectory + "Images\\" + this.FileUploadRecruiterPhoto.FileName;
                string uploadphoto = Request.PhysicalApplicationPath + "Images\\";
                registerRecruiterEntity.PhotoPath = uploadphoto.ToString();
                string result = registerRecruiterBAL.SaveNewRecruiterBAL(registerRecruiterEntity);

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
    }
}