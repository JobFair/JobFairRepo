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
    /// <summary>
    /// Class ContactDetailsInsert.
    /// </summary>
    public partial class ContactDetailsInsert : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the btnSubmit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
             try
        {

            ContactDetailsJSBAL cdBAL = new ContactDetailsJSBAL();
            ContactDetailsJobSeekerEntity cdEntity = new ContactDetailsJobSeekerEntity();
                 //set the value of ContactDetailsJobSeekerEntity

            cdEntity.UserID = "1200132426";//static data used because session value not set
            cdEntity.AltMobileNo = txtAltNo.Text.Trim();
            cdEntity.LandLineNo = txtLandno.Text.Trim();
            cdEntity.WhatsAppNo = txtWhatsappNo.Text.Trim();
            cdEntity.LinkedID = txtLinkedIn.Text.Trim();
            cdEntity.FacebookID = txtFacebook.Text.Trim();
            cdEntity.TwitterID = txtTwitter.Text.Trim();
            cdEntity.GtalkID = txtGTalk.Text.Trim();
            cdEntity.SkypeID = txtSkype.Text.Trim();
            cdEntity.GooglePlus = txtGooglePlus.Text.Trim();
            int result = cdBAL.ContactDetailsJobSeeker(cdEntity);
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

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //txtAltNo.Text = "";
            //txtLandno.Text = "";
            //txtWhatsappNo.Text = "";
            //txtLinkedIn.Text = "";
            //txtFacebook.Text = "";
            //txtTwitter.Text = "";
            //txtGTalk.Text = "";
            //txtSkype.Text = "";
            //txtGooglePlus.Text = "";
        }
        
    }
}