using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.JobSeeker;

namespace JobFair.UserControls.JobSeeker
{
    /// <summary>
    /// Class AffirmativeDetails
    /// </summary>
    public partial class AffirmativeDetails : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
        ///  Handles the Click event of the btnSubmit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            AffirmativeDetailsEntity adEntity = new AffirmativeDetailsEntity();
            AffirmativeDetailsJSBAL adBAL = new AffirmativeDetailsJSBAL();
            //set the value of AffirmativeDetailsJSEntity
            adEntity.candidateId = "JS00001";//static data used because session value not set
            adEntity.language = txtLanguageFirst.Text;
            adEntity.proficiencyLevel = ddlProficiencyFirst.SelectedItem.Text;
            adEntity.read = Convert.ToByte(chkReadFirst.Checked);
            adEntity.write = Convert.ToByte(chkWriteFirst.Checked);
            adEntity.speak = Convert.ToByte(chkSpeakFirst.Checked);
            adEntity.physicallyChallenged = string.Empty;
            if (rbtYes.Checked)
            {
                adEntity.physicallyChallenged = "Yes";    
            }
            else
            {
                adEntity.physicallyChallenged = "No";
            }
            adEntity.description = txtDescription.Text;
            adEntity.sports = txtSports.Text;
            adEntity.sportsDescription = txtSportsDescription.Text;
            adEntity.usaPermit = string.Empty;
            if (rbtYesUSA.Checked)
            {
                adEntity.usaPermit = "Yes";
            }
            else
            {
                adEntity.usaPermit = "No";
            }
            adEntity.otherPermits = txtOtherPermit.Text;
            int result = adBAL.AffirmativeDetailsBAL(adEntity);
            if (result > 0)
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