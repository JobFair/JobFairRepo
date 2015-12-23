using BAL;
using Entities.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.Forms.Recruiter
{
    public partial class AffirmativeDetails : System.Web.UI.Page
    {
        public int RecruiterId=3;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                BindLanguages();
            }

        }

        private void BindLanguages()
        {
            try
            {
                AffirmativeDetailsREBAL affirmativeDetailsBAL = new AffirmativeDetailsREBAL();

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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            List<LanguageEntity> languageDetailsList = new List<LanguageEntity>();
            AffirmativeDetailsEntity affirmativeDetailsEntity = new AffirmativeDetailsEntity();
            AffirmativeDetailsREBAL affirmativeDetailsREBAL = new AffirmativeDetailsREBAL();
            //set the value of AffirmativeDetailsJSEntity
          

            // Set the value of LanguageEntity for first language
            LanguageEntity firstlanguageEntity = new LanguageEntity();
            firstlanguageEntity.CandidateId = RecruiterId;           
            firstlanguageEntity.LanguageId = Convert.ToInt32(ddlLanguageFirst.SelectedValue);
            firstlanguageEntity.ProficiencyLevel = ddlProficiencyFirst.SelectedItem.Text;
            firstlanguageEntity.Read = chkReadFirst.Checked;
            firstlanguageEntity.Write = chkWriteFirst.Checked;
            firstlanguageEntity.Speak = chkSpeakFirst.Checked;
           

            // Add language details into collection.
            languageDetailsList.Add(firstlanguageEntity);

            //set the value of LanguageEntity for second language
            LanguageEntity secondlanguageEntity = new LanguageEntity();
            secondlanguageEntity.CandidateId = RecruiterId;
            secondlanguageEntity.LanguageId = Convert.ToInt32(ddlLanguageSecond.SelectedValue);
            secondlanguageEntity.ProficiencyLevel = ddlProficiencySecond.SelectedItem.Text;
            secondlanguageEntity.Read = chkReadSecond.Checked;
            secondlanguageEntity.Write = chkWriteSecond.Checked;
            secondlanguageEntity.Speak = chkSpeakSecond.Checked;
          

            // Add language details into collection.
            languageDetailsList.Add(secondlanguageEntity);

            //set the value of LanguageEntity for third language
            LanguageEntity thirdlanguageEntity = new LanguageEntity();
            thirdlanguageEntity.CandidateId = RecruiterId;
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
            
             affirmativeDetailsEntity.ID = RecruiterId;
            //if (rbtYesUSA.Checked)
            //    affirmativeDetailsEntity.USAPermit = "Yes";
            //else
            //    affirmativeDetailsEntity.USAPermit = "No";
            affirmativeDetailsEntity.USAPermit = rbtUSAPermit.SelectedItem.Text;
            affirmativeDetailsEntity.OtherPermits = txtOtherPermit.Text.Trim();

            // Save language details
            bool isLanguageSaved = affirmativeDetailsREBAL.SaveLanguageDetailsBAL(languageDetailsList);
            // Save affermative Details.
            bool isOtherDetailsSaved = affirmativeDetailsREBAL.SaveAffirmaiveDetailsBAL(affirmativeDetailsEntity);

            if (isLanguageSaved == isOtherDetailsSaved)
            {
                Response.Write("<script language='javascript'>alert('Affirmative Details Inserted')</script>");
            }
            else
            {
                Response.Write("<script language='javascript'>alert('Sorry')</script>");
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