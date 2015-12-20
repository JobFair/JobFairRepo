using BAL;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class JSViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // Check page is not post back
                if (!IsPostBack)
                {
                    string candidateId = Convert.ToString(Session["candidateId"]);
                    // Check session is not null
                    if (string.IsNullOrEmpty(candidateId))
                    {
                        Response.Redirect("LogIn.aspx");
                    }
                    else
                    {
                        BindAllUserDetails(candidateId);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Bind all users details
        /// </summary>
        /// <param name="candidateId">candidateId</param>
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

                BindRoleSkillDetails(viewProfileJSBAL, candidateId);

                BindProfessionalDetails(viewProfileJSBAL, candidateId);

                BindCurrentPastJobDetails(viewProfileJSBAL, candidateId);

                BindEducationDetails(viewProfileJSBAL, candidateId);

                BindWorkshopDetails(viewProfileJSBAL, candidateId);

                BindCertificationDetails(viewProfileJSBAL, candidateId);
            }
            catch (Exception ex)
            {
                //   throw;
            }
        }

        private void BindCurrentPastJobDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsCurrentPastJobDetails = new DataSet();
                dsCurrentPastJobDetails = objViewProfile.ViewCurrentPastJobBAL(candidateId);
                if (dsCurrentPastJobDetails != null)
                {
                    rptrEmployer.DataSource = dsCurrentPastJobDetails;
                    rptrEmployer.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BindProfessionalDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsProfessionalDetails = new DataSet();
                dsProfessionalDetails = objViewProfile.ViewProfessionalDetailsBAL(candidateId);
                // Check if dataset is not null
                if (dsProfessionalDetails != null)
                {
                    rptrProfessionalSummary.DataSource = dsProfessionalDetails;
                    rptrProfessionalSummary.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Bind certification to rptrCertification control
        /// </summary>
        /// <param name="objViewProfile">ViewProfileJSBAL</param>
        /// <param name="candidateId">candidateId</param>
        private void BindCertificationDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsCertification = new DataSet();
                dsCertification = objViewProfile.ViewCertificationBAL(candidateId);
                if (dsCertification != null)
                {
                    rptrCertification.DataSource = dsCertification;
                    rptrCertification.DataBind();
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Bind workshps to rptrWorkshop control
        /// </summary>
        /// <param name="objViewProfile">ViewProfileJSBAL</param>
        /// <param name="candidateId">candidateId</param>
        private void BindWorkshopDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsWorkshop = new DataSet();
                dsWorkshop = objViewProfile.ViewWorksopBAL(candidateId);
                // Check if dataset is not null
                if (dsWorkshop != null)
                {
                    rptrWorkshop.DataSource = dsWorkshop;
                    rptrWorkshop.DataBind();
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        ///  Bind role skills to rptrRoleSkills control
        /// </summary>
        /// <param name="objViewProfile">ViewProfileJSBAL</param>
        /// <param name="candidateId">candidateId</param>
        private void BindRoleSkillDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsRoleSkills = new DataSet();
                dsRoleSkills = objViewProfile.ViewRoleSkillsBAL(candidateId);
                // Check if dataset is not null
                if (dsRoleSkills != null)
                {
                    rptrRoleSkills.DataSource = dsRoleSkills;
                    rptrRoleSkills.DataBind();
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Bind educational details to rptrEducationalDetails control
        /// </summary>
        /// <param name="objViewProfile">ViewProfileJSBAL</param>
        /// <param name="candidateId">candidateId</param>
        private void BindEducationDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsEducationDetails = new DataSet();
                dsEducationDetails = objViewProfile.ViewEducationDetailsBAL(candidateId);
                // Check if dataset is not null
                if (dsEducationDetails != null)
                {
                    rptrEducationalDetails.DataSource = dsEducationDetails;
                    rptrEducationalDetails.DataBind();
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        protected void rptrEducationalDetails_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            // Check commond for edit
            if (e.CommandName == "edit")
            {
                Label lbl = (Label)e.Item.FindControl("lblDegreeId");
                int degreeId = Convert.ToInt32(lbl.Text);
                Response.Redirect("DemoEducationalDetails.aspx?dId=" + degreeId);
            }
        }

        /// <summary>
        /// Bind technical skills rptrTechnicalSkills control
        /// </summary>
        /// <param name="objViewProfile">ViewProfileJSBAL</param>
        /// <param name="candidateId">candidateId</param>
        private void BindTechnicalDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsTechnicalSkills = new DataSet();
                dsTechnicalSkills = objViewProfile.ViewTechnicalSkillBAL(candidateId);
                // Check if dataset is not null
                if (dsTechnicalSkills != null)
                {
                    rptrTechnicalSkills.DataSource = dsTechnicalSkills;
                    rptrTechnicalSkills.DataBind();
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Bind project details to rptrProjectDetails control
        /// </summary>
        /// <param name="objViewProfile">ViewProfileJSBAL</param>
        /// <param name="candidateId">candidateId</param>
        private void BindProjectDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsProjectDetails = new DataSet();
                dsProjectDetails = objViewProfile.ViewProjectDetailsBAL(candidateId);
                // Check if dataset is not null
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

        /// <summary>
        /// View affirmative details
        /// </summary>
        /// <param name="objViewProfile">ViewProfileJSBAL</param>
        /// <param name="candidateId">candidateId</param>
        private void BindAffirmativeDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsAffirmativeDetails = new DataSet();
                dsAffirmativeDetails = objViewProfile.ViewAffirmativeDetailsBAL(candidateId);
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
            catch (Exception ex)
            {
                // throw;
            }
        }

        /// <summary>
        /// View personal details
        /// </summary>
        /// <param name="objViewProfile">ViewProfileJSBAL</param>
        /// <param name="candidateId">candidateId</param>
        private void BindPersonalDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsPersonalDetails = new DataSet();
                dsPersonalDetails = objViewProfile.ViewPersonalDetailsBAL(candidateId);
                // Check if dataset is not null
                if (dsPersonalDetails != null)
                {
                    if (dsPersonalDetails.Tables.Count > 0)
                    {
                        if (dsPersonalDetails.Tables[0].Rows.Count > 0)
                        {
                            Image1.ImageUrl = Convert.ToString(dsPersonalDetails.Tables[0].Rows[0]["photo"]);
                            lblPresentAddress.Text = Convert.ToString(dsPersonalDetails.Tables[1].Rows[0]["CurrentAddress"]);
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

        /// <summary>
        /// View contact details
        /// </summary>
        /// <param name="objViewProfile">ViewProfileJSBAL</param>
        /// <param name="candidateId">candidateId</param>
        private void BindContactDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsContactDetails = new DataSet();
                dsContactDetails = objViewProfile.ViewContactDetailsBAL(candidateId);
                // Check if dataset is not null
                if (dsContactDetails != null)
                {
                    if (dsContactDetails.Tables.Count > 0)
                    {
                        if (dsContactDetails.Tables[0].Rows.Count > 0)
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

        /// <summary>
        /// View profile summary
        /// </summary>
        /// <param name="objViewProfile">ViewProfileJSBAL</param>
        /// <param name="candidateId">candidateId</param>
        private void BindProfileDetails(ViewProfileJSBAL objViewProfile, string candidateId)
        {
            try
            {
                DataSet dsViewProfile = new DataSet();
                dsViewProfile = objViewProfile.ViewProfileBAL(candidateId);
                string firstName, lastName, before, after;
                // Check if dataset is not null
                if (dsViewProfile != null)
                {
                    if (dsViewProfile.Tables.Count > 0)
                    {
                        if (dsViewProfile.Tables[0].Rows.Count > 0)
                        {
                            lblCandidateID.Text = candidateId;
                            imgProfilePhoto.ImageUrl = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["photo"]);
                            firstName = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["FirstName"]);
                            lastName = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["LastName"]);
                            lblName.Text = firstName + " " + lastName;
                            lblEmailId.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["EmailId"]);
                            lblMobNo.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["MobileNo"]);
                            lblGender.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["Gender"]);
                            lblCurrentCity.Text = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["CityName"]);

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
                            before = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["BeforeTime"]);
                            after = Convert.ToString(dsViewProfile.Tables[0].Rows[0]["AfterTime"]);
                            lblAvailabilityInWeek.Text = before + " To " + after;
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
                lblEmailId.Text = String.Empty;
                lblMobNo.Text = String.Empty;
                lblGender.Text = String.Empty;
                lblCurrentCity.Text = String.Empty;
                lblPreferedCity.Text = String.Empty;
                lblCurrentCTC.Text = String.Empty;
                lblExpectedCTC.Text = String.Empty;
                lblNoticePeriod.Text = String.Empty;
                lblInterview.Text = String.Empty;
                lblEmployeeStatus.Text = String.Empty;
                lblJobType.Text = String.Empty;
                lblCompanyType.Text = String.Empty;
                lblExperience.Text = String.Empty;
                lblJobPostLooking.Text = String.Empty;
                lblWorkStatus.Text = String.Empty;
                lblAvailabilityInWeek.Text = String.Empty;
            }
            catch (Exception ex)
            {
                //   throw;
            }
        }

        protected void lnkEditProject_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProjectDetails.aspx?isCheck=true");
        }

        protected void lnkEditConacts_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx/ContactDetails.ascx?isCheck=true");
        }

        protected void lnkEditPersonalDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx/PersonalDetails.ascx?isCheck=true");
        }
    }
}