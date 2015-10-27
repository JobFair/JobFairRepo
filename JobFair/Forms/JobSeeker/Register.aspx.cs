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
        {}
        


        /// <summary>
        /// Handles the Click event of the btnSubmit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterEntity jobSeekerEntity = new RegisterEntity();
                string path = AppDomain.CurrentDomain.BaseDirectory + "UploadFiles\\" + this.FileUploadResume.FileName;

                // Set value to job seeker entity
                jobSeekerEntity.FirstName = txtFirstName.Text.Trim();
                jobSeekerEntity.LastName = txtLastName.Text.Trim();
                jobSeekerEntity.EmailId = txtEmailId.Text.Trim();
              
                jobSeekerEntity.Gender = rblGender.SelectedItem.Text;
                jobSeekerEntity.MobileNo = txtMobileNo.Text.Trim();
                jobSeekerEntity.Password = txtPassword.Text.Trim();
                jobSeekerEntity.CurrentCity = txtCurrCity.Text.Trim();
                jobSeekerEntity.CurrentAddress = txtCurrAddress.Text.Trim();
                jobSeekerEntity.RefCandidateId = txtRefCandidateId.Text;
                string uploadFolder = Request.PhysicalApplicationPath + "UploadFiles\\";

                jobSeekerEntity.UploadResumepath = uploadFolder.ToString();
                RegisterJobSeekerBAL jobSeekerBAL = new RegisterJobSeekerBAL();

                string result = jobSeekerBAL.SaveRegisterNewJobSeekerBAL(jobSeekerEntity);
                if (result != null)
                {
                    // Check if fileupload control has a file.
                    if (FileUploadResume.HasFile)
                    {
                        string extension = Path.GetExtension(FileUploadResume.PostedFile.FileName);
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
    }
}