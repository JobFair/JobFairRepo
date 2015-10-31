using BAL;
using Entities.JobSeeker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace JobFair.UserControls.JobSeeker
{
     /// <summary>
    /// Class MoreCertifications.
    /// </summary>
    public partial class MoreCertifications : System.Web.UI.UserControl
    {
        private MoreCertificationBAL certificationDetails = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 certificationDetails = new MoreCertificationBAL();
                // Bind Month List
                List<string> monthList = CommonUtil.Utility.GetMonths();
                ddlMonth.DataSource = monthList;
                ddlMonth.DataBind();

                // Bind Year List
                List<string> yearList = CommonUtil.Utility.GetYears();
                ddlYear.DataSource = yearList;
                ddlYear.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            PlaceHolder PlaceHolder1 = new PlaceHolder();
            int numlabels = 2;
            Label lblCert1 = new Label();
            for (int i = 1; i <= numlabels; i++)
            {
                // Set the label's Text and ID properties.
                lblCert1.Text = "Certificate" + i.ToString();
                lblCert1.ID = "lblCert" + i.ToString();
                PlaceHolder1.Controls.Add(lblCert1);
                // Add a spacer in the form of an HTML <br /> element.
                PlaceHolder1.Controls.Add(new LiteralControl("<br />"));
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            List<CertificationEntity> certificationDetailsList = new List<CertificationEntity>();
            certificationDetails = new MoreCertificationBAL();

            CertificationEntity certificationEntity = new CertificationEntity();
            certificationEntity.CandidateId = "JS9";
            certificationEntity.CertificationName = txtCertificationName.Text.Trim();
            certificationEntity.Institute = txtCertificationInstitute.Text.Trim();
            certificationEntity.Duration = txtCertificationDuration.Text.Trim();
            certificationEntity.YearOfCompletion = ddlMonth.Text + ddlYear.Text;
            certificationEntity.Grade = txtCertificationGrade.Text.Trim();
           
            // Add object to the MoreCertification details collection
            certificationDetailsList.Add(certificationEntity);
      

            // Save educational deails.
            if (certificationDetails.SaveMoreCertificationBAL(certificationDetailsList))
            {

                lblSuccess.Text = "Data saved Successfully...!!";
                lblSuccess.Visible = true;
            }
            else
            {
                lblError.Text = "Data was not saved successfuly";
                lblError.Visible = true;
            }
        }
    }
}