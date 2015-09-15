using Entities.JobSeeker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace JobFair.UserControls.JobSeeker
{
    public partial class AffirmativeDetails : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!IsPostBack)
            {
                AffirmativeDetailsJSBAL adBAL = new AffirmativeDetailsJSBAL();
                ddlLanguageFirst.DataSource = adBAL.GetLanguageBAL();
                ddlLanguageFirst.DataTextField = "LanguageName";
                ddlLanguageFirst.DataValueField = "LanguageId";
                ddlLanguageFirst.DataBind();
                ddlLanguageFirst.Items.Insert(0, new ListItem("--Select--", "0"));
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            AffirmativeDetailsEntity adEntity = new AffirmativeDetailsEntity();
            AffirmativeDetailsJSBAL adBAL = new AffirmativeDetailsJSBAL();
            LanguageEntity languageEntity = new LanguageEntity();
            //set the value of AffirmativeDetailsJSEntity and LanguageEntity
            adEntity.CandidateId = "JS00001";//static data used because session value not set
            languageEntity.CandidateId = "JS00001";
            languageEntity.LanguageId = Convert.ToInt32(ddlLanguageFirst.SelectedValue);
            languageEntity.ProficiencyLevel = ddlProficiencyFirst.SelectedItem.Text;
            languageEntity.Read = Convert.ToBoolean(chkReadFirst.Checked);
            languageEntity.Write = Convert.ToBoolean(chkWriteFirst.Checked);
            languageEntity.Speak = Convert.ToBoolean(chkSpeakFirst.Checked);
            adEntity.PhysicallyChallenged = string.Empty;
            if (rbtYes.Checked)
            {
                adEntity.PhysicallyChallenged = "Yes";
            }
            else
            {
                adEntity.PhysicallyChallenged = "No";
            }

            adEntity.Description = txtDescription.Text;
            adEntity.Sports = txtSports.Text;
            adEntity.SportsDescription = txtSportsDescription.Text;
            adEntity.USAPermit = string.Empty;
            if (rbtYesUSA.Checked)
            {
                adEntity.USAPermit = "Yes";
            }
            else
            {
                adEntity.USAPermit = "No";
            }
            adEntity.OtherPermits = txtOtherPermit.Text;
            int success = adBAL.LanguageDetailsBAL(languageEntity);
            int result = adBAL.AffirmaiveDetailsBAL(adEntity);
            
            if (result > 0 && success > 0)
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