using BAL;
using Entities.JobSeeker;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    public partial class AffirmativeDetails : System.Web.UI.UserControl
    {
        private DataSet ds = new DataSet();
        private AffirmativeDetailsJSBAL AffirmativeDetailsBAL = new AffirmativeDetailsJSBAL();
        private AffirmativeDetailsEntity affirmativeDetailsEntity = new AffirmativeDetailsEntity();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ds = AffirmativeDetailsBAL.GetLanguageBAL();
                ddlLanguageFirst.DataSource = ds;
                ddlLanguageFirst.DataTextField = "LanguageName";
                ddlLanguageFirst.DataValueField = "LanguageId";
                ddlLanguageFirst.DataBind();
                ddlLanguageFirst.Items.Insert(0, new ListItem("--Select--", "0"));

                ds = AffirmativeDetailsBAL.GetLanguageBAL();
                ddlLanguageSecond.DataSource = ds;
                ddlLanguageSecond.DataTextField = "LanguageName";
                ddlLanguageSecond.DataValueField = "LanguageId";
                ddlLanguageSecond.DataBind();
                ddlLanguageSecond.Items.Insert(0, new ListItem("--Select--", "0"));

                ds = AffirmativeDetailsBAL.GetLanguageBAL();
                ddlLanguageThird.DataSource = ds;
                ddlLanguageThird.DataTextField = "LanguageName";
                ddlLanguageThird.DataValueField = "LanguageId";
                ddlLanguageThird.DataBind();
                ddlLanguageThird.Items.Insert(0, new ListItem("--Select--", "0"));
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
            //set the value of AffirmativeDetailsJSEntity
            affirmativeDetailsEntity.CandidateId = "JS00001";//static data used because session value not set

            //set the value of LanguageEntity for first language
            LanguageEntity firstlanguageEntity = new LanguageEntity();
            firstlanguageEntity.CandidateId = "JS00001";
            firstlanguageEntity.LanguageId = Convert.ToInt32(ddlLanguageFirst.SelectedValue);
            firstlanguageEntity.ProficiencyLevel = ddlProficiencyFirst.SelectedItem.Text;
            int res = 0;
            if (chkReadFirst.Checked)
            {
                res = 1;
                firstlanguageEntity.Read = Convert.ToBoolean(res);
            }
            else
            {
                res = 0;
                firstlanguageEntity.Read = Convert.ToBoolean(res);
            }

            if (chkWriteFirst.Checked)
            {
                firstlanguageEntity.Write = Convert.ToBoolean(1);
            }
            else
            {
                firstlanguageEntity.Write = Convert.ToBoolean(0);
            }

            if (chkSpeakFirst.Checked)
            {
                firstlanguageEntity.Speak = Convert.ToBoolean(1);
            }
            else
            {
                firstlanguageEntity.Speak = Convert.ToBoolean(0);
            }

            //set the value of LanguageEntity for second language
            LanguageEntity secondlanguageEntity = new LanguageEntity();
            secondlanguageEntity.CandidateId = "JS00001";
            secondlanguageEntity.LanguageId = Convert.ToInt32(ddlLanguageSecond.SelectedValue);
            secondlanguageEntity.ProficiencyLevel = ddlProficiencySecond.SelectedItem.Text;

            if (chkReadSecond.Checked)
            {
                res = 1;
                secondlanguageEntity.Read = Convert.ToBoolean(res);
            }
            else
            {
                res = 0;
                secondlanguageEntity.Read = Convert.ToBoolean(res);
            }

            if (chkWriteSecond.Checked)
            {
                secondlanguageEntity.Write = Convert.ToBoolean(1);
            }
            else
            {
                secondlanguageEntity.Write = Convert.ToBoolean(0);
            }

            if (chkSpeakSecond.Checked)
            {
                secondlanguageEntity.Speak = Convert.ToBoolean(1);
            }
            else
            {
                secondlanguageEntity.Speak = Convert.ToBoolean(0);
            }

            //set the value of LanguageEntity for third language
            LanguageEntity thirdlanguageEntity = new LanguageEntity();
            thirdlanguageEntity.CandidateId = "JS00001";
            thirdlanguageEntity.LanguageId = Convert.ToInt32(ddlLanguageThird.SelectedValue);
            thirdlanguageEntity.ProficiencyLevel = ddlProficiencyThird.SelectedItem.Text;
            thirdlanguageEntity.Read = chkReadThird.Checked;
            thirdlanguageEntity.Write = chkWriteThird.Checked;
            thirdlanguageEntity.Speak = chkSpeakThird.Checked;
            //if (chkReadThird.Checked)
            //{
            //    res = 1;
            //    thirdlanguageEntity.Read = Convert.ToBoolean(res);
            //}
            //else
            //{
            //    res = 0;
            //    thirdlanguageEntity.Read = Convert.ToBoolean(res);
            //}

            //if (chkWriteThird.Checked)
            //{
            //    thirdlanguageEntity.Write = Convert.ToBoolean(1);
            //}
            //else
            //{
            //    thirdlanguageEntity.Write = Convert.ToBoolean(0);
            //}

            //if (chkSpeakThird.Checked)
            //{
            //    thirdlanguageEntity.Speak = Convert.ToBoolean(1);
            //}
            //else
            //{
            //    thirdlanguageEntity.Speak = Convert.ToBoolean(0);
            //}

            affirmativeDetailsEntity.PhysicallyChallenged = string.Empty;
            if (rbtYes.Checked)
            {
                affirmativeDetailsEntity.PhysicallyChallenged = "Yes";
            }
            else
            {
                affirmativeDetailsEntity.PhysicallyChallenged = "No";
            }

            affirmativeDetailsEntity.Description = txtDescription.Text;
            affirmativeDetailsEntity.Sports = txtSports.Text;
            affirmativeDetailsEntity.SportsDescription = txtSportsDescription.Text;
            affirmativeDetailsEntity.USAPermit = string.Empty;
            if (rbtYesUSA.Checked)
            {
                affirmativeDetailsEntity.USAPermit = "Yes";
            }
            else
            {
                affirmativeDetailsEntity.USAPermit = "No";
            }
            affirmativeDetailsEntity.OtherPermits = txtOtherPermit.Text;
            int success = AffirmativeDetailsBAL.SaveLanguageDetailsBAL(firstlanguageEntity);
            int save = AffirmativeDetailsBAL.SaveLanguageDetailsBAL(secondlanguageEntity);
            int insert = AffirmativeDetailsBAL.SaveLanguageDetailsBAL(thirdlanguageEntity);
            int result = AffirmativeDetailsBAL.SaveAffirmaiveDetailsBAL(affirmativeDetailsEntity);

            if (result > 0 && success > 0 && save > 0 && insert > 0)
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