using BAL;
using CommonUtil;
using System;
using System.IO;

namespace JobFair.Forms.JobSeeker
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();

            try
            {
                JobSeekerRegisterBAL jsrBAL = new JobSeekerRegisterBAL();
                string path = AppDomain.CurrentDomain.BaseDirectory + "UploadFiles\\" + this.FileUploadResume.FileName;

                ///Provide the min and max limit for the no
                jsrBAL.UserId = Convert.ToString(randomNumber.Next(100, int.MaxValue));
                jsrBAL.FirstName = txtFirstName.Text.Trim();
                jsrBAL.LastName = txtLastName.Text.Trim();
                jsrBAL.EmailId = txtEmailId.Text.Trim();
                jsrBAL.DesiredUserName = txtDesiredUserName.Text.Trim();
                jsrBAL.Gender = rblGender.SelectedItem.Text;
                jsrBAL.MobileNo = txtMobileNo.Text.Trim();
                jsrBAL.Password = txtPassword.Text.Trim();

                jsrBAL.CurrentCity = txtCurrCity.Text.Trim();
                jsrBAL.CurrentAddress = txtCurrAddress.Text.Trim();
                string uploadFolder = Request.PhysicalApplicationPath + "UploadFiles\\";
                if (FileUploadResume.HasFile)
                {
                    string extension = Path.GetExtension(FileUploadResume.PostedFile.FileName);
                    FileUploadResume.SaveAs(uploadFolder + jsrBAL.UserId + extension);
                    Label1.Text = "File uploaded successfully as: " + "Test" + extension;
                }
                else
                {
                    Label1.Text = "First select a file.";
                }
                jsrBAL.UploadResumepath = uploadFolder.ToString();
                JobSeekerRegisterCommon jsrCom = new JobSeekerRegisterCommon();

                int result = jsrCom.RegisterNewJobSeekerBAL(jsrBAL);
                if (result > 1)
                {
                    Response.Redirect("SearchJobs.aspx");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}