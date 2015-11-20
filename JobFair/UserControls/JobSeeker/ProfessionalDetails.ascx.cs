using BAL;
using Entities.JobSeeker;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    public partial class ProfessionalDetails : System.Web.UI.UserControl
    {
        private string candidateId;
        static double Temp = 0;
        private bool isCheck = true;
        /// <summary>
        /// Handles the Load event of Page
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
             //candidateId = Convert.ToString(Session["candidateId"]);
            candidateId = "JS3";
            if (!IsPostBack)
            {
                if (isCheck)
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                        ds = currentDesiredJobBAL.ViewCurrentJobDetailsBAL(candidateId);

                        BindRepeaterJobPostLooking();

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {
                    bindState();
                    BindMonth();
                    BindYear();

                    BindFunctionalArea();
                    BindIndustry();
                    BindDepartment();
                    hfCandidateId.Value = "JS3";
                    AddExperienceRecords();
                    AddJobLookingRecords();
                }
            }
        }

        private void BindRepeaterJobPostLooking()
        {
            DataSet ds = new DataSet();
             CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
             ds = currentDesiredJobBAL.ViewCurrentJobDetailsBAL(candidateId);
           
          
            rptrJobPostLookinFor.DataSource = ds;
            rptrJobPostLookinFor.DataBind();
            
        }
        /// <summary>
        /// Method Bind state to the ddlState control
        /// </summary>
        private void bindState()
        {
            CurrentDesiredJobBAL currentjobBAL = new CurrentDesiredJobBAL();
            DataSet ds = new DataSet();
            try
            {
                ds = currentjobBAL.GetStateBAL();
                ddlState.DataSource = ds;
                ddlState.DataTextField = "StateName";
                ddlState.DataValueField = "StateId";
                ddlState.DataBind();
                ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
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
                throw;
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
                throw;
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
                throw;
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
                ddlFunctionalRole.DataSource = ds;
                ddlFunctionalRole.DataTextField = "FunctionalArea";
                ddlFunctionalRole.DataValueField = "FunctionalAreaId";
                ddlFunctionalRole.DataBind();
                ddlFunctionalRole.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
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
                throw;
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
            catch (Exception)
            {
                throw;
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
            catch (Exception)
            {
                throw;
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
                throw;
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
                throw;
            }
        }
        /// <summary>
        /// Method to Bind data of datatable to gvExperience control
        /// </summary>
        private void AddNewRecordToGrid()
        {
            double months = MonthDifference();
            
            Label1.Text = months.ToString();

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
                throw;
            }
        }
        /// <summary>
        /// Method to count difference between two dates and total experience
        /// </summary>
        /// <returns>System.Double</returns>
        private double MonthDifference()
        {
            DateTime d1 = new DateTime(Convert.ToInt32(ddlFromYear.SelectedItem.Text), Convert.ToInt32(ddlFromMonth.SelectedIndex + 1), 1);
            DateTime d2 = new DateTime(Convert.ToInt32(ddlTillYear.SelectedItem.Text), Convert.ToInt32(ddlTillMonth.SelectedIndex + 1), 1);
            int months = (d2.Month - d1.Month) + 12 * (d2.Year - d1.Year);
            double year = Math.Abs((double)months / 12);            
            Temp = Temp + year;
            return Temp;           
        }
        /// <summary>
        /// Handles the click event of btnAddMoreJobPost control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnAddMoreJobPost_Click(object sender, EventArgs e)
        {
            AddMoreJobs();
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
                throw;
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
                currentDesiredJobEntity.TotalExperience = Label1.Text;
                currentDesiredJobEntity.ResumeHeadline = txtResumeHeadline.Text.Trim();
                currentDesiredJobEntity.CurrentWorkingStatus = ddlWorkStatus.SelectedItem.Text.Trim();
                currentDesiredJobEntity.CurrentAnualSal = Convert.ToDouble(txtcurrentannualsalary.Text);
                currentDesiredJobEntity.ExpectedAnualSal = Convert.ToDouble(txtexpectedsalary.Text);
                currentDesiredJobEntity.NoticePeriod = ddlNoticePeriod.SelectedItem.Text.Trim();
                currentDesiredJobEntity.EmploymentStatus = rblEmploymentStatus.Text;
                currentDesiredJobEntity.JobType = rblJobType123.SelectedItem.Text;
                currentDesiredJobEntity.CompanyType = rblCompanyType123.SelectedItem.Text;
                currentDesiredJobEntity.Availabilityforinterview = rblYesNo.SelectedItem.Text;
                currentDesiredJobEntity.TimeInWeekdays = "From" + ddlBeforeHours.SelectedItem.Text + "." + ddlBeforeMinutes.SelectedItem.Text + " " + ddlBeforeTime.SelectedItem.Text + " To " + ddlAfterHours.SelectedItem.Text + "." + ddlAfterMinutes.SelectedItem.Text + " " + ddlAfterTime.SelectedItem.Text + " " + ddlISTETE.SelectedItem.Text;
                currentDesiredJobEntity.PreferredCity = "," + string.Join(",", selectedcity.Select(x => x.Value)) + ",";
                currentDesiredJobEntity.PreferrefArea = "," + string.Join(",", selectedarea.Select(x => x.Value)) + ",";
                currentDesiredJobBAL.SaveJobLookingDetailsBAL(dt);
                currentDesiredJobBAL.SaveDesiredJobDetailsBAL(currentDesiredJobEntity);
                currentDesiredJobBAL.SaveJobDetailsBAL(currentDesiredJobEntity);
                Response.Write("<script language='javascript'>alert('Details saved successfully')</script>");
            }
            catch (Exception)
            {
                throw;
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
            divDesireJobDetails.Visible = true;
            divCurrentEmployer.Visible = false;
        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of ddlState control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                int stateId = Convert.ToInt32(ddlState.SelectedValue);
                ds = currentDesiredJobBAL.GetCity(stateId);
                chklCity.DataSource = ds;
                chklCity.DataTextField = "cityName";
                chklCity.DataValueField = "cityID";
                chklCity.DataBind();
                chklCity.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
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
                //for(int i=1;i<=chklCity.Items.Cast<ListItem>().Count(li => li.Selected);i++)
                //{
                //int cityId = Convert.ToInt32(chklCity.SelectedValue);
                string cityId = "," + string.Join(",", selectedcity.Select(x => x.Value)) + ",";
                ds = currentDesiredJobBAL.GetArea(cityId);
                chklArea.DataSource = ds;
                chklArea.DataTextField = "AreaName";
                chklArea.DataValueField = "AreaId";
                chklArea.DataBind();
                //}
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of chklArea control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void chklArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedarea = chklArea.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
            txtarea.Text = string.Join(",", selectedarea.Select(x => x.Text));
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

        }

        protected void rptrJobPostLookinFor_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "edit")
            {
                ((Label)e.Item.FindControl("lblJobPostLooking")).Visible = false;
                ((Label)e.Item.FindControl("lblIndustry")).Visible = false;
                ((Label)e.Item.FindControl("lblDepartment")).Visible = false;
                ((Label)e.Item.FindControl("lblFunctionalRole")).Visible = false;
                ((Label)e.Item.FindControl("lblRelevantExperience")).Visible = false;
                ((TextBox)e.Item.FindControl("txtJobPostLooking")).Visible = true;
                ((DropDownList)e.Item.FindControl("ddlIndustry")).Visible = true;
                ((DropDownList)e.Item.FindControl("ddlDepartment")).Visible = true;
                ((DropDownList)e.Item.FindControl("ddlFunctionalRole")).Visible = true;
                ((TextBox)e.Item.FindControl("txtRelevantExperience")).Visible = true;
                ((LinkButton)e.Item.FindControl("lnkEdit")).Visible = false;
                ((LinkButton)e.Item.FindControl("lnkDelete")).Visible = false;
                ((LinkButton)e.Item.FindControl("lnkUpdate")).Visible = true;
                ((LinkButton)e.Item.FindControl("lnkCancel")).Visible = true;
            }
            if (e.CommandName == "update")
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
                currentDesiredJobEntity.JobPostLookingFor = ((TextBox)e.Item.FindControl("txtJobPostLooking")).Text;
               currentDesiredJobEntity.Industry=((DropDownList)e.Item.FindControl("ddlIndustry")).SelectedItem.Value;
               
               currentDesiredJobEntity.Department = ((DropDownList)e.Item.FindControl("ddlDepartment")).SelectedItem.Value;
                currentDesiredJobEntity.FunctionalRole = ((DropDownList)e.Item.FindControl("ddlFunctionalRole")).SelectedItem.Value;
                currentDesiredJobEntity.RelevantExp = ((TextBox)e.Item.FindControl("txtRelevantExperience")).Text;
                DataSet ds = new DataSet();
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                 currentDesiredJobBAL.UpdateJobLookingBAL(candidateId);
               
                BindRepeaterJobPostLooking();
            }
            if (e.CommandName == "delete")
            {
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                currentDesiredJobBAL.DeleteJobPostLookingForBAL(candidateId);
               
                BindRepeaterJobPostLooking();
            }
            if (e.CommandName == "cancel")
            {
                ((Label)e.Item.FindControl("lblJobPostLooking")).Visible = true;
                ((Label)e.Item.FindControl("lblIndustry")).Visible = true;
                ((Label)e.Item.FindControl("lblDepartment")).Visible = true;
                ((Label)e.Item.FindControl("lblFunctionalRole")).Visible = true;
                ((Label)e.Item.FindControl("lblRelevantExperience")).Visible = true;
                ((TextBox)e.Item.FindControl("txtJobPostLooking")).Visible = false;
                ((DropDownList)e.Item.FindControl("ddlIndustry")).Visible = false;
                ((DropDownList)e.Item.FindControl("ddlDepartment")).Visible = false;
                ((DropDownList)e.Item.FindControl("ddlFunctionalRole")).Visible = false;
                ((TextBox)e.Item.FindControl("txtRelevantExperience")).Visible = false;
                ((LinkButton)e.Item.FindControl("lnkEdit")).Visible = true;
                ((LinkButton)e.Item.FindControl("lnkDelete")).Visible = true;
                ((LinkButton)e.Item.FindControl("lnkUpdate")).Visible = false;
                ((LinkButton)e.Item.FindControl("lnkCancel")).Visible = false;
            }
    
        }
    }
}