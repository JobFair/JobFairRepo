using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

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
            divContact.Visible = true;
            lblContact.Visible = false;
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            lblContact.Visible = true;
            divContact.Visible = false;
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

       
      

       
     

       
       

       

           }
}