using BAL;
using Entities.JobSeeker;
using System;
using System.Data;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;


namespace JobFair.Forms.JobSeeker
{
    /// <summary>
    /// Class ProjectDetails
    /// </summary>
    public partial class ProjectDetails : System.Web.UI.Page
    {
      
        private bool isCheck;
        private string candidateId;

     
        protected void Page_Load(object sender, EventArgs e)
        {
            isCheck = Convert.ToBoolean(Request.QueryString["isCheck"]);
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
                            GetRole();

                            hfCandidateId.Value = candidateId;
                            AddDefaultFirstRecord();

                            if (isCheck)
                            {
                                pnlEdit.Visible = true;
                                BindRepeater();
                            }
                            else
                            {
                                pnlInsert.Visible = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            //  throw;
                        }
                    }
                    if (rbtYes.Checked)
                    {
                        panelProjectLink.Visible = true;
                        return;
                    }
                    panelProjectLink.Visible = false;
                }
            }
        }

        /// <summary>
        /// Bind Repeater for ProjectDetails.
        /// </summary>
        private void BindRepeater()
        {
            try
            {
                DataSet ds = new DataSet();
                ProjectDetailsBAL projectDetailsBAL = new ProjectDetailsBAL();
                ds = projectDetailsBAL.ViewProjectDetailsBAL(candidateId);
                if (ds != null)
                {
                    rptrProjectDetails.DataSource = ds;
                    rptrProjectDetails.DataBind();
                }
            }
            catch (Exception)
            {
                // throw;
            } 
        }

        protected void rptrProjectDetails_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            LinkButton lnkUpdate = (LinkButton)e.Item.FindControl("lnkUpdate");
            LinkButton lnkCancel = (LinkButton)e.Item.FindControl("lnkCancel");
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");
            Label lblrptID = (Label)e.Item.FindControl("lblID");
            Label lblProjectFor = (Label)e.Item.FindControl("lblProjectFor");
            Label lblProjectTiltle = (Label)e.Item.FindControl("lblProjectTiltle");
            Label lblCompanyName = (Label)e.Item.FindControl("lblCompanyName");
            Label lblClientName = (Label)e.Item.FindControl("lblClientName");
            Label lblDuration = (Label)e.Item.FindControl("lblDuration");
            Label lblProjectLocation = (Label)e.Item.FindControl("lblProjectLocation");
            Label lblEmploymentType = (Label)e.Item.FindControl("lblEmploymentType");
            Label lblProjectDetails = (Label)e.Item.FindControl("lblProjectDetails");
            Label lblRolesandResponsibility = (Label)e.Item.FindControl("lblRolesandResponsibility");
            Label lblSkillUsed = (Label)e.Item.FindControl("lblSkillUsed");
            Label lblProjectLive = (Label)e.Item.FindControl("lblProjectLive");
            Label lblProjectLink = (Label)e.Item.FindControl("lblProjectLink");
            TextBox txtProjectTiltle = (TextBox)e.Item.FindControl("txtProjectTiltle");
            TextBox txtCompanyName = (TextBox)e.Item.FindControl("txtCompanyName");
            TextBox txtClientName = (TextBox)e.Item.FindControl("txtClientName");
            TextBox txtDuration = (TextBox)e.Item.FindControl("txtDuration");
            TextBox txtProjectLocation = (TextBox)e.Item.FindControl("txtProjectLocation");
            TextBox txtEmploymentType = (TextBox)e.Item.FindControl("txtEmploymentType");
            TextBox txtProjectDetails = (TextBox)e.Item.FindControl("txtProjectDetails");
            TextBox txtRolesandResponsibility = (TextBox)e.Item.FindControl("txtRolesandResponsibility");
            TextBox txtSkillUsed = (TextBox)e.Item.FindControl("txtSkillUsed");
            TextBox txtProjectLive = (TextBox)e.Item.FindControl("txtProjectLive");
            TextBox txtProjectLink = (TextBox)e.Item.FindControl("txtProjectLink");
            DropDownList ddlRole = (DropDownList)e.Item.FindControl("ddlRole");
            DropDownList ddlTeamSize = (DropDownList)e.Item.FindControl("ddlTeamSize");
            DropDownList ddlProjectFor = (DropDownList)e.Item.FindControl("ddlProjectFor");
            DropDownList ddlDegree = (DropDownList)e.Item.FindControl("ddlDegree");
            CheckBox chkDelete = (CheckBox)e.Item.FindControl("chkDelete");

            if (e.CommandName == "edit")
            {
                lnkCancel.Visible = true;
                lnkUpdate.Visible = true;
                lnkEdit.Visible = false;
                txtProjectTiltle.Visible = true;
                txtCompanyName.Visible = true;
                txtClientName.Visible = true;
                txtDuration.Visible = true;
                txtEmploymentType.Visible = true;
                txtRolesandResponsibility.Visible = true;
                txtProjectLive.Visible = true;
                txtProjectLocation.Visible = true;
                txtProjectLink.Visible = true;
                txtSkillUsed.Visible = true;
                txtProjectDetails.Visible = true;
                txtProjectLink.Visible = true;
                ddlProjectFor.Visible = true;
                lblProjectFor.Visible = false;
                lblProjectTiltle.Visible = false;
                lblCompanyName.Visible = false;
                lblClientName.Visible = false;
                lblDuration.Visible = false;
                lblProjectLocation.Visible = false;
                lblEmploymentType.Visible = false;
                lblProjectDetails.Visible = false;
                lblRolesandResponsibility.Visible = false;
                lblSkillUsed.Visible = false;
                lblProjectLive.Visible = false;
                lblProjectLink.Visible = false;
            }
            if (e.CommandName == "cancel")
            {
                BindRepeater();
            }
            if (e.CommandName == "update")
            {
                try
                {
                    ProjectDetailsBAL projectDetailsBAL = new ProjectDetailsBAL();
                    ProjectDetailsEntity projectDetailsEntity = new ProjectDetailsEntity();
                    projectDetailsEntity.ProjectTitle = txtProjectTiltle.Text;
                    projectDetailsEntity.CompanyName = txtCompanyName.Text;
                    projectDetailsEntity.YourRole = Convert.ToInt32(ddlRole.SelectedValue);
                    projectDetailsEntity.ClientName = txtClientName.Text;
                    projectDetailsEntity.Duration = txtDuration.Text;
                    projectDetailsEntity.ProjectLocation = txtProjectLocation.Text;
                    projectDetailsEntity.EmploymentType = txtEmploymentType.Text;
                    projectDetailsEntity.ProjectDescription = txtProjectDetails.Text;
                    projectDetailsEntity.RolesandResponsibility = txtRolesandResponsibility.Text;
                    projectDetailsEntity.TeamSize = ddlTeamSize.SelectedValue;
                    projectDetailsEntity.SkillUsed = txtSkillUsed.Text;
                    projectDetailsEntity.ProjectLive = txtProjectLive.Text;
                    projectDetailsEntity.ProjectLink = txtProjectLink.Text;
                    projectDetailsEntity.Degree = ddlDegree.SelectedValue;
                    projectDetailsEntity.ProjectFor = ddlProjectFor.SelectedValue;
                    projectDetailsEntity.ProjectId = Convert.ToInt32(e.CommandArgument);
                    projectDetailsBAL.UpdateProjectDetailsBAL(projectDetailsEntity);
                }
                catch (Exception ex)
                {
                    //  throw;
                }

                BindRepeater();
            }
            if (e.CommandName == "delete")
            {
                try
                {
                    ProjectDetailsBAL projectDetailsBAL = new ProjectDetailsBAL();
                    int projectId = Convert.ToInt32(e.CommandArgument);
                    projectDetailsBAL.DeleteProjectDetailsBAL(projectId);
                }
                catch (Exception)
                {
                    // throw;
                }
                BindRepeater();
            }
        }

        protected void rptrProjectDetails_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            DropDownList ddlRole = (DropDownList)e.Item.FindControl("ddlRole");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                try
                {
                    ProjectDetailsBAL projectDetailsBAL = new ProjectDetailsBAL();
                    DataSet ds = new DataSet();
                    ds = projectDetailsBAL.GetRole();
                    if (ds != null)
                    {
                        ddlRole.DataSource = ds;
                        ddlRole.DataTextField = "RoleName";
                        ddlRole.DataValueField = "RoleId";
                        ddlRole.DataBind();
                        ddlRole.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "RoleId"));
                    }
                }
                catch (Exception)
                {
                    // throw;
                }
            }
            DropDownList ddlTeamSize = (DropDownList)e.Item.FindControl("ddlTeamSize");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                ddlTeamSize.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "TeamSize"));
            }
            DropDownList ddlDegree = (DropDownList)e.Item.FindControl("ddlDegree");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                ddlDegree.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Degree"));
            }
            DropDownList ddlProjectFor = (DropDownList)e.Item.FindControl("ddlProjectFor");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                ddlProjectFor.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProjectFor"));
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //foreach (RepeaterItem Item in cpRepeater.Items)
            //{
            //    CheckBox chkDelete = (CheckBox)Item.FindControl("chkDelete");
            //    Label lblrptID = (Label)Item.FindControl("lblID");

            //    if (chkDelete.Checked)
            //    {
            //        SqlConnection SqlCnn = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ConnectionString);
            //        SqlCommand SqlCmd = new SqlCommand("delete JS_ProjectDetail where ProjectId=@ID", SqlCnn);
            //        SqlCmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = lblrptID.Text;
            //        SqlCmd.Connection = SqlCnn;
            //        SqlCnn.Open();
            //        SqlCmd.ExecuteNonQuery();
            //        SqlCnn.Close();
            //    }
            //}
            //BindRepeater();
        }

        /// <summary>
        /// Bind Functional roles.
        /// </summary>
        private void GetRole()
        {
            try
            {
                ProjectDetailsBAL projectDetailsBAL = new ProjectDetailsBAL();
                DataSet ds = new DataSet();
                ds = projectDetailsBAL.GetRole();
                if (ds != null)
                {
                    ddlRole.DataSource = ds;
                    ddlRole.DataTextField = "RoleName";
                    ddlRole.DataValueField = "RoleId";
                    ddlRole.DataBind();
                    ddlRole.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
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

        /// <summary>
        /// Add project to GridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            drCurrentRow["RoleId"] = ddlRole.SelectedValue;
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
                // throw;
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
                dt.Columns.Add(new DataColumn("RoleId", typeof(int)));
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
                // throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnsubmitProject control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnsubmitProject_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectDetailsBAL projectDetailsBAL = new ProjectDetailsBAL();
                DataTable dtProjectDetails = (DataTable)ViewState["ProjectDetails"];
                projectDetailsBAL.SaveProjectDetailsBAL(dtProjectDetails);
                grdProjectDetails.DataSource = null;
                grdProjectDetails.DataBind();
                ViewState["ProjectDetails"] = null;
                Response.Write("<script language='javascript'>alert('Project Details Inserted')</script>");
            }
            catch (Exception)
            {
                // throw;
            }
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
                //  throw;
            }
        }
    }
}