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
        private AffirmativeDetailsJSBAL AffirmativeDetailsBAL = new AffirmativeDetailsJSBAL();
        private AffirmativeDetailsEntity affirmativeDetailsEntity = new AffirmativeDetailsEntity();
        private int languageCount = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = new DataSet();
                ds = AffirmativeDetailsBAL.GetLanguageBAL();

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
            if (rbtYes.Checked)
            {
                txtDescription.Visible = true;
                lblDescription.Visible = true;
            }
            else
            {
                txtDescription.Visible = false;
                lblDescription.Visible = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            List<LanguageEntity> languageDetailsList = new List<LanguageEntity>();

            //set the value of AffirmativeDetailsJSEntity
            affirmativeDetailsEntity.CandidateId = "JS00001";//static data used because session value not set

            // Set the value of LanguageEntity for first language
            LanguageEntity firstlanguageEntity = new LanguageEntity();
            firstlanguageEntity.CandidateId = "JS00001";
            firstlanguageEntity.LanguageId = Convert.ToInt32(ddlLanguageFirst.SelectedValue);
            firstlanguageEntity.ProficiencyLevel = ddlProficiencyFirst.SelectedItem.Text;
            firstlanguageEntity.Read = chkReadFirst.Checked;
            firstlanguageEntity.Write = chkWriteFirst.Checked;
            firstlanguageEntity.Speak = chkSpeakFirst.Checked;

            // Add language details into collection.
            languageDetailsList.Add(firstlanguageEntity);

            //set the value of LanguageEntity for second language
            LanguageEntity secondlanguageEntity = new LanguageEntity();
            secondlanguageEntity.CandidateId = "JS00001";
            secondlanguageEntity.LanguageId = Convert.ToInt32(ddlLanguageSecond.SelectedValue);
            secondlanguageEntity.ProficiencyLevel = ddlProficiencySecond.SelectedItem.Text;
            secondlanguageEntity.Read = chkReadSecond.Checked;
            secondlanguageEntity.Write = chkWriteSecond.Checked;
            secondlanguageEntity.Speak = chkSpeakSecond.Checked;

            // Add language details into collection.
            languageDetailsList.Add(secondlanguageEntity);

            //set the value of LanguageEntity for third language
            LanguageEntity thirdlanguageEntity = new LanguageEntity();
            thirdlanguageEntity.CandidateId = "JS00001";
            thirdlanguageEntity.LanguageId = Convert.ToInt32(ddlLanguageThird.SelectedValue);
            thirdlanguageEntity.ProficiencyLevel = ddlProficiencyThird.SelectedItem.Text;
            thirdlanguageEntity.Read = chkReadThird.Checked;
            thirdlanguageEntity.Write = chkWriteThird.Checked;
            thirdlanguageEntity.Speak = chkSpeakThird.Checked;

            // Add language details into collection.
            languageDetailsList.Add(thirdlanguageEntity);

            affirmativeDetailsEntity.PhysicallyChallenged = string.Empty;
            if (rbtYes.Checked)
                affirmativeDetailsEntity.PhysicallyChallenged = "Yes";
            else
                affirmativeDetailsEntity.PhysicallyChallenged = "No";

            affirmativeDetailsEntity.Description = txtDescription.Text;
            affirmativeDetailsEntity.Sports = txtSports.Text;
            affirmativeDetailsEntity.SportsDescription = txtSportsDescription.Text;
            affirmativeDetailsEntity.USAPermit = string.Empty;
            if (rbtYesUSA.Checked)
                affirmativeDetailsEntity.USAPermit = "Yes";
            else
                affirmativeDetailsEntity.USAPermit = "No";

            affirmativeDetailsEntity.OtherPermits = txtOtherPermit.Text;

            // Save language details
            bool isLanguageSaved = AffirmativeDetailsBAL.SaveLanguageDetailsBAL(languageDetailsList);
            // Save affermative Details.
            bool isOtherDetailsSaved = AffirmativeDetailsBAL.SaveAffirmaiveDetailsBAL(affirmativeDetailsEntity);

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
}