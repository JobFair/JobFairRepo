using BAL;
using Entities.JobSeeker;
using System;
using System.Data;

namespace JobFair.Forms.JobSeeker
{
    public partial class ChangeLoginDetails : System.Web.UI.Page
    {
        private string candidateId;

        /// <summary>
        /// Handles Load event of ChangeLoginDetails page
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check session is not null
            if (Session["candidateId"] != null)
            {
                if (Session["candidateId"].ToString() != "")
                {
                    candidateId = Convert.ToString(Session["candidateId"]);
                    // Check page is not post back
                    if (!IsPostBack)
                    {
                        try
                        {
                            DataSet datasetLoginDetails = new DataSet();
                            ChangeLoginDetailsBAL changeLoginDetailsBAL = new ChangeLoginDetailsBAL();
                            datasetLoginDetails = changeLoginDetailsBAL.GetLoginDetailsBAL(candidateId);
                            // Check dataset is not null
                            if (datasetLoginDetails != null)
                            {
                                lblLoginMailId.Text = Convert.ToString(datasetLoginDetails.Tables[0].Rows[0]["EmailId"]);
                                lblAlternateMailId.Text = Convert.ToString(datasetLoginDetails.Tables[0].Rows[0]["AltEmailId"]);
                                lblPrimaryMobNo.Text = Convert.ToString(datasetLoginDetails.Tables[0].Rows[0]["MobileNo"]);
                                lblAlternateMobNo.Text = Convert.ToString(datasetLoginDetails.Tables[0].Rows[0]["AltMobile"]);
                            }
                        }
                        catch (Exception)
                        {
                            //  throw;
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
        /// Handles Click event of lnkbtnMakeLoginId control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void lnkbtnMakeLoginId_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsLoginDetails = new DataSet();
                ChangeLoginDetailsBAL changeLoginDetailsBAL = new ChangeLoginDetailsBAL();
                ChangeLoginDetailsEntity changeLoginDetailsEntity = new ChangeLoginDetailsEntity();
                dsLoginDetails = changeLoginDetailsBAL.GetLoginDetailsBAL(candidateId);
                // Check dataset is not null
                if (dsLoginDetails != null)
                {
                    lblLoginMailId.Text = Convert.ToString(dsLoginDetails.Tables[0].Rows[0]["EmailId"]);
                    changeLoginDetailsEntity.CandidateId = candidateId;
                    changeLoginDetailsEntity.MailId = Convert.ToString(dsLoginDetails.Tables[0].Rows[0]["AltEmailId"]);
                    changeLoginDetailsBAL.ChangePrimaryMailIdBAL(changeLoginDetailsEntity);
                    Response.Write("<script language='javascript'>alert('Your Primary Mail id changed successfully. Please Refresh Page.')</script>");
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Handles Click event of lnkbtnAlternateMobNo control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void lnkbtnAlternateMobNo_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet datasetLoginDetail = new DataSet();
                //DataSet datasetUpdateMobileDetails = new DataSet();
                ChangeLoginDetailsBAL changeLoginDetailsBAL = new ChangeLoginDetailsBAL();
                ChangeLoginDetailsEntity changeLoginDetailsEntity = new ChangeLoginDetailsEntity();
                datasetLoginDetail = changeLoginDetailsBAL.GetLoginDetailsBAL(candidateId);
                // Check dataset is not null
                if (datasetLoginDetail != null)
                {
                    lblPrimaryMobNo.Text = Convert.ToString(datasetLoginDetail.Tables[0].Rows[0]["MobileNo"]);
                    changeLoginDetailsEntity.CandidateId = candidateId;
                    changeLoginDetailsEntity.MobileNo = Convert.ToString(datasetLoginDetail.Tables[0].Rows[0]["AltMobile"]);
                    changeLoginDetailsBAL.ChangePrimaryMobileNoBAL(changeLoginDetailsEntity);
                    Response.Write("<script language='javascript'>alert('Your Primary Mobile number changed successfully. Please Refresh Page.')</script>");
                }
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        /// <summary>
        /// Handles Click event of btnAddMailId control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnAddMailId_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeLoginDetailsBAL changeLoginDetailsBAL = new ChangeLoginDetailsBAL();
                ChangeLoginDetailsEntity changeLoginDetailsEntity = new ChangeLoginDetailsEntity();
                changeLoginDetailsEntity.CandidateId = candidateId;
                changeLoginDetailsEntity.MailId = txtEmailId.Text.Trim();
                int result = changeLoginDetailsBAL.NewMailIdBAL(changeLoginDetailsEntity);
                Response.Write("<script language='javascript'>alert('Your New Email Id saved successfully. Please Refresh Page.')</script>");
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        /// <summary>
        /// Handles Click event of btnAddMobileNo control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnAddMobileNo_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeLoginDetailsBAL changeLoginDetailsBAL = new ChangeLoginDetailsBAL();
                ChangeLoginDetailsEntity changeLoginDetailsEntity = new ChangeLoginDetailsEntity();
                changeLoginDetailsEntity.CandidateId = candidateId;
                changeLoginDetailsEntity.MobileNo = txtMobileNumber.Text.Trim();
                int result = changeLoginDetailsBAL.NewMoblieNoBAL(changeLoginDetailsEntity);
                Response.Write("<script language='javascript'>alert('Your New Mobile Number saved successfully.Please Refresh Page.')</script>");
            }
            catch (Exception)
            {
                // throw;
            }
        }
    }
}