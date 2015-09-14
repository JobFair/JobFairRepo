using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities.Recruiter;
using BAL;
using System.IO;

namespace JobFair.UserControls.Recruiter
{
    public partial class RecruiterRegistration : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {           
            RegisterRecruiterEntity rrentity = new RegisterRecruiterEntity();
            RegisterRecruiterBAL rrBAL = new RegisterRecruiterBAL();
            rrentity.FullName = txtFullName.Text.Trim();
            rrentity.Company = txtCompany.Text.Trim();
            rrentity.MobileNo = txtMobNo.Text.Trim();
            rrentity.OficialEmailId = txtOffEmailid.Text.Trim();
            rrentity.Password = txtPassword.Text.Trim();
            rrentity.City = txtCity.Text.Trim();
            //get path of photos
            string path = AppDomain.CurrentDomain.BaseDirectory + "Images\\" + this.FileUploadRecruiterPhoto.FileName;
            string uploadphoto = Request.PhysicalApplicationPath + "Images\\";
            rrentity.PhotoPath = uploadphoto.ToString();
            string result= rrBAL.NewRecruiterBAL(rrentity);
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