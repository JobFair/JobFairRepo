using BAL;
using System;
using System.Data;

namespace JobFair.Forms.JobSeeker
{
    public partial class JSViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["candidateId"] != null)
                {
                    if (Session["candidateId"].ToString() != "")
                    {
                        try
                        {
                            string candidateId = Convert.ToString(Session["candidateId"]);
                            BindAllUserDetails(candidateId);
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
        }

        private void BindAllUserDetails(string candidateId)
        {
            try
            {
                ViewProfileJSBAL viewProfileJSBAL = new ViewProfileJSBAL();
                BindProfileDetails(viewProfileJSBAL, candidateId);

                BindContactDetails(viewProfileJSBAL, candidateId);

                BindPersonalDetails(viewProfileJSBAL, candidateId);

                BindProjectDetails(viewProfileJSBAL, candidateId);

                BindAffirmativeDetails(viewProfileJSBAL, candidateId);

                BindTechnicalDetails(viewProfileJSBAL, candidateId);
                //BindProfessionalDetals(candidateId);

                //BindEducationDetails(candidateId);
            }
            catch (Exception ex)
            {
                //   throw;
            }
        }

        private void BindTechnicalDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsTechnicalSills = new DataSet();
                dsTechnicalSills = objViewProfile.ViewTechnicalSkillBAL(candidateId);
                if (dsTechnicalSills != null)
                {
                    rptrTechnicalSkills.DataSource = dsTechnicalSills;
                    rptrTechnicalSkills.DataBind();
                }
            }
            catch (Exception ex)
            {
                // throw;
            }
        }

        private void BindProjectDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsProjectDetails = new DataSet();
                dsProjectDetails = objViewProfile.ViewProjectDetailsBAL(candidateId);
                if (dsProjectDetails != null)
                {
                    rptrProjectDetails.DataSource = dsProjectDetails;
                    rptrProjectDetails.DataBind();
                }
            }
            catch (Exception ex)
            {
                //  throw;
            }
        }

        private void BindAffirmativeDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsAffirmativeDetails = new DataSet();
                dsAffirmativeDetails = objViewProfile.ViewAffirmativeDetailsBAL(candidateId);
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
            catch (Exception ex)
            {
                // throw;
            }
        }

        private void BindPersonalDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsPersonalDetails = new DataSet();
                dsPersonalDetails = objViewProfile.ViewPersonalDetailsBAL(candidateId);

                if (dsPersonalDetails != null)
                {
                    if (dsPersonalDetails.Tables.Count > 0)
                    {
                        if (dsPersonalDetails.Tables[0].Rows.Count > 0)
                        {
                            Image1.ImageUrl = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["photo"]);
                            lblPresentAddress.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PresentAddress"]);
                            lblPresentCountry.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PresentCountryName"]);
                            lblPresentState.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PresentStateName"]);
                            lblPresentCity.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PresentCityName"]);
                            lblPresentArea.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PresentAreaName"]);
                            lblPresentPincode.Text = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["PresentPincode"]);
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
                        else
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // throw;
            }
        }

        private void BindContactDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsContactDetails = new DataSet();
                dsContactDetails = objViewProfile.ViewContactDetailsBAL(candidateId);

                if (dsContactDetails != null)
                {
                    if (dsContactDetails.Tables.Count > 0)
                    {
                        if (dsContactDetails.Tables[0].Rows.Count > 0)
                        {
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
                        else
                        {
                            // ClearProfileInfo();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // throw;
            }
        }

        private void BindProfileDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsViewProfile = new DataSet();
                dsViewProfile = objViewProfile.ViewProfileBAL(candidateId);

                if (dsViewProfile != null)
                {
                    if (dsViewProfile.Tables.Count > 0)
                    {
                        if (dsViewProfile.Tables[0].Rows.Count > 0)
                        {
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
                        }
                        else
                        {
                            ClearProfileInfo();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //   throw;
            }
        }

        private void ClearProfileInfo()
        {
            try
            {
                lblName.Text = String.Empty;
            }
            catch (Exception ex)
            {
                //   throw;
            }
        }
    }
}