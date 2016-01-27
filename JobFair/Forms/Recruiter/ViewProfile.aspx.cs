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
        }

        /// <summary>
        /// Bind All View profile of recruiter
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        private void BindAllUserDetails(int recruiterId)
        {
            try
            {
                ViewProfileREBAL viewProfileBAL = new ViewProfileREBAL();
                BindViewProfile(recruiterId, viewProfileBAL);
                BindViewPersonalDetails(recruiterId, viewProfileBAL);
                BindViewContactDetails(recruiterId, viewProfileBAL);
                BindViewAffirmativeDetails(recruiterId, viewProfileBAL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Bind view profile of affirmative details
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <param name="viewProfileBAL">ViewProfileREBAL</param>
        private void BindViewAffirmativeDetails(int recruiterId, ViewProfileREBAL viewProfileBAL)
        {
            try
            {
                DataSet dsAffirmativeDetails = new DataSet();
                dsAffirmativeDetails = viewProfileBAL.ViewAffirmativeDetailsBAL(recruiterId);
                // Check if dataset is not null
                if (dsAffirmativeDetails != null)
                {
                    if (dsAffirmativeDetails.Tables.Count > 0)
                    {
                        if (dsAffirmativeDetails.Tables[0].Rows.Count > 0)
                        {
                            lblLanguageFirst.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["LanguageName"]);
                            lblProficiencyFirst.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["ProficiencyLevel"]);
                            bool isSelected = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[0]["LanguageRead"]);
                            if (isSelected == true)
                            {
                                chkReadFirst.Checked = true;
                            }
                            bool languageWrite = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[0]["LanguageWrite"]);
                            if (languageWrite == true)
                            {
                                chkWriteFirst.Checked = true;
                            }

                            bool languageSpeak = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[0]["LanguageSpeak"]);
                            if (languageSpeak == true)
                            {
                                chkSpeakFirst.Checked = true;
                            }

                            lblLanguageSecond.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[1]["LanguageName"]);
                            lblProficiencySecond.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[1]["ProficiencyLevel"]);
                            bool languageSecond = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[1]["LanguageRead"]);
                            if (languageSecond == true)
                            {
                                chkReadSecond.Checked = true;
                            }

                            bool writeSecond = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[1]["LanguageWrite"]);
                            if (writeSecond == true)
                            {
                                chkWriteSecond.Checked = true;
                            }

                            bool speakSecond = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[1]["LanguageSpeak"]);
                            if (speakSecond == true)
                            {
                                chkSpeakSecond.Checked = true;
                            }

                            lblLanguageThird.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[2]["LanguageName"]);
                            lblProficiencyThird.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[2]["ProficiencyLevel"]);
                            bool languageThird = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[2]["LanguageRead"]);
                            if (languageThird == true)
                            {
                                chkReadThird.Checked = true;
                            }

                            bool writeThird = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[2]["LanguageWrite"]);
                            if (writeThird == true)
                            {
                                chkWriteThird.Checked = true;
                            }

                            bool speakThird = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[2]["LanguageSpeak"]);
                            if (speakThird == true)
                            {
                                chkSpeakThird.Checked = true;
                            }
                            lblPhysicallyChallenged.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["PhysicallyChallenged"]);
                            lblDescription.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["Description"]);
                            lblSports.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["Sports"]);
                            lblSportsDescription.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["SportsDescription"]);
                            lblHobbies.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["Hobbies"]);
                            lblActivity.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["ExtraActivity"]);
                            lblUSAPermit.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["USApermit"]);
                            lblOtherPermit.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["OtherPermits"]);
                        }
                        else
                        {
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Bind view contact details
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <param name="viewProfileBAL">ViewProfileREBAL</param>
        private void BindViewContactDetails(int recruiterId, ViewProfileREBAL viewProfileBAL)
        {
            try
            {
                DataSet dsContactDetails = new DataSet();
                dsContactDetails = viewProfileBAL.ViewContactDetailsBAL(recruiterId);
                // Check if dataset is not null
                if (dsContactDetails != null)
                {
                    lblAltEmailId.Text = Convert.ToString(dsContactDetails.Tables[0].Rows[0]["AltEmailId"]);
                    lblAltMobNo.Text = Convert.ToString(dsContactDetails.Tables[0].Rows[0]["AltMobile"]);
                    lblLandLineNo.Text = Convert.ToString(dsContactDetails.Tables[0].Rows[0]["LandLine"]);
                    lblWhatsAppNo.Text = Convert.ToString(dsContactDetails.Tables[0].Rows[0]["WhatsapNo"]);
                    lblLinkIn.Text = Convert.ToString(dsContactDetails.Tables[0].Rows[0]["LinkedId"]);
                    lblFacebook.Text = Convert.ToString(dsContactDetails.Tables[0].Rows[0]["FaceBookId"]);
                    lblTwitter.Text = Convert.ToString(dsContactDetails.Tables[0].Rows[0]["TwitterId"]);
                    lblGtalk.Text = Convert.ToString(dsContactDetails.Tables[0].Rows[0]["GtalkId"]);
                    lblSkype.Text = Convert.ToString(dsContactDetails.Tables[0].Rows[0]["skypeId"]);
                    lblGooglePlus.Text = Convert.ToString(dsContactDetails.Tables[0].Rows[0]["GoogleP"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Bind view personal details
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <param name="viewProfileBAL">ViewProfileREBAL</param>
        private void BindViewPersonalDetails(int recruiterId, ViewProfileREBAL viewProfileBAL)
        {
            try
            {
                DataSet dsPersonalDetails = new DataSet();
                dsPersonalDetails = viewProfileBAL.ViewPersonalDetails(recruiterId);
                // Check if dataset is not null
                if (dsPersonalDetails != null)
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

        /// <summary>
        /// Bind view profile summary
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <param name="viewProfileBAL">ViewProfileREBAL</param>
        private void BindViewProfile(int recruiterId, ViewProfileREBAL viewProfileBAL)
        {
            try
            {
                DataSet dsViewProfile = new DataSet();
                dsViewProfile = viewProfileBAL.ViewProfileBAL(recruiterId);
                // Check if dataset is not null
                if (dsViewProfile != null)
                {
                    imgProfilePhoto.ImageUrl = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["PhotoPath"]);
                    lblFullName.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["RecruiterfullName"]);
                    lblRecruiterId.Text = Convert.ToString(recruiterId);
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