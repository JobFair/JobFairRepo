using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BAL;

namespace JobFair.Forms.JobSeeker
{
    public partial class JSViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string candidateId = Convert.ToString(Session["candidateId"]);
           try
           {
               DataSet dsViewProfile = new DataSet();
               ViewProfileJSBAL viewProfileJSBAL=new ViewProfileJSBAL();
               dsViewProfile=viewProfileJSBAL.ViewProfileBAL(candidateId);
               lblCandidateID.Text = candidateId;
               imgProfilePhoto.ImageUrl = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["photo"]);
               string firstName = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["FirstName"]);
               string lastName = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["LastName"]);
               lblName.Text = firstName + " " + lastName;
               lblEmailId.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["EmailId"]);
               lblMobNo.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["MobileNo"]);
               lblGender.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["Gender"]);
               lblCurrentCity.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["CurrentCity"]);
               lblPreferedCity.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["PreferredCity"]);
               lblCurrentCTC.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["CurrentAnualSalary"]);
               lblExpectedCTC.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["ExpectedAnualSalary"]);
               lblNoticePeriod.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["NoticePeriod"]);
               lblInterview.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["AvailabilityForInterview"]);
               lblEmployeeStatus.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["EmploymentStatus"]);
               lblJobType.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["JobType"]);
               lblCompanyType.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["CompanyType"]);
               //lblQualification.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["MobileNo"]);
               lblExperience.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["TotalExpriance"]);
               lblJobPostLooking.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["JobPostLookingFor"]);
               lblWorkStatus.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["CurrentWorkingStatus"]);
               lblAvailabilityInWeek.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["TimeInWeekday"]);


               DataSet dsViewContactDetails = new DataSet();

               
           }
           catch (Exception)
           {
               throw;
           }
        }
    }
}