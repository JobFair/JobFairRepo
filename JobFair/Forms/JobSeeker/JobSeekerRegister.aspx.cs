using BAL;
using Entities;
using System;
using System.IO;

namespace JobFair.Forms.JobSeeker
{
    /// <summary>
    /// Class JobSeekerRegister.
    /// </summary>
    public partial class JobSeekerRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
                Random randomNumber = new Random();
                RegisterJobSeekerEntity jobSeekerEntity = new RegisterJobSeekerEntity();
                string path = AppDomain.CurrentDomain.BaseDirectory + "UploadFiles\\" + this.FileUploadResume.FileName;

                // Provide the min and max limit for the no
                jobSeekerEntity.UserId = Convert.ToString(randomNumber.Next(100, int.MaxValue));

                // Set value to job seeker entity
                jobSeekerEntity.FirstName = txtFirstName.Text.Trim();
                jobSeekerEntity.LastName = txtLastName.Text.Trim();
                jobSeekerEntity.EmailId = txtEmailId.Text.Trim();
                jobSeekerEntity.DesiredUserName = txtDesiredUserName.Text.Trim();
                jobSeekerEntity.Gender = rblGender.SelectedItem.Text;
                jobSeekerEntity.MobileNo = txtMobileNo.Text.Trim();
                jobSeekerEntity.Password = txtPassword.Text.Trim();
                jobSeekerEntity.CurrentCity = txtCurrCity.Text.Trim();
                jobSeekerEntity.CurrentAddress = txtCurrAddress.Text.Trim();
                string uploadFolder = Request.PhysicalApplicationPath + "UploadFiles\\";

                // Check if fileupload control has a file.
                if (FileUploadResume.HasFile)
                {
                    string extension = Path.GetExtension(FileUploadResume.PostedFile.FileName);
                    FileUploadResume.SaveAs(uploadFolder + jobSeekerEntity.UserId + extension);
                    lblMessage.Text = "File uploaded successfully as: " + jobSeekerEntity.UserId + extension;
                }
                else
                {
                    lblMessage.Text = "First select a file.";
                }
                jobSeekerEntity.UploadResumepath = uploadFolder.ToString();
                RegisterJobSeekerBAL jobSeekerBAL = new RegisterJobSeekerBAL();

                int result = jobSeekerBAL.RegisterNewJobSeekerBAL(jobSeekerEntity);
                if (result >= 1)
                {
                    Response.Redirect("Feedback Us.aspx");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}