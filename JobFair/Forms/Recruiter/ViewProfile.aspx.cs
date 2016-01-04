using BAL;
using System;
using System.Data;

namespace JobFair.Forms.Recruiter
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        /// <summary>
        /// Class ViewProfile
        /// </summary>
        private int recruiterId = 12;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // Check page is not post back
                if (!IsPostBack)
                {
                    //string candidateId = Convert.ToString(Session["candidateId"]);
                    //// Check session is not null
                    //if (string.IsNullOrEmpty(candidateId))
                    //{
                    //    Response.Redirect("LogIn.aspx");
                    //}
                    //else
                    //{
                    BindAllUserDetails(recruiterId);
                    
                    //}
                }
            }
            catch (Exception)
            {
                throw;
            }
            //DataSet ds = new DataSet();
            //ViewProfileREBAL viewProfileBAL = new ViewProfileREBAL();
            //ViewProfileEntity viewProfileEntity = new ViewProfileEntity();
            //viewProfileBAL.ViewProfile(viewProfileEntity);
            ////Set the value of viewProfileEntity
            //lblRecruiterName.Text = viewProfileEntity.name;
            //lblCompanyName.Text = viewProfileEntity.companyName;
            //lblMobile.Text = viewProfileEntity.mobNo;
            //lblEmail.Text = viewProfileEntity.emailId;
            //lblCity.Text = viewProfileEntity.city;
            //Image1.ImageUrl = viewProfileEntity.photo;
            ////Bind repeater control
            //ds = viewProfileBAL.ViewJobPostBAL();
            //Repeater1.DataSource = ds;
            //Repeater1.DataBind();
        }

        private void BindAllUserDetails(int recruiterId)
        {
            try
            {
                ViewProfileREBAL viewProfileBAL = new ViewProfileREBAL();
                BindViewProfile(recruiterId, viewProfileBAL);
                BindViewPersonalDetails(recruiterId, viewProfileBAL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BindViewPersonalDetails(int recruiterId, ViewProfileREBAL viewProfileBAL)
        {
            try
            {
                DataSet dsPersonalDetails = new DataSet();
                dsPersonalDetails = viewProfileBAL.ViewPersonalDetails(recruiterId);
                    if(dsPersonalDetails!=null)
                    {
                        lblPresentAddress.Text = Convert.ToString(dsPersonalDetails.Tables[1].Rows[0]["Address"]);
                        lblPresentCountry.Text = Convert.ToString(dsPersonalDetails.Tables[1].Rows[0]["PresentCountryName"]);
                        lblPresentState.Text = Convert.ToString(dsPersonalDetails.Tables[1].Rows[0]["PresentStateName"]);
                        lblPresentCity.Text = Convert.ToString(dsPersonalDetails.Tables[1].Rows[0]["PresentCityName"]);
                        lblPresentArea.Text = Convert.ToString(dsPersonalDetails.Tables[1].Rows[0]["PresentAreaName"]);
                        lblPresentPincode.Text = Convert.ToString(dsPersonalDetails.Tables[1].Rows[0]["PinCode"]);
                        lblPermanentAddress.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantAddress"]);
                        lblPermanentCountry.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantCountryName"]);
                        lblPermanentState.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantStateName"]);
                        lblPermanentCity.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantCityName"]);
                        lblPermanentArea.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantAreaName"]);
                        lblPermanentPincode.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PermantPincode"]);
                        string date = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["DateOfBirth"]);
                        lblDateOfBirth.Text = DateTime.Parse(date).ToShortDateString();
                        lblMaritalState.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["MaritalStatus"]);
                        lblPassportNo.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PassportNumber"]);
                        lblPassportValidity.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PassportValidity"]);
                    }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void BindViewProfile(int recruiterId, ViewProfileREBAL viewProfileBAL)
        {
            try
            {
                DataSet dsViewProfile = new DataSet();
                dsViewProfile = viewProfileBAL.ViewProfileBAL(recruiterId);
                if (dsViewProfile != null)
                {
                    imgProfilePhoto.ImageUrl = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["PhotoPath"]);
                    lblFullName.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["RecruiterfullName"]);
                    lblRecruiterId.Text =Convert.ToString(recruiterId);
                    lblCompany.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["Company"]);
                    lblOfficicalNumber.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["MobileNumber"]);
                    lblMobileNumber.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["AltMobile"]);
                    lblOfficialEmailId.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["OfficialEmail_ID"]);
                    lblFreelancer.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["FreelanceOrEmployee"]);
                    lblAddress.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["Address"]);
                    lblCity.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["CityName"]);
                    lblArea.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["AreaName"]);
                    lblPincode.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["Pincode"]);
                    lblEmployeeStatus.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["EmploymentStatus"]);
                    lblJobType.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["JobType"]);
                    lblPanNumber.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["PANCardNo"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}