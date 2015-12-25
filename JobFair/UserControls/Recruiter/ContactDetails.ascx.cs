using BAL;
using Entities.Recruiter;
using System;
using System.Data;

namespace JobFair.UserControls.Recruiter
{
    public partial class ContactDetails : System.Web.UI.UserControl
    {
        private bool isEdit = true;
        private Int64 recruiterId = 12;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (isEdit)
                    {
                        BindContactDetails();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BindContactDetails()
        {
            try
            {
                DataSet dsConatctDetails = new DataSet();
                ContactDetailsREBAL contactDetailsBAL = new ContactDetailsREBAL();
                dsConatctDetails = contactDetailsBAL.ViewContactDetailsBAL(recruiterId);
                // Check dataset is not null
                if (dsConatctDetails != null)
                {
                    // Check number of tables greater than zero
                    if (dsConatctDetails.Tables.Count > 0)
                    {
                        // Check rows greater than zero
                        if (dsConatctDetails.Tables[0].Rows.Count > 0)
                        {
                            txtAltEmailId.Text = Convert.ToString(dsConatctDetails.Tables[0].Rows[0]["AltEmailId"]);
                            txtAltNo.Text = Convert.ToString(dsConatctDetails.Tables[0].Rows[0]["AltMobile"]);
                            txtLandno.Text = Convert.ToString(dsConatctDetails.Tables[0].Rows[0]["LandLine"]);
                            txtWhatsappNo.Text = Convert.ToString(dsConatctDetails.Tables[0].Rows[0]["WhatsapNo"]);
                            txtLinkedIn.Text = Convert.ToString(dsConatctDetails.Tables[0].Rows[0]["LinkedId"]);
                            txtFacebook.Text = Convert.ToString(dsConatctDetails.Tables[0].Rows[0]["FaceBookId"]);
                            txtTwitter.Text = Convert.ToString(dsConatctDetails.Tables[0].Rows[0]["TwitterId"]);
                            txtGTalk.Text = Convert.ToString(dsConatctDetails.Tables[0].Rows[0]["GtalkId"]);
                            txtSkype.Text = Convert.ToString(dsConatctDetails.Tables[0].Rows[0]["skypeId"]);
                            txtGooglePlus.Text = Convert.ToString(dsConatctDetails.Tables[0].Rows[0]["GoogleP"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(isEdit)
                {
                    ContactDetailsREBAL contactDetailsBAL = new ContactDetailsREBAL();
                    ContactDetailsEntity contactDetailsEntity = new ContactDetailsEntity();
                    // Set the value of ContactDetailsJobSeekerEntity

                    contactDetailsEntity.Id = recruiterId;
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

                    int result = contactDetailsBAL.UpdateContactDetailsBAL(contactDetailsEntity);
                    // Check result is greater than zero or not
                    if (result > 0)
                    {
                        Response.Write("<script language='javascript'>alert('Contact Details Updated')</script>");
                    }
                    else
                    {
                        Response.Write("<script language='javascript'>alert('Sorry')</script>");
                    }
                }
                else
                {
                    ContactDetailsREBAL contactDetailsBAL = new ContactDetailsREBAL();
                    ContactDetailsEntity contactDetailsEntity = new ContactDetailsEntity();
                    // Set the value of ContactDetailsJobSeekerEntity

                    contactDetailsEntity.Id = recruiterId;
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
               
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}