using BAL;
using Entities.JobSeeker;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    public partial class ProfessionalDetails : System.Web.UI.UserControl
    {
        private string JobSeekerPrefix = ConfigurationManager.AppSettings["JobSeekerPrefix"];
        private string candidateId;
        private bool isCheck = true;

        /// <summary>
        /// Handles the Load event of Page
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            isCheck = Convert.ToBoolean(Request.QueryString["isCheck"]);
            // Check session is not null
            if (Session["candidateId"] != null)
            {
                if (Session["candidateId"].ToString() != "")
                {
                    candidateId = Convert.ToString(Session["candidateId"]);
                    // Check page is not post back
                    if (!IsPostBack)
                    {
                        if (isCheck)
                        {
                            try
                            {
                                BindIndustry();
                                BindDepartment();
                                BindFunctionalArea();
                                hfCandidateId.Value = candidateId;
                                BindRepeaterJobPostLooking();
                                BindRepeaterCurrentPastExp();
                                divCurrentEmployer.Visible = false;
                                

                                DataSet ds = new DataSet();
                                DataSet ds2 = new DataSet();
                                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                                ds = currentDesiredJobBAL.ViewCurrentJobDetailsBAL(candidateId);

                                // Bind Country
                                DataSet datasetCountry = new DataSet();

                                datasetCountry = currentDesiredJobBAL.GetCountry();
                                ddlPreferredCountry.DataSource = datasetCountry;
                                ddlPreferredCountry.DataTextField = "CountryName";
                                ddlPreferredCountry.DataValueField = "CountryId";
                                ddlPreferredCountry.DataBind();

                                ddlPreferredCountry.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["PreferredCountry"]);

                                // Bind State
                                int countryId = Convert.ToInt32(ds.Tables[0].Rows[0]["PreferredCountry"]);
                                DataSet datasetState = new DataSet();
                                datasetState = currentDesiredJobBAL.GetState(countryId);
                                chklState.DataSource = datasetState;
                                chklState.DataValueField = "StateId";
                                chklState.DataTextField = "StateName";
                                chklState.DataBind();

                                string stateId = Convert.ToString(ds.Tables[0].Rows[0]["PreferredState"]);
                                List<string> listofState = new List<string>(stateId.Split(','));
                                listofState.RemoveAll(x => x == "");
                                foreach (var list in listofState)
                                {
                                    
                                    string k = "";
                                    for (int i = 0; i < chklState.Items.Count; i++)
                                    {
                                       
                                        if (chklState.Items[i].Selected)
                                        {
                                            chklState.SelectedValue = list;
                                            var selectedState = chklState.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                                            txtPreferredState.Text = string.Join(",", selectedState.Select(x => x.Text));
                                        }
                                    }  
                                }

                                //var selectedState = chklState.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                                //txtPreferredState.Text = string.Join(",", selectedState.Select(x => x.Text));

                                // Bind City
                                DataSet getcityDataSet = new DataSet();
                                getcityDataSet = currentDesiredJobBAL.GetCity(stateId);
                                chklCity.DataSource = getcityDataSet;
                                chklCity.DataTextField = "cityName";
                                chklCity.DataValueField = "cityID";
                                chklCity.DataBind();

                                string cityId = Convert.ToString(ds.Tables[0].Rows[0]["PreferredCity"]);
                                List<string> listofCity = new List<string>(cityId.Split(','));
                                listofCity.RemoveAll(x => x == "");
                                foreach (var list in listofCity)
                                {
                                    string k = "";
                                    for (int i = 0; i < chklCity.Items.Count; i++)
                                    {
                                        if (chklCity.Items[i].Selected)
                                        {

                                            k = k + chklCity.Items[i].Text + "</br>";
                                        }

                                    }  
                                    chklCity.SelectedValue = list;
                                }

                                //foreach (var list in listofCity)
                                //{
                                //   // chklCity.SelectedValue = list;
                                //    foreach(CheckBox chk in chklCity)
                                //    {
                                //        if (chk. == list)
                                //          {
                                //               chklCity.SetItemChecked(i, true);
                                //          }
                                //    }

                                //    //for(int i = 0; i < chklCity.Items.Cast<CheckBox>().Count(); i++)
                                //    //{
                                //    //    if (chklCity.Items[i]. == list)
                                //    //      {
                                //    //           chklCity.SetItemChecked(i, true);
                                //    //      }
                                //    // }
                                //    //chklCity.Items.Cast<ListItem>(). //.Where(x=>x.Selected=true
                                //    //Select(x=>x.Selected=true).Where()

                                //    //var t = (from item in chklCity.Items.Cast<ListItem>()
                                //    //   where
                                //    //   select int.Parse(item.Value));
                                //    (from i in chklCity.Items.Cast<CheckBox>()
                                //     where i.sel = list
                                //     select i)

                                //    //ToList().ForEach(i => i.Selected = true)
                                //}

                                var selectedCity = chklCity.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                                txtCity.Text = string.Join(",", selectedCity.Select(x => x.Text));

                                // Bind CityArea
                                DataSet datasetCityArea = new DataSet();
                                datasetCityArea = currentDesiredJobBAL.GetArea(cityId);
                                chklArea.DataSource = datasetCityArea;
                                chklArea.DataValueField = "AreaId";
                                chklArea.DataTextField = "AreaName";
                                chklArea.DataBind();

                                string areaId = Convert.ToString(ds.Tables[0].Rows[0]["PreferredArea"]);
                                List<string> listofArea = new List<string>(areaId.Split(','));
                                listofArea.RemoveAll(x => x == "");
                                foreach (var list in listofArea)
                                {
                                    chklArea.SelectedValue = list;
                                }

                                var selectedarea = chklArea.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                                txtarea.Text = string.Join(",", selectedarea.Select(x => x.Text));

                                txtResumeHeadline.Text = Convert.ToString(ds.Tables[0].Rows[0]["ResumeHeadline"]);
                                txtObjective.Text = Convert.ToString(ds.Tables[0].Rows[0]["Objective"]);
                                txtProfileSummary.Text = Convert.ToString(ds.Tables[0].Rows[0]["ProfileSummary"]);
                                lblTotalExp.Text = Convert.ToString(ds.Tables[0].Rows[0]["TotalExpriance"]);
                                txtcurrentannualsalary.Text = Convert.ToString(ds.Tables[0].Rows[0]["CurrentAnualSalary"]);
                                txtexpectedsalary.Text = Convert.ToString(ds.Tables[0].Rows[0]["ExpectedAnualSalary"]);

                                ddlWorkStatus.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["CurrentWorkingStatus"]);
                                ddlNoticePeriod.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["NoticePeriod"]);
                                chklEmploymentStatus.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["EmploymentStatus"]);
                                chklJobType.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["JobType"]);
                                chklCompanyType.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["CompanyType"]);
                                rblYesNo.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["AvailabilityForInterview"]);

                                string format = Convert.ToString(ds.Tables[0].Rows[0]["BeforeTime"]); 
                                string[] Words = format.Split(new char[] { ':' });
                                int count1 = 0;
                                string format1 = Convert.ToString(ds.Tables[0].Rows[0]["AfterTime"]);
                                string[] Words1 = format1.Split(new char[] { ':' });
                                int count2 = 0;

                                foreach (string Word in Words)
                                {
                                    count1 += 1;
                                    if (count1 == 1)
                                    { ddlBeforeHours.SelectedValue = Word; }
                                    if (count1 == 2)
                                    { ddlBeforeMinutes.SelectedValue = Word; }
                                    if (count1 == 3)
                                    { ddlBeforeTime.SelectedValue = Word; }
                                }

                                foreach (string word in Words1)
                                {
                                    count2 += 1;
                                    if (count2 == 1)
                                    { ddlAfterHours.SelectedValue = word; }
                                    if (count2 == 2)
                                    { ddlAfterMinutes.SelectedValue = word; }
                                    if (count2 == 3)
                                    { ddlAfterTime.SelectedValue = word; }
                                    if (count2 == 4)
                                    { ddlISTETE.SelectedValue = word; }
                                }
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }
                        else
                        {
                            BindCountry();
                            BindMonth();
                            BindYear();

                            BindFunctionalArea();
                            BindIndustry();
                            BindDepartment();
                            hfCandidateId.Value = candidateId;
                            AddExperienceRecords();
                            AddJobLookingRecords();
                        }
                    }
                }
            }
        }
        private void BindCountry()
        {
            CurrentDesiredJobBAL currentjobBAL = new CurrentDesiredJobBAL();
            DataSet ds = new DataSet();
            try
            {
                ds = currentjobBAL.GetCountryBAL();
                if (ds != null)
                {
                    ddlPreferredCountry.DataSource = ds;
                    ddlPreferredCountry.DataTextField = "CountryName";
                    ddlPreferredCountry.DataValueField = "CountryId";
                    ddlPreferredCountry.DataBind();
                    ddlPreferredCountry.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindRepeaterCurrentPastExp()
        {
            try
            {
                DataSet ds = new DataSet();
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                ds = currentDesiredJobBAL.ViewCurrentPastJobDetailsBAL(candidateId);
                if (ds != null)
                {
                    rptrPastCurrentJobDetails.DataSource = ds;

                    rptrPastCurrentJobDetails.DataBind();
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindRepeaterJobPostLooking()
        {
            try
            {
                DataSet ds = new DataSet();
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                ds = currentDesiredJobBAL.ViewJobPostLookingBAL(candidateId);
                if (ds != null)
                {
                    rptrJobPostLookinFor.DataSource = ds;

                    rptrJobPostLookinFor.DataBind();
                }
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        /// <summary>
        /// Method to Add Job Looking for to gvJobsLookingFor control
        /// </summary>
        private void AddJobLookingRecords()
        {
            try
            {
                // Creating DataTable
                DataTable datatable = new DataTable();
                DataRow datarow;
                datatable.TableName = "JobDetails";
                // Creating columns for DataTable
                datatable.Columns.Add(new DataColumn("CandidateId", typeof(string)));
                datatable.Columns.Add(new DataColumn("JobPostLookingFor", typeof(string)));
                datatable.Columns.Add(new DataColumn("Industry", typeof(int)));
                datatable.Columns.Add(new DataColumn("Department", typeof(int)));
                datatable.Columns.Add(new DataColumn("FunctionalRole", typeof(int)));
                datatable.Columns.Add(new DataColumn("RelevantExperience", typeof(float)));
                datarow = datatable.NewRow();
                datatable.Rows.Add(datarow);
                ViewState["JobDetails"] = datatable;
                gvJobsLookingFor.DataSource = datatable;
                gvJobsLookingFor.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method to Bind years to ddlFromYear & ddlTillYear control
        /// </summary>
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
                // throw;
            }
        }

        /// <summary>
        /// Method to Bind months to ddlFromMonth & ddlTillMonth control
        /// </summary>
        private void BindMonth()
        {
            try
            {
                List<string> monthList = CommonUtil.Utility.GetMonths();
                ddlFromMonth.DataSource = monthList;
                ddlTillMonth.DataSource = monthList;
                ddlFromMonth.DataBind();
                ddlTillMonth.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method to Bind FunctionalArea to ddlFunctionalRole control
        /// </summary>
        private void BindFunctionalArea()
        {
            CurrentDesiredJobBAL currentjobBAL = new CurrentDesiredJobBAL();
            DataSet ds = new DataSet();
            try
            {
                ds = currentjobBAL.GetFunctionalArea();
                if (ds != null)
                {
                    ddlFunctionalRole.DataSource = ds;
                    ddlFunctionalRole.DataTextField = "FunctionalArea";
                    ddlFunctionalRole.DataValueField = "FunctionalAreaId";
                    ddlFunctionalRole.DataBind();
                    ddlFunctionalRole.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method to Add Experience details to the gvExperience control
        /// </summary>
        private void AddExperienceRecords()
        {
            try
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
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method to Bind department ddlDepartment & ddlDepartment123 control
        /// </summary>
        private void BindDepartment()
        {
            CurrentDesiredJobBAL currentjobBAL = new CurrentDesiredJobBAL();
            try
            {
                DataSet ds = new DataSet();
                ds = currentjobBAL.GetDepartment();
                if (ds != null)
                {
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
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method to Bind industry to ddlIndustry & ddlIndustry123 control
        /// </summary>
        private void BindIndustry()
        {
            CurrentDesiredJobBAL currentjobBAL = new CurrentDesiredJobBAL();
            DataSet ds = new DataSet();
            try
            {
                ds = currentjobBAL.GetIndustry();
                if (ds != null)
                {
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
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                ds = null;
            }
        }

        /// <summary>
        /// Handles Click event of btnSaveCurrentJob control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSaveCurrentJob_Click(object sender, EventArgs e)
        {
            CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
            Entities.JobSeeker.CurrentDesiredJobEntity currentDesiredJobEntity = new Entities.JobSeeker.CurrentDesiredJobEntity();
            currentDesiredJobEntity.Candidateid = hfCandidateId.Value.Trim();

            DataTable dt = (DataTable)ViewState["ProfessionalDetails"];
            try
            {
                currentDesiredJobBAL.SaveExperienceDetailsBAL(dt);

                Response.Write("<script language='javascript'>alert('Details saved successfully')</script>");
            }
            catch (Exception)
            {
                //  throw;
            }
            finally
            {
                dt = null;
                currentDesiredJobBAL = null;
            }
        }

        /// <summary>
        /// Handles Click event of btnAddExperience control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnAddExperience_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewRecordToGrid();
                txtDesignation.Text = "";
                txtCurrentEmployer.Text = "";
                txtRollesResponsibilities.Text = "";
                txtReasonforJobchange.Text = "";
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method to Bind data of datatable to gvExperience control
        /// </summary>
        private void AddNewRecordToGrid()
        {
            double months = MonthDifference();

            lblTotalExp.Text = months.ToString();

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
                            // Creating new row
                            dr = dt.NewRow();
                            dr["CandidateId"] = hfCandidateId.Value.Trim();
                            dr["CompanyCurrentOrPast"] = chkCurrentYes.Checked.ToString();
                            dr["ComapnyName"] = txtCurrentEmployer.Text.Trim();
                            dr["Designation"] = txtDesignation.Text.Trim();
                            dr["RolesResponsibilities"] = txtRollesResponsibilities.Text;
                            dr["FromMonth"] = ddlFromMonth.Text;
                            dr["TillMonth"] = ddlTillMonth.Text;
                            dr["FromYear"] = ddlFromYear.Text;
                            dr["TillYear"] = ddlTillYear.Text;
                            dr["Industry"] = ddlIndustry.SelectedItem.Value;
                            dr["Department"] = ddlDepartment.SelectedItem.Value;
                            dr["EmploymentStatus"] = rblEmployeStatus.Text;
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
                //  throw;
            }
        }

        /// <summary>
        /// Method to count difference between two dates and total experience
        /// </summary>
        /// <returns>System.Double</returns>
        private double MonthDifference()
        {
            double temp = 0.0;
            DateTime fromMonth, tillMonth;
            try
            {
                fromMonth = new DateTime(Convert.ToInt32(ddlFromYear.SelectedItem.Text), Convert.ToInt32(ddlFromMonth.SelectedIndex + 1), 1);
                tillMonth = new DateTime(Convert.ToInt32(ddlTillYear.SelectedItem.Text), Convert.ToInt32(ddlTillMonth.SelectedIndex + 1), 1);
                int months = (tillMonth.Month - fromMonth.Month) + 12 * (tillMonth.Year - fromMonth.Year);
                double year = Math.Abs((double)months / 12);
                temp = temp + year;
            }
            catch (Exception)
            {
                // throw;
            }
            return temp;
        }

        /// <summary>
        /// Handles the click event of btnAddMoreJobPost control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnAddMoreJobPost_Click(object sender, EventArgs e)
        {
            try
            {
                AddMoreJobs();
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        /// <summary>
        /// Method to Add More JobDetails of Jobseeker
        /// </summary>
        private void AddMoreJobs()
        {
            try
            {
                if (ViewState["JobDetails"] != null)
                {
                    DataTable datatable = (DataTable)ViewState["JobDetails"];
                    DataRow datarow = null;
                    if (datatable.Rows.Count > 0)
                    {
                        for (int i = 1; i <= datatable.Rows.Count; i++)
                        {
                            // Creating new row
                            datarow = datatable.NewRow();
                            datarow["CandidateId"] = hfCandidateId.Value.Trim();
                            datarow["JobPostLookingFor"] = txtJobPostLookingFor.Text.Trim();
                            datarow["Industry"] = ddlIndustry123.SelectedItem.Value;
                            datarow["Department"] = ddlDepartment123.SelectedItem.Value;
                            datarow["FunctionalRole"] = ddlFunctionalRole.SelectedItem.Value;
                            datarow["RelevantExperience"] = txtRelevantExp.Text.Trim();
                        }
                        // Removing initial row
                        if (datatable.Rows[0][0].ToString() == "")
                        {
                            datatable.Rows[0].Delete();
                            datatable.AcceptChanges();
                        }

                        // Add new record to the datatable
                        datatable.Rows.Add(datarow);

                        // Storing datatable to viewstate
                        ViewState["JobDetails"] = datatable;

                        // Binding gridview with new row
                        gvJobsLookingFor.DataSource = datatable;
                        gvJobsLookingFor.DataBind();
                    }
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Handles the Click event of btnSaveMoreJobs control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSaveMoreJobs_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["JobDetails"];
            CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
            CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
            var selectedcity = chklCity.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
            var selectedarea = chklArea.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
            var selectedstate = chklState.Items.Cast<ListItem>().Where(li => li.Selected).ToList();

            try
            {
                currentDesiredJobEntity.Candidateid = hfCandidateId.Value.Trim();
                currentDesiredJobEntity.Objective = txtObjective.Text.Trim();
                currentDesiredJobEntity.ProfileSummary = txtProfileSummary.Text.Trim();
                if (rbtEmployed.Checked)
                {
                    currentDesiredJobEntity.CurrentEmployeedUnemployeed = rbtEmployed.Text.Trim();
                }
                else
                {
                    currentDesiredJobEntity.CurrentEmployeedUnemployeed = rbtUnEmployed.Text.Trim();
                }
                currentDesiredJobEntity.TotalExperience = lblTotalExp.Text;
                currentDesiredJobEntity.ResumeHeadline = txtResumeHeadline.Text.Trim();
                currentDesiredJobEntity.CurrentWorkingStatus = ddlWorkStatus.SelectedItem.Text.Trim();
                currentDesiredJobEntity.CurrentAnualSal = Convert.ToDouble(txtcurrentannualsalary.Text);
                currentDesiredJobEntity.ExpectedAnualSal = Convert.ToDouble(txtexpectedsalary.Text);
                currentDesiredJobEntity.NoticePeriod = ddlNoticePeriod.SelectedItem.Text.Trim();

                var selectedStatus = chklEmploymentStatus.Items.Cast<ListItem>().Where(li => li.Selected).ToList();            
                currentDesiredJobEntity.EmploymentStatus = string.Join(",", selectedStatus.Select(x => x.Text));

                var selectedJobType = chklJobType.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                currentDesiredJobEntity.JobType = string.Join(",",selectedJobType.Select(x=>x.Text));

                var selectedCompanyType = chklCompanyType.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                currentDesiredJobEntity.CompanyType = string.Join(",",selectedCompanyType.Select(x=>x.Text));

                currentDesiredJobEntity.Availabilityforinterview = rblYesNo.SelectedItem.Text;
                currentDesiredJobEntity.TimeInWeekdays = "From" + ddlBeforeHours.SelectedItem.Text + "." + ddlBeforeMinutes.SelectedItem.Text + " " + ddlBeforeTime.SelectedItem.Text + " To " + ddlAfterHours.SelectedItem.Text + "." + ddlAfterMinutes.SelectedItem.Text + " " + ddlAfterTime.SelectedItem.Text + " " + ddlISTETE.SelectedItem.Text;
                currentDesiredJobEntity.PreferredCountry = Convert.ToInt32(ddlPreferredCountry.SelectedValue);
                currentDesiredJobEntity.PreferredState = "," + string.Join(",", selectedstate.Select(x => x.Value)) + ",";
                currentDesiredJobEntity.PreferredCity = "," + string.Join(",", selectedcity.Select(x => x.Value)) + ",";
                currentDesiredJobEntity.PreferrefArea = "," + string.Join(",", selectedarea.Select(x => x.Value)) + ",";

                currentDesiredJobEntity.BeforeTime = ddlBeforeHours.SelectedItem.Text + ":" + ddlBeforeMinutes.SelectedItem.Text + ":" + ddlBeforeTime.SelectedItem.Text;

                currentDesiredJobEntity.AfterTime = ddlAfterHours.SelectedItem.Text + ":" + ddlAfterMinutes.SelectedItem.Text + ":" + ddlAfterTime.SelectedItem.Text + ":" + ddlISTETE.SelectedItem.Text;

                currentDesiredJobBAL.SaveJobLookingDetailsBAL(dt);
                currentDesiredJobBAL.SaveDesiredJobDetailsBAL(currentDesiredJobEntity);
                currentDesiredJobBAL.SaveJobDetailsBAL(currentDesiredJobEntity);
                Response.Write("<script language='javascript'>alert('Details saved successfully')</script>");
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                dt = null;
                currentDesiredJobBAL = null;
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of rbtEmployed control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void rbtEmployed_CheckedChanged(object sender, EventArgs e)
        {
            divDesireJobDetails.Visible = true;
            divCurrentEmployer.Visible = true;
        }

        /// <summary>
        /// Handles the CheckedChanged event of rbtUnEmployed control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void rbtUnEmployed_CheckedChanged(object sender, EventArgs e)
        {
            divFresher.Visible = true;
           
        }

        /// <summary>
        /// Handles the Click event of btnCity control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnCity_Click(object sender, EventArgs e)
        {
            Panelcity.Visible = true;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of chklCity control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void chklCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedcity = chklCity.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                txtCity.Text = string.Join(",", selectedcity.Select(x => x.Text));
                DataSet ds = new DataSet();
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();

                string cityId = "," + string.Join(",", selectedcity.Select(x => x.Value)) + ",";
                ds = currentDesiredJobBAL.GetArea(cityId);
                if (ds != null)
                {
                    chklArea.DataSource = ds;
                    chklArea.DataTextField = "AreaName";
                    chklArea.DataValueField = "AreaId";
                    chklArea.DataBind();
                }
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of chklArea control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void chklArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedarea = chklArea.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                txtarea.Text = string.Join(",", selectedarea.Select(x => x.Text));
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Click event of btnarea button to select area of cities
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnarea_Click(object sender, EventArgs e)
        {
            PanelArea.Visible = true;
        }

        protected void rptrPastCurrentJobDetails_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Label lblCurrentComapny = (Label)e.Item.FindControl("lblCurrentComapny");
            CheckBox chkCurrentYes = (CheckBox)e.Item.FindControl("chkCurrentYes");
            Label lblCompanyName = (Label)e.Item.FindControl("lblCompanyName");
            TextBox txtComapnyName = (TextBox)e.Item.FindControl("txtComapnyName");
            Label lblDesignation = (Label)e.Item.FindControl("lblDesignation");
            TextBox txtDesignation = (TextBox)e.Item.FindControl("txtDesignation");
            Label lblRolesResponsibility = (Label)e.Item.FindControl("lblRolesResponsibility");
            TextBox txtRolesResponsibility = (TextBox)e.Item.FindControl("txtRolesResponsibility");
            Label lblFromMonth = (Label)e.Item.FindControl("lblFromMonth");
            Label lblFromYear = (Label)e.Item.FindControl("lblFromYear");
            Label lblTillMonth = (Label)e.Item.FindControl("lblTillMonth");
            Label lblTillYear = (Label)e.Item.FindControl("lblTillYear");
            DropDownList ddlFromMonth = (DropDownList)e.Item.FindControl("ddlFromMonth");
            DropDownList ddlFromYear = (DropDownList)e.Item.FindControl("ddlFromYear");
            DropDownList ddlTillMonth = (DropDownList)e.Item.FindControl("ddlTillMonth");
            DropDownList ddlTillYear = (DropDownList)e.Item.FindControl("ddlTillYear");
            Label lbltillword = (Label)e.Item.FindControl("lbltillword");
            Label lblIndustry = (Label)e.Item.FindControl("lblIndustry");
            Label lblDepartment = (Label)e.Item.FindControl("lblDepartment");
            DropDownList ddlIndustry = (DropDownList)e.Item.FindControl("ddlIndustry");
            DropDownList ddlDepartment = (DropDownList)e.Item.FindControl("ddlDepartment");
            Label lblEmploymentStatus = (Label)e.Item.FindControl("lblEmploymentStatus");
            RadioButtonList rbtlEmployementStatus = (RadioButtonList)e.Item.FindControl("rbtlEmployementStatus");
            Label lblJobType = (Label)e.Item.FindControl("lblJobType");
            RadioButtonList rblJobType = (RadioButtonList)e.Item.FindControl("rblJobType");
            Label lblCompanyType = (Label)e.Item.FindControl("lblCompanyType");
            RadioButtonList rblCompanyType = (RadioButtonList)e.Item.FindControl("rblCompanyType");
            Label lblReasonforjobchange = (Label)e.Item.FindControl("lblReasonforjobchange");
            TextBox txtReasonforJobchange = (TextBox)e.Item.FindControl("txtReasonforJobchange");

            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");
            LinkButton lnkUpdate = (LinkButton)e.Item.FindControl("lnkUpdate");
            LinkButton lnkCancel = (LinkButton)e.Item.FindControl("lnkCancel");

            if (e.CommandName == "edit")
            {
                lblCurrentComapny.Visible = false;
                chkCurrentYes.Visible = true;
                lblCompanyName.Visible = false;
                txtComapnyName.Visible = true;
                lblDesignation.Visible = false;
                txtDesignation.Visible = true;
                lblRolesResponsibility.Visible = false;
                txtRolesResponsibility.Visible = true;
                lblFromMonth.Visible = false;
                lblFromYear.Visible = false;
                lblTillMonth.Visible = false;
                lblTillYear.Visible = false;
                ddlFromMonth.Visible = true;
                ddlFromYear.Visible = true;
                ddlTillMonth.Visible = true;
                ddlTillYear.Visible = true;
                lbltillword.Visible = true;
                lblEmploymentStatus.Visible = false;
                rbtlEmployementStatus.Visible = true;
                lblJobType.Visible = false;
                rblJobType.Visible = true;
                lblCompanyType.Visible = false;
                rblCompanyType.Visible = true;
                lblReasonforjobchange.Visible = false;
                txtReasonforJobchange.Visible = true;

                lblIndustry.Visible = false;
                lblDepartment.Visible = false;

                ddlIndustry.Visible = true;
                ddlDepartment.Visible = true;

                lnkEdit.Visible = false;
                lnkDelete.Visible = false;
                lnkUpdate.Visible = true;
                lnkCancel.Visible = true;
            }
            if (e.CommandName == "update")
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
                currentDesiredJobEntity.CurrentCompanyOrNot = chkCurrentYes.Checked.ToString();
                currentDesiredJobEntity.CompanyName = txtComapnyName.Text.Trim();
                currentDesiredJobEntity.Designation = txtDesignation.Text.Trim();
                currentDesiredJobEntity.Industry = ddlIndustry.SelectedValue;
                currentDesiredJobEntity.RolesResponsibility = lblRolesResponsibility.Text.Trim();
                currentDesiredJobEntity.FromMonth = ddlFromMonth.SelectedItem.Value;
                currentDesiredJobEntity.FromYear = ddlFromYear.SelectedItem.Value;
                currentDesiredJobEntity.TillMonth = ddlTillMonth.SelectedItem.Value;
                currentDesiredJobEntity.TillYear = ddlTillYear.SelectedItem.Value;
                currentDesiredJobEntity.CurrentEmploymentStatus = rbtlEmployementStatus.Text;
                currentDesiredJobEntity.JobType = rblJobType.Text;
                currentDesiredJobEntity.CompanyType = rblCompanyType.Text;
                currentDesiredJobEntity.ReasonForJobChange = txtReasonforJobchange.Text.Trim();

                currentDesiredJobEntity.Department = ddlDepartment.SelectedValue;

                currentDesiredJobEntity.ExpId = Convert.ToInt32(e.CommandArgument);
                DataSet ds = new DataSet();
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                currentDesiredJobBAL.UpdateCurrentPastExperienceDetailsBAL(currentDesiredJobEntity);

                BindRepeaterCurrentPastExp();
            }
            if (e.CommandName == "delete")
            {
                int expId = Convert.ToInt32(e.CommandArgument);
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                currentDesiredJobBAL.DeleteCurrentPastJobDetailsBAL(expId);

                BindRepeaterCurrentPastExp();
            }
            if (e.CommandName == "cancel")
            {
                BindRepeaterCurrentPastExp();
            }
        }

        protected void rptrJobPostLookinFor_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Label lblJobPostLooking = (Label)e.Item.FindControl("lblJobPostLooking");
            Label lblIndustry = (Label)e.Item.FindControl("lblIndustry");
            Label lblDepartment = (Label)e.Item.FindControl("lblDepartment");
            Label lblFunctionalRole = (Label)e.Item.FindControl("lblFunctionalRole");
            Label lblRelevantExperience = (Label)e.Item.FindControl("lblRelevantExperience");
            TextBox txtJobPostLooking = (TextBox)e.Item.FindControl("txtJobPostLooking");
            DropDownList ddlIndustry123 = (DropDownList)e.Item.FindControl("ddlIndustry123");
            DropDownList ddlDepartment123 = (DropDownList)e.Item.FindControl("ddlDepartment123");
            DropDownList ddlFunctionalRole = (DropDownList)e.Item.FindControl("ddlFunctionalRole");
            TextBox txtRelevantExperience = (TextBox)e.Item.FindControl("txtRelevantExperience");
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");
            LinkButton lnkUpdate = (LinkButton)e.Item.FindControl("lnkUpdate");
            LinkButton lnkCancel = (LinkButton)e.Item.FindControl("lnkCancel");

            if (e.CommandName == "edit")
            {
                lblJobPostLooking.Visible = false;
                lblIndustry.Visible = false;
                lblDepartment.Visible = false;
                lblFunctionalRole.Visible = false;
                lblRelevantExperience.Visible = false;
                txtJobPostLooking.Visible = true;
                ddlIndustry123.Visible = true;
                ddlDepartment123.Visible = true;
                ddlFunctionalRole.Visible = true;
                txtRelevantExperience.Visible = true;
                lnkEdit.Visible = false;
                lnkDelete.Visible = false;
                lnkUpdate.Visible = true;
                lnkCancel.Visible = true;
            }
            if (e.CommandName == "update")
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
                currentDesiredJobEntity.JobPostLookingFor = txtJobPostLooking.Text;
                currentDesiredJobEntity.Industry = ddlIndustry123.SelectedValue;

                currentDesiredJobEntity.Department = ddlDepartment123.SelectedValue;
                currentDesiredJobEntity.FunctionalRole = ddlFunctionalRole.SelectedValue;
                currentDesiredJobEntity.RelevantExp = txtRelevantExperience.Text;
                currentDesiredJobEntity.JobPostLookingId = Convert.ToInt32(e.CommandArgument);
                DataSet ds = new DataSet();
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                currentDesiredJobBAL.UpdateJobLookingBAL(currentDesiredJobEntity);

                BindRepeaterJobPostLooking();
            }
            if (e.CommandName == "delete")
            {
                int JobpostlookingId = Convert.ToInt32(e.CommandArgument);
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                currentDesiredJobBAL.DeleteJobPostLookingForBAL(JobpostlookingId);

                BindRepeaterJobPostLooking();
            }
            if (e.CommandName == "cancel")
            {
                BindRepeaterJobPostLooking();
            }
        }

        protected void rptrJobPostLookinFor_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
            DropDownList ddlIndustry123 = (DropDownList)e.Item.FindControl("ddlIndustry123");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //DataSet ds1 = new DataSet();

                //ds1 = currentDesiredJobBAL.ViewCurrentJobDetailsBAL(candidateId);
                //bindState();

                DataSet ds = new DataSet();
                ds = currentDesiredJobBAL.GetIndustry();
                if (ds != null)
                {
                    ddlIndustry123.DataSource = ds;
                    ddlIndustry123.DataTextField = "IndustryName";
                    ddlIndustry123.DataValueField = "IndustryId";
                    ddlIndustry123.DataBind();
                    ddlIndustry123.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Industry"));
                }
            }
            DropDownList ddlDepartment123 = (DropDownList)e.Item.FindControl("ddlDepartment123");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataSet ds1 = new DataSet();
                ds1 = currentDesiredJobBAL.GetDepartment();
                if (ds1 != null)
                {
                    ddlDepartment123.DataSource = ds1;
                    ddlDepartment123.DataTextField = "DepartmentName";
                    ddlDepartment123.DataValueField = "DepartmentId";
                    ddlDepartment123.DataBind();
                    ddlDepartment123.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Department"));
                }
            }
            DropDownList ddlFunctionalRole = (DropDownList)e.Item.FindControl("ddlFunctionalRole");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataSet ds2 = new DataSet();

                ds2 = currentDesiredJobBAL.GetFunctionalArea();
                if (ds2 != null)
                {
                    ddlFunctionalRole.DataSource = ds2;
                    ddlFunctionalRole.DataTextField = "FunctionalArea";
                    ddlFunctionalRole.DataValueField = "FunctionalAreaId";
                    ddlFunctionalRole.DataBind();
                    ddlFunctionalRole.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "FunctionalRole"));
                }
            }
        }

        protected void rptrPastCurrentJobDetails_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
            DropDownList ddlIndustry = (DropDownList)e.Item.FindControl("ddlIndustry");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //DataSet ds1 = new DataSet();

                //ds1 = currentDesiredJobBAL.ViewCurrentJobDetailsBAL(candidateId);
                //bindState();

                DataSet ds = new DataSet();
                ds = currentDesiredJobBAL.GetIndustry();
                if (ds != null)
                {
                    ddlIndustry.DataSource = ds;
                    ddlIndustry.DataTextField = "IndustryName";
                    ddlIndustry.DataValueField = "IndustryId";
                    ddlIndustry.DataBind();
                    ddlIndustry.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Industry"));
                }
            }
            DropDownList ddlDepartment = (DropDownList)e.Item.FindControl("ddlDepartment");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataSet ds1 = new DataSet();
                ds1 = currentDesiredJobBAL.GetDepartment();
                if (ds1 != null)
                {
                    ddlDepartment.DataSource = ds1;
                    ddlDepartment.DataTextField = "DepartmentName";
                    ddlDepartment.DataValueField = "DepartmentId";
                    ddlDepartment.DataBind();
                    ddlDepartment.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Department"));
                }
            }

            DropDownList ddlFromMonth = (DropDownList)e.Item.FindControl("ddlFromMonth");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                List<string> monthList = CommonUtil.Utility.GetMonths();
                ddlFromMonth.DataSource = monthList;

                ddlFromMonth.DataBind();

                ddlFromMonth.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "FromMonth"));
            }

            DropDownList ddlTillMonth = (DropDownList)e.Item.FindControl("ddlTillMonth");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                List<string> monthList = CommonUtil.Utility.GetMonths();
                ddlTillMonth.DataSource = monthList;

                ddlTillMonth.DataBind();

                ddlTillMonth.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "TillMonth"));
            }

            DropDownList ddlFromYear = (DropDownList)e.Item.FindControl("ddlFromYear");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                List<string> yearList = CommonUtil.Utility.GetYears();
                ddlFromYear.DataSource = yearList;
                ddlFromYear.DataBind();

                ddlFromYear.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "FromYear"));
            }

            DropDownList ddlTillYear = (DropDownList)e.Item.FindControl("ddlTillYear");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                List<string> yearList = CommonUtil.Utility.GetYears();
                ddlTillYear.DataSource = yearList;
                ddlTillYear.DataBind();

                ddlTillYear.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "TillYear"));
            }

            RadioButtonList rbtlEmployementStatus = (RadioButtonList)e.Item.FindControl("rbtlEmployementStatus");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                rbtlEmployementStatus.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "EmploymentStatus"));
            }

            RadioButtonList rblCompanyType = (RadioButtonList)e.Item.FindControl("rblCompanyType");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                rblCompanyType.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "CompanyType"));
            }

            RadioButtonList rblJobType = (RadioButtonList)e.Item.FindControl("rblJobType");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                rblJobType.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "JobType"));
            }
        }

        protected void ddlPreferredCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                int countryId = Convert.ToInt32(ddlPreferredCountry.SelectedValue);
                ds = currentDesiredJobBAL.GetState(countryId);
                if (ds != null)
                {
                    chklState.DataSource = ds;
                    chklState.DataTextField = "StateName";
                    chklState.DataValueField = "StateId";
                    chklState.DataBind();
                    chklState.Items.Insert(0, new ListItem("--Select--", "0"));
                }

                //}
            }
            catch (Exception)
            {
                // throw;
            }
        }

        protected void btnState_Click(object sender, EventArgs e)
        {
            PanelState.Visible = true;
        }

        protected void chklState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var selectedcity = chklCity.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
            //txtCity.Text = string.Join(",", selectedcity.Select(x => x.Text));

            try
            {
                var selectedstate = chklState.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                txtPreferredState.Text = string.Join(",", selectedstate.Select(x => x.Text));
                DataSet ds = new DataSet();
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();

                string stateId = "," + string.Join(",", selectedstate.Select(x => x.Value)) + ",";
                ds = currentDesiredJobBAL.GetCityBAL(stateId);
                if (ds != null)
                {
                    chklCity.DataSource = ds;
                    chklCity.DataTextField = "CityName";
                    chklCity.DataValueField = "CityId";
                    chklCity.DataBind();
                }

                //}
            }
            catch (Exception)
            {
                // throw;
            }
        }

        protected void rbFresher_CheckedChanged(object sender, EventArgs e)
        {
            divDesireJobDetails.Visible = true;
            divCurrentEmployer.Visible = false;
        }

        protected void rbExperienced_CheckedChanged(object sender, EventArgs e)
        {
            divCurrentEmployer.Visible = true;
            divDesireJobDetails.Visible = true;
        }
    }
}