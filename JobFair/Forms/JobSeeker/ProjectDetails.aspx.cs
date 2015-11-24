using BAL;
using System;
using System.Data;
using System.Globalization;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    /// <summary>
    /// Class ProjectDetails
    /// </summary>
    public partial class ProjectDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string candidateId = Convert.ToString(Session["candidateId"]);
            bool isCheck = true;
            //CheckAuthorised(candidateId);

            if (!IsPostBack)
            {
                GetRole();
                // Take Candidate Id from Session
                hfCandidateId.Value = candidateId;
                AddDefaultFirstRecord();
            }

            if (rbtYes.Checked)
            {
                panelProjectLink.Visible = true;
                return;
            }
            panelProjectLink.Visible = false;
            if(isCheck)
            {
                
            }
        }

        private void GetRole()
        {
            try
            {
                ProjectDetailsBAL projectDetailsBAL = new ProjectDetailsBAL();
                DataSet ds = new DataSet();
                ds = projectDetailsBAL.GetRole();
                ddlRole.DataSource = ds;
                ddlRole.DataTextField = "RoleName";
                ddlRole.DataValueField = "RoleId";
                ddlRole.DataBind();
                ddlRole.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void CheckAuthorised(string candidateId)
        {
            if (string.IsNullOrEmpty(candidateId))
            {
                string message = "Sorry your session has been expired !!!!";
                string url = "LogIn.aspx";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "');";
                script += "window.location = '";
                script += url;
                script += "'; }";
                ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            AddNewRecordRowToGrid();
            txtProjectTitle.Text = "";
            txtCompanyName.Text = "";
            txtClientName.Text = "";
            txtFromDate.Text = "";
            txtTodate.Text = "";
            txtLocation.Text = "";
            txtProjectDetails.Text = "";
            txtRolesAndResponsibility.Text = "";
            txtSkillUsed.Text = "";
            txtLink.Text = "";
            ddlAcademicLevel.SelectedIndex = 0;
            ddlTeamSize.SelectedIndex = 0;
        }

        private void AddNewRecordRowToGrid()
        {
            try
            {
                if (ViewState["ProjectDetails"] != null)
                {
                    DataTable dtCurrentTable = (DataTable)ViewState["ProjectDetails"];
                    DataRow drCurrentRow = null;

                    if (dtCurrentTable.Rows.Count > 0)
                    {
                        for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                        {
                            TimeSpan o = new TimeSpan(0, 0, 0);
                            DateTime startDate = Convert.ToDateTime(this.txtFromDate.Text.Trim(), new CultureInfo("en-Gb"));
                            DateTime endDate = Convert.ToDateTime(this.txtTodate.Text.Trim(), new CultureInfo("en-Gb"));
                            o += endDate.Subtract(startDate);
                            int days = o.Days;
                            // Creating new row and assigning values
                            drCurrentRow = dtCurrentTable.NewRow();
                            drCurrentRow["CandidateId"] = hfCandidateId.Value.Trim();
                            drCurrentRow["ProjectFor"] = rbtProjectTypeList.SelectedItem.Text;
                            drCurrentRow["ProjectTitle"] = txtProjectTitle.Text.Trim();
                            drCurrentRow["CompanyName"] = txtCompanyName.Text.Trim();
                            drCurrentRow["Role"] = ddlRole.SelectedItem.Text;
                            drCurrentRow["ClientName"] = txtClientName.Text.Trim();
                            drCurrentRow["Duration"] = Convert.ToInt32(days);
                            drCurrentRow["ProjectLocation"] = txtLocation.Text.Trim();

                            if (rbtFullTime.Checked)
                            {
                                drCurrentRow["EmploymentType"] = "FullTime";
                            }
                            else if (rbtPartTime.Checked)
                            {
                                drCurrentRow["EmploymentType"] = "PartTime";
                            }

                            drCurrentRow["ProjectDetails"] = txtProjectDetails.Text.Trim();
                            drCurrentRow["RolesandResponsibility"] = txtRolesAndResponsibility.Text.Trim();
                            drCurrentRow["TeamSize"] = ddlTeamSize.SelectedItem.Text;
                            drCurrentRow["SkillUsed"] = txtSkillUsed.Text.Trim();

                            if (rbtYes.Checked)
                            {
                                drCurrentRow["ProjectLive"] = "Yes";
                            }
                            else if (rbtNo.Checked)
                            {
                                drCurrentRow["ProjectLive"] = "No";
                            }
                            drCurrentRow["ProjectLink"] = txtLink.Text.Trim();
                            drCurrentRow["Degree"] = ddlAcademicLevel.SelectedItem.Text.Trim();
                        }
                        // Removing initial blank row
                        if (dtCurrentTable.Rows[0][0].ToString() == "")
                        {
                            dtCurrentTable.Rows[0].Delete();
                            dtCurrentTable.AcceptChanges();
                        }

                        // Added New Record to the DataTable
                        dtCurrentTable.Rows.Add(drCurrentRow);
                        // Storing DataTable to ViewState
                        ViewState["ProjectDetails"] = dtCurrentTable;
                        // Binding Gridview with New Row
                        grdProjectDetails.DataSource = dtCurrentTable;
                        grdProjectDetails.DataBind();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AddDefaultFirstRecord()
        {
            try
            {
                // Creating DataTable
                DataTable dt = new DataTable();
                DataRow dr;
                dt.TableName = "ProjectDetails";
                // Creating columns for DataTable
                dt.Columns.Add(new DataColumn("CandidateId", typeof(string)));
                dt.Columns.Add(new DataColumn("ProjectFor", typeof(string)));
                dt.Columns.Add(new DataColumn("ProjectTitle", typeof(string)));
                dt.Columns.Add(new DataColumn("CompanyName", typeof(string)));
                dt.Columns.Add(new DataColumn("Role", typeof(string)));
                dt.Columns.Add(new DataColumn("ClientName", typeof(string)));
                dt.Columns.Add(new DataColumn("Duration", typeof(int)));
                dt.Columns.Add(new DataColumn("ProjectLocation", typeof(string)));
                dt.Columns.Add(new DataColumn("EmploymentType", typeof(string)));
                dt.Columns.Add(new DataColumn("ProjectDetails", typeof(string)));
                dt.Columns.Add(new DataColumn("RolesandResponsibility", typeof(string)));
                dt.Columns.Add(new DataColumn("TeamSize", typeof(string)));
                dt.Columns.Add(new DataColumn("SkillUsed", typeof(string)));
                dt.Columns.Add(new DataColumn("ProjectLive", typeof(string)));
                dt.Columns.Add(new DataColumn("ProjectLink", typeof(string)));
                dt.Columns.Add(new DataColumn("Degree", typeof(string)));
                dr = dt.NewRow();
                dt.Rows.Add(dr);

                ViewState["ProjectDetails"] = dt;
                grdProjectDetails.DataSource = dt;
                grdProjectDetails.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnsubmitProject control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnsubmitProject_Click(object sender, EventArgs e)
        {
            ProjectDetailsBAL projectDetailsBAL = new ProjectDetailsBAL();
            DataTable dtProjectDetails = (DataTable)ViewState["ProjectDetails"];
            projectDetailsBAL.SaveProjectDetailsBAL(dtProjectDetails);
            grdProjectDetails.DataSource = null;
            grdProjectDetails.DataBind();
            ViewState["ProjectDetails"] = null;
            Response.Write("<script language='javascript'>alert('Project Details Inserted')</script>");
        }

        protected void rbtProjectTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtProjectTypeList.SelectedValue == "1")
                {
                    panelAcademicLevel.Visible = true;
                    return;
                }
                panelAcademicLevel.Visible = false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}