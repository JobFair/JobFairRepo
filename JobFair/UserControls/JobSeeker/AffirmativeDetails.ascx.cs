using BAL;
using Entities.JobSeeker;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    public partial class AffirmativeDetails : System.Web.UI.UserControl
    {
        private string candidateId;
        private bool isEdit;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                candidateId = Convert.ToString(Session["candidateId"]);
                isEdit = Convert.ToBoolean(Request.QueryString["isCheck"]);
                // Check session is not null
                if (string.IsNullOrEmpty(candidateId))
                {
                    Response.Redirect("LogIn.aspx");
                }
                else
                {
                    // Check page is not post back
                    if (!IsPostBack)
                    {
                        BindLanguages();
                        // Check the isEdit is true for edit
                        if (isEdit)
                        {
                            BindAffirmativeDetails(candidateId);
                        }
                    }
                   
                }
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        /// <summary>
        /// Bind languages
        /// </summary>
        private void BindLanguages()
        {
            try
            {
                AffirmativeDetailsJSBAL affirmativeDetailsBAL = new AffirmativeDetailsJSBAL();

                DataSet dsLanguagDetails = new DataSet();
                dsLanguagDetails = affirmativeDetailsBAL.GetLanguageBAL();
                int languageCount = 0;
                // Check dataset is not null
                if (dsLanguagDetails != null)
                {
                    languageCount = dsLanguagDetails.Tables[0].Rows.Count;
                    ddlLanguageFirst.DataSource = dsLanguagDetails;
                    ddlLanguageFirst.DataTextField = "LanguageName";
                    ddlLanguageFirst.DataValueField = "LanguageId";
                    ddlLanguageFirst.DataBind();
                    ddlLanguageFirst.Items.Insert(0, new ListItem("--Select--", "0"));

                    ddlLanguageSecond.DataSource = dsLanguagDetails;
                    ddlLanguageSecond.DataTextField = "LanguageName";
                    ddlLanguageSecond.DataValueField = "LanguageId";
                    ddlLanguageSecond.DataBind();
                    ddlLanguageSecond.Items.Insert(0, new ListItem("--Select--", "0"));

                    ddlLanguageThird.DataSource = dsLanguagDetails;
                    ddlLanguageThird.DataTextField = "LanguageName";
                    ddlLanguageThird.DataValueField = "LanguageId";
                    ddlLanguageThird.DataBind();
                    ddlLanguageThird.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Bind affirmative details for edit
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        private void BindAffirmativeDetails(string candidateId)
        {
            try
            {
                AffirmativeDetailsJSBAL affirmativeDetailsBAL = new AffirmativeDetailsJSBAL();
                AffirmativeDetailsEntity affirmativeDetailsEntity = new AffirmativeDetailsEntity();
                DataSet dsAffirmativeDetails = new DataSet();
                dsAffirmativeDetails = affirmativeDetailsBAL.viewAffirmativeDetailsBAL(candidateId);
                bool isSelected, languageWrite, languageSpeak, languageSecond, writeSecond, speakSecond, languageThird, writeThird, speakThird;
                string physicallyChallenged, USApermit;
                // Check dataset is not null
                if (dsAffirmativeDetails != null)
                {
                    // Check the count than zero
                    if (dsAffirmativeDetails.Tables.Count > 0)
                    {
                        // Check rows greater than zero
                        if (dsAffirmativeDetails.Tables[0].Rows.Count > 0)
                        {
                            ddlLanguageFirst.SelectedValue = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["LanguageId"]);
                            ddlProficiencyFirst.SelectedValue = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["ProficiencyLevel"]);
                            isSelected = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[0]["LanguageRead"]);
                            // Check if isSelected is true
                            if (isSelected == true)
                            {
                                chkReadFirst.Checked = true;
                            }

                            languageWrite = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[0]["LanguageWrite"]);
                            // Check if languageWrite is true
                            if (languageWrite == true)
                            {
                                chkWriteFirst.Checked = true;
                            }

                            languageSpeak = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[0]["LanguageSpeak"]);
                            // Check if languageSpeck is true
                            if (languageSpeak == true)
                            {
                                chkSpeakFirst.Checked = true;
                            }

                            ddlLanguageSecond.SelectedValue = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[1]["LanguageId"]);
                            ddlProficiencySecond.SelectedValue = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[1]["ProficiencyLevel"]);
                            languageSecond = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[1]["LanguageRead"]);
                            // Check if secondLanguage is true
                            if (languageSecond == true)
                            {
                                chkReadSecond.Checked = true;
                            }

                            writeSecond = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[1]["LanguageWrite"]);
                            //  Check if WriteSecond is true
                            if (writeSecond == true)
                            {
                                chkWriteSecond.Checked = true;
                            }

                            speakSecond = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[1]["LanguageSpeak"]);
                            // Check if speakSecond is true
                            if (speakSecond == true)
                            {
                                chkSpeakSecond.Checked = true;
                            }

                            ddlLanguageThird.SelectedValue = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[2]["LanguageId"]);
                            ddlProficiencyThird.SelectedValue = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[2]["ProficiencyLevel"]);
                            languageThird = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[2]["LanguageRead"]);
                            //  Check if languageThird is true
                            if (languageThird == true)
                            {
                                chkReadThird.Checked = true;
                            }

                            writeThird = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[2]["LanguageWrite"]);
                            // Check if writeThird is true
                            if (writeThird == true)
                            {
                                chkWriteThird.Checked = true;
                            }

                            speakThird = Convert.ToBoolean(dsAffirmativeDetails.Tables[0].Rows[2]["LanguageSpeak"]);
                            // Check if speakThird is true
                            if (speakThird == true)
                            {
                                chkSpeakThird.Checked = true;
                            }

                            physicallyChallenged = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["PhysicallyChallenged"]);
                            rbtPhysicallyChallenged.Items.FindByText(physicallyChallenged).Selected = true;
                            // Check if physicallychallenge is true
                            if (physicallyChallenged == "Yes")
                            {
                                pnlPhysicallyChallenged.Visible = true;
                            }
                            txtDescription.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["Description"]);
                            txtSports.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["Sports"]);
                            txtSportsDescription.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["SportsDescription"]);
                            txtHobbies.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["Hobbies"]);
                            txtExtraActivity.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["ExtraActivity"]);
                            USApermit = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["USApermit"]);
                            rbtUSAPermit.Items.FindByValue(USApermit).Selected = true;
                            txtOtherPermit.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["OtherPermits"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if isEdit is true for update
                if (!isEdit)
                {
                    List<LanguageEntity> languageDetailsList = new List<LanguageEntity>();
                    AffirmativeDetailsEntity affirmativeDetailsEntity = new AffirmativeDetailsEntity();
                    AffirmativeDetailsJSBAL affirmativeDetailsBAL = new AffirmativeDetailsJSBAL();
                    //set the value of AffirmativeDetailsJSEntity
                    affirmativeDetailsEntity.CandidateId = candidateId;

                    // Set the value of LanguageEntity for first language
                    LanguageEntity firstlanguageEntity = new LanguageEntity();
                    firstlanguageEntity.CandidateId = candidateId;
                    firstlanguageEntity.LanguageId = Convert.ToInt32(ddlLanguageFirst.SelectedValue);
                    firstlanguageEntity.ProficiencyLevel = ddlProficiencyFirst.SelectedItem.Text;
                    firstlanguageEntity.Read = chkReadFirst.Checked;
                    firstlanguageEntity.Write = chkWriteFirst.Checked;
                    firstlanguageEntity.Speak = chkSpeakFirst.Checked;

                    // Add language details into collection.
                    languageDetailsList.Add(firstlanguageEntity);

                    //set the value of LanguageEntity for second language
                    LanguageEntity secondlanguageEntity = new LanguageEntity();
                    secondlanguageEntity.CandidateId = candidateId;
                    secondlanguageEntity.LanguageId = Convert.ToInt32(ddlLanguageSecond.SelectedValue);
                    secondlanguageEntity.ProficiencyLevel = ddlProficiencySecond.SelectedItem.Text;
                    secondlanguageEntity.Read = chkReadSecond.Checked;
                    secondlanguageEntity.Write = chkWriteSecond.Checked;
                    secondlanguageEntity.Speak = chkSpeakSecond.Checked;

                    // Add language details into collection.
                    languageDetailsList.Add(secondlanguageEntity);

                    //set the value of LanguageEntity for third language
                    LanguageEntity thirdlanguageEntity = new LanguageEntity();
                    thirdlanguageEntity.CandidateId = candidateId;
                    thirdlanguageEntity.LanguageId = Convert.ToInt32(ddlLanguageThird.SelectedValue);
                    thirdlanguageEntity.ProficiencyLevel = ddlProficiencyThird.SelectedItem.Text;
                    thirdlanguageEntity.Read = chkReadThird.Checked;
                    thirdlanguageEntity.Write = chkWriteThird.Checked;
                    thirdlanguageEntity.Speak = chkSpeakThird.Checked;

                    // Add language details into collection.
                    languageDetailsList.Add(thirdlanguageEntity);

                    affirmativeDetailsEntity.PhysicallyChallenged = string.Empty;
                    affirmativeDetailsEntity.PhysicallyChallenged = rbtPhysicallyChallenged.SelectedItem.Text;
                    // Check if PhysicallyChallenged is visible
                    if (pnlPhysicallyChallenged.Visible = true)
                    {
                        affirmativeDetailsEntity.PhysicallyChallenged = rbtPhysicallyChallenged.SelectedItem.Text;
                    }

                    affirmativeDetailsEntity.Description = txtDescription.Text.Trim();
                    affirmativeDetailsEntity.Sports = txtSports.Text.Trim();
                    affirmativeDetailsEntity.SportsDescription = txtSportsDescription.Text.Trim();
                    affirmativeDetailsEntity.Hobbies = txtHobbies.Text.Trim();
                    affirmativeDetailsEntity.ExtraActivity = txtExtraActivity.Text.Trim();
                    affirmativeDetailsEntity.USAPermit = string.Empty;
                    //if (rbtYesUSA.Checked)
                    //    affirmativeDetailsEntity.USAPermit = "Yes";
                    //else
                    //    affirmativeDetailsEntity.USAPermit = "No";
                    affirmativeDetailsEntity.USAPermit = rbtUSAPermit.SelectedItem.Text;
                    affirmativeDetailsEntity.OtherPermits = txtOtherPermit.Text.Trim();

                    // Save language details
                    bool isLanguageSaved = affirmativeDetailsBAL.UpdateLanguageDetailsBAL(languageDetailsList, candidateId);
                    // Save affirmative Details.
                    bool isOtherDetailsSaved = affirmativeDetailsBAL.UpdateAffirmativeDetailsBAL(affirmativeDetailsEntity);
                    // Check if isLanguageDetails and isOtherDetails are equal
                    if (isLanguageSaved == isOtherDetailsSaved)
                    {
                        Response.Write("<script language='javascript'>alert('Affirmative Details Updated')</script>");
                    }
                    else
                    {
                        Response.Write("<script language='javascript'>alert('Sorry')</script>");
                    }
                }
                else
                {
                    List<LanguageEntity> languageDetailsList = new List<LanguageEntity>();
                    AffirmativeDetailsEntity affirmativeDetailsEntity = new AffirmativeDetailsEntity();
                    AffirmativeDetailsJSBAL affirmativeDetailsBAL = new AffirmativeDetailsJSBAL();
                    //set the value of AffirmativeDetailsJSEntity
                    affirmativeDetailsEntity.CandidateId = candidateId;

                    // Set the value of LanguageEntity for first language
                    LanguageEntity firstlanguageEntity = new LanguageEntity();
                    firstlanguageEntity.CandidateId= candidateId;
                    firstlanguageEntity.LanguageId = Convert.ToInt32(ddlLanguageFirst.SelectedValue);
                    firstlanguageEntity.ProficiencyLevel = ddlProficiencyFirst.SelectedItem.Text;
                    firstlanguageEntity.Read = chkReadFirst.Checked;
                    firstlanguageEntity.Write = chkWriteFirst.Checked;
                    firstlanguageEntity.Speak = chkSpeakFirst.Checked;

                    // Add language details into collection.
                    languageDetailsList.Add(firstlanguageEntity);

                    //set the value of LanguageEntity for second language
                    LanguageEntity secondlanguageEntity = new LanguageEntity();
                    secondlanguageEntity.CandidateId = candidateId;
                    secondlanguageEntity.LanguageId = Convert.ToInt32(ddlLanguageSecond.SelectedValue);
                    secondlanguageEntity.ProficiencyLevel = ddlProficiencySecond.SelectedItem.Text;
                    secondlanguageEntity.Read = chkReadSecond.Checked;
                    secondlanguageEntity.Write = chkWriteSecond.Checked;
                    secondlanguageEntity.Speak = chkSpeakSecond.Checked;

                    // Add language details into collection.
                    languageDetailsList.Add(secondlanguageEntity);

                    //set the value of LanguageEntity for third language
                    LanguageEntity thirdlanguageEntity = new LanguageEntity();
                    thirdlanguageEntity.CandidateId = candidateId;
                    thirdlanguageEntity.LanguageId = Convert.ToInt32(ddlLanguageThird.SelectedValue);
                    thirdlanguageEntity.ProficiencyLevel = ddlProficiencyThird.SelectedItem.Text;
                    thirdlanguageEntity.Read = chkReadThird.Checked;
                    thirdlanguageEntity.Write = chkWriteThird.Checked;
                    thirdlanguageEntity.Speak = chkSpeakThird.Checked;

                    // Add language details into collection.
                    languageDetailsList.Add(thirdlanguageEntity);

                    affirmativeDetailsEntity.PhysicallyChallenged = string.Empty;
                    affirmativeDetailsEntity.PhysicallyChallenged = rbtPhysicallyChallenged.SelectedItem.Text;
                    // Check if PhysicallyChallenged is visible
                    if (pnlPhysicallyChallenged.Visible = true)
                    {
                        affirmativeDetailsEntity.PhysicallyChallenged = rbtPhysicallyChallenged.SelectedItem.Text;
                    }

                    affirmativeDetailsEntity.Description = txtDescription.Text.Trim();
                    affirmativeDetailsEntity.Sports = txtSports.Text.Trim();
                    affirmativeDetailsEntity.SportsDescription = txtSportsDescription.Text.Trim();
                    affirmativeDetailsEntity.Hobbies = txtHobbies.Text.Trim();
                    affirmativeDetailsEntity.ExtraActivity = txtExtraActivity.Text.Trim();
                    affirmativeDetailsEntity.USAPermit = string.Empty;
                    //if (rbtYesUSA.Checked)
                    //    affirmativeDetailsEntity.USAPermit = "Yes";
                    //else
                    //    affirmativeDetailsEntity.USAPermit = "No";
                    affirmativeDetailsEntity.USAPermit = rbtUSAPermit.SelectedItem.Text;
                    affirmativeDetailsEntity.OtherPermits = txtOtherPermit.Text.Trim();

                    // Save language details
                    bool isLanguageSaved = affirmativeDetailsBAL.SaveLanguageDetailsBAL(languageDetailsList);
                    // Save affermative Details.
                    bool isOtherDetailsSaved = affirmativeDetailsBAL.SaveAffirmaiveDetailsBAL(affirmativeDetailsEntity);

                    if (isLanguageSaved == isOtherDetailsSaved)
                    {
                        Response.Write("<script language='javascript'>alert('Affirmative Details Inserted')</script>");
                    }
                    else
                    {
                        Response.Write("<script language='javascript'>alert('Sorry')</script>");
                    }
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        protected void rbtPhysicallyChallenged_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if physicallyChallenged selected value equal 1
                if (rbtPhysicallyChallenged.SelectedValue == "1")
                {
                    pnlPhysicallyChallenged.Visible = true;
                    return;
                }
                pnlPhysicallyChallenged.Visible = false;
            }
            catch (Exception)
            {
                //  throw;
            }
        }
    }
}