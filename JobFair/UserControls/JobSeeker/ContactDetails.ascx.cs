using BAL;
using Entities;
using System;

namespace JobFair.UserControls.JobSeeker
{
    /// <summary>
    /// Class ContactDetails
    /// </summary>
    public partial class ContactDetails : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ContactDetailsJSBAL contactDetailsBAL = new ContactDetailsJSBAL();
                ContactDetailsEntity contactDetailsEntity = new ContactDetailsEntity();
                //set the value of ContactDetailsJobSeekerEntity

                contactDetailsEntity.CandidateId = "JS00001";//static data used because session value not set
                contactDetailsEntity.AltMobileNo = txtAltNo.Text.Trim();
                contactDetailsEntity.LandLineNo = txtLandno.Text.Trim();
                contactDetailsEntity.WhatsAppNo = txtWhatsappNo.Text.Trim();
                contactDetailsEntity.LinkedId = txtLinkedIn.Text.Trim();
                contactDetailsEntity.FacebookId = txtFacebook.Text.Trim();
                contactDetailsEntity.TwitterId = txtTwitter.Text.Trim();
                contactDetailsEntity.GtalkId = txtGTalk.Text.Trim();
                contactDetailsEntity.SkypeId = txtSkype.Text.Trim();
                contactDetailsEntity.GooglePlus = txtGooglePlus.Text.Trim();
                int result = contactDetailsBAL.SaveContactDetailsBAL(contactDetailsEntity);
                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('Contact Details Inserted')</script>");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Sorry')</script>");
                }
            }
            catch (Exception ex)
            {
                Label2.Text = ex.Message.ToString();
            }
        }
    }
}