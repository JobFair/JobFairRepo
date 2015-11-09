using BAL;
using Entities;
using System;
using System.Data;

namespace JobFair.UserControls.JobSeeker
{
    /// <summary>
    /// Class ContactDetails
    /// </summary>
    public partial class ContactDetails : System.Web.UI.UserControl
    {
        string candidateId;
        protected void Page_Load(object sender, EventArgs e)
        {
           candidateId = Convert.ToString(Session["candidateId"]);

              bool isCheck=true;
           
           // isCheck = Convert.ToBoolean(Request.QueryString["isCheck"]);
            if(isCheck)
            {
                try
                {
                     DataSet ds = new DataSet();
                     ContactDetailsJSBAL contactDetailsBAL = new ContactDetailsJSBAL();
                     ds = contactDetailsBAL.ViewContactDetailsBAL(candidateId);
                     txtAltNo.Text = Convert.ToString(ds.Tables[0].Rows[0]["AltMobile"]);
                     txtLandno.Text = Convert.ToString(ds.Tables[0].Rows[0]["LandLine"]);
                     txtWhatsappNo.Text = Convert.ToString(ds.Tables[0].Rows[0]["WhatsapNo"]);
                     txtLinkedIn.Text = Convert.ToString(ds.Tables[0].Rows[0]["LinkedId"]);
                     txtFacebook.Text = Convert.ToString(ds.Tables[0].Rows[0]["FaceBookId"]);
                     txtTwitter.Text = Convert.ToString(ds.Tables[0].Rows[0]["TwitterId"]);
                     txtGTalk.Text = Convert.ToString(ds.Tables[0].Rows[0]["GtalkId"]);
                     txtSkype.Text = Convert.ToString(ds.Tables[0].Rows[0]["skypeId"]);
                     txtGooglePlus.Text = Convert.ToString(ds.Tables[0].Rows[0]["GoogleP"]);
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
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ContactDetailsJSBAL contactDetailsBAL = new ContactDetailsJSBAL();
                ContactDetailsEntity contactDetailsEntity = new ContactDetailsEntity();
                // Set the value of ContactDetailsJobSeekerEntity

                contactDetailsEntity.CandidateId = candidateId;
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
            catch (Exception)
            {
                throw;
            }
        }
    }
}