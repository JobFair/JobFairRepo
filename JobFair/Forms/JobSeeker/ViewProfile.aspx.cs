using BAL;
using Entities.JobSeeker;
using System;
using System.Data;
using System.IO;

namespace JobFair.Forms.JobSeeker
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        private ViewProfileJSBAL viewProfileJSBAL = new ViewProfileJSBAL();
        private ViewProfileEntity viewProfileEntity = new ViewProfileEntity();
        private DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "UploadFiles\\" + "JS4.txt";
            //   UploadFile(path);

            byte[] arraycontent = ReadFileData(path);
            txtResumeDetails.Text = System.Text.Encoding.UTF8.GetString(arraycontent);

            LoadUploadedImages();

            //  JobseekerRegisterDetails();
            //  JobSeekerPersonalDetails();
            //  JobSeekerProfessionalDetails();
            //  string filename = "JS12.jpg";
            ////  string path = AppDomain.CurrentDomain.BaseDirectory + "Images\\" + filename;
            //  // Please change the value of path which used to store the file.
            //  string path = AppDomain.CurrentDomain.BaseDirectory + "UploadFiles\\" + this.FileUploadResume.FileName;
            //  this.FileUploadResume.SaveAs(path);
            //  this.txtResume.Text = ShowContent(path);
        }

        private void LoadUploadedImages()
        {
            DirectoryInfo di = new DirectoryInfo(Server.MapPath("~/Images/"));

            foreach (FileInfo fi in di.GetFiles())
            {
                if (fi.Name == "JS12.jpg")
                {
                    imgCandidate.ImageUrl = "~/Images/" + fi.Name;
                }
            }
        }

        public byte[] ReadFileData(String fileName)
        {
            byte[] buff = null;
            FileStream fs = new FileStream(fileName,
                                           FileMode.Open,
                                           FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(fileName).Length;
            buff = br.ReadBytes((int)numBytes);
            return buff;
        }

        //private void UploadFile(string path)
        //{
        //    try
        //    {
        //        this.fileupload1.SaveAs(path);
        //        FileInfo fi = new FileInfo(path);
        //        FileStream fs = fi.OpenRead();
        //        string filename = Path.GetFileName(this.fileupload1.FileName);
        //    }
        //    catch (Exception ex)
        //    {
        //        //   throw;
        //    }
        //}
        //protected void btnRead_Click(object sender, EventArgs e)
        //{
        //    string path = AppDomain.CurrentDomain.BaseDirectory + "UploadFiles\\" + this.fileupload1.FileName;
        //    UploadFile(path);

        //    byte[] arraycontent = ReadFileData(path);
        //    textBoxContents.Text = System.Text.Encoding.UTF8.GetString(arraycontent);

        //}
        //private void JobSeekerProfessionalDetails()
        //{
        //    viewProfileJSBAL.ProfessionalDetailsBAL(viewProfileEntity);
        //    lblWorkexperience.Text = viewProfileEntity.WorkExperience;
        //    lblCurrentEmployer.Text = viewProfileEntity.CurrentEmployer;
        //    lblDesignationCurrent.Text = viewProfileEntity.DesignationCurrent;
        //    lblCompanyType.Text = viewProfileEntity.CompanyType;
        //    lblAnnualSalary.Text = viewProfileEntity.AnnualSalary;
        //    lblExpectedSalary.Text = viewProfileEntity.ExpectedSalary;
        //}

        //private void JobSeekerPersonalDetails()
        //{
        //    viewProfileJSBAL.PersonalDetailsBAL(viewProfileEntity);
        //    lblLoginMailId.Text = viewProfileEntity.EmailId;
        //    lblName1.Text = viewProfileEntity.FirstName + " " + viewProfileEntity.LastName;
        //    lblBirthDate.Text = viewProfileEntity.Birthdate.ToShortDateString();
        //    int year = DateTime.Now.Year - viewProfileEntity.Birthdate.Year;
        //    lblAge.Text = year.ToString() + " " + "Years";
        //    lblAdress.Text = viewProfileEntity.Address;
        //}

        //private void JobseekerRegisterDetails()
        //{
        //    viewProfileJSBAL.RegisterDetailsBAL(viewProfileEntity);
        //    lblContact.Text = viewProfileEntity.MobileNumber;
        //    lblFullName.Text = viewProfileEntity.FirstName + " " + viewProfileEntity.LastName;
        //    lblEmailId.Text = viewProfileEntity.EmailId;
        //}

        //public string ShowContent(string path)
        //{
        //    string strInput = "";
        //    string GetStream = "";

        //    if (File.Exists(path))
        //    {
        //        StreamReader sr = new StreamReader(path, UnicodeEncoding.GetEncoding("UTF-8"));
        //        strInput = sr.ReadLine();
        //        while (strInput != null)
        //        {
        //            GetStream += strInput;
        //            strInput = sr.ReadLine();
        //        }
        //        sr.Close();
        //    }
        //    else
        //    {
        //        Response.Write("file does not exist!");
        //    }
        //    return GetStream;
        //}

        //protected void btnResumeskills_Click(object sender, EventArgs e)
        //{
        //    divTextSkills.Visible = true;
        //    divLabelSkills.Visible = false;
        //}

        //protected void btnAddResumeSkills_Click(object sender, EventArgs e)
        //{
        //    divLabelSkills.Visible = true;
        //    divTextSkills.Visible = false;
        //}

        //protected void lbEditContact_Click(object sender, EventArgs e)
        //{
        //    txtContact.Text = viewProfileEntity.MobileNumber;
        //    divContact.Visible = true;
        //    lblContact.Visible = false;
        //}

        //protected void btnOk_Click(object sender, EventArgs e)
        //{
        //    if (txtContact.Text != viewProfileEntity.MobileNumber)
        //    {
        //        viewProfileEntity.MobileNumber = txtContact.Text;
        //        int result = viewProfileJSBAL.ChangeContactNoBAL(viewProfileEntity);
        //        lblContact.Visible = true;
        //        divContact.Visible = false;
        //    }
        //    else
        //    {
        //        lblContact.Visible = true;
        //        divContact.Visible = false;
        //    }
        //}

        //protected void btnCancelResumeSkills_Click(object sender, EventArgs e)
        //{
        //    divLabelSkills.Visible = true;
        //    divTextSkills.Visible = false;
        //}

        //protected void btnLoaction_Click(object sender, EventArgs e)
        //{
        //    divLabelLocation.Visible = false;
        //    divTexBoxtLocation.Visible = true;
        //}

        //protected void btnAddLocation_Click(object sender, EventArgs e)
        //{
        //    divTexBoxtLocation.Visible = false;
        //    divLabelLocation.Visible = true;
        //}

        //protected void btnCancelLocation_Click(object sender, EventArgs e)
        //{
        //    divTexBoxtLocation.Visible = false;
        //    divLabelLocation.Visible = true;
        //}

        //protected void btnUpdatePersonal_Click(object sender, EventArgs e)
        //{
        //    txtFirstNamePersonalDetails.Text = viewProfileEntity.FirstName;
        //    txtLastNamePersonalDetails.Text = viewProfileEntity.LastName;
        //    txtLoginmailId.Text = viewProfileEntity.EmailId;
        //    txtBirthdate.Text = viewProfileEntity.Birthdate.ToShortDateString();
        //    txtAddress.Text = viewProfileEntity.Address;
        //    divLabelPersonal.Visible = false;
        //    divTextBoxPersonal.Visible = true;
        //}

        //protected void btnAddPersonal_Click(object sender, EventArgs e)
        //{
        //    viewProfileEntity.FirstName = txtFirstNamePersonalDetails.Text;
        //    viewProfileEntity.LastName = txtLastNamePersonalDetails.Text;
        //    viewProfileEntity.EmailId = txtLoginmailId.Text;
        //    viewProfileEntity.Birthdate = Convert.ToDateTime(txtBirthdate.Text);
        //    viewProfileEntity.Address = txtAddress.Text;

        //    int result = viewProfileJSBAL.ChangePersonalDetailsBAL(viewProfileEntity);
        //    divTextBoxPersonal.Visible = false;
        //    divLabelPersonal.Visible = true;
        //}

        //protected void btnCancelPersonal_Click(object sender, EventArgs e)
        //{
        //    divTextBoxPersonal.Visible = false;
        //    divLabelPersonal.Visible = true;
        //}

        //protected void lbPreviousEmployment_Click(object sender, EventArgs e)
        //{
        //    divPreviousEmployment.Visible = true;
        //}

        //protected void btnUpdateEmployerDetails_Click(object sender, EventArgs e)
        //{
        //    txtExpectedAnualSalary.Text = viewProfileEntity.ExpectedSalary;
        //    txtAnnualSalary.Text = viewProfileEntity.AnnualSalary;
        //    txtCurrentEmployer.Text = viewProfileEntity.CurrentEmployer;
        //    txtWorkExp.Text = viewProfileEntity.WorkExperience;
        //    txtDesignationCurrent.Text = viewProfileEntity.DesignationCurrent;
        //    divLabelEmployer.Visible = false;
        //    divTextBoxEmployer.Visible = true;
        //}

        //protected void btnAddEmployerDetails_Click(object sender, EventArgs e)
        //{
        //    viewProfileEntity.ExpectedSalary = txtExpectedAnualSalary.Text;
        //    viewProfileEntity.AnnualSalary = txtAnnualSalary.Text;
        //    viewProfileEntity.CurrentEmployer = txtCurrentEmployer.Text;
        //    viewProfileEntity.WorkExperience = txtWorkExp.Text;
        //    viewProfileEntity.DesignationCurrent = txtDesignationCurrent.Text;
        //    viewProfileEntity.CompanyType = ddlCompanyType.SelectedItem.Value.ToString();
        //    int result = viewProfileJSBAL.ChangeProfessionalDetailsBAL(viewProfileEntity);
        //    divTextBoxEmployer.Visible = false;
        //    divLabelEmployer.Visible = true;
        //}

        //protected void btnCancelEmployerDetails_Click(object sender, EventArgs e)
        //{
        //    divTextBoxEmployer.Visible = false;
        //    divLabelEmployer.Visible = true;
        //}

        //protected void lbAddmoreProject1_Click(object sender, EventArgs e)
        //{
        //    divTextBoxProjectDetails.Visible = true;
        //    divLabelProjectDetails.Visible = false;
        //}

        //protected void btnUpdateEducation_Click(object sender, EventArgs e)
        //{
        //    divLabelEducation.Visible = false;
        //    divTextBoxEducation.Visible = true;
        //}

        //protected void btnAddEduaction_Click(object sender, EventArgs e)
        //{
        //    divTextBoxEducation.Visible = false;
        //    divLabelEducation.Visible = true;
        //}

        //protected void btnCancelEducation_Click(object sender, EventArgs e)
        //{
        //    divTextBoxEducation.Visible = false;
        //    divLabelEducation.Visible = true;
        //}

        //protected void btnUpdateProject_Click(object sender, EventArgs e)
        //{
        //    divLabelProjectDetails.Visible = false;
        //    divTextBoxProjectDetails.Visible = true;
        //}

        //protected void btnAddProject_Click(object sender, EventArgs e)
        //{
        //    divTextBoxProjectDetails.Visible = false;
        //    divLabelProjectDetails.Visible = true;
        //}

        //protected void btnCancelProject_Click(object sender, EventArgs e)
        //{
        //    divTextBoxProjectDetails.Visible = false;
        //    divLabelProjectDetails.Visible = true;
        //}

        //protected void btnUpdateIndustry_Click(object sender, EventArgs e)
        //{
        //    divLabelIndustry.Visible = false;
        //    divTextBoxIndustry.Visible = true;
        //}

        //protected void btnAddIndustry_Click(object sender, EventArgs e)
        //{
        //    divTextBoxIndustry.Visible = false;
        //    divLabelIndustry.Visible = true;
        //}

        //protected void btnCancelIndustry_Click(object sender, EventArgs e)
        //{
        //    divTextBoxIndustry.Visible = false;
        //    divLabelIndustry.Visible = true;
        //}

        //protected void btnUpload_Click(object sender, EventArgs e)
        //{
        //    string path = AppDomain.CurrentDomain.BaseDirectory + "UploadFiles\\" + this.FileUploadResume.FileName;
        //    this.FileUploadResume.SaveAs(path);
        //    this.txtResume.Text = ShowContent(path);
        //}
    }
}