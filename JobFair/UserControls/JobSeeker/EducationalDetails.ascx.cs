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

                BindDropDownUnderGraduateDiploma();
                BindDropDownBachelorDegree();
                BindDropDownDualBachelorDegree();
                BindDropDownPostGraduateDiploma();
                BindDropDownMasterDegree();
                BindDropDownDualMasterDegree();
                BindDropDownDoctorOfPhilosophy();

            }
        }
        /// <summary>
        /// Handles the Click event of the btnSubmit control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e"></param>
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
                        sscDetails.CandidateId = "JS9";
                        sscDetails.DegreeId = Convert.ToInt32 (item.Value);
                        sscDetails.MediumOfEducation = txtSSCMedium.Text.Trim();
                        sscDetails.Specialization = "Null";
                        sscDetails.Status = rblSSCStat.SelectedValue.Trim();
                        sscDetails.YearOfCompletion = txtSSCYear.Text.Trim();
                        sscDetails.University = txtSSCBoard.Text.Trim();
                        sscDetails.Percantage = txtSSCPercentage.Text.Trim();
                        // Add object to the education details collection
                        educationDetailsList.Add(sscDetails);
                        break;

                    case "HSC / 12th":
                        EducationalDetailsEntity hscDetails = new EducationalDetailsEntity();
                        hscDetails.CandidateId = "JS9";
                        hscDetails.DegreeId = Convert.ToInt32(item.Value);
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
                        ugDiplomaDetails.CandidateId = "JS9";
                        ugDiplomaDetails.DegreeId = Convert.ToInt32(item.Value);
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
                        bachelorDegreeDetails.CandidateId = "JS9";
                        bachelorDegreeDetails.DegreeId = Convert.ToInt32(item.Value);
                        bachelorDegreeDetails.MediumOfEducation = txtBDMedium.Text.Trim();
                        bachelorDegreeDetails.Status = rblBDStat.SelectedValue.Trim();
                        bachelorDegreeDetails.Specialization = ddlBD.SelectedValue.Trim();
                        bachelorDegreeDetails.YearOfCompletion = txtBDYear.Text.Trim();
                        bachelorDegreeDetails.University = txtBDUniversity.Text.Trim();
                        bachelorDegreeDetails.Percantage = txtBDPercentage.Text.Trim();
                        // Add object to the education details collection
                        educationDetailsList.Add(bachelorDegreeDetails);
                        // functionality for adding records for Dual Bachelore Degree
                        if (pnlCollapsableDualBD.Visible == true)
                        { 
                            EducationalDetailsEntity dualBachelorDegreeDetails = new EducationalDetailsEntity();
                            dualBachelorDegreeDetails.CandidateId = "JS9";
                            dualBachelorDegreeDetails.DegreeId = Convert.ToInt32(item.Value);
                            dualBachelorDegreeDetails.MediumOfEducation = txtDualBDMedium.Text.Trim();
                            dualBachelorDegreeDetails.Status = rblDualBDStat.SelectedValue.Trim();
                            dualBachelorDegreeDetails.Specialization = ddlDualBD.SelectedValue.Trim();
                            dualBachelorDegreeDetails.YearOfCompletion = txtDualBDYear.Text.Trim();
                            dualBachelorDegreeDetails.University = txtDualBDUniversity.Text.Trim();
                            dualBachelorDegreeDetails.Percantage = txtDualBDPercentage.Text.Trim();
                            // Add object to the education details collection
                            educationDetailsList.Add(dualBachelorDegreeDetails);
                        }
                        break;

                    case "PG Diploma":
                        EducationalDetailsEntity pgDiplomaDetails = new EducationalDetailsEntity();
                        pgDiplomaDetails.CandidateId = "JS9";
                        pgDiplomaDetails.DegreeId = Convert.ToInt32(item.Value);
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
                        masterDegreeDetails.CandidateId = "JS9";
                        masterDegreeDetails.DegreeId = Convert.ToInt32(item.Value);
                        masterDegreeDetails.MediumOfEducation = txtMDMedium.Text.Trim();
                        masterDegreeDetails.Specialization = ddlMD.SelectedValue.Trim();
                        masterDegreeDetails.Status = rblMDStat.SelectedValue.Trim();
                        masterDegreeDetails.YearOfCompletion = txtMDYear.Text.Trim();
                        masterDegreeDetails.University = txtMDUniversity.Text.Trim();
                        masterDegreeDetails.Percantage = txtMDPercentage.Text.Trim();
                        // Add object to the education details collection
                        educationDetailsList.Add(masterDegreeDetails);
                        // functionality for adding records for Dual Master Degree
                        if (pnlCollapsableDualMD.Visible == true)
                        {
                            EducationalDetailsEntity dualMasterDegreeDetails = new EducationalDetailsEntity();
                            dualMasterDegreeDetails.CandidateId = "JS9";
                            dualMasterDegreeDetails.DegreeId = Convert.ToInt32(item.Value);
                            dualMasterDegreeDetails.MediumOfEducation = txtDualMDMedium.Text.Trim();
                            dualMasterDegreeDetails.Specialization = ddlDualMD.SelectedValue.Trim();
                            dualMasterDegreeDetails.Status = rblDualMDStat.SelectedValue.Trim();
                            dualMasterDegreeDetails.YearOfCompletion = txtDualMDYear.Text.Trim();
                            dualMasterDegreeDetails.University = txtDualMDUniversity.Text.Trim();
                            dualMasterDegreeDetails.Percantage = txtDualMDPercentage.Text.Trim();
                            // Add object to the education details collection
                            educationDetailsList.Add(dualMasterDegreeDetails);
                        }
                        break;

                    case "Doctorate/ PHD Degree":
                        EducationalDetailsEntity phdDetails = new EducationalDetailsEntity();
                        phdDetails.CandidateId = "JS9";
                        phdDetails.DegreeId = Convert.ToInt32(item.Value);
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

        protected void btnGo_Click(object sender, EventArgs e)
        {
            BtnSubmit.Visible = true;
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
        /// <summary>
        /// Method for binding DropDown with UnderGraduateDiploma_Table of Database
        /// </summary>
        private void BindDropDownUnderGraduateDiploma()
        {
            DataSet UnderGraduateDiplomaData = new DataSet();
            educationalDetails = new EducationalDetailsBAL();
            // Get Under Graduate Diploma details
            UnderGraduateDiplomaData = educationalDetails.GetUnderGraduateDiplomaBAL();
            ddlDip.DataSource = UnderGraduateDiplomaData;
            ddlDip.DataValueField = "UGDID";
            ddlDip.DataTextField = "UGDName";
            ddlDip.DataBind();

            ddlDip.Items.Insert(Convert.ToInt32(ddlDip.Items[ddlDip.Items.Count - 1].Value), new ListItem("----Other----", ""));
            ddlDip.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        /// <summary>
        /// Method for binding DropDown with BachelorDegree_Table of Database
        /// </summary>
        private void BindDropDownBachelorDegree()
        {
            DataSet BachelorDegreeData = new DataSet();
            educationalDetails = new EducationalDetailsBAL();
            // Get Bachelor Degree details
            BachelorDegreeData = educationalDetails.GetBachelorDegreeBAL();
            ddlBD.DataSource = BachelorDegreeData;
            ddlBD.DataValueField = "BDId";
            ddlBD.DataTextField = "BDName";
            ddlBD.DataBind();

            ddlBD.Items.Insert(Convert.ToInt32(ddlBD.Items[ddlBD.Items.Count - 1].Value), new ListItem("----Other----", ""));
            ddlBD.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        /// <summary>
        /// Method for binding DropDown with BachelorDegree_Table of Database
        /// </summary>
        private void BindDropDownDualBachelorDegree()
        {
            DataSet DualBachelorDegreeData = new DataSet();
            educationalDetails = new EducationalDetailsBAL();
            // Get Bachelor Degree details
            DualBachelorDegreeData = educationalDetails.GetBachelorDegreeBAL();
            ddlDualBD.DataSource = DualBachelorDegreeData;
            ddlDualBD.DataValueField = "BDId";
            ddlDualBD.DataTextField = "BDName";
            ddlDualBD.DataBind();

            ddlDualBD.Items.Insert(Convert.ToInt32(ddlDualBD.Items[ddlDualBD.Items.Count - 1].Value), new ListItem("----Other----", ""));
            ddlDualBD.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        /// <summary>
        /// Method for binding DropDown with PostGraduateDiploma_Table of Database
        /// </summary>
        private void BindDropDownPostGraduateDiploma()
        {
            DataSet PostGraduateDiplomaData = new DataSet();
            educationalDetails = new EducationalDetailsBAL();
            // Get Post Graduate Diploma details
            PostGraduateDiplomaData = educationalDetails.GetPostGraduateDiplomaBAL();
            ddlPgd.DataSource = PostGraduateDiplomaData;
            ddlPgd.DataValueField = "PGDId";
            ddlPgd.DataTextField = "PGDName";
            ddlPgd.DataBind();

            ddlPgd.Items.Insert(Convert.ToInt32(ddlPgd.Items[ddlPgd.Items.Count - 1].Value), new ListItem("----Other----", ""));
            ddlPgd.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        /// <summary>
        /// Method for binding DropDown with MasterDegree_Table of Database
        /// </summary>
        private void BindDropDownMasterDegree()
        {
            DataSet MasterDegreeData = new DataSet();
            educationalDetails = new EducationalDetailsBAL();
            // Get Master Degree details
            MasterDegreeData = educationalDetails.GetMasterDegreeBAL();
            ddlMD.DataSource = MasterDegreeData;
            ddlMD.DataValueField = "MDId";
            ddlMD.DataTextField = "MDName";
            ddlMD.DataBind();

            ddlMD.Items.Insert(Convert.ToInt32(ddlMD.Items[ddlMD.Items.Count - 1].Value), new ListItem("----Other----", ""));
            ddlMD.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        /// <summary>
        /// Method for binding DropDown with MasterDegree_Table of Database
        /// </summary>
        private void BindDropDownDualMasterDegree()
        {
            DataSet DualMasterDegreeData = new DataSet();
            educationalDetails = new EducationalDetailsBAL();
            // Get Master Degree details
            DualMasterDegreeData = educationalDetails.GetMasterDegreeBAL();
            ddlDualMD.DataSource = DualMasterDegreeData;
            ddlDualMD.DataValueField = "MDId";
            ddlDualMD.DataTextField = "MDName";
            ddlDualMD.DataBind();

            ddlDualMD.Items.Insert(Convert.ToInt32(ddlDualMD.Items[ddlDualMD.Items.Count - 1].Value), new ListItem("----Other----", ""));
            ddlDualMD.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        /// <summary>
        /// Method for binding DropDown with DoctorOfPhilosophy_Table of Database
        /// </summary>
        private void BindDropDownDoctorOfPhilosophy()
        {
            DataSet DoctorOfPhilosophyData = new DataSet();
            educationalDetails = new EducationalDetailsBAL();
            // Get Doctor Of Philosophy details
            DoctorOfPhilosophyData = educationalDetails.GetDoctorOfPhilosophyBAL();
            ddlPHD.DataSource = DoctorOfPhilosophyData;
            ddlPHD.DataValueField = "PHDId";
            ddlPHD.DataTextField = "PHDName";
            ddlPHD.DataBind();

            ddlPHD.Items.Insert(Convert.ToInt32(ddlPHD.Items[ddlPHD.Items.Count - 1].Value), new ListItem("----Other----", ""));
            ddlPHD.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        /// <summary>
        ///ddlDip_SelectedIndexChanged for checking the index of DropDown
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlDip_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checking item of dropdown
            if (ddlDip.SelectedItem.ToString() == "----Other----")
            {
                txtDipAdd.Visible = true;
                btnDipAdd.Visible = true;
            }
        }
        /// <summary>
        ///ddlBD_SelectedIndexChanged for checking the index of DropDown
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checking item of dropdown
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
        /// <summary>
        ///ddlPgd_SelectedIndexChanged for checking the index of DropDown
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlPgd_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checking item of dropdown
            if (ddlPgd.SelectedItem.ToString() == "----Other----")
            {
                txtPgdAdd.Visible = true;
                btnPgdAdd.Visible = true;
            }
        }
        /// <summary>
        ///ddlMD_SelectedIndexChanged for checking the index of DropDown
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlMD_SelectedIndexChanged(object sender, EventArgs e)
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
        /// <summary>
        ///ddlPHD_SelectedIndexChanged for checking the index of DropDown
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlPHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checking item of dropdown
            if (ddlPHD.SelectedItem.ToString() == "----Other----")
            {
                txtPHDAdd.Visible = true;
                btnPHDAdd.Visible = true;
            }
        }
        /// <summary>
        ///Adding new Under Graduate Diploma in database
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">the<see cref="EventArgs"/>containing event data</param>
        protected void btnDipAdd_Click(object sender, EventArgs e)
        {
            EducationalDetailsEntity educationalDetailsEntity = new EducationalDetailsEntity();
            EducationalDetailsBAL educationalDetailsBAL = new EducationalDetailsBAL();
            // Assign values to entity
            educationalDetailsEntity.AddUnderGraduateDiplomaName = txtDipAdd.Text;
            // Add data to the database 
            educationalDetailsBAL.AddUnderGraduateDiplomaBAL(educationalDetailsEntity);
        }
        /// <summary>
        ///Adding new Bachelor Degree in database
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">the<see cref="EventArgs"/>containing event data</param>
        protected void btnBDAdd_Click(object sender, EventArgs e)
        {
            EducationalDetailsEntity educationalDetailsEntity = new EducationalDetailsEntity();
            EducationalDetailsBAL educationalDetailsBAL = new EducationalDetailsBAL();
            // Assign values to entity
            educationalDetailsEntity.AddBachelorDegreeName = txtBDAdd.Text;
            // Add data to the database 
            educationalDetailsBAL.AddBachelorDegreeBAL(educationalDetailsEntity);
        }
        /// <summary>
        ///Adding new Post Graduate Diploma in database
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">the<see cref="EventArgs"/>containing event data</param>
        protected void btnPgdAdd_Click(object sender, EventArgs e)
        {
            EducationalDetailsEntity educationalDetailsEntity = new EducationalDetailsEntity();
            EducationalDetailsBAL educationalDetailsBAL = new EducationalDetailsBAL();
            // Assign values to entity
            educationalDetailsEntity.AddPostGraduateDiplomaName = txtPgdAdd.Text;
            // Add data to the database 
            educationalDetailsBAL.AddPostGraduateDiplomaBAL(educationalDetailsEntity);
        }
        /// <summary>
        ///Adding new Master Degree in database
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">the<see cref="EventArgs"/>containing event data</param>
        protected void btnMDAdd_Click(object sender, EventArgs e)
        {
            EducationalDetailsEntity educationalDetailsEntity = new EducationalDetailsEntity();
            EducationalDetailsBAL educationalDetailsBAL = new EducationalDetailsBAL();
            // Assign values to entity
            educationalDetailsEntity.AddMasterDegreeName = txtMDAdd.Text;
            // Add data to the database 
            educationalDetailsBAL.AddMasterDegreeBAL(educationalDetailsEntity);
        }
        /// <summary>
        ///Adding new Doctor Of Philosophy in database
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">the<see cref="EventArgs"/>containing event data</param>
        protected void btnPHDAdd_Click(object sender, EventArgs e)
        {
            EducationalDetailsEntity educationalDetailsEntity = new EducationalDetailsEntity();
            EducationalDetailsBAL educationalDetailsBAL = new EducationalDetailsBAL();
            // Assign values to entity
            educationalDetailsEntity.AddDoctorOfPhilosophyName = txtPHDAdd.Text;
            // Add data to the database 
            educationalDetailsBAL.AddDoctorOfPhilosophyBAL(educationalDetailsEntity);
        }

     
        static int cnt = 0;
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