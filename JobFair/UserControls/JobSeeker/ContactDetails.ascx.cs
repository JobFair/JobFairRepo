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
        private string candidateId;
        private bool isCheck;

        protected void Page_Load(object sender, EventArgs e)
        {
            isCheck = Convert.ToBoolean(Request.QueryString["isCheck"]);
            // Check session is not null
            if (Session["candidateId"] != null)
            {
                if (Session["candidateId"].ToString() != "")
                {
                    candidateId = Convert.ToString(Session["candidateId"]);
                    // Check page is not post back
                    if (!IsPostBack)
                    {
                        // Check the isCheck is true for edit
                        if (isCheck)
                        {
                            try
                            {
                                BindContactDetails();
                            }
                            catch (Exception)
                            {
                                //   throw;
                            }
                        }
                    }
                }
            }
            else
            {
                Response.Redirect("LogIn.aspx");
            }
        }

        /// <summary>
        /// Bind Contact Details for edit
        /// </summary>
        private void BindContactDetails()
        {
            try
            {
                DataSet dsConatctDetails = new DataSet();
                ContactDetailsJSBAL contactDetailsBAL = new ContactDetailsJSBAL();
                dsConatctDetails = contactDetailsBAL.ViewContactDetailsBAL(candidateId);
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
                //  throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Check isCheck is true for update contact details
            if (isCheck)
            {
                try
                {
                    ContactDetailsJSBAL contactDetailsBAL = new ContactDetailsJSBAL();
                    ContactDetailsEntity objContactDetailsEntity = new ContactDetailsEntity();
                    // Set the value of ContactDetailsJobSeekerEntity

                    objContactDetailsEntity.CandidateId = candidateId;
                    objContactDetailsEntity.AltMobileNo = txtAltNo.Text.Trim();
                    objContactDetailsEntity.LandLineNo = txtLandno.Text.Trim();
                    objContactDetailsEntity.WhatsAppNo = txtWhatsappNo.Text.Trim();
                    objContactDetailsEntity.LinkedId = txtLinkedIn.Text.Trim();
                    objContactDetailsEntity.FacebookId = txtFacebook.Text.Trim();
                    objContactDetailsEntity.TwitterId = txtTwitter.Text.Trim();
                    objContactDetailsEntity.GtalkId = txtGTalk.Text.Trim();
                    objContactDetailsEntity.SkypeId = txtSkype.Text.Trim();
                    objContactDetailsEntity.GooglePlus = txtGooglePlus.Text.Trim();
                    objContactDetailsEntity.AltEmailId = txtAltEmailId.Text.Trim();
                    int result = contactDetailsBAL.UpdateContactDetailsBAL(objContactDetailsEntity);
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
                catch (Exception)
                {
                    //  throw;
                }
            }
            else
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
                    //  throw;
                }
            }
        }
    }
}