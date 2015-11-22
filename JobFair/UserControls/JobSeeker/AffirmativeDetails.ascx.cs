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
            }

            if(isCheck)
            {
                try
                {
                    DataSet ds = new DataSet();
                    ds= affirmativeDetailsBAL.viewAffirmativeDetailsBAL(candidateId);
                    ddlLanguageFirst.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["LanguageId"]);
                    ddlProficiencyFirst.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["ProficiencyLevel"]);
                    bool isSelected = Convert.ToBoolean(ds.Tables[0].Rows[0]["LanguageRead"]);
                    if(isSelected==true)
                    {
                        chkReadFirst.Checked = true;
                    }
                    chkReadFirst.Checked = false;

                    bool languageWrite = Convert.ToBoolean(ds.Tables[0].Rows[0]["LanguageWrite"] as CheckBox);
                    if (languageWrite == true)
                    {
                        chkWriteFirst.Checked = true;
                    }
                    chkWriteFirst.Checked = false;

                    bool languageSpeak = Convert.ToBoolean(ds.Tables[0].Rows[0]["LanguageSpeak"] as CheckBox);
                    if (languageSpeak == true)
                    {
                        chkSpeakFirst.Checked = true;
                    }
                    chkSpeakFirst.Checked = false;

                    string physicallyChallenged = Convert.ToString(ds.Tables[0].Rows[0]["PhysicallyChallenged"]);
                    //rbtPhysicallyChallenged.Items.FindByValue(physicallyChallenged).Selected = true;
                    txtSports.Text = Convert.ToString(ds.Tables[0].Rows[0]["Sports"]);
                    txtSportsDescription.Text = Convert.ToString(ds.Tables[0].Rows[0]["SportsDescription"]);
                    txtHobbies.Text = Convert.ToString(ds.Tables[0].Rows[0]["Hobbies"]);
                    txtExtraActivity.Text = Convert.ToString(ds.Tables[0].Rows[0]["ExtraActivity"]);
                    string USApermit = Convert.ToString(ds.Tables[0].Rows[0]["USApermit"]);
                    rbtUSAPermit.Items.FindByValue(USApermit).Selected = true;
                    txtOtherPermit.Text = Convert.ToString(ds.Tables[0].Rows[0]["OtherPermits"]);
                }
                catch (Exception)
                {
                    
                    throw;
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
                if(upPhysicallyChallenged.Visible=true)
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

        protected void rbtPhysicallyChallenged_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbtPhysicallyChallenged.SelectedValue=="1")
            {
                upPhysicallyChallenged.Visible = true;
                return;
            }
                upPhysicallyChallenged.Visible = false;
        }  
    }
}