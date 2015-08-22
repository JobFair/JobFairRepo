using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using BAL;
using System.IO;

namespace JobFair.Forms.JobSeeker
{
    public partial class RegisterJobSeeker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {


            try
            {
                Random randomNumber = new Random();
                RegisterJobSeekerEntity rjsEnitity = new RegisterJobSeekerEntity();
                string path = AppDomain.CurrentDomain.BaseDirectory + "UploadFiles\\" + this.FileUploadResume.FileName;

                ///Provide the min and max limit for the no
                rjsEnitity.UserId = Convert.ToString(randomNumber.Next(100, int.MaxValue));
                rjsEnitity.FirstName = txtFirstName.Text.Trim();
                rjsEnitity.LastName = txtLastName.Text.Trim();
                rjsEnitity.EmailId = txtEmailId.Text.Trim();
                rjsEnitity.DesiredUserName = txtDesiredUserName.Text.Trim();
                rjsEnitity.Gender = rblGender.SelectedItem.Text;
                rjsEnitity.MobileNo = txtMobileNo.Text.Trim();
                rjsEnitity.Password = txtPassword.Text.Trim();

                rjsEnitity.CurrentCity = txtCurrCity.Text.Trim();
                rjsEnitity.CurrentAddress = txtCurrAddress.Text.Trim();
                string uploadFolder = Request.PhysicalApplicationPath + "UploadFiles\\";
                if (FileUploadResume.HasFile)
                {
                    string extension = Path.GetExtension(FileUploadResume.PostedFile.FileName);
                    FileUploadResume.SaveAs(uploadFolder + rjsEnitity.UserId + extension);
                    Label1.Text = "File uploaded successfully as: " + "Test" + extension;
                }
                else
                {
                    Label1.Text = "First select a file.";
                }
                rjsEnitity.UploadResumepath = uploadFolder.ToString();
                RegisterJobSeekerBAL rjsBAL = new RegisterJobSeekerBAL();

                int result = rjsBAL.RegisterNewJobSeekerBAL(rjsEnitity);
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