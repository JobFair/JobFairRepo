using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities.JobSeeker;
using System.Data;
using BAL;

namespace JobFair.Forms.JobSeeker
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        ViewProfileEntity viewProfileEntity = new ViewProfileEntity();
        ViewProfileJSBAL viewProfileJSBAL = new ViewProfileJSBAL();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ds = viewProfileJSBAL.ViewProfileBAL(viewProfileEntity);
                lblFirstName.Text = viewProfileEntity.FirstName;
                lblLastName.Text = viewProfileEntity.LastName;
              
                lblEmailId.Text = viewProfileEntity.EmailId;
                lblContact.Text = viewProfileEntity.MobileNumber;
                lblResumeTitle.Text = viewProfileEntity.ResumeTitle;
                lblSkills.Text = viewProfileEntity.Skills;
                
            }
            
        }

        protected void btnResumeskills_Click(object sender, EventArgs e)
        {
            divTextSkills.Visible = true;
            divLabelSkills.Visible = false;
        }

        protected void btnAddResumeSkills_Click(object sender, EventArgs e)
        {

            if (txtResumeTitle.Text != viewProfileEntity.ResumeTitle)
            {
                viewProfileEntity.ResumeTitle = txtResumeTitle.Text;
            }
            int result = viewProfileJSBAL.ResumeDetailsBAL(viewProfileEntity);
            divLabelSkills.Visible = true;
            divTextSkills.Visible = false;
        }

        protected void lbEditContact_Click(object sender, EventArgs e)
        {
            divContact.Visible = true;
            lblContact.Visible = false;
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (viewProfileEntity.MobileNumber != txtContact.Text.Trim())
            {
                viewProfileEntity.MobileNumber = txtContact.Text.Trim();
            }
            int result= viewProfileJSBAL.ChangeContactNoBAL(viewProfileEntity);
            if (result > 0)
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