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
                hfCandidateId.Value = "JS3";
                AddExperienceRecords();
                AddJobLookingRecords();
            }
        }

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
            // try
            //{
            //    string[] months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
            //    List<string> monthList = null;
            //    monthList = new List<string>(months);
            //    monthList.RemoveAt(12);
            //    return monthList;
            //}
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

        private void BindFunctionalArea()
        {
            try
            {
                DataSet ds = new DataSet();
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

        private void BindDepartment()
        {
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

        private void BindIndustry()
        {
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

        private void BindArea()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = currentjobBAL.GetArea();
                ddlArea.DataSource = ds;
                ddlArea.DataTextField = "AreaName";
                ddlArea.DataValueField = "AreaId";
                ddlArea.DataBind();
                ddlArea.Items.Insert(0, new ListItem("--Select--", "0"));
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

        private void BindCity()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = currentjobBAL.GetCity();
                ddlPreferredCity.DataSource = ds;
                ddlPreferredCity.DataTextField = "CityName";
                ddlPreferredCity.DataValueField = "CityId";
                ddlPreferredCity.DataBind();
                ddlPreferredCity.Items.Insert(0, new ListItem("--Select--", "0"));
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

        protected void btnSaveCurrentJob_Click(object sender, EventArgs e)
        {
            CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
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

        private void AddNewRecordToGrid()
        {
            int months = MonthDifference();

            double year = Math.Abs((double)months / 12);
            Label1.Text = (Math.Abs((double)months / 12)).ToString();

            //            public static int MonthDifference(this DateTime lValue, DateTime rValue)
            //{
            //    return (lValue.Month - rValue.Month) + 12 * (lValue.Year - rValue.Year);
            //}
            //            public static int MonthDifference(this DateTime lValue, DateTime rValue)
            //{
            //    return Math.Abs((lValue.Month - rValue.Month) + 12 * (lValue.Year - rValue.Year));
            //}
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

        private int MonthDifference()
        {
            DateTime d1 = new DateTime(Convert.ToInt32(ddlFromYear.SelectedItem.Text), Convert.ToInt32(ddlFromMonth.SelectedIndex + 1), 1);
            DateTime d2 = new DateTime(Convert.ToInt32(ddlTillYear.SelectedItem.Text), Convert.ToInt32(ddlTillMonth.SelectedIndex + 1), 1);
            return (d2.Month - d1.Month) + 12 * (d2.Year - d1.Year);

            //            public static int MonthDifference(this DateTime lValue, DateTime rValue)
            //{
            //    return (lValue.Month - rValue.Month) + 12 * (lValue.Year - rValue.Year);

            //}
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
                    DataTable datatable = (DataTable)ViewState["JobDetails"];
                    DataRow datarow = null;
                    if (datatable.Rows.Count > 0)
                    {
                        for (int i = 1; i <= datatable.Rows.Count; i++)
                        {
                            //creating new row
                            datarow = datatable.NewRow();
                            datarow["CandidateId"] = hfCandidateId.Value.Trim();
                            datarow["JobPostLookingFor"] = txtJobPostLookingFor.Text.Trim();
                            datarow["Industry"] = ddlIndustry123.SelectedItem.Value;
                            datarow["Department"] = ddlDepartment123.SelectedItem.Value;
                            datarow["FunctionalRole"] = ddlFunctionalRole.SelectedItem.Value;
                            datarow["RelevantExperience"] = txtRelevantExp.Text.Trim();
                        }
                        //Removing initial row
                        if (datatable.Rows[0][0].ToString() == "")
                        {
                            datatable.Rows[0].Delete();
                            datatable.AcceptChanges();
                        }

                        //add new record to the datatable
                        datatable.Rows.Add(datarow);

                        //storing datatable to viewstate
                        ViewState["JobDetails"] = datatable;

                        //binding gridview with new row
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

        protected void btnSaveMoreJobs_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["JobDetails"];
            CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
            try
            {
                currentDesiredJobBAL.SaveJobLookingDetailsBAL(dt);
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
    }
}