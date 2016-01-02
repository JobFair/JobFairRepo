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
        private string candidateId;
        private bool isEdit = true;
        private bool isAddNewEducation = false ;
        private int degreeId;
        private int specializationId;

        private EducationalDetailsBAL educationalDetails = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //isEdit = Convert.ToBoolean(Request.QueryString["isCheck"]);
            if (Session["candidateId"] != null)
            {
                if (Session["candidateId"].ToString() != "")
                {
                    //CheckAuthorised(candidateId);
                    candidateId = Convert.ToString(Session["candidateId"]);
                    
                    if (!IsPostBack)
                    {
                        try
                        {
                            BindAllEducationalDetails();
                            
                            if (isAddNewEducation)
                            {
                                BtnAddNewEducation_Click(sender,e);
                            }
                        }
                        catch (Exception)
                        {
                            // throw;
                        }
                    }
                }
            }
        }

        private void BindAllEducationalDetails()
        {
            try
            {
                BindEducationalDegreeType();
                BindDropDownHSC();
                BindDropDownUnderGraduateDiploma();
                BindDropDownBachelorDegree();
                BindDropDownDualBachelorDegree();
                BindDropDownPostGraduateDiploma();
                BindDropDownMasterDegree();
                BindDropDownDualMasterDegree();
                BindDropDownDoctorOfPhilosophy();

                //Declration For ALL
                List<string> YearList = CommonUtil.Utility.GetYears();
                List<string> MonthList = CommonUtil.Utility.GetMonths();
                BindSSCYear(YearList);
                BindSSCMonth(MonthList);

                BindHSCYear(YearList);
                BindHSCMonth(MonthList);

                BindDiplomaYear(YearList);
                BindDiplomaMonth(MonthList);

                BindBachelorDegreeYear(YearList);
                BindBachelorDegreeMonth(MonthList);

                BindDualBDYear(YearList);
                BindDualBDMonth(MonthList);

                BindPGDYear(YearList);
                BindPGDMonth(MonthList);

                BindMastersYear(YearList);
                BindMastersMonth(MonthList);

                BindDualMDYear(YearList);
                BindDualMDMonth(MonthList);

                BindPHDYear(YearList);
                BindPHDMonth(MonthList);
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindPHDMonth(List<string> MonthList)
        {
            try
            {
                ddlPHDMonthFrom.DataSource = MonthList;
                ddlPHDMonthFrom.DataBind();
                ddlPHDMonthTo.DataSource = MonthList;
                ddlPHDMonthTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindPHDYear(List<string> YearList)
        {
            try
            {
                ddlPHDYearFrom.DataSource = YearList;
                ddlPHDYearFrom.DataBind();
                ddlPHDYearTo.DataSource = YearList;
                ddlPHDYearTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindDualMDYear(List<string> YearList)
        {
            try
            {
                ddlDualMDYearFrom.DataSource = YearList;
                ddlDualMDYearFrom.DataBind();
                ddlDualMDYearTo.DataSource = YearList;
                ddlDualMDYearTo.DataBind();
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        private void BindDualMDMonth(List<string> MonthList)
        {
            try
            {
                ddlDualMDMonthFrom.DataSource = MonthList;
                ddlDualMDMonthFrom.DataBind();
                ddlDualMDMonthTo.DataSource = MonthList;
                ddlDualMDMonthTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindMastersYear(List<string> YearList)
        {
            try
            {
                ddlMDYearFrom.DataSource = YearList;
                ddlMDYearFrom.DataBind();
                ddlMDYearTo.DataSource = YearList;
                ddlMDYearTo.DataBind();
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        private void BindMastersMonth(List<string> MonthList)
        {
            try
            {
                ddlMDMonthFrom.DataSource = MonthList;
                ddlMDMonthFrom.DataBind();
                ddlMDMonthTo.DataSource = MonthList;
                ddlMDMonthTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindPGDYear(List<string> YearList)
        {
            try
            {
                ddlPgdYearFrom.DataSource = YearList;
                ddlPgdYearFrom.DataBind();
                ddlPgdYearTo.DataSource = YearList;
                ddlPgdYearTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindPGDMonth(List<string> MonthList)
        {
            try
            {
                ddlPgdMonthFrom.DataSource = MonthList;
                ddlPgdMonthFrom.DataBind();
                ddlPgdMonthTo.DataSource = MonthList;
                ddlPgdMonthTo.DataBind();
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        private void BindDualBDYear(List<string> YearList)
        {
            try
            {
                ddlDualBDYearFrom.DataSource = YearList;
                ddlDualBDYearFrom.DataBind();
                ddlDualBDYearTo.DataSource = YearList;
                ddlDualBDYearTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindDualBDMonth(List<string> MonthList)
        {
            try
            {
                ddlDualBDMonthFrom.DataSource = MonthList;
                ddlDualBDMonthFrom.DataBind();
                ddlDualBDMonthTo.DataSource = MonthList;
                ddlDualBDMonthTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindBachelorDegreeYear(List<string> YearList)
        {
            try
            {
                ddlBDYearFrom.DataSource = YearList;
                ddlBDYearFrom.DataBind();
                ddlBDYearTo.DataSource = YearList;
                ddlBDYearTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindBachelorDegreeMonth(List<string> MonthList)
        {
            try
            {
                ddlBDMonthFrom.DataSource = MonthList;
                ddlBDMonthFrom.DataBind();
                ddlBDMonthTo.DataSource = MonthList;
                ddlBDMonthTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindDiplomaYear(List<string> YearList)
        {
            try
            {
                ddlDipYearFrom.DataSource = YearList;
                ddlDipYearFrom.DataBind();
                ddlDipYearTo.DataSource = YearList;
                ddlDipYearTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindDiplomaMonth(List<string> MonthList)
        {
            try
            {
                ddlDipMonthFrom.DataSource = MonthList;
                ddlDipMonthFrom.DataBind();
                ddlDipMonthTo.DataSource = MonthList;
                ddlDipMonthTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindHSCYear(List<string> YearList)
        {
            try
            {
                ddlHSCYearFrom.DataSource = YearList;
                ddlHSCYearFrom.DataBind();
                ddlHSCYearTo.DataSource = YearList;
                ddlHSCYearTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindHSCMonth(List<string> MonthList)
        {
            try
            {
                ddlHSCMonthFrom.DataSource = MonthList;
                ddlHSCMonthFrom.DataBind();
                ddlHSCMonthTo.DataSource = MonthList;
                ddlHSCMonthTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindSSCYear(List<string> YearList)
        {
            try
            {
                ddlSSCYearFrom.DataSource = YearList;
                ddlSSCYearFrom.DataBind();
                ddlSSCYearTo.DataSource = YearList;
                ddlSSCYearTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindSSCMonth(List<string> MonthList)
        {
            try
            {
                ddlSSCMonthFrom.DataSource = MonthList;
                ddlSSCMonthFrom.DataBind();
                ddlSSCMonthTo.DataSource = MonthList;
                ddlSSCMonthTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindEducationalDegreeType()
        {
            try
            {
                educationalDetails = new EducationalDetailsBAL();
                DataSet degreeData = new DataSet();

                // Get educational degree type details
                degreeData = educationalDetails.GetEducationalDegreeTypeBAL();
                if (degreeData != null)
                {
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
            catch (Exception)
            {
                //  throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSubmit control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e"></param>
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
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
                            sscDetails.CandidateId = candidateId;
                            sscDetails.HighestQualificationId = ddlHQ.SelectedValue.Trim();
                            sscDetails.DegreeId = Convert.ToInt32(item.Value);
                            sscDetails.MediumOfEducation = txtSSCMedium.Text.Trim();
                            sscDetails.SpecializationId = 0;
                            sscDetails.Status = rblSSCStat.SelectedValue.Trim();
                            sscDetails.FromYear = ddlSSCMonthFrom.Text + '/' + ddlSSCYearFrom.Text;
                            sscDetails.ToYear = ddlSSCMonthTo.Text + '/' + ddlSSCYearTo.Text;
                            sscDetails.College = txtSSCSchool.Text.Trim();
                            sscDetails.University = txtSSCBoard.Text.Trim();
                            sscDetails.Percantage = txtSSCPercentage.Text.Trim();
                            // Add object to the education details collection
                            educationDetailsList.Add(sscDetails);
                            break;

                        case "HSC / 12th":
                            EducationalDetailsEntity hscDetails = new EducationalDetailsEntity();
                            hscDetails.CandidateId = candidateId;
                            hscDetails.HighestQualificationId = ddlHQ.SelectedValue.Trim();
                            hscDetails.DegreeId = Convert.ToInt32(item.Value);
                            hscDetails.MediumOfEducation = txtHSCMedium.Text.Trim();
                            hscDetails.SpecializationId = Convert.ToInt32(ddlHSC.SelectedValue.Trim());
                            hscDetails.Status = rblHSCStat.SelectedValue.Trim();
                            hscDetails.FromYear = ddlHSCMonthFrom.Text + '/' + ddlHSCYearFrom.Text;
                            hscDetails.ToYear = ddlHSCMonthTo.Text + '/' + ddlHSCYearTo.Text;
                            hscDetails.College = txtHSCCollege.Text.Trim();
                            hscDetails.University = txtHSCBoard.Text.Trim();
                            hscDetails.Percantage = txtHSCPercentage.Text.Trim();
                            // Add object to the education details collection
                            educationDetailsList.Add(hscDetails);
                            break;

                        case "UG Diploma":
                            EducationalDetailsEntity ugDiplomaDetails = new EducationalDetailsEntity();
                            ugDiplomaDetails.CandidateId = candidateId;
                            ugDiplomaDetails.HighestQualificationId = ddlHQ.SelectedValue.Trim();
                            ugDiplomaDetails.DegreeId = Convert.ToInt32(item.Value);
                            ugDiplomaDetails.MediumOfEducation = txtDipMedium.Text.Trim();
                            ugDiplomaDetails.SpecializationId = Convert.ToInt32(ddlDip.SelectedValue.Trim());
                            ugDiplomaDetails.Status = rblDipStat.SelectedValue.Trim();
                            ugDiplomaDetails.FromYear = ddlDipMonthFrom.Text + '/' + ddlDipYearFrom.Text;
                            ugDiplomaDetails.ToYear = ddlDipMonthTo.Text + '/' + ddlDipYearTo.Text;
                            ugDiplomaDetails.College = txtDipCollege.Text.Trim();
                            ugDiplomaDetails.University = txtDipUniversity.Text.Trim();
                            ugDiplomaDetails.Percantage = txtDipPercentage.Text.Trim();
                            // Add object to the education details collection
                            educationDetailsList.Add(ugDiplomaDetails);
                            break;

                        case "Bachelors Degree":
                            EducationalDetailsEntity bachelorDegreeDetails = new EducationalDetailsEntity();
                            bachelorDegreeDetails.CandidateId = candidateId;
                            bachelorDegreeDetails.HighestQualificationId = ddlHQ.SelectedValue.Trim();
                            bachelorDegreeDetails.DegreeId = Convert.ToInt32(item.Value);
                            bachelorDegreeDetails.MediumOfEducation = txtBDMedium.Text.Trim();
                            bachelorDegreeDetails.Status = rblBDStat.SelectedValue.Trim();
                            bachelorDegreeDetails.SpecializationId = Convert.ToInt32(ddlBD.SelectedValue.Trim());
                            bachelorDegreeDetails.FromYear = ddlBDMonthFrom.Text + '/' + ddlBDYearFrom.Text;
                            bachelorDegreeDetails.ToYear = ddlBDMonthTo.Text + '/' + ddlBDYearTo.Text;
                            bachelorDegreeDetails.College = txtBDCollege.Text.Trim();
                            bachelorDegreeDetails.University = txtBDUniversity.Text.Trim();
                            bachelorDegreeDetails.Percantage = txtBDPercentage.Text.Trim();
                            // Add object to the education details collection
                            educationDetailsList.Add(bachelorDegreeDetails);
                            // functionality for adding records for Dual Bachelore Degree
                            if (pnlCollapsableDualBD.Visible == true)
                            {
                                EducationalDetailsEntity dualBachelorDegreeDetails = new EducationalDetailsEntity();
                                dualBachelorDegreeDetails.CandidateId = candidateId;
                                dualBachelorDegreeDetails.HighestQualificationId = ddlHQ.SelectedValue.Trim();
                                dualBachelorDegreeDetails.DegreeId = Convert.ToInt32(item.Value);
                                dualBachelorDegreeDetails.MediumOfEducation = txtDualBDMedium.Text.Trim();
                                dualBachelorDegreeDetails.Status = rblDualBDStat.SelectedValue.Trim();
                                dualBachelorDegreeDetails.SpecializationId = Convert.ToInt32(ddlDualBD.SelectedValue.Trim());
                                dualBachelorDegreeDetails.FromYear = ddlDualBDMonthFrom.Text + '/' + ddlDualBDYearFrom.Text;
                                dualBachelorDegreeDetails.ToYear = ddlDualBDMonthTo.Text + '/' + ddlDualBDYearTo.Text;
                                dualBachelorDegreeDetails.College = txtDualBDCollege.Text.Trim();
                                dualBachelorDegreeDetails.University = txtDualBDUniversity.Text.Trim();
                                dualBachelorDegreeDetails.Percantage = txtDualBDPercentage.Text.Trim();
                                // Add object to the education details collection
                                educationDetailsList.Add(dualBachelorDegreeDetails);
                            }
                            break;

                        case "PG Diploma":
                            EducationalDetailsEntity pgDiplomaDetails = new EducationalDetailsEntity();
                            pgDiplomaDetails.CandidateId = candidateId;
                            pgDiplomaDetails.HighestQualificationId = ddlHQ.SelectedValue.Trim();
                            pgDiplomaDetails.DegreeId = Convert.ToInt32(item.Value);
                            pgDiplomaDetails.MediumOfEducation = txtPgdMedium.Text.Trim();
                            pgDiplomaDetails.Status = rblPgdStat.SelectedValue.Trim();
                            pgDiplomaDetails.SpecializationId = Convert.ToInt32(ddlPgd.SelectedValue.Trim());
                            pgDiplomaDetails.FromYear = ddlPgdMonthFrom.Text + '/' + ddlPgdYearFrom.Text;
                            pgDiplomaDetails.ToYear = ddlPgdMonthTo.Text + '/' + ddlPgdYearTo.Text;
                            pgDiplomaDetails.College = txtPgdCollege.Text.Trim();
                            pgDiplomaDetails.University = txtPgdUniversity.Text.Trim();
                            pgDiplomaDetails.Percantage = txtPgdPercentage.Text.Trim();
                            // Add object to the education details collection
                            educationDetailsList.Add(pgDiplomaDetails);
                            break;

                        case "Masters Degree":
                            EducationalDetailsEntity masterDegreeDetails = new EducationalDetailsEntity();
                            masterDegreeDetails.CandidateId = candidateId;
                            masterDegreeDetails.HighestQualificationId = ddlHQ.SelectedValue.Trim();
                            masterDegreeDetails.DegreeId = Convert.ToInt32(item.Value);
                            masterDegreeDetails.MediumOfEducation = txtMDMedium.Text.Trim();
                            masterDegreeDetails.SpecializationId = Convert.ToInt32(ddlMD.SelectedValue.Trim());
                            masterDegreeDetails.Status = rblMDStat.SelectedValue.Trim();
                            masterDegreeDetails.FromYear = ddlMDMonthFrom.Text + '/' + ddlMDYearFrom.Text;
                            masterDegreeDetails.ToYear = ddlMDMonthTo.Text + '/' + ddlMDYearTo.Text;
                            masterDegreeDetails.College = txtMDCollege.Text.Trim();
                            masterDegreeDetails.University = txtMDUniversity.Text.Trim();
                            masterDegreeDetails.Percantage = txtMDPercentage.Text.Trim();
                            // Add object to the education details collection
                            educationDetailsList.Add(masterDegreeDetails);
                            // functionality for adding records for Dual Master Degree
                            if (pnlCollapsableDualMD.Visible == true)
                            {
                                EducationalDetailsEntity dualMasterDegreeDetails = new EducationalDetailsEntity();
                                dualMasterDegreeDetails.CandidateId = candidateId;
                                dualMasterDegreeDetails.HighestQualificationId = ddlHQ.SelectedValue.Trim();
                                dualMasterDegreeDetails.DegreeId = Convert.ToInt32(item.Value);
                                dualMasterDegreeDetails.MediumOfEducation = txtDualMDMedium.Text.Trim();
                                dualMasterDegreeDetails.SpecializationId = Convert.ToInt32(ddlDualMD.SelectedValue.Trim());
                                dualMasterDegreeDetails.Status = rblDualMDStat.SelectedValue.Trim();
                                dualMasterDegreeDetails.FromYear = ddlDualMDMonthFrom.Text + '/' + ddlDualMDYearFrom.Text;
                                dualMasterDegreeDetails.ToYear = ddlDualMDMonthTo.Text + '/' + ddlDualMDYearTo.Text;
                                dualMasterDegreeDetails.College = txtDualMDCollege.Text.Trim();
                                dualMasterDegreeDetails.University = txtDualMDUniversity.Text.Trim();
                                dualMasterDegreeDetails.Percantage = txtDualMDPercentage.Text.Trim();
                                // Add object to the education details collection
                                educationDetailsList.Add(dualMasterDegreeDetails);
                            }
                            break;

                        case "Doctorate/ PHD Degree":
                            EducationalDetailsEntity phdDetails = new EducationalDetailsEntity();
                            phdDetails.CandidateId = candidateId;
                            phdDetails.HighestQualificationId = ddlHQ.SelectedValue.Trim();
                            phdDetails.DegreeId = Convert.ToInt32(item.Value);
                            phdDetails.MediumOfEducation = txtPHDMedium.Text.Trim();
                            phdDetails.SpecializationId = Convert.ToInt32(ddlPHD.SelectedValue.Trim());
                            phdDetails.Status = rblPHDStat.SelectedValue.Trim();
                            phdDetails.FromYear = ddlPHDMonthFrom.Text + '/' + ddlPHDYearFrom.Text;
                            phdDetails.ToYear = ddlPHDMonthTo.Text + '/' + ddlPHDYearTo.Text;
                            phdDetails.College = txtPHDCollege.Text.Trim();
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

                    pnlCollapsableDualBD.Visible = false;

                    pnlCollapsablePgd.Visible = false;

                    pnlCollapsableMD.Visible = false;

                    pnlCollapsableDualMD.Visible = false;

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
            catch (Exception)
            {
                //  throw;
            }
        }

        protected void BtnAddNewEducation_Click(object sender, EventArgs e)
        {
            try
            {
                educationalDetails = new EducationalDetailsBAL();
                DataSet degreeData = new DataSet();
                degreeData = educationalDetails.GetEducationalDegreeTypeBAL(candidateId);
                if (degreeData != null)
                {
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
                
                
                
                
                //educationalDetails = new EducationalDetailsBAL();
                //DataSet dsEducationalDetails = new DataSet();
                //dsEducationalDetails = educationalDetails.ViewEducationalDegreeDetailsBAL(candidateId);

                //if (dsEducationalDetails != null)
                {
                    //isAddNewEducation = true;
                    //Response.Redirect("DemoEducationalDetails.aspx?isAddNewEducation=" + isAddNewEducation );
                     
                    divMain.Visible = true;

                    footer.Visible = false;
                }
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                BtnSubmit.Visible = true;
                //Declration For ALL
                List<string> YearList = CommonUtil.Utility.GetYears();
                List<string> MonthList = CommonUtil.Utility.GetMonths();
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
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with DegreeDetails_Table of Database
        /// </summary>
        private void BindDropDownHSC()
        {
            try
            {
                degreeId = 2;
                DataSet dsDegreeDetails = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get HSC details
                dsDegreeDetails = educationalDetails.GetDegreeDetailsBAL(degreeId);
                if (dsDegreeDetails != null)
                {
                    ddlHSC.DataSource = dsDegreeDetails;
                    ddlHSC.DataValueField = "SpecializationId";
                    ddlHSC.DataTextField = "DegreeName";
                    ddlHSC.DataBind();

                    ddlHSC.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }
        
        private void BindDropDownUnderGraduateDiploma()
        {
        //    try
        //    {
        //        DataSet UnderGraduateDiplomaData = new DataSet();
        //        educationalDetails = new EducationalDetailsBAL();
        //        // Get Under Graduate Diploma details
        //        UnderGraduateDiplomaData = educationalDetails.GetUnderGraduateDiplomaBAL();
        //        if (UnderGraduateDiplomaData != null)
        //        {
        //            ddlDip.DataSource = UnderGraduateDiplomaData;
        //            ddlDip.DataValueField = "UGDID";
        //            ddlDip.DataTextField = "UGDName";
        //            ddlDip.DataBind();

        //            ddlDip.Items.Insert(Convert.ToInt32(ddlDip.Items[ddlDip.Items.Count - 1].Value), new ListItem("----Other----", ""));
        //            ddlDip.Items.Insert(0, new ListItem("--Select--", "0"));
        //        }
        //    }
            try
            {
                degreeId = 3;
                DataSet dsDegreeDetails = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get Under Graduate Diploma details
                dsDegreeDetails = educationalDetails.GetDegreeDetailsBAL(degreeId);
                if (dsDegreeDetails != null)
                {
                    ddlDip.DataSource = dsDegreeDetails;
                    ddlDip.DataValueField = "SpecializationId";
                    ddlDip.DataTextField = "DegreeName";
                    ddlDip.DataBind();

                    ddlDip.Items.Insert(Convert.ToInt32(ddlDip.Items.Count), new ListItem("----Other----", ""));
                    ddlDip.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with BachelorDegree_Table of Database
        /// </summary>
        private void BindDropDownBachelorDegree()
        {
            try
            {
                degreeId = 4;
                DataSet dsDegreeDetails = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get Bachelor Degree details
                dsDegreeDetails = educationalDetails.GetDegreeDetailsBAL(degreeId);
                if (dsDegreeDetails != null)
                {
                    ddlBD.DataSource = dsDegreeDetails;
                    ddlBD.DataValueField = "SpecializationId";
                    ddlBD.DataTextField = "DegreeName";
                    ddlBD.DataBind();

                    ddlBD.Items.Insert(Convert.ToInt32(ddlBD.Items.Count), new ListItem("----Other----", ""));
                    ddlBD.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with BachelorDegree_Table of Database
        /// </summary>
        private void BindDropDownDualBachelorDegree()
        {
            try
            {
                degreeId = 4;
                DataSet dsDegreeDetails = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get Dual Bachelor Degree details
                dsDegreeDetails = educationalDetails.GetDegreeDetailsBAL(degreeId);
                if (dsDegreeDetails != null)
                {
                    ddlDualBD.DataSource = dsDegreeDetails;
                    ddlDualBD.DataValueField = "SpecializationId";
                    ddlDualBD.DataTextField = "DegreeName";
                    ddlDualBD.DataBind();

                    ddlDualBD.Items.Insert(Convert.ToInt32(ddlDualBD.Items.Count), new ListItem("----Other----", ""));
                    ddlDualBD.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with PostGraduateDiploma_Table of Database
        /// </summary>
        private void BindDropDownPostGraduateDiploma()
        {
            try
            {
                degreeId = 5;
                DataSet dsDegreeDetails = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get Post Graduate Diploma details
                dsDegreeDetails = educationalDetails.GetDegreeDetailsBAL(degreeId);
                if (dsDegreeDetails != null)
                {
                    ddlPgd.DataSource = dsDegreeDetails;
                    ddlPgd.DataValueField = "SpecializationId";
                    ddlPgd.DataTextField = "DegreeName";
                    ddlPgd.DataBind();

                    ddlPgd.Items.Insert(Convert.ToInt32(ddlPgd.Items.Count), new ListItem("----Other----", ""));
                    ddlPgd.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with MasterDegree_Table of Database
        /// </summary>
        private void BindDropDownMasterDegree()
        {
           try
            {
                degreeId = 6;
                DataSet dsDegreeDetails = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get Master Degree details
                dsDegreeDetails = educationalDetails.GetDegreeDetailsBAL(degreeId);
                if (dsDegreeDetails != null)
                {
                    ddlMD.DataSource = dsDegreeDetails;
                    ddlMD.DataValueField = "SpecializationId";
                    ddlMD.DataTextField = "DegreeName";
                    ddlMD.DataBind();

                    ddlMD.Items.Insert(Convert.ToInt32(ddlMD.Items.Count), new ListItem("----Other----", ""));
                    ddlMD.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with MasterDegree_Table of Database
        /// </summary>
        private void BindDropDownDualMasterDegree()
        {
            try
            {
                degreeId = 6;
                DataSet dsDegreeDetails = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get Dual Master Degree details
                dsDegreeDetails = educationalDetails.GetDegreeDetailsBAL(degreeId);
                if (dsDegreeDetails != null)
                {
                    ddlDualMD.DataSource = dsDegreeDetails;
                    ddlDualMD.DataValueField = "SpecializationId";
                    ddlDualMD.DataTextField = "DegreeName";
                    ddlDualMD.DataBind();

                    ddlDualMD.Items.Insert(Convert.ToInt32(ddlDualMD.Items.Count), new ListItem("----Other----", ""));
                    ddlDualMD.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with DoctorOfPhilosophy_Table of Database
        /// </summary>
        private void BindDropDownDoctorOfPhilosophy()
        {
            try
            {
                degreeId = 7;
                DataSet dsDegreeDetails = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get Doctor Of Philosophy details
                dsDegreeDetails = educationalDetails.GetDegreeDetailsBAL(degreeId);
                if (dsDegreeDetails != null)
                {
                    ddlPHD.DataSource = dsDegreeDetails;
                    ddlPHD.DataValueField = "SpecializationId";
                    ddlPHD.DataTextField = "DegreeName";
                    ddlPHD.DataBind();

                    ddlPHD.Items.Insert(Convert.ToInt32(ddlPHD.Items.Count), new ListItem("----Other----", ""));
                    ddlPHD.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }
        /// <summary>
        ///ddlDip_SelectedIndexChanged for checking the index of DropDown
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlDip_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Checking item of dropdown
                if (ddlDip.SelectedItem.ToString() == "----Other----")
                {
                    txtDipAdd.Visible = true;
                    btnDipAdd.Visible = true;
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        ///ddlBD_SelectedIndexChanged for checking the index of DropDown
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlBD.SelectedItem.ToString() == "----Other----")
                {
                    txtBDAdd.Visible = true;
                    btnBDAdd.Visible = true;
                }
                // Checking item of dropdown
                if (ddlDualBD.SelectedItem.ToString() == "----Other----")
                {
                    txtDualBDAdd.Visible = true;
                    btnDualBDAdd.Visible = true;
                }
            }
            catch (Exception)
            {
                // throw;
            }
            // Checking item of dropdown
        }

        /// <summary>
        ///ddlPgd_SelectedIndexChanged for checking the index of DropDown
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlPgd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Checking item of dropdown
                if (ddlPgd.SelectedItem.ToString() == "----Other----")
                {
                    txtPgdAdd.Visible = true;
                    btnPgdAdd.Visible = true;
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        ///ddlMD_SelectedIndexChanged for checking the index of DropDown
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlMD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Checking item of dropdown
                if (ddlMD.SelectedItem.ToString() == "----Other----")
                {
                    txtMDAdd.Visible = true;
                    btnMDAdd.Visible = true;
                }
                // Checking item of dropdown
                if (ddlDualMD.SelectedItem.ToString() == "----Other----")
                {
                    txtDualMDAdd.Visible = true;
                    btnDualMDAdd.Visible = true;
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        ///ddlPHD_SelectedIndexChanged for checking the index of DropDown
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlPHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Checking item of dropdown
                if (ddlPHD.SelectedItem.ToString() == "----Other----")
                {
                    txtPHDAdd.Visible = true;
                    btnPHDAdd.Visible = true;
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        ///Adding new Under Graduate Diploma in database
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">the<see cref="EventArgs"/>containing event data</param>
        protected void btnDipAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EducationalDetailsEntity educationalDetailsEntity = new EducationalDetailsEntity();
                EducationalDetailsBAL educationalDetailsBAL = new EducationalDetailsBAL();
                // Assign values to entity
                educationalDetailsEntity.AddUnderGraduateDiplomaName = txtDipAdd.Text;
                // Add data to the database
                educationalDetailsBAL.AddUnderGraduateDiplomaBAL(educationalDetailsEntity);
                BindDropDownUnderGraduateDiploma();
                txtDipAdd.Visible = false;
                btnDipAdd.Visible = false;
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        ///Adding new Bachelor Degree in database
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">the<see cref="EventArgs"/>containing event data</param>
        protected void btnBDAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EducationalDetailsEntity educationalDetailsEntity = new EducationalDetailsEntity();
                EducationalDetailsBAL educationalDetailsBAL = new EducationalDetailsBAL();
                // Assign values to entity
                educationalDetailsEntity.AddBachelorDegreeName = txtBDAdd.Text;
                // Add data to the database
                educationalDetailsBAL.AddBachelorDegreeBAL(educationalDetailsEntity);
                BindDropDownBachelorDegree();
                txtBDAdd.Visible = false;
                btnBDAdd.Visible = false;
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        /// <summary>
        ///Adding new Post Graduate Diploma in database
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">the<see cref="EventArgs"/>containing event data</param>
        protected void btnPgdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EducationalDetailsEntity educationalDetailsEntity = new EducationalDetailsEntity();
                EducationalDetailsBAL educationalDetailsBAL = new EducationalDetailsBAL();
                // Assign values to entity
                educationalDetailsEntity.AddPostGraduateDiplomaName = txtPgdAdd.Text;
                // Add data to the database
                educationalDetailsBAL.AddPostGraduateDiplomaBAL(educationalDetailsEntity);
                BindDropDownPostGraduateDiploma();
                txtPgdAdd.Visible = false;
                btnPgdAdd.Visible = false;
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        ///Adding new Master Degree in database
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">the<see cref="EventArgs"/>containing event data</param>
        protected void btnMDAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EducationalDetailsEntity educationalDetailsEntity = new EducationalDetailsEntity();
                EducationalDetailsBAL educationalDetailsBAL = new EducationalDetailsBAL();
                // Assign values to entity
                educationalDetailsEntity.AddMasterDegreeName = txtMDAdd.Text;
                // Add data to the database
                educationalDetailsBAL.AddMasterDegreeBAL(educationalDetailsEntity);
                BindDropDownMasterDegree();
                txtMDAdd.Visible = false;
                btnMDAdd.Visible = false;
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        ///Adding new Doctor Of Philosophy in database
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">the<see cref="EventArgs"/>containing event data</param>
        protected void btnPHDAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EducationalDetailsEntity educationalDetailsEntity = new EducationalDetailsEntity();
                EducationalDetailsBAL educationalDetailsBAL = new EducationalDetailsBAL();
                // Assign values to entity
                educationalDetailsEntity.AddPHDName = txtPHDAdd.Text;
                // Add data to the database
                educationalDetailsBAL.AddPHDBAL(educationalDetailsEntity);
                BindDropDownDoctorOfPhilosophy();
                txtPHDAdd.Visible = false;
                btnPHDAdd.Visible = false;
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private static int cnt = 0;

        protected void btnDualBD_Click(object sender, EventArgs e)
        {
            cnt++;
            if (cnt % 2 != 0)
            {
                btnDualBD.Text = "Hide Dual Bachelors Degree Details";
                pnlCollapsableDualBD.Visible = true;
            }
            if (cnt % 2 == 0)
            {
                btnDualBD.Text = "Add Dual Bachelors Degree Details";
                pnlCollapsableDualBD.Visible = false;
            }
        }

        protected void btnDualMD_Click(object sender, EventArgs e)
        {
            cnt++;
            if (cnt % 2 != 0)
            {
                btnDualMD.Text = "Hide Dual Master Degree Details";
                pnlCollapsableDualMD.Visible = true;
            }
            if (cnt % 2 == 0)
            {
                btnDualMD.Text = "Add Dual Master Degree Details";
                pnlCollapsableDualMD.Visible = false;
            }
        }
    }
}