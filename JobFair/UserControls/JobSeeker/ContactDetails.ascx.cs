using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities;

namespace JobFair.UserControls.JobSeeker
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

                ContactDetailsJSBAL cdBAL = new ContactDetailsJSBAL();
                ContactDetailsEntity cdEntity = new ContactDetailsEntity();
                //set the value of ContactDetailsJobSeekerEntity

                cdEntity.CandidateId = "JS00001";//static data used because session value not set
                cdEntity.AltMobileNo = txtAltNo.Text.Trim();
                cdEntity.LandLineNo = txtLandno.Text.Trim();
                cdEntity.WhatsAppNo = txtWhatsappNo.Text.Trim();
                cdEntity.LinkedId = txtLinkedIn.Text.Trim();
                cdEntity.FacebookId = txtFacebook.Text.Trim();
                cdEntity.TwitterId = txtTwitter.Text.Trim();
                cdEntity.GtalkId = txtGTalk.Text.Trim();
                cdEntity.SkypeId = txtSkype.Text.Trim();
                cdEntity.GooglePlus = txtGooglePlus.Text.Trim();
                int result = cdBAL.ContactDetailsBAL(cdEntity);
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