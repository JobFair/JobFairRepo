using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using BAL;

namespace JobFair.Forms.JobSeeker
{
    public partial class ProfessionalDetailsJobSeeker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <cref="EventArgs">instance containing event data</param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //calculting total experience     
                DateTime FromYear = Convert.ToDateTime(txtFromdate.Text);
                DateTime ToYear = Convert.ToDateTime(txtTill.Text);
                //Creating object of TimeSpan Class  
                TimeSpan objTimeSpan = ToYear - FromYear;
                //years  
                int Years = ToYear.Year - FromYear.Year;
                int Month = ToYear.Month - FromYear.Month;
                Label1.Text = Years + "Years-" + Month + "Months";
                Current_DesiredJobDetailsEntity curentity = new Current_DesiredJobDetailsEntity();
                RegisterJobSeekerBAL rjsBAL = new RegisterJobSeekerBAL();
                curentity.Userid = "1200132426";
                curentity.ResumeHeadline = txtResumeHeadline.Text;
                curentity.TotalExperience = (Years + '.' + Month);
                curentity.Industry = ddlIndustry.SelectedItem.Text;
                curentity.Department = ddlDepartment.SelectedItem.Text;
                curentity.CurrentJobRole = txtCurrentJobRole.Text;
                curentity.PrimFunctionalRole = ddlPrimaryRole.SelectedItem.Text;
                curentity.PrimJobDescrip = txtJobdescriptionPrimar.Text;
                curentity.PrimTechSkills = txtTechnicalskillPrimary.Text;
                curentity.SecFunctionalRole = ddlSecRole.SelectedItem.Text;
                curentity.SecJobDescrip = txtjobdescriptionSec.Text;
                curentity.SecTechSkills = txtTechnicalskillSec.Text;
                curentity.Designation = txtDesignation.Text;
                curentity.ReasonforJobChange = txtReasonforJobchange.Text;
                curentity.CurrentEmployer = txtemployeer.Text;
                curentity.TechnicalSkills = txtTechSkills.Text;
                int result = rjsBAL.CurrentProfessionalDetailsBAL(curentity);
                if (result > 0)
                {
                    lblmsg.Text = "Your details saved successfully";
                }
                else
                {
                    lblmsg.Text = "Your details are not saved";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }





    }
}