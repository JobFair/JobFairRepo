using BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    public partial class ProfessionalDetails : System.Web.UI.UserControl
    {
        private CurrentDesiredJobBAL currentjobBAL = new CurrentDesiredJobBAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //BindDropDownIndustry();
                //BindDropDownDepartment();
                //BindDropDownCountry();
                //divPastEmloyer.Visible = false;
                //Bind Month List
                BindMonth();
                BindYear();
                BindCity();
                BindArea();
                BindFunctionalArea();
                BindIndustry();
                BindDepartment();
                hfCandidateId.Value = "JS2";
                AddExperienceRecords();
                AddJobLookingRecords();
            }
        }

        private void AddJobLookingRecords()
        {
           
            // Creating DataTable
            DataTable dt = new DataTable();
            DataRow dr;
            dt.TableName = "JobDetails";
            // Creating columns for DataTable
            dt.Columns.Add(new DataColumn("CandidateId", typeof(string)));
            dt.Columns.Add(new DataColumn("JobPostLookingFor", typeof(string)));
            dt.Columns.Add(new DataColumn("Industry", typeof(int)));
            dt.Columns.Add(new DataColumn("Department", typeof(int)));          
            dt.Columns.Add(new DataColumn("FunctionalRole", typeof(int)));
            dt.Columns.Add(new DataColumn("RelevantExperience", typeof(float)));          
            dr = dt.NewRow();
            dt.Rows.Add(dr);
            ViewState["JobDetails"] = dt;
            gvJobsLookingFor.DataSource = dt;
            gvJobsLookingFor.DataBind();
            ViewState["JobDetails"] = null;
           
        }

        private void BindYear()
        {
            try
            {
                // Bind Year List
                List<string> yearList = CommonUtil.Utility.GetYears();
                ddlFromYear.DataSource = yearList;
                ddlFromYear.DataBind();
                ddlTillYear.DataSource = yearList;
                ddlTillYear.DataBind();

            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        private void BindMonth()
        {
            List<string> monthList = CommonUtil.Utility.GetMonths();
            ddlFromMonth.DataSource = monthList;
            ddlTillMonth.DataSource = monthList;
            ddlFromMonth.DataBind();
            ddlTillMonth.DataBind();            
        }

        private void BindFunctionalArea()
        {
            DataSet ds = new DataSet();
            ds = currentjobBAL.GetFunctionalArea();
            ddlFunctionalRole.DataSource = ds;
            ddlFunctionalRole.DataTextField = "FunctionalArea";
            ddlFunctionalRole.DataValueField = "FunctionalAreaId";
            ddlFunctionalRole.DataBind();
            ddlFunctionalRole.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        private void AddExperienceRecords()
        {
            // Creating DataTable
            DataTable dt = new DataTable();
            DataRow dr;
            dt.TableName = "ProfessionalDetails";
            // Creating columns for DataTable
            dt.Columns.Add(new DataColumn("CandidateId", typeof(string)));
            dt.Columns.Add(new DataColumn("CompanyCurrentOrPast", typeof(string)));
            dt.Columns.Add(new DataColumn("ComapnyName", typeof(string)));
            dt.Columns.Add(new DataColumn("CompanyName", typeof(string)));
            dt.Columns.Add(new DataColumn("Designation", typeof(string)));
            dt.Columns.Add(new DataColumn("RolesResponsibilities", typeof(string)));
            dt.Columns.Add(new DataColumn("FromMonth", typeof(string)));
            dt.Columns.Add(new DataColumn("FromYear", typeof(string)));
            dt.Columns.Add(new DataColumn("TillMonth", typeof(string)));
            dt.Columns.Add(new DataColumn("TillYear", typeof(string)));
            dt.Columns.Add(new DataColumn("Industry", typeof(int)));
            dt.Columns.Add(new DataColumn("Department", typeof(int)));
            dt.Columns.Add(new DataColumn("EmploymentStatus", typeof(string)));
            dt.Columns.Add(new DataColumn("JobType", typeof(string)));
            dt.Columns.Add(new DataColumn("CompanyType", typeof(string)));
            dt.Columns.Add(new DataColumn("Reason", typeof(string)));
            dr = dt.NewRow();
            dt.Rows.Add(dr);
            ViewState["ProfessionalDetails"] = dt;
            gvExperience.DataSource = dt;
            gvExperience.DataBind();
            ViewState["ProfessionalDetails"] = null;
        }

        private void BindDepartment()
        {
            DataSet ds = new DataSet();
            ds = currentjobBAL.GetDepartment();
            ddlDepartment.DataSource = ds;
            ddlDepartment123.DataSource = ds;
            ddlDepartment.DataTextField = "DepartmentName";
            ddlDepartment.DataValueField = "DepartmentId";
            ddlDepartment123.DataTextField = "DepartmentName";
            ddlDepartment123.DataValueField = "DepartmentId";
            ddlDepartment.DataBind();
            ddlDepartment123.DataBind();
            ddlDepartment123.Items.Insert(0, new ListItem("--Select--", "0"));
            ddlDepartment.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        private void BindIndustry()
        {
            DataSet ds = new DataSet();
            ds = currentjobBAL.GetIndustry();
            ddlIndustry.DataSource = ds;
            ddlIndustry123.DataSource = ds;
            ddlIndustry.DataTextField = "IndustryName";
            ddlIndustry.DataValueField = "IndustryId";
            ddlIndustry123.DataTextField = "IndustryName";
            ddlIndustry123.DataValueField = "IndustryId";
            ddlIndustry.DataBind();
            ddlIndustry123.DataBind();
            ddlIndustry123.Items.Insert(0, new ListItem("--Select--", "0"));
            ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        private void BindArea()
        {
            DataSet ds = new DataSet();
            ds = currentjobBAL.GetArea();
            ddlArea.DataSource = ds;
            ddlArea.DataTextField = "AreaName";
            ddlArea.DataValueField = "AreaId";
            ddlArea.DataBind();
            ddlArea.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        private void BindCity()
        {
            DataSet ds = new DataSet();
            ds = currentjobBAL.GetCity();
            ddlPreferredCity.DataSource = ds;
            ddlPreferredCity.DataTextField = "CityName";
            ddlPreferredCity.DataValueField = "CityId";
            ddlPreferredCity.DataBind();
            ddlPreferredCity.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void lbPastEmployer_Click(object sender, EventArgs e)
        {
        }

        protected void rbtEmployed_CheckedChanged(object sender, EventArgs e)
        {
            divCurrentEmployer.Visible = true;
            divDesireJobDetails.Visible = true;
        }

        protected void rbtUnEmployed_CheckedChanged(object sender, EventArgs e)
        {
            divExperience.Visible = true;
            divCurrentEmployer.Visible = false;
            divDesireJobDetails.Visible = false;
        }

        protected void rbtPastExperience_CheckedChanged(object sender, EventArgs e)
        {
            divExperience.Visible = false;
            divDesireJobDetails.Visible = true;
        }

        protected void rbtNoExpeience_CheckedChanged(object sender, EventArgs e)
        {
            divCurrentEmployer.Visible = false;
            divDesireJobDetails.Visible = true;
        }

        protected void lbAddMoreJobPost_Click(object sender, EventArgs e)
        {
            divAddMoreJob.Visible = true;
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> Getcity(string prefixText)
        {
            DataTable dt = new DataTable();
            CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
            dt = currentDesiredJobBAL.GetPreferredCityBAL(prefixText);
            List<string> cityList = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cityList.Add(dt.Rows[i][1].ToString());
            }
            return cityList;
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> GetArea(string prefixText)
        {
            DataTable dt = new DataTable();
            CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
            dt = currentDesiredJobBAL.GetPreferredAreaBAL(prefixText);
            List<string> cityAreaList = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cityAreaList.Add(dt.Rows[i][1].ToString());
            }
            return cityAreaList;
        }

        protected void btnSaveCurrentJob_Click(object sender, EventArgs e)
        {
            CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
            DataTable dt = (DataTable)ViewState["ProfessionalDetails"];
            currentDesiredJobBAL.SaveExperienceDetailsBAL(dt);
            Response.Write("<script language='javascript'>alert('Details saved successfully')</script>");
        }

        protected void btnAddExperience_Click(object sender, EventArgs e)
        {
            AddNewRecordToGrid();
            txtDesignation.Text = "";
            txtCurrentEmployer.Text = "";
            txtRollesResponsibilities.Text = "";           
            txtReasonforJobchange.Text = "";
        }

        private void AddNewRecordToGrid()
        {
            try
            {
                if (ViewState["ProfessionalDetails"] != null)
                {
                    DataTable dt = (DataTable)ViewState["ProfessionalDetails"];
                    DataRow dr = null;
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 1; i <= dt.Rows.Count; i++)
                        {
                            //DateTime f1 = Convert.ToDateTime(txtFromDate.Text);
                            //DateTime f2 = Convert.ToDateTime(txtTillDate.Text);
                            //int f3 = f2.Month - f1.Month;
                            //int f4 = f2.Year - f1.Year;
                            // Creating new row
                            dr = dt.NewRow();
                            dr["CandidateId"] = hfCandidateId.Value.Trim();
                            dr["CompanyCurrentOrPast"] = chkCurrentYes.Text;
                            dr["ComapnyName"] = txtCurrentEmployer.Text.Trim();
                            dr["Designation"] = txtDesignation.Text.Trim();
                            dr["RolesResponsibilities"] = txtRollesResponsibilities.Text;
                            dr["FromMonth"] = ddlFromMonth.Text;
                            dr["TillMonth"] = ddlTillYear.Text;
                            dr["FromYear"] = ddlFromYear.Text;
                            dr["TillYear"] = ddlTillYear.Text;
                            dr["Industry"] = ddlIndustry.SelectedItem.Value;
                            dr["Department"] = ddlDepartment.SelectedItem.Value;
                            dr["EmploymentStatus"] = rblEmploymentStatus.Text;
                            dr["JobType"] = rblJobType.Text;
                            dr["CompanyType"] = rblCompanyType.Text;
                            dr["Reason"] = txtReasonforJobchange.Text.Trim();
                        }
                        // Removing initial row
                        if (dt.Rows[0][0].ToString() == "")
                        {
                            dt.Rows[0].Delete();
                            dt.AcceptChanges();
                        }

                        // Add new record to the datatable
                        dt.Rows.Add(dr);

                        // Storing datatable to viewstate
                        ViewState["ProfessionalDetails"] = dt;

                        //binding gridview with new row
                        gvExperience.DataSource = dt;
                        gvExperience.DataBind();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void ddlFromYear_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void btnAddMoreJobPost_Click(object sender, EventArgs e)
        {
            AddMoreJobs();
        }

        private void AddMoreJobs()
        {
            try
            {
                if (ViewState["JobDetails"] != null)
                {
                    DataTable dt = (DataTable)ViewState["JobDetails"];
                    DataRow dr = null;
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 1; i <= dt.Rows.Count; i++)
                        {
                            //creating new row
                            dr = dt.NewRow();
                            dr["CandidateId"] = hfCandidateId.Value.Trim();
                            dr["JobPostLookingFor"] = txtJobPostLookingFor.Text.Trim();
                            dr["Industry"] = ddlIndustry123.SelectedItem.Value;
                            dr["Department"] = ddlDepartment123.SelectedItem.Value;
                            dr["FunctionalRole"] = ddlFunctionalRole.SelectedItem.Value;
                            dr["RelevantExperience"] = txtRelevantExp.Text.Trim();
                        }
                        //Removing initial row
                        if (dt.Rows[0][0].ToString() == "")
                        {
                            dt.Rows[0].Delete();
                            dt.AcceptChanges();
                        }

                        //add new record to the datatable
                        dt.Rows.Add(dr);

                        //storing datatable to viewstate
                        ViewState["JobDetails"] = dt;

                        //binding gridview with new row
                        gvJobsLookingFor.DataSource = dt;
                        gvJobsLookingFor.DataBind();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnSaveMoreJobs_Click(object sender, EventArgs e)
        {
            //CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
            //DataTable dt = (DataTable)ViewState["ProfessionalDetails"];
            //currentDesiredJobBAL.SaveExperienceDetailsBAL(dt);
            //Response.Write("<script language='javascript'>alert('Details saved successfully')</script>");
            try
            {
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                DataTable dt = (DataTable)ViewState["ProfessionalDetails"];
                currentDesiredJobBAL.SaveJobLookingDetailsBAL(dt);
                Response.Write("<script language='javascript'>alert('Details saved successfully')</script>");


            }
            catch (Exception)
            {
                
                throw;
            }

        }

      

       
    }
}

/// <summary>
/// Method for binding Dropdown with Country_table of database
/// </summary>
//private void BindDropDownCountry()
//{
//    ds = currentjobBAL.GetCountry();
//    ddlCountry.DataSource = ds;
//    ddlCountry.DataTextField = "CountryName";
//    ddlCountry.DataValueField = "CountryId";
//    ddlCountry.DataBind();
//    ddlCountry.Items.Insert(0, new ListItem("--Select--", "0"));
//}

///// <summary>
///// Method for binding Dropdown with Department_table of database
///// </summary>

//private void BindDropDownDepartment()
//{
//    ds = currentjobBAL.GetDepartment();

//    ddlDepartment.DataSource = ds;
//    ddlDepartment.DataTextField = "DepartmentName";
//    ddlDepartment.DataValueField = "DepartmentId";
//    ddlDepartment.DataBind();
//    ddlDepartment.Items.Insert(0, new ListItem("--Select--", "0"));
//}

///// <summary>
///// Method for binding DropDown with Industry_table of database
///// </summary>
//private void BindDropDownIndustry()
//{
//    ds = currentjobBAL.GetIndustry();
//    ddlIndustry.DataSource = ds;
//    ddlIndustry.DataTextField = "IndustryName";
//    ddlIndustry.DataValueField = "IndustryId";
//    ddlIndustry.DataBind();
//    ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));
//}

///// <summary>
///// Handles the Click event of the btnSave control of current job details
///// </summary>
///// <param name="sender">The source of event</param>
///// <param name="e">The <cref="EventArgs">instance containing event data</param>
//protected void btnSave_Click(object sender, EventArgs e)
//{
//    try
//    {
//        //calculting total experience
//        DateTime FromYear = Convert.ToDateTime(txtFromdate.Text);
//        DateTime ToYear = Convert.ToDateTime(txtTill.Text);
//        //Creating object of TimeSpan Class
//        TimeSpan objTimeSpan = ToYear - FromYear;
//        //years
//        int Years = ToYear.Year - FromYear.Year;
//        int Month = ToYear.Month - FromYear.Month;
//        Label1.Text = Years + "Years-" + Month + "Months";
//        CurrentDesiredJobEntity currentJobEntity = new CurrentDesiredJobEntity();
//        CurrentDesiredJobBAL currentjobBAL = new CurrentDesiredJobBAL();

//        currentJobEntity.Candidateid = "JS00001";
//        currentJobEntity.ResumeHeadline = txtResumeHeadline.Text;
//        currentJobEntity.TotalExperience = Years + "." + Month;
//        currentJobEntity.Industry = Convert.ToInt32(ddlIndustry.SelectedItem.Value);
//        currentJobEntity.Department = ddlDepartment.SelectedIndex;
//        currentJobEntity.CurrentJobRole = txtCurrentJobRole.Text;
//        currentJobEntity.PrimFunctionalRole = ddlPrimaryRole.SelectedItem.Text;
//        currentJobEntity.PrimJobDescrip = txtJobdescriptionPrimar.Text;
//        currentJobEntity.PrimTechSkills = txtTechnicalskillPrimary.Text;
//        currentJobEntity.SecFunctionalRole = ddlSecRole.SelectedItem.Text;
//        currentJobEntity.SecJobDescrip = txtjobdescriptionSec.Text;
//        currentJobEntity.SecTechSkills = txtTechnicalskillSec.Text;
//        currentJobEntity.Designation = txtDesignation.Text;
//        currentJobEntity.ReasonforJobChange = txtReasonforJobchange.Text;
//        currentJobEntity.CurrentEmployer = txtemployeer.Text;
//        currentJobEntity.TechnicalSkills = txtTechSkills.Text;
//        int result = currentjobBAL.CurrentProfessionalDetailsBAL(currentJobEntity);
//        if (result > 0)
//        {
//            lblmsgsave.Text = "Your current professional  details saved successfully";
//        }
//        else
//        {
//            lblmsgsave.Text = "Your current professional  details are not saved";
//        }
//    }
//    catch (Exception ex)
//    {
//        throw ex;
//    }
//}

///// <summary>
///// Handles the Click event of the btnsaveDesJob control of desired job details
///// </summary>
///// <param name="sender">The source of event</param>
///// <param name="e">The <cref="EventArgs">instance containing event data</param>
//protected void btnsaveDesJob_Click(object sender, EventArgs e)
//{
//    try
//    {
//        CurrentDesiredJobBAL cdjBAL = new CurrentDesiredJobBAL();
//        CurrentDesiredJobEntity cdjEntity = new CurrentDesiredJobEntity();
//        cdjEntity.Candidateid = "JS00001";
//        cdjEntity.JobPostLooking = txtJobPostLooking.Text;
//        cdjEntity.RelevantExp = txtReleventExp.Text;
//        cdjEntity.CurrentAnualSal = Convert.ToDouble(txtcurrentannualsalary.Text);
//        cdjEntity.ExpectedAnualSal = Convert.ToDouble(txtexpectedsalary.Text);
//        cdjEntity.NoticePeriod = ddlNoticePeriod.SelectedItem.Text;
//        cdjEntity.EmploymentStatus = cblEmploymentStatus.SelectedItem.Text;
//        cdjEntity.JobType = cblJobType.SelectedItem.Text;
//        cdjEntity.WorkArea = txtworkarea.Text;
//        cdjEntity.PreferredCountry = ddlCountry.SelectedItem.Value;
//        cdjEntity.PreferredState = ddlState.SelectedItem.Value;
//        cdjEntity.PreferredCity = ddlCountry.SelectedItem.Value;
//        int result = cdjBAL.DesiredJobDetailsBAL(cdjEntity);
//        if (result > 0)
//        {
//            lblmsg.Text = "Your desired job details saved successfully";
//        }
//        else
//        {
//            lblmsg.Text = "Your details not saved successfully";
//        }
//    }
//    catch (Exception ex)
//    {
//        throw ex;
//    }
//}

///// <summary>
///// ddlCountry_SelectedIndexChanged() index of ddlCountry for selection of country
///// </summary>
///// <param name="sender">The source of event</param>
///// <param name="e">The <cref="EventArgs">instance containing event data</param>
//protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
//{
//    int CountryId = Convert.ToInt32(ddlCountry.SelectedValue);
//    DataSet ds = new DataSet();
//    ds = currentjobBAL.GetState(CountryId);
//    ddlState.DataSource = ds;

//    ddlState.DataTextField = "StateName";
//    ddlState.DataValueField = "StateId";
//    ddlState.DataBind();
//    ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
//}

///// <summary>
///// ddlState_SelectedIndexChanged() index of ddlState for selection of state
///// </summary>
///// <param name="sender">The source of event</param>
///// <param name="e">The <cref="EventArgs">instance containing event data</param>
//protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
//{
//    int StateId = Convert.ToInt32(ddlState.SelectedValue);
//    DataSet ds = new DataSet();
//    ds = currentjobBAL.GetCity(StateId);
//    ddlCity.DataSource = ds;

//    ddlCity.DataTextField = "cityName";
//    ddlCity.DataValueField = "cityID";
//    ddlCity.DataBind();
//    ddlCity.Items.Insert(0, new ListItem("--Select--", "0"));
//}