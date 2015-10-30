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
    /// Class MoreWorkshops.
    /// </summary>
    public partial class MoreWorkshops : System.Web.UI.UserControl
    {
        private MoreWorkshopBAL workshopDetails = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                workshopDetails = new MoreWorkshopBAL();
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

        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            List<WorkshopEntity> workshopDetailsList = new List<WorkshopEntity>();
            workshopDetails = new MoreWorkshopBAL();

            WorkshopEntity workshopEntity = new WorkshopEntity();
            workshopEntity.CandidateId = "JS9";
            workshopEntity.WorkshopName = txtWorkshopName.Text.Trim();
            workshopEntity.Institute = txtWorkshopInstitute.Text.Trim();
            workshopEntity.Duration = txtWorkshopDuration.Text.Trim();
            workshopEntity.YearOfCompletion = ddlMonth.Text + ddlYear.Text;
            workshopEntity.Grade = txtworkspGrade.Text.Trim();

            // Add object to the MoreCertification details collection
            workshopDetailsList.Add(workshopEntity);

            // Save educational deails.
            if (workshopDetails.SaveMoreCertificationBAL(workshopDetailsList))
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