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
        private AffirmativeDetailsJSBAL affirmativeDetailsBAL = new AffirmativeDetailsJSBAL();
        private AffirmativeDetailsEntity affirmativeDetailsEntity = new AffirmativeDetailsEntity();
        private int languageCount = 0;
        private string candidateId;
        private bool isCheck = true;
        // isCheck = Convert.ToBoolean(Request.QueryString["isCheck"]);

        protected void Page_Load(object sender, EventArgs e)
        {
            candidateId = Convert.ToString(Session["candidateId"]);

            if (!IsPostBack)
            {
                DataSet ds = new DataSet();
                ds = affirmativeDetailsBAL.GetLanguageBAL();

                if (ds != null)
                {
                    languageCount = ds.Tables[0].Rows.Count;
                    ddlLanguageFirst.DataSource = ds;
                    ddlLanguageFirst.DataTextField = "LanguageName";
                    ddlLanguageFirst.DataValueField = "LanguageId";
                    ddlLanguageFirst.DataBind();
                    ddlLanguageFirst.Items.Insert(0, new ListItem("--Select--", "0"));

                    ddlLanguageSecond.DataSource = ds;
                    ddlLanguageSecond.DataTextField = "LanguageName";
                    ddlLanguageSecond.DataValueField = "LanguageId";
                    ddlLanguageSecond.DataBind();
                    ddlLanguageSecond.Items.Insert(0, new ListItem("--Select--", "0"));

                    ddlLanguageThird.DataSource = ds;
                    ddlLanguageThird.DataTextField = "LanguageName";
                    ddlLanguageThird.DataValueField = "LanguageId";
                    ddlLanguageThird.DataBind();
                    ddlLanguageThird.Items.Insert(0, new ListItem("--Select--", "0"));
                }


                if (isCheck)
                {
                    try
                    {
                        DataSet dsAffirmativeDetails = new DataSet();
                        dsAffirmativeDetails = affirmativeDetailsBAL.viewAffirmativeDetailsBAL(candidateId);
                        ddlLanguageFirst.SelectedValue = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["LanguageId"]);
                        ddlProficiencyFirst.SelectedValue = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["ProficiencyLevel"]);
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

                        ddlLanguageSecond.SelectedValue = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[1]["LanguageId"]);
                        ddlProficiencySecond.SelectedValue = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[1]["ProficiencyLevel"]);
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

                        ddlLanguageThird.SelectedValue = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[2]["LanguageId"]);
                        ddlProficiencyThird.SelectedValue = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[2]["ProficiencyLevel"]);
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

                        string physicallyChallenged = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["PhysicallyChallenged"]);
                        rbtPhysicallyChallenged.Items.FindByText(physicallyChallenged).Selected = true;
                        if (physicallyChallenged == "Yes")
                        {
                            upPhysicallyChallenged.Visible = true;
                        }
                        txtDescription.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["Description"]);
                        txtSports.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["Sports"]);
                        txtSportsDescription.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["SportsDescription"]);
                        txtHobbies.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["Hobbies"]);
                        txtExtraActivity.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["ExtraActivity"]);
                        string USApermit = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["USApermit"]);
                        rbtUSAPermit.Items.FindByValue(USApermit).Selected = true;
                        txtOtherPermit.Text = Convert.ToString(dsAffirmativeDetails.Tables[0].Rows[0]["OtherPermits"]);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isCheck)
            {
                try
                {
                    List<LanguageEntity> languageDetailsList = new List<LanguageEntity>();

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
                    //if (rbtYes.Checked)
                    //    affirmativeDetailsEntity.PhysicallyChallenged = "Yes";
                    //else
                    //    affirmativeDetailsEntity.PhysicallyChallenged = "No";
                    if (upPhysicallyChallenged.Visible = true)
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
                    bool isLanguageSaved = affirmativeDetailsBAL.UpdateLanguageDetailsBAL(languageDetailsList,candidateId);
                    // Save affermative Details.
                    bool isOtherDetailsSaved = affirmativeDetailsBAL.UpdateAffirmativeDetailsBAL(affirmativeDetailsEntity);

                    if (isLanguageSaved == isOtherDetailsSaved)
                    {
                        Response.Write("<script language='javascript'>alert('Affirmative Details Updated')</script>");
                    }
                    else
                    {
                        Response.Write("<script language='javascript'>alert('Sorry')</script>");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                try
                {
                    List<LanguageEntity> languageDetailsList = new List<LanguageEntity>();

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
                    //if (rbtYes.Checked)
                    //    affirmativeDetailsEntity.PhysicallyChallenged = "Yes";
                    //else
                    //    affirmativeDetailsEntity.PhysicallyChallenged = "No";
                    if (upPhysicallyChallenged.Visible = true)
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
                catch (Exception)
                {
                    throw;
                }
            }
        }

        protected void rbtPhysicallyChallenged_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtPhysicallyChallenged.SelectedValue == "1")
            {
                upPhysicallyChallenged.Visible = true;
                return;
            }
            upPhysicallyChallenged.Visible = false;
        }
    }
}