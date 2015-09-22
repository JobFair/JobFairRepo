using BAL;
using Entities.JobSeeker;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    /// <summary>
    /// Class EducationalDetails.
    /// </summary>
    public partial class EducationalDetails : System.Web.UI.UserControl
    {
        private EducationalDetailsBAL educationalDetails = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                educationalDetails = new EducationalDetailsBAL();
                DataSet degreeData = new DataSet();
                // Get educational degree type details
                degreeData = educationalDetails.GetEducationalDegreeTypeBAL();
                ddlHQ.DataSource = degreeData;
                ddlHQ.DataValueField = "degreeId";
                ddlHQ.DataTextField = "degreeType";
                ddlHQ.DataBind();
                ddlHQ.Items.Insert(0, new ListItem("--Select--", "0"));

                chkList.DataSource = degreeData;
                chkList.DataValueField = "degreeId";
                chkList.DataTextField = "degreeType";
                chkList.DataBind();
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            List<EducationalDetailsEntity> educationDetailsList = new List<EducationalDetailsEntity>();
            educationalDetails = new EducationalDetailsBAL();
            // Get only selected checkboxes list
            var selectedDegreeTypes = chkList.Items.Cast<ListItem>().Where(li => li.Selected).ToList();

            foreach (var item in selectedDegreeTypes)
            {
                switch (item.Text)
                {
                    case "SSC / 10th":
                        EducationalDetailsEntity sscDetails = new EducationalDetailsEntity();
                        sscDetails.CandidateId = "JS10";
                        sscDetails.DegreeId = item.Value;
                        sscDetails.MediumOfEducation = txtSSCMedium.Text.Trim();
                        sscDetails.Status = rblSSCStat.SelectedValue.Trim();
                        sscDetails.YearOfCompletion = txtSSCYear.Text.Trim();
                        sscDetails.University = txtSSCBoard.Text.Trim();
                        sscDetails.Percantage = txtSSCPercentage.Text.Trim();
                        // Add object to the education details collection
                        educationDetailsList.Add(sscDetails);
                        break;

                    case "HSC / 12th":
                        EducationalDetailsEntity hscDetails = new EducationalDetailsEntity();
                        hscDetails.CandidateId = "JS10";
                        hscDetails.DegreeId = item.Value;
                        hscDetails.MediumOfEducation = txtHSCMedium.Text.Trim();
                        hscDetails.Specialization = ddlHSC.SelectedValue.Trim();
                        hscDetails.Status = rblHSCStat.SelectedValue.Trim();
                        hscDetails.YearOfCompletion = txtHSCYear.Text.Trim();
                        hscDetails.University = txtHSCBoard.Text.Trim();
                        hscDetails.Percantage = txtHSCPercentage.Text.Trim();
                        // Add object to the education details collection
                        educationDetailsList.Add(hscDetails);
                        break;

                    case "UG Diploma":
                        EducationalDetailsEntity ugDiplomaDetails = new EducationalDetailsEntity();
                        ugDiplomaDetails.CandidateId = "JS10";
                        ugDiplomaDetails.DegreeId = item.Value;
                        ugDiplomaDetails.MediumOfEducation = txtDipMedium.Text.Trim();
                        ugDiplomaDetails.Specialization = ddlDip.SelectedValue.Trim();
                        ugDiplomaDetails.Status = rblDipStat.SelectedValue.Trim();
                        ugDiplomaDetails.YearOfCompletion = txtDipYear.Text.Trim();
                        ugDiplomaDetails.University = txtDipUniversity.Text.Trim();
                        ugDiplomaDetails.Percantage = txtDipPercentage.Text.Trim();
                        // Add object to the education details collection
                        educationDetailsList.Add(ugDiplomaDetails);
                        break;

                    case "Bachelors Degree":
                        EducationalDetailsEntity bachelorDegreeDetails = new EducationalDetailsEntity();
                        bachelorDegreeDetails.CandidateId = "JS10";
                        bachelorDegreeDetails.DegreeId = item.Value;
                        bachelorDegreeDetails.MediumOfEducation = txtBDMedium.Text.Trim();
                        bachelorDegreeDetails.Status = rblBDStat.SelectedValue.Trim();
                        bachelorDegreeDetails.Specialization = ddlBD.SelectedValue.Trim();
                        bachelorDegreeDetails.YearOfCompletion = txtBDYear.Text.Trim();
                        bachelorDegreeDetails.University = txtBDUniversity.Text.Trim();
                        bachelorDegreeDetails.Percantage = txtBDPercentage.Text.Trim();
                        // Add object to the education details collection
                        educationDetailsList.Add(bachelorDegreeDetails);
                        break;

                    case "PG Diploma":
                        EducationalDetailsEntity pgDiplomaDetails = new EducationalDetailsEntity();
                        pgDiplomaDetails.CandidateId = "JS10";
                        pgDiplomaDetails.DegreeId = item.Value;
                        pgDiplomaDetails.MediumOfEducation = txtPgdMedium.Text.Trim();
                        pgDiplomaDetails.Status = rblPgdStat.SelectedValue.Trim();
                        pgDiplomaDetails.Specialization = ddlPgd.SelectedValue.Trim();
                        pgDiplomaDetails.YearOfCompletion = txtPgdYear.Text.Trim();
                        pgDiplomaDetails.University = txtPgdUniversity.Text.Trim();
                        pgDiplomaDetails.Percantage = txtPgdPercentage.Text.Trim();
                        // Add object to the education details collection
                        educationDetailsList.Add(pgDiplomaDetails);
                        break;

                    case "Masters Degree":
                        EducationalDetailsEntity masterDegreeDetails = new EducationalDetailsEntity();
                        masterDegreeDetails.CandidateId = "JS10";
                        masterDegreeDetails.DegreeId = item.Value;
                        masterDegreeDetails.MediumOfEducation = txtMDMedium.Text.Trim();
                        masterDegreeDetails.Specialization = ddlMD.SelectedValue.Trim();
                        masterDegreeDetails.Status = rblMDStat.SelectedValue.Trim();
                        masterDegreeDetails.YearOfCompletion = txtMDYear.Text.Trim();
                        masterDegreeDetails.University = txtMDUniversity.Text.Trim();
                        masterDegreeDetails.Percantage = txtMDPercentage.Text.Trim();
                        // Add object to the education details collection
                        educationDetailsList.Add(masterDegreeDetails);
                        break;

                    case "Doctorate/ PHD Degree":
                        EducationalDetailsEntity phdDetails = new EducationalDetailsEntity();
                        phdDetails.CandidateId = "JS10";
                        phdDetails.DegreeId = item.Value;
                        phdDetails.MediumOfEducation = txtPHDMedium.Text.Trim();
                        phdDetails.Specialization = ddlPHD.SelectedValue.Trim();
                        phdDetails.Status = rblPHDStat.SelectedValue.Trim();
                        phdDetails.YearOfCompletion = txtPHDYear.Text.Trim();
                        phdDetails.University = txtPHDUniversity.Text.Trim();
                        phdDetails.Percantage = txtPHDPercentage.Text.Trim();
                        // Add object to the education details collection
                        educationDetailsList.Add(phdDetails);
                        break;

                    default:
                        break;
                }
            }

            // Save educational deails.
            if (educationalDetails.SaveEducationalDetailsBAL(educationDetailsList))
            {
                pnlCollapsableSSC.Visible = false;

                pnlCollapsableHSC.Visible = false;

                pnlCollapsableDip.Visible = false;

                pnlCollapsableBD.Visible = false;

                pnlCollapsablePgd.Visible = false;

                pnlCollapsableMD.Visible = false;

                pnlCollapsablePHD.Visible = false;

                lblSuccess.Text = "Data saved Successfully...!!";
                lblSuccess.Visible = true;
            }
            else
            {
                lblError.Text = "Data was not saved successfuly";
                lblError.Visible = true;
            }
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            // Get only selected checkboxes list
            var selectedDegreeTypes = chkList.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
            foreach (var item in selectedDegreeTypes)
            {
                switch (item.Text)
                {
                    case "SSC / 10th":
                        pnlCollapsableSSC.Visible = true;

                        break;

                    case "HSC / 12th":
                        pnlCollapsableHSC.Visible = true;

                        break;

                    case "UG Diploma":
                        pnlCollapsableDip.Visible = true;
                        break;

                    case "Bachelors Degree":
                        pnlCollapsableBD.Visible = true;
                        break;

                    case "PG Diploma":
                        pnlCollapsablePgd.Visible = true;
                        break; ;

                    case "Masters Degree":
                        pnlCollapsableMD.Visible = true;
                        break;

                    case "Doctorate/ PHD Degree":
                        pnlCollapsablePHD.Visible = true;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}