using BAL;
using System;
using System.Data;

namespace JobFair.Forms.JobSeeker
{
    public partial class ChangeLoginDetails : System.Web.UI.Page
    {
        private string candidateId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["candidateId"] != null)
            {
                if (Session["candidateId"].ToString() != "")
                {
                    candidateId = Convert.ToString(Session["candidateId"]);

                    if (!IsPostBack)
                    {
                     
                        DataSet datasetLoginDetails = new DataSet();
                        ChangeLoginDetailsBAL changeLoginDetailsBAL = new ChangeLoginDetailsBAL();
                        datasetLoginDetails = changeLoginDetailsBAL.GetLoginDetailsBAL(candidateId);
                        lblLoginMailId.Text = Convert.ToString(datasetLoginDetails.Tables[0].Rows[0]["EmailId"]);
                        lblAlternateMailId.Text = Convert.ToString(datasetLoginDetails.Tables[0].Rows[0]["AltEmailId"]);
                        lblPrimaryMobNo.Text = Convert.ToString(datasetLoginDetails.Tables[0].Rows[0]["MobileNo"]);
                        lblAlternateMobNo.Text = Convert.ToString(datasetLoginDetails.Tables[0].Rows[0]["AltMobile"]);
                    }
                }
            }
        }

        protected void lnkbtnMakeLoginId_Click(object sender, EventArgs e)
        {
            
            try
            {
               
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void lnkbtnAlternateMobNo_Click(object sender, EventArgs e)
        {
        }
    }
}