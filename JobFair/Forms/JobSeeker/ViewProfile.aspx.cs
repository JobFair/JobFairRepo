using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.JobSeeker;
using System.Data;
using System.IO;
using System.Text;

namespace JobFair.Forms.JobSeeker
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        ViewProfileJSBAL viewProfileJSBAL = new ViewProfileJSBAL();
        ViewProfileEntity viewProfileEntity = new ViewProfileEntity();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            viewProfileJSBAL.ViewProfileBAL(viewProfileEntity);
            lblContact.Text = viewProfileEntity.MobileNumber;
            lblFirstName.Text = viewProfileEntity.FirstName;
            lblLastName.Text = viewProfileEntity.LastName;
            lblEmailId.Text = viewProfileEntity.EmailId;
            lblName1.Text = viewProfileEntity.FirstName + " " + viewProfileEntity.LastName;
            lblLoginMailId.Text = viewProfileEntity.EmailId;
            lblBirthDate.Text = viewProfileEntity.Birthdate.ToShortDateString();
            int year = DateTime.Now.Year - viewProfileEntity.Birthdate.Year;
            lblAge.Text = year.ToString() +" "+"Years";
            lblAdress.Text = viewProfileEntity.Address;
            txtFirstNamePersonalDetails.Text = viewProfileEntity.FirstName;
            txtLastNamePersonalDetails.Text = viewProfileEntity.LastName;
            txtLoginmailId.Text = viewProfileEntity.EmailId;
            txtBirthdate.Text = viewProfileEntity.Birthdate.ToShortDateString();
            txtAddress.Text = viewProfileEntity.Address;

            // Please change the value of path which used to store the file.
            ////string path = AppDomain.CurrentDomain.BaseDirectory + "UploadFiles\\" + this.FileUploadResume.FileName;
            ////this.FileUploadResume.SaveAs(path);
            ////this.txtResume.Text = ShowContent(path);

            
                    
        }
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

        protected void btnResumeskills_Click(object sender, EventArgs e)
        {
            divTextSkills.Visible = true;
            divLabelSkills.Visible = false;
        }

        protected void btnAddResumeSkills_Click(object sender, EventArgs e)
        {
            divLabelSkills.Visible = true;
            divTextSkills.Visible = false;
        }

        protected void lbEditContact_Click(object sender, EventArgs e)
        {
            txtContact.Text = viewProfileEntity.MobileNumber;
            divContact.Visible = true;
            lblContact.Visible = false;
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
           
            
            if (txtContact.Text != viewProfileEntity.MobileNumber)
            {
                viewProfileEntity.MobileNumber = txtContact.Text;
                int result = viewProfileJSBAL.ChangeContactNoBAL(viewProfileEntity);
                lblContact.Visible = true;
                divContact.Visible = false;

            }
            else
            {
                lblContact.Visible = true;
                divContact.Visible = false;
            }         
            
           

           
        }

        protected void btnCancelResumeSkills_Click(object sender, EventArgs e)
        {
            divLabelSkills.Visible = true;
            divTextSkills.Visible = false;
        }

        protected void btnLoaction_Click(object sender, EventArgs e)
        {
            divLabelLocation.Visible = false;
            divTexBoxtLocation.Visible = true;
        }

        protected void btnAddLocation_Click(object sender, EventArgs e)
        {
           
            divTexBoxtLocation.Visible = false;
            divLabelLocation.Visible =true;
        }

        protected void btnCancelLocation_Click(object sender, EventArgs e)
        {
           
            divTexBoxtLocation.Visible = false;
            divLabelLocation.Visible = true;
        }

        protected void btnUpdatePersonal_Click(object sender, EventArgs e)
        {
            divLabelPersonal.Visible = false;
            divTextBoxPersonal.Visible = true;
        }

        protected void btnAddPersonal_Click(object sender, EventArgs e)
        {
            
                viewProfileEntity.FirstName = txtFirstNamePersonalDetails.Text;
                viewProfileEntity.LastName = txtLastNamePersonalDetails.Text;
                viewProfileEntity.EmailId = txtLoginmailId.Text;
                viewProfileEntity.Birthdate = Convert.ToDateTime(txtBirthdate.Text);
                viewProfileEntity.Address = txtAddress.Text;
          
            int result= viewProfileJSBAL.ChangePersonalDetailsBAL(viewProfileEntity);
            divTextBoxPersonal.Visible = false;
            divLabelPersonal.Visible = true;
        }

        protected void btnCancelPersonal_Click(object sender, EventArgs e)
        {
            divTextBoxPersonal.Visible = false;
            divLabelPersonal.Visible = true;
        }

        protected void lbPreviousEmployment_Click(object sender, EventArgs e)
        {
            divPreviousEmployment.Visible = true;
        }

        protected void btnUpdateEmployerDetails_Click(object sender, EventArgs e)
        {
            divLabelEmployer.Visible =false;
            divTextBoxEmployer.Visible = true;
        }

        protected void btnAddEmployerDetails_Click(object sender, EventArgs e)
        {
           
            divTextBoxEmployer.Visible = false;
            divLabelEmployer.Visible = true;
            }

        protected void btnCancelEmployerDetails_Click(object sender, EventArgs e)
        {
            divTextBoxEmployer.Visible = false;
            divLabelEmployer.Visible = true;
        }

        protected void lbAddmoreProject1_Click(object sender, EventArgs e)
        {

            divTextBoxProjectDetails.Visible = true;
            divLabelProjectDetails.Visible = false;
        }

        protected void btnUpdateEducation_Click(object sender, EventArgs e)
        {
            divLabelEducation.Visible = false;
            divTextBoxEducation.Visible = true;
        }

        protected void btnAddEduaction_Click(object sender, EventArgs e)
        {
            divTextBoxEducation.Visible = false;
            divLabelEducation.Visible = true;
        }

        protected void btnCancelEducation_Click(object sender, EventArgs e)
        {
            divTextBoxEducation.Visible = false;
            divLabelEducation.Visible = true;   
        }

        protected void btnUpdateProject_Click(object sender, EventArgs e)
        {
            divLabelProjectDetails.Visible = false;
            divTextBoxProjectDetails.Visible = true;
        }

        protected void btnAddProject_Click(object sender, EventArgs e)
        {
            divTextBoxProjectDetails.Visible = false;
            divLabelProjectDetails.Visible = true;
        }

        protected void btnCancelProject_Click(object sender, EventArgs e)
        {
            divTextBoxProjectDetails.Visible = false;
            divLabelProjectDetails.Visible = true;
        }

        protected void btnUpdateIndustry_Click(object sender, EventArgs e)
        {
            divLabelIndustry.Visible = false;
            divTextBoxIndustry.Visible = true;
        }

        protected void btnAddIndustry_Click(object sender, EventArgs e)
        {
            divTextBoxIndustry.Visible = false;
            divLabelIndustry.Visible = true;
        }

        protected void btnCancelIndustry_Click(object sender, EventArgs e)
        {
            divTextBoxIndustry.Visible = false;
            divLabelIndustry.Visible = true;
        }

       


       
            
             

       
     

       
       

       

           }
}