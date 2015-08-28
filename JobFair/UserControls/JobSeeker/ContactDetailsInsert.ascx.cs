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
    public partial class ContactDetailsInsert : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
             try
        {
             
            RegisterJobSeekerBAL rejBAL = new RegisterJobSeekerBAL();
            ContactDetailsJobSeekerEntity cdEntity = new ContactDetailsJobSeekerEntity();
            cdEntity.UserID = "1200132426";//static data used
            cdEntity.AltMobileNo = txtAltNo.Text.Trim();
            cdEntity.LandLineNo = txtLandno.Text.Trim();
            cdEntity.WhatsAppNo = txtWhatsappNo.Text.Trim();
            cdEntity.LinkedID = txtLinkedIn.Text.Trim();
            cdEntity.FacebookID = txtFacebook.Text.Trim();
            cdEntity.TwitterID = txtTwitter.Text.Trim();
            cdEntity.GtalkID = txtGTalk.Text.Trim();
            cdEntity.SkypeID = txtSkype.Text.Trim();
            cdEntity.GooglePlus = txtGooglePlus.Text.Trim();
            int result = rejBAL.ContactDetailsJobSeeker(cdEntity);
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