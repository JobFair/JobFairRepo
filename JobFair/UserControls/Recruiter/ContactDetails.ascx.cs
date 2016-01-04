using BAL;
using Entities.Recruiter;
using System;

namespace JobFair.UserControls.Recruiter
{
    public partial class ContactDetails : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ContactDetailsREBAL contactDetailsBAL = new ContactDetailsREBAL();
                ContactDetailsEntity contactDetailsEntity = new ContactDetailsEntity();
                // Set the value of ContactDetailsJobSeekerEntity

                contactDetailsEntity.RecruiterId = "1";
                contactDetailsEntity.AltMobileNo = txtAltNo.Text.Trim();
                contactDetailsEntity.LandLineNo = txtLandno.Text.Trim();
                contactDetailsEntity.WhatsAppNo = txtWhatsappNo.Text.Trim();
                contactDetailsEntity.LinkedId = txtLinkedIn.Text.Trim();
                contactDetailsEntity.FacebookId = txtFacebook.Text.Trim();
                contactDetailsEntity.TwitterId = txtTwitter.Text.Trim();
                contactDetailsEntity.GtalkId = txtGTalk.Text.Trim();
                contactDetailsEntity.SkypeId = txtSkype.Text.Trim();
                contactDetailsEntity.GooglePlus = txtGooglePlus.Text.Trim();
                contactDetailsEntity.AltEmailId = txtAltEmailId.Text.Trim();
                int result = contactDetailsBAL.SaveContactDetailsBAL(contactDetailsEntity);
                // Check result is greater than zero or not
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