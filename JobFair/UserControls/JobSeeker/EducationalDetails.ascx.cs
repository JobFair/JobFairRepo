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
        private bool isAddNewEducation = false;
        private int degreeId = 4;

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
                    //degreeId =Convert.ToInt32(Request.QueryString["dId"]);
                    if (!IsPostBack)
                    {
                        try
                        {
                            BindAllEducationalDetails();
                            
                            if (isEdit)
                            {
                                BindEducationalDetails();
                            }
                            if (isAddNewEducation)
                            {
                               // BtnAddNewEducation_Click(sender,e);
                            }
                        }
                        catch (Exception)
                        {
                             throw;
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

        private void BindEducationalDetails()
        {
            try
            {
                //List<EducationalDetailsEntity> educationDetailsList = new List<EducationalDetailsEntity>();
                educationalDetails = new EducationalDetailsBAL();
                // Get only selected checkboxes list
                //var selectedDegreeTypes = chkList.Items.Cast<ListItem>().Where(li => li.Selected).ToList();

                // Get only selected checkboxes list
                //var selectedDegreeTypes = chkList.Items.Cast<ListItem>().Where(li => li.Selected).ToList();

                DataSet dsEducationalDetails = new DataSet();

                dsEducationalDetails = educationalDetails.ViewEducationalDetailsBAL(candidateId);
                if (dsEducationalDetails != null)
                {
                   // var listofDegrees = Convert.ToString(degreeIdS);
                   // foreach (var list in listofDegrees)
                   // for (; ; degreeIdS++)
                    {
                        switch (degreeId)
                        {
                            case 1://"SSC / 10th"
                                pnlEducatioList.Visible = false;
                                footer.Visible = false;
                                pnlCollapsableSSC.Visible = true;
                                EducationalDetailsEntity sscDetails = new EducationalDetailsEntity();
                                sscDetails.CandidateId = candidateId;
                                //ddlHQ.SelectedItem.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["HighestQualificationId"]);
                                //dsEducationalDetails = educationalDetails.UpdateEducationalDetailsBAL(CandidateId);
                                sscDetails.DegreeId = Convert.ToInt32(degreeId); ;
                               // txtSSCMedium.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["MediumOfEducation"]);
                                //txtSSCMedium.Text = (from DataRow row in dsEducationalDetails.Tables[0].Rows from ["MediumOfEducation"] in row.MediumOfEducation where degreeId == "1" select row);
                                txtSSCMedium.Text = Convert.ToString(dsEducationalDetails.Tables[0].DefaultView.RowFilter = "(Select MediumOfEducation  where degreeId == 1);");
                                string sscStatus = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Status"]);
                                rblSSCStat.Items.FindByValue(sscStatus).Selected = true;
                                sscDetails.Specialization = "Null";

                                string sscFromYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]); ;
                                string[] sscFromYearSplit = sscFromYear.Split(new char[] { '/' });
                                int countssc = 0;
                                foreach (string Word in sscFromYearSplit)
                                {
                                    countssc += 1;
                                    if (countssc == 1)
                                    { ddlSSCMonthFrom.SelectedValue = Word; }
                                    if (countssc == 2)
                                    { ddlSSCYearFrom.SelectedValue = Word; }
                                }

                                string sscToYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]); ;
                                string[] sscToYearSplit = sscToYear.Split(new char[] { '/' });
                                countssc = 0;
                                foreach (string Word in sscToYearSplit)
                                {
                                    countssc += 1;
                                    if (countssc == 1)
                                    { ddlSSCMonthTo.SelectedValue = Word; }
                                    if (countssc == 2)
                                    { ddlSSCYearTo.SelectedValue = Word; }
                                }

                                //ddlSSCMonthFrom.SelectedItem.Text + ddlSSCYearFrom.SelectedItem.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]);
                                //ddlSSCMonthTo.Text + ddlSSCYearTo.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]);
                                txtSSCSchool.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["College"]);
                                txtSSCBoard.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["University"]);
                                txtSSCPercentage.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Percantage"]);
                                // Add object to the education details collection
                                //educationDetailsList.Add(sscDetails);
                                btnSSCUpdate.Visible = true;
                                //goto default;
                                break;

                            case 2://"HSC / 12th"
                                pnlEducatioList.Visible = false;
                                footer.Visible = false;
                                pnlCollapsableHSC.Visible = true;
                                EducationalDetailsEntity hscDetails = new EducationalDetailsEntity();
                                hscDetails.CandidateId = candidateId;
                                hscDetails.DegreeId = Convert.ToInt32(degreeId);
                                txtHSCMedium.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["MediumOfEducation"]);
                                string hscStatus = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Status"]);
                                rblHSCStat.Items.FindByValue(hscStatus).Selected = true;
                                ddlHSC.SelectedItem.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Specialization"]);

                                string hscFromYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]); ;
                                string[] hscFromYearSplit = hscFromYear.Split(new char[] { '/' });
                                int counthsc = 0;
                                foreach (string Word in hscFromYearSplit)
                                {
                                    counthsc += 1;
                                    if (counthsc == 1)
                                    { ddlHSCMonthFrom.SelectedValue = Word; }
                                    if (counthsc == 2)
                                    { ddlHSCYearFrom.SelectedValue = Word; }
                                }

                                string hscToYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]); ;
                                string[] hscToYearSplit = hscToYear.Split(new char[] { '/' });
                                counthsc = 0;
                                foreach (string Word in hscToYearSplit)
                                {
                                    counthsc += 1;
                                    if (counthsc == 1)
                                    { ddlHSCMonthTo.SelectedValue = Word; }
                                    if (counthsc == 2)
                                    { ddlHSCYearTo.SelectedValue = Word; }
                                }

                                //ddlHSCMonthFrom.Text + ddlHSCYearFrom.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]);
                                //ddlHSCMonthTo.Text + ddlHSCYearTo.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]);
                                txtHSCCollege.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["College"]);
                                txtHSCBoard.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["University"]);
                                txtHSCPercentage.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Percantage"]);
                                // Add object to the education details collection
                                //educationDetailsList.Add(hscDetails);
                                btnHSCUpdate.Visible = true;
                                break;

                            case 3://"UG Diploma"
                                pnlEducatioList.Visible = false;
                                footer.Visible = false;
                                pnlCollapsableDip.Visible = true;
                                EducationalDetailsEntity ugDiplomaDetails = new EducationalDetailsEntity();
                                ugDiplomaDetails.CandidateId = candidateId;
                                ugDiplomaDetails.DegreeId = Convert.ToInt32(degreeId);
                                txtDipMedium.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["MediumOfEducation"]);
                                string ugdStatus = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Status"]);
                                rblDipStat.Items.FindByValue(ugdStatus).Selected = true;
                                ddlDip.SelectedItem.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Specialization"]);

                                string ugdFromYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]); ;
                                string[] ugdFromYearSplit = ugdFromYear.Split(new char[] { '/' });
                                int countugd = 0;
                                foreach (string Word in ugdFromYearSplit)
                                {
                                    countugd += 1;
                                    if (countugd == 1)
                                    { ddlDipMonthFrom.SelectedValue = Word; }
                                    if (countugd == 2)
                                    { ddlDipYearFrom.SelectedValue = Word; }
                                }

                                string ugdToYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]); ;
                                string[] ugdToYearSplit = ugdToYear.Split(new char[] { '/' });
                                countugd = 0;
                                foreach (string Word in ugdToYearSplit)
                                {
                                    countugd += 1;
                                    if (countugd == 1)
                                    { ddlDipMonthTo.SelectedValue = Word; }
                                    if (countugd == 2)
                                    { ddlDipYearTo.SelectedValue = Word; }
                                }

                                //ddlDipMonthFrom.Text + ddlDipYearFrom.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]);
                                //ddlDipMonthTo.Text + ddlDipYearTo.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]);
                                txtDipCollege.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["College"]);
                                txtDipUniversity.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["University"]);
                                txtDipPercentage.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Percantage"]);
                                // Add object to the education details collection
                                //educationDetailsList.Add(ugDiplomaDetails);
                                btnDipUpdate.Visible = true;
                                break;

                            case 4://"Bachelors Degree"
                                pnlEducatioList.Visible = false;
                                footer.Visible = false;
                                pnlCollapsableBD.Visible = true;
                                EducationalDetailsEntity bachelorDegreeDetails = new EducationalDetailsEntity();
                                bachelorDegreeDetails.CandidateId = candidateId;
                                bachelorDegreeDetails.DegreeId = Convert.ToInt32(degreeId);
                                txtBDMedium.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["MediumOfEducation"]);
                               // txtBDMedium.Text = Convert.ToString(dsEducationalDetails.Tables[0].DefaultView.RowFilter = "(Select MediumOfEducation where degreeId == 4);");
                                string bdStatus = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Status"]);
                                rblBDStat.Items.FindByValue(bdStatus).Selected = true;
                                ddlBD.SelectedValue = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["SpecializationId"]);

                                string bdFromYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]); ;
                                string[] bdFromYearSplit = bdFromYear.Split(new char[] { '/' });
                                int countbd = 0;
                                foreach (string Word in bdFromYearSplit)
                                {
                                    countbd += 1;
                                    if (countbd == 1)
                                    { ddlBDMonthFrom.SelectedValue = Word; }
                                    if (countbd == 2)
                                    { ddlBDYearFrom.SelectedValue = Word; }
                                }

                                string bdToYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]); ;
                                string[] bdToYearSplit = bdToYear.Split(new char[] { '/' });
                                countbd = 0;
                                foreach (string Word in bdToYearSplit)
                                {
                                    countbd += 1;
                                    if (countbd == 1)
                                    { ddlBDMonthTo.SelectedValue = Word; }
                                    if (countbd == 2)
                                    { ddlBDYearTo.SelectedValue = Word; }
                                }

                                //ddlBDMonthFrom.Text + ddlBDYearFrom.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]);
                                //ddlBDMonthTo.Text + ddlBDYearTo.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]);
                                txtBDCollege.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["College"]);
                                txtBDUniversity.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["University"]);
                                txtBDPercentage.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Percantage"]);
                                btnBDUpdate.Visible = true;
                                // Add object to the education details collection
                                //educationDetailsList.Add(bachelorDegreeDetails);
                                // functionality for adding records for Dual Bachelore Degree
                                if (degreeId == 4)
                                {
                                    pnlCollapsableDualBD.Visible = true;
                                    EducationalDetailsEntity dualBachelorDegreeDetails = new EducationalDetailsEntity();
                                    dualBachelorDegreeDetails.CandidateId = candidateId;
                                    dualBachelorDegreeDetails.DegreeId = Convert.ToInt32(degreeId);
                                    txtDualBDMedium.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["MediumOfEducation"]);
                                    string dualbdStatus = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Status"]);
                                    rblDualBDStat.Items.FindByValue(dualbdStatus).Selected = true;
                                    ddlDualBD.SelectedValue = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["SpecializationId"]);

                                    string dualbdFromYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]); ;
                                    string[] dualbdFromYearSplit = dualbdFromYear.Split(new char[] { '/' });
                                    int countdualbd = 0;
                                    foreach (string Word in dualbdFromYearSplit)
                                    {
                                        countdualbd += 1;
                                        if (countdualbd == 1)
                                        { ddlDualBDMonthFrom.SelectedValue = Word; }
                                        if (countdualbd == 2)
                                        { ddlDualBDYearFrom.SelectedValue = Word; }
                                    }

                                    string dualbdToYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]); ;
                                    string[] dualbdToYearSplit = dualbdToYear.Split(new char[] { '/' });
                                    countdualbd = 0;
                                    foreach (string Word in dualbdToYearSplit)
                                    {
                                        countdualbd += 1;
                                        if (countdualbd == 1)
                                        { ddlDualBDMonthTo.SelectedValue = Word; }
                                        if (countdualbd == 2)
                                        { ddlDualBDYearTo.SelectedValue = Word; }
                                    }

                                    //ddlDualBDMonthFrom.Text + ddlDualBDYearFrom.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]);
                                    //ddlDualBDMonthTo.Text + ddlDualBDYearTo.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]);
                                    txtDualBDCollege.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["College"]);
                                    txtDualBDUniversity.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["University"]);
                                    txtDualBDPercentage.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Percantage"]);
                                    // Add object to the education details collection
                                    //educationDetailsList.Add(dualBachelorDegreeDetails);
                                    btnDualBD.Visible = false;
                                    btnBDUpdate.Visible = true;
                                }
                                break;

                            case 5://"PG Diploma"
                                pnlEducatioList.Visible = false;
                                footer.Visible = false;
                                pnlCollapsablePgd.Visible = true;
                                EducationalDetailsEntity pgDiplomaDetails = new EducationalDetailsEntity();
                                pgDiplomaDetails.CandidateId = candidateId;
                                pgDiplomaDetails.DegreeId = Convert.ToInt32(degreeId);
                                txtPgdMedium.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["MediumOfEducation"]);
                                string pgdStatus = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Status"]);
                                rblPgdStat.Items.FindByValue(pgdStatus).Selected = true;
                                ddlPgd.SelectedItem.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Specialization"]);

                                string pgdFromYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]); ;
                                string[] pgdFromYearSplit = pgdFromYear.Split(new char[] { '/' });
                                int countpgd = 0;
                                foreach (string Word in pgdFromYearSplit)
                                {
                                    countpgd += 1;
                                    if (countpgd == 1)
                                    { ddlPgdMonthFrom.SelectedValue = Word; }
                                    if (countpgd == 2)
                                    { ddlPgdYearFrom.SelectedValue = Word; }
                                }

                                string pgdToYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]); ;
                                string[] pgdToYearSplit = pgdToYear.Split(new char[] { '/' });
                                countpgd = 0;
                                foreach (string Word in pgdToYearSplit)
                                {
                                    countpgd += 1;
                                    if (countpgd == 1)
                                    { ddlPgdMonthTo.SelectedValue = Word; }
                                    if (countpgd == 2)
                                    { ddlPgdYearTo.SelectedValue = Word; }
                                }

                                //ddlPgdMonthFrom.Text + ddlPgdYearFrom.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]);
                                //ddlPgdMonthTo.Text + ddlPgdYearTo.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]);
                                txtPgdCollege.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["College"]);
                                txtPgdUniversity.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["University"]);
                                txtPgdPercentage.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Percantage"]);
                                // Add object to the education details collection
                                //educationDetailsList.Add(pgDiplomaDetails);
                                btnPgdUpdate.Visible = true;
                                break;

                            case 6://"Masters Degree"
                                pnlEducatioList.Visible = false;
                                footer.Visible = false;
                                pnlCollapsableMD.Visible = true;
                                EducationalDetailsEntity masterDegreeDetails = new EducationalDetailsEntity();
                                masterDegreeDetails.CandidateId = candidateId;
                                masterDegreeDetails.DegreeId = Convert.ToInt32(degreeId);
                                txtMDMedium.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["MediumOfEducation"]);
                                string mdStatus = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Status"]);
                                rblMDStat.Items.FindByValue(mdStatus).Selected = true;
                                ddlMD.SelectedItem.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Specialization"]);

                                string mdFromYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]); ;
                                string[] mdFromYearSplit = mdFromYear.Split(new char[] { '/' });
                                int countmd = 0;
                                foreach (string Word in mdFromYearSplit)
                                {
                                    countmd += 1;
                                    if (countmd == 1)
                                    { ddlMDMonthFrom.SelectedValue = Word; }
                                    if (countmd == 2)
                                    { ddlMDYearFrom.SelectedValue = Word; }
                                }

                                string mdToYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]); ;
                                string[] mdToYearSplit = mdToYear.Split(new char[] { '/' });
                                countmd = 0;
                                foreach (string Word in mdToYearSplit)
                                {
                                    countmd += 1;
                                    if (countmd == 1)
                                    { ddlMDMonthTo.SelectedValue = Word; }
                                    if (countmd == 2)
                                    { ddlMDYearTo.SelectedValue = Word; }
                                }

                                //ddlMDMonthFrom.Text + ddlMDYearFrom.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]);
                                //ddlMDMonthTo.Text + ddlMDYearTo.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]);
                                txtMDCollege.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["College"]);
                                txtMDUniversity.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["University"]);
                                txtMDPercentage.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Percantage"]);
                                btnMDUpdate.Visible = true;
                                // Add object to the education details collection
                                //educationDetailsList.Add(masterDegreeDetails);
                                // functionality for adding records for Dual Master Degree
                                if (degreeId == 6)
                                {
                                    EducationalDetailsEntity dualMasterDegreeDetails = new EducationalDetailsEntity();
                                    dualMasterDegreeDetails.CandidateId = candidateId;
                                    dualMasterDegreeDetails.DegreeId = Convert.ToInt32(degreeId);
                                    txtDualMDMedium.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["MediumOfEducation"]);
                                    string dualmdStatus = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Status"]);
                                    rblDualMDStat.Items.FindByValue(dualmdStatus).Selected = true;
                                    ddlDualMD.SelectedItem.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Specialization"]);

                                    string dualmdFromYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]); ;
                                    string[] dualmdFromYearSplit = dualmdFromYear.Split(new char[] { '/' });
                                    int countdualmd = 0;
                                    foreach (string Word in dualmdFromYearSplit)
                                    {
                                        countdualmd += 1;
                                        if (countdualmd == 1)
                                        { ddlDualMDMonthFrom.SelectedValue = Word; }
                                        if (countdualmd == 2)
                                        { ddlDualMDYearFrom.SelectedValue = Word; }
                                    }

                                    string dualmdToYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]); ;
                                    string[] dualmdToYearSplit = dualmdToYear.Split(new char[] { '/' });
                                    countdualmd = 0;
                                    foreach (string Word in dualmdToYearSplit)
                                    {
                                        countdualmd += 1;
                                        if (countdualmd == 1)
                                        { ddlDualMDMonthTo.SelectedValue = Word; }
                                        if (countdualmd == 2)
                                        { ddlDualMDYearTo.SelectedValue = Word; }
                                    }

                                    //ddlDualMDMonthFrom.Text + ddlDualMDYearFrom.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]);
                                    //ddlDualMDMonthTo.Text + ddlDualMDYearTo.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]);
                                    txtDualMDCollege.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["College"]);
                                    txtDualMDUniversity.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["University"]);
                                    txtDualMDPercentage.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Percantage"]);
                                    // Add object to the education details collection
                                    //educationDetailsList.Add(dualMasterDegreeDetails);
                                    btnDualMD.Visible = false;
                                    btnDualMDUpdate.Visible = true;
                                }
                                break;

                            case 7://"Doctorate/ PHD Degree"
                                pnlEducatioList.Visible = false;
                                footer.Visible = false;
                                pnlCollapsablePHD.Visible = true;
                                EducationalDetailsEntity phdDetails = new EducationalDetailsEntity();
                                phdDetails.CandidateId = candidateId;
                                phdDetails.DegreeId = Convert.ToInt32(degreeId);
                                txtPHDMedium.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["MediumOfEducation"]);
                                string phdStatus = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Status"]);
                                rblPHDStat.Items.FindByValue(phdStatus).Selected = true;
                                ddlPHD.SelectedItem.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Specialization"]);

                                string phdFromYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]); ;
                                string[] phdFromYearSplit = phdFromYear.Split(new char[] { '/' });
                                int countphd = 0;
                                foreach (string Word in phdFromYearSplit)
                                {
                                    countphd += 1;
                                    if (countphd == 1)
                                    { ddlPHDMonthFrom.SelectedValue = Word; }
                                    if (countphd == 2)
                                    { ddlPHDYearFrom.SelectedValue = Word; }
                                }

                                string phdToYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]); ;
                                string[] phdToYearSplit = phdToYear.Split(new char[] { '/' });
                                countphd = 0;
                                foreach (string Word in phdToYearSplit)
                                {
                                    countphd += 1;
                                    if (countphd == 1)
                                    { ddlPHDMonthTo.SelectedValue = Word; }
                                    if (countphd == 2)
                                    { ddlPHDYearTo.SelectedValue = Word; }
                                }

                                //ddlPHDMonthFrom.Text + ddlPHDYearFrom.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]);
                                //ddlPHDMonthTo.Text + ddlPHDYearTo.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]);
                                txtPHDCollege.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["College"]);
                                txtPHDUniversity.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["University"]);
                                txtPHDPercentage.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Percantage"]);
                                // Add object to the education details collection
                                //educationDetailsList.Add(phdDetails);
                                btnPHDUpdate.Visible = true;
                                break;

                            //default:
                               // BtnAddNewEducation.Visible = true;
                              //  break;
                        }
                    }
                }
                //foreach (var item in selectedDegreeTypes)
            }
            catch (Exception)
            {
                 throw;
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
                 throw;
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
                 throw;
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
                  throw;
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
                 throw;
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
                  throw;
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
                 throw;
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
                 throw;
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
                 throw;
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
                 throw;
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
                 throw;
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
                 throw;
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
                 throw;
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
                 throw;
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
                 throw;
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
                 throw;
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
                 throw;
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
                 throw;
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
                 throw;
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
                  throw;
            }
        }

        protected void btnSSCUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                EducationalDetailsBAL educationalDetails = new EducationalDetailsBAL();
                EducationalDetailsEntity sscDetails = new EducationalDetailsEntity();
                sscDetails.CandidateId = candidateId;
                sscDetails.DegreeId = Convert.ToInt32(degreeId); ;
                sscDetails.MediumOfEducation = txtSSCMedium.Text.Trim();
                sscDetails.Specialization = "Null";
                sscDetails.Status = rblSSCStat.SelectedValue.Trim();
                sscDetails.FromYear = ddlSSCMonthFrom.Text + '/' + ddlSSCYearFrom.Text;
                sscDetails.ToYear = ddlSSCMonthTo.Text + '/' + ddlSSCYearTo.Text;
                sscDetails.College = txtSSCSchool.Text.Trim();
                sscDetails.University = txtSSCBoard.Text.Trim();
                sscDetails.Percantage = txtSSCPercentage.Text.Trim();
                // Add object to the update education details
                educationalDetails.UpdateEducationalDetailsBAL(sscDetails);
            }
            catch (Exception)
            {
                 throw;
            }
        }

        protected void btnHSCUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                EducationalDetailsEntity hscDetails = new EducationalDetailsEntity();
                hscDetails.CandidateId = candidateId;
                hscDetails.DegreeId = Convert.ToInt32(degreeId);
                hscDetails.MediumOfEducation = txtHSCMedium.Text.Trim();
                hscDetails.Specialization = ddlHSC.SelectedValue.Trim();
                hscDetails.Status = rblHSCStat.SelectedValue.Trim();
                hscDetails.FromYear = ddlHSCMonthFrom.Text + '/' + ddlHSCYearFrom.Text;
                hscDetails.ToYear = ddlHSCMonthTo.Text + '/' + ddlHSCYearTo.Text;
                hscDetails.College = txtHSCCollege.Text.Trim();
                hscDetails.University = txtHSCBoard.Text.Trim();
                hscDetails.Percantage = txtHSCPercentage.Text.Trim();
                // Add object to the update education details
                educationalDetails.UpdateEducationalDetailsBAL(hscDetails);
            }
            catch (Exception)
            {
                 throw;
            }
        }

        protected void btnDipUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                EducationalDetailsEntity ugDiplomaDetails = new EducationalDetailsEntity();
                ugDiplomaDetails.CandidateId = candidateId;
                ugDiplomaDetails.DegreeId = Convert.ToInt32(degreeId);
                ugDiplomaDetails.MediumOfEducation = txtDipMedium.Text.Trim();
                ugDiplomaDetails.Specialization = ddlDip.SelectedValue.Trim();
                ugDiplomaDetails.Status = rblDipStat.SelectedValue.Trim();
                ugDiplomaDetails.FromYear = ddlDipMonthFrom.Text + '/' + ddlDipYearFrom.Text;
                ugDiplomaDetails.ToYear = ddlDipMonthTo.Text + '/' + ddlDipYearTo.Text;
                ugDiplomaDetails.College = txtDipCollege.Text.Trim();
                ugDiplomaDetails.University = txtDipUniversity.Text.Trim();
                ugDiplomaDetails.Percantage = txtDipPercentage.Text.Trim();
                // Add object to the update education details
                educationalDetails.UpdateEducationalDetailsBAL(ugDiplomaDetails);
            }
            catch (Exception)
            {
                 throw;
            }
        }

        protected void btnBDUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                EducationalDetailsEntity bachelorDegreeDetails = new EducationalDetailsEntity();
                bachelorDegreeDetails.CandidateId = candidateId;
                bachelorDegreeDetails.DegreeId = Convert.ToInt32(degreeId);
                bachelorDegreeDetails.MediumOfEducation = txtBDMedium.Text.Trim();
                bachelorDegreeDetails.Status = rblBDStat.SelectedValue.Trim();
                bachelorDegreeDetails.Specialization = ddlBD.SelectedValue.Trim();
                bachelorDegreeDetails.FromYear = ddlBDMonthFrom.Text + '/' + ddlBDYearFrom.Text;
                bachelorDegreeDetails.ToYear = ddlBDMonthTo.Text + '/' + ddlBDYearTo.Text;
                bachelorDegreeDetails.College = txtBDCollege.Text.Trim();
                bachelorDegreeDetails.University = txtBDUniversity.Text.Trim();
                bachelorDegreeDetails.Percantage = txtBDPercentage.Text.Trim();
                // Add object to the update education details
                educationalDetails.UpdateEducationalDetailsBAL(bachelorDegreeDetails);
                // functionality for updating records for Dual Bachelore Degree
                if (pnlCollapsableDualBD.Visible == true)
                {
                    EducationalDetailsEntity dualBachelorDegreeDetails = new EducationalDetailsEntity();
                    dualBachelorDegreeDetails.CandidateId = candidateId;
                    dualBachelorDegreeDetails.DegreeId = Convert.ToInt32(degreeId);
                    dualBachelorDegreeDetails.MediumOfEducation = txtDualBDMedium.Text.Trim();
                    dualBachelorDegreeDetails.Status = rblDualBDStat.SelectedValue.Trim();
                    dualBachelorDegreeDetails.Specialization = ddlDualBD.SelectedValue.Trim();
                    dualBachelorDegreeDetails.FromYear = ddlDualBDMonthFrom.Text + '/' + ddlDualBDYearFrom.Text;
                    dualBachelorDegreeDetails.ToYear = ddlDualBDMonthTo.Text + '/' + ddlDualBDYearTo.Text;
                    dualBachelorDegreeDetails.College = txtDualBDCollege.Text.Trim();
                    dualBachelorDegreeDetails.University = txtDualBDUniversity.Text.Trim();
                    dualBachelorDegreeDetails.Percantage = txtDualBDPercentage.Text.Trim();
                    // Add object to the update education details
                    educationalDetails.UpdateEducationalDetailsBAL(dualBachelorDegreeDetails);
                }
            }
            catch (Exception)
            {
                 throw;
            }
        }


        protected void btnDualBDUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (pnlCollapsableDualBD.Visible == true)
                {
                    EducationalDetailsEntity dualBachelorDegreeDetails = new EducationalDetailsEntity();
                    dualBachelorDegreeDetails.CandidateId = candidateId;
                    dualBachelorDegreeDetails.DegreeId = Convert.ToInt32(degreeId);
                    dualBachelorDegreeDetails.MediumOfEducation = txtDualBDMedium.Text.Trim();
                    dualBachelorDegreeDetails.Status = rblDualBDStat.SelectedValue.Trim();
                    dualBachelorDegreeDetails.Specialization = ddlDualBD.SelectedValue.Trim();
                    dualBachelorDegreeDetails.FromYear = ddlDualBDMonthFrom.Text + '/' + ddlDualBDYearFrom.Text;
                    dualBachelorDegreeDetails.ToYear = ddlDualBDMonthTo.Text + '/' + ddlDualBDYearTo.Text;
                    dualBachelorDegreeDetails.College = txtDualBDCollege.Text.Trim();
                    dualBachelorDegreeDetails.University = txtDualBDUniversity.Text.Trim();
                    dualBachelorDegreeDetails.Percantage = txtDualBDPercentage.Text.Trim();
                    // Add object to the update education details
                    educationalDetails.UpdateEducationalDetailsBAL(dualBachelorDegreeDetails);
                }
            }
            catch (Exception)
            {
                 throw;
            }
        }


        protected void btnPgdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                EducationalDetailsEntity pgDiplomaDetails = new EducationalDetailsEntity();
                pgDiplomaDetails.CandidateId = candidateId;
                pgDiplomaDetails.DegreeId = Convert.ToInt32(degreeId);
                pgDiplomaDetails.MediumOfEducation = txtPgdMedium.Text.Trim();
                pgDiplomaDetails.Status = rblPgdStat.SelectedValue.Trim();
                pgDiplomaDetails.Specialization = ddlPgd.SelectedValue.Trim();
                pgDiplomaDetails.FromYear = ddlPgdMonthFrom.Text + '/' + ddlPgdYearFrom.Text;
                pgDiplomaDetails.ToYear = ddlPgdMonthTo.Text + '/' + ddlPgdYearTo.Text;
                pgDiplomaDetails.College = txtPgdCollege.Text.Trim();
                pgDiplomaDetails.University = txtPgdUniversity.Text.Trim();
                pgDiplomaDetails.Percantage = txtPgdPercentage.Text.Trim();
                // Add object to the update education details
                educationalDetails.UpdateEducationalDetailsBAL(pgDiplomaDetails);
            }
            catch (Exception)
            {
                 throw;
            }
        }

        protected void btnMDUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                EducationalDetailsEntity masterDegreeDetails = new EducationalDetailsEntity();
                masterDegreeDetails.CandidateId = candidateId;
                masterDegreeDetails.DegreeId = Convert.ToInt32(degreeId);
                masterDegreeDetails.MediumOfEducation = txtMDMedium.Text.Trim();
                masterDegreeDetails.Specialization = ddlMD.SelectedValue.Trim();
                masterDegreeDetails.Status = rblMDStat.SelectedValue.Trim();
                masterDegreeDetails.FromYear = ddlMDMonthFrom.Text + '/' + ddlMDYearFrom.Text;
                masterDegreeDetails.ToYear = ddlMDMonthTo.Text + '/' + ddlMDYearTo.Text;
                masterDegreeDetails.College = txtMDCollege.Text.Trim();
                masterDegreeDetails.University = txtMDUniversity.Text.Trim();
                masterDegreeDetails.Percantage = txtMDPercentage.Text.Trim();
                // Add object to the update education details
                educationalDetails.UpdateEducationalDetailsBAL(masterDegreeDetails);
                // functionality for updating records for Dual Master Degree
                if (pnlCollapsableDualMD.Visible == true)
                {
                    EducationalDetailsEntity dualMasterDegreeDetails = new EducationalDetailsEntity();
                    dualMasterDegreeDetails.CandidateId = candidateId;
                    dualMasterDegreeDetails.DegreeId = Convert.ToInt32(degreeId);
                    dualMasterDegreeDetails.MediumOfEducation = txtDualMDMedium.Text.Trim();
                    dualMasterDegreeDetails.Specialization = ddlDualMD.SelectedValue.Trim();
                    dualMasterDegreeDetails.Status = rblDualMDStat.SelectedValue.Trim();
                    dualMasterDegreeDetails.FromYear = ddlDualMDMonthFrom.Text + '/' + ddlDualMDYearFrom.Text;
                    dualMasterDegreeDetails.ToYear = ddlDualMDMonthTo.Text + '/' + ddlDualMDYearTo.Text;
                    dualMasterDegreeDetails.College = txtDualMDCollege.Text.Trim();
                    dualMasterDegreeDetails.University = txtDualMDUniversity.Text.Trim();
                    dualMasterDegreeDetails.Percantage = txtDualMDPercentage.Text.Trim();
                    // Add object to the update education details
                    educationalDetails.UpdateEducationalDetailsBAL(dualMasterDegreeDetails);
                }
            }
            catch (Exception)
            {
                  throw;
            }
        }

        protected void btnDualMDUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (pnlCollapsableDualMD.Visible == true)
                {
                    EducationalDetailsEntity dualMasterDegreeDetails = new EducationalDetailsEntity();
                    dualMasterDegreeDetails.CandidateId = candidateId;
                    dualMasterDegreeDetails.DegreeId = Convert.ToInt32(degreeId);
                    dualMasterDegreeDetails.MediumOfEducation = txtDualMDMedium.Text.Trim();
                    dualMasterDegreeDetails.Specialization = ddlDualMD.SelectedValue.Trim();
                    dualMasterDegreeDetails.Status = rblDualMDStat.SelectedValue.Trim();
                    dualMasterDegreeDetails.FromYear = ddlDualMDMonthFrom.Text + '/' + ddlDualMDYearFrom.Text;
                    dualMasterDegreeDetails.ToYear = ddlDualMDMonthTo.Text + '/' + ddlDualMDYearTo.Text;
                    dualMasterDegreeDetails.College = txtDualMDCollege.Text.Trim();
                    dualMasterDegreeDetails.University = txtDualMDUniversity.Text.Trim();
                    dualMasterDegreeDetails.Percantage = txtDualMDPercentage.Text.Trim();
                    // Add object to the update education details
                    educationalDetails.UpdateEducationalDetailsBAL(dualMasterDegreeDetails);
                }
            }
            catch (Exception)
            {
                  throw;
            }
        }

        protected void btnPHDUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                EducationalDetailsEntity phdDetails = new EducationalDetailsEntity();
                phdDetails.CandidateId = candidateId;
                phdDetails.DegreeId = Convert.ToInt32(degreeId);
                phdDetails.MediumOfEducation = txtPHDMedium.Text.Trim();
                phdDetails.Specialization = ddlPHD.SelectedValue.Trim();
                phdDetails.Status = rblPHDStat.SelectedValue.Trim();
                phdDetails.FromYear = ddlPHDMonthFrom.Text + '/' + ddlPHDYearFrom.Text;
                phdDetails.ToYear = ddlPHDMonthTo.Text + '/' + ddlPHDYearTo.Text;
                phdDetails.College = txtPHDCollege.Text.Trim();
                phdDetails.University = txtPHDUniversity.Text.Trim();
                phdDetails.Percantage = txtPHDPercentage.Text.Trim();
                // Add object to the update education details
                educationalDetails.UpdateEducationalDetailsBAL(phdDetails);
            }
            catch (Exception)
            {
                 throw;
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
                            sscDetails.Specialization = "Null";
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
                            hscDetails.Specialization = ddlHSC.SelectedValue.Trim();
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
                            ugDiplomaDetails.Specialization = ddlDip.SelectedValue.Trim();
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
                            bachelorDegreeDetails.Specialization = ddlBD.SelectedValue.Trim();
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
                                dualBachelorDegreeDetails.Specialization = ddlDualBD.SelectedValue.Trim();
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
                            pgDiplomaDetails.Specialization = ddlPgd.SelectedValue.Trim();
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
                            masterDegreeDetails.Specialization = ddlMD.SelectedValue.Trim();
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
                                dualMasterDegreeDetails.Specialization = ddlDualMD.SelectedValue.Trim();
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
                            phdDetails.Specialization = ddlPHD.SelectedValue.Trim();
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
                  throw;
            }
        }

        protected void BtnAddNewEducation_Click(object sender, EventArgs e)
        {
            try
            {
                //educationalDetails = new EducationalDetailsBAL();
                //DataSet dsEducationalDetails = new DataSet();
                //dsEducationalDetails = educationalDetails.ViewEducationalDetailsBAL(candidateId);
                //if (dsEducationalDetails != null)
                {
                    isAddNewEducation = true;
                    Response.Redirect("DemoEducationalDetails.aspx?isAddNewEducation=" + isAddNewEducation );
                }
            }
            catch (Exception)
            {
                  throw;
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
                 throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with UnderGraduateDiploma_Table of Database
        /// </summary>
        private void BindDropDownUnderGraduateDiploma()
        {
            try
            {
                DataSet UnderGraduateDiplomaData = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get Under Graduate Diploma details
                UnderGraduateDiplomaData = educationalDetails.GetUnderGraduateDiplomaBAL();
                if (UnderGraduateDiplomaData != null)
                {
                    ddlDip.DataSource = UnderGraduateDiplomaData;
                    ddlDip.DataValueField = "UGDID";
                    ddlDip.DataTextField = "UGDName";
                    ddlDip.DataBind();

                    ddlDip.Items.Insert(Convert.ToInt32(ddlDip.Items[ddlDip.Items.Count - 1].Value), new ListItem("----Other----", ""));
                    ddlDip.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                 throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with BachelorDegree_Table of Database
        /// </summary>
        private void BindDropDownBachelorDegree()
        {
            try
            {
                DataSet BachelorDegreeData = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get Bachelor Degree details
                BachelorDegreeData = educationalDetails.GetBachelorDegreeBAL();
                if (BachelorDegreeData != null)
                {
                    ddlBD.DataSource = BachelorDegreeData;
                    ddlBD.DataValueField = "BDId";
                    ddlBD.DataTextField = "BDName";
                    ddlBD.DataBind();

                    ddlBD.Items.Insert(Convert.ToInt32(ddlBD.Items[ddlBD.Items.Count - 1].Value), new ListItem("----Other----", ""));
                    ddlBD.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                 throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with BachelorDegree_Table of Database
        /// </summary>
        private void BindDropDownDualBachelorDegree()
        {
            try
            {
                DataSet DualBachelorDegreeData = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get Bachelor Degree details
                DualBachelorDegreeData = educationalDetails.GetBachelorDegreeBAL();
                if (DualBachelorDegreeData != null)
                {
                    ddlDualBD.DataSource = DualBachelorDegreeData;
                    ddlDualBD.DataValueField = "BDId";
                    ddlDualBD.DataTextField = "BDName";
                    ddlDualBD.DataBind();

                    ddlDualBD.Items.Insert(Convert.ToInt32(ddlDualBD.Items[ddlDualBD.Items.Count - 1].Value), new ListItem("----Other----", ""));
                    ddlDualBD.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                 throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with PostGraduateDiploma_Table of Database
        /// </summary>
        private void BindDropDownPostGraduateDiploma()
        {
            try
            {
                DataSet PostGraduateDiplomaData = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get Post Graduate Diploma details
                PostGraduateDiplomaData = educationalDetails.GetPostGraduateDiplomaBAL();
                if (PostGraduateDiplomaData != null)
                {
                    ddlPgd.DataSource = PostGraduateDiplomaData;
                    ddlPgd.DataValueField = "PGDId";
                    ddlPgd.DataTextField = "PGDName";
                    ddlPgd.DataBind();

                    ddlPgd.Items.Insert(Convert.ToInt32(ddlPgd.Items[ddlPgd.Items.Count - 1].Value), new ListItem("----Other----", ""));
                    ddlPgd.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                 throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with MasterDegree_Table of Database
        /// </summary>
        private void BindDropDownMasterDegree()
        {
            try
            {
                DataSet MasterDegreeData = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get Master Degree details
                MasterDegreeData = educationalDetails.GetMasterDegreeBAL();
                if (MasterDegreeData != null)
                {
                    ddlMD.DataSource = MasterDegreeData;
                    ddlMD.DataValueField = "MDId";
                    ddlMD.DataTextField = "MDName";
                    ddlMD.DataBind();

                    ddlMD.Items.Insert(Convert.ToInt32(ddlMD.Items[ddlMD.Items.Count - 1].Value), new ListItem("----Other----", ""));
                    ddlMD.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                 throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with MasterDegree_Table of Database
        /// </summary>
        private void BindDropDownDualMasterDegree()
        {
            try
            {
                DataSet DualMasterDegreeData = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get Master Degree details
                DualMasterDegreeData = educationalDetails.GetMasterDegreeBAL();
                if (DualMasterDegreeData != null)
                {
                    ddlDualMD.DataSource = DualMasterDegreeData;
                    ddlDualMD.DataValueField = "MDId";
                    ddlDualMD.DataTextField = "MDName";
                    ddlDualMD.DataBind();

                    ddlDualMD.Items.Insert(Convert.ToInt32(ddlDualMD.Items[ddlDualMD.Items.Count - 1].Value), new ListItem("----Other----", ""));
                    ddlDualMD.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                 throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with DoctorOfPhilosophy_Table of Database
        /// </summary>
        private void BindDropDownDoctorOfPhilosophy()
        {
            try
            {
                DataSet DoctorOfPhilosophyData = new DataSet();
                educationalDetails = new EducationalDetailsBAL();
                // Get Doctor Of Philosophy details
                DoctorOfPhilosophyData = educationalDetails.GetDoctorOfPhilosophyBAL();
                if (DoctorOfPhilosophyData != null)
                {
                    ddlPHD.DataSource = DoctorOfPhilosophyData;
                    ddlPHD.DataValueField = "PHDId";
                    ddlPHD.DataTextField = "PHDName";
                    ddlPHD.DataBind();

                    ddlPHD.Items.Insert(Convert.ToInt32(ddlPHD.Items[ddlPHD.Items.Count - 1].Value), new ListItem("----Other----", ""));
                    ddlPHD.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                 throw;
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
                 throw;
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
                 throw;
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
                 throw;
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
                 throw;
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
                 throw;
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
            }
            catch (Exception)
            {
                 throw;
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
            }
            catch (Exception)
            {
                  throw;
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
            }
            catch (Exception)
            {
                 throw;
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
            }
            catch (Exception)
            {
                 throw;
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
                educationalDetailsEntity.AddDoctorOfPhilosophyName = txtPHDAdd.Text;
                // Add data to the database
                educationalDetailsBAL.AddDoctorOfPhilosophyBAL(educationalDetailsEntity);
            }
            catch (Exception)
            {
                 throw;
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