using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities.JobSeeker;
using BAL;
using CommonUtil;

namespace JobFair.Forms.JobSeeker
{
    public partial class ProfessionalDetailsJobSeeker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BindDropDownIndustry();
            BindDropDownDepartment();
            
        }

        private void BindDropDownDepartment()
        {
            ddlDepartment.DataSource = Utility.GetDepartmentBAL();
            ddlDepartment.DataTextField = "DepartmentName";
            ddlDepartment.DataValueField = "DepartmentId";
            ddlDepartment.DataBind();
            ddlDepartment.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        private void BindDropDownIndustry()
        {

            ddlIndustry.DataSource= Utility.GetIndustryBAL();
            ddlIndustry.DataTextField = "IndustryName";
            ddlIndustry.DataValueField = "IndustryId";
            ddlIndustry.DataBind();
            ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));

           
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
                CurrentDesiredJobEntity curentity = new CurrentDesiredJobEntity();
                CurrentDesiredJobBAL curjobBAL = new CurrentDesiredJobBAL();
                //ProfessionalDetailsCurrentJSBAL rjsBAL = new ProfessionalDetailsCurrentJSBAL();
                curentity.Candidateid = "JS9";
                curentity.ResumeHeadline = txtResumeHeadline.Text;
            //  curentity.TotalExperience = (Years + '.' + Month);
                curentity.Industry = ddlIndustry.SelectedIndex;
                curentity.Department = ddlDepartment.SelectedIndex;
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
                int result = curjobBAL.CurrentProfessionalDetailsBAL(curentity);
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

        protected void btnsaveDesJob_Click(object sender, EventArgs e)
        {

        }

       
        





    }
}