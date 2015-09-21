using BAL;
using Entities.Recruiter;
using System;
using System.IO;

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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}