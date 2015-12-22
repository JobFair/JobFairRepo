using BAL;
using Entities.JobSeeker;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    /// <summary>
    /// TechnicalSkillsDetails Class
    /// </summary>
    public partial class TechnicalSkillsDetails : System.Web.UI.UserControl
    {
        private bool isCheck = true;
        private string candidateId;

        /// <summary>
        /// Handles the Load event of Page
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            candidateId = Convert.ToString(Session["candidateId"]);
            // Check session is not null
            if (string.IsNullOrEmpty(candidateId))
            {
                Response.Redirect("LogIn.aspx");
            }
            else
            {
                // Check page is not post back

                if (!IsPostBack)
                {
                    // Check the isCheck is true for edit
                    if (isCheck)
                    {
                        BindRepeaterTechnicalSkills();
                        divTechnicalRepeater.Visible = true;
                    }
                    else
                    {
                        BindTechnicalSkills();
                        BindMonth();
                        BindYears();
                        hfCandidateId.Value = candidateId;
                        AddTechnicalSkills();
                    }
                }
            }
        }

        /// <summary>
        /// Bind repeater to technical skills details
        /// </summary>
        private void BindRepeaterTechnicalSkills()
        {
            try
            {
                DataSet dsTechnicalSkills = new DataSet();
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                dsTechnicalSkills = currentDesiredJobBAL.ViewTechnicalSkillDetailsBAL(candidateId);
                // Check dataset is not null
                if (dsTechnicalSkills != null)
                {
                    rptrTechnicalSkills.DataSource = dsTechnicalSkills;
                    rptrTechnicalSkills.DataBind();
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method to Create Skills Record Table for gvSkillsDetails Control
        /// </summary>
        private void AddTechnicalSkills()
        {
            try
            {
                // Creating DataTable
                DataTable datatable = new DataTable();
                DataRow datarow;
                datatable.TableName = "SkillDetails";
                // Creating columns for DataTable
                datatable.Columns.Add(new DataColumn("CandidateId", typeof(string)));
                datatable.Columns.Add(new DataColumn("TechnicalSkills", typeof(int)));
                datatable.Columns.Add(new DataColumn("FromDate", typeof(string)));
                datatable.Columns.Add(new DataColumn("TillDate", typeof(string)));
                datatable.Columns.Add(new DataColumn("Proficiency", typeof(string)));
                datatable.Columns.Add(new DataColumn("TotalYear", typeof(string)));
                datarow = datatable.NewRow();
                datatable.Rows.Add(datarow);
                ViewState["SkillDetails"] = datatable;
                gvSkillsDetails.DataSource = datatable;
                gvSkillsDetails.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method Bind Year List to ddlFromYear Control
        /// </summary>
        private void BindYears()
        {
            try
            {
                List<string> yearlist = CommonUtil.Utility.GetYears();
                ddlFromYear.DataSource = yearlist;
                ddlTillYear.DataSource = yearlist;
                ddlFromYear.DataBind();
                ddlTillYear.DataBind();
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        /// <summary>
        /// Method to Bind Month List to ddlFromMonth Control
        /// </summary>
        private void BindMonth()
        {
            try
            {
                List<string> monthlist = CommonUtil.Utility.GetMonths();
                ddlFromMonth.DataSource = monthlist;
                ddlTillMonth.DataSource = monthlist;
                ddlFromMonth.DataBind();
                ddlTillMonth.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method to Create Skills Records Table for gvSkillsDetails Control
        /// </summary>
        private void BindTechnicalSkills()
        {
            try
            {
                DataSet dsTechnicalSkill = new DataSet();
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                dsTechnicalSkill = currentDesiredJobBAL.GetTechnicalSkillsDetailsBAL();
                // Check dataset is not null
                if (dsTechnicalSkill != null)
                {
                    ddlTechnicalSkills.DataSource = dsTechnicalSkill;
                    ddlTechnicalSkills.DataValueField = "TechnicalSkillId";
                    ddlTechnicalSkills.DataTextField = "TechnicalSkillName";
                    ddlTechnicalSkills.DataBind();
                    ddlTechnicalSkills.Items.Insert(Convert.ToInt32(ddlTechnicalSkills.Items[ddlTechnicalSkills.Items.Count - 1].Value), new ListItem("----Other----", ""));
                    ddlTechnicalSkills.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Handles the Click event of btnAddMoreSkills Control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnAddMoreSkills_Click(object sender, EventArgs e)
        {
            try
            {
                AddMoreSkills();
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        /// <summary>
        /// Method to Insert Data into gvSkillsDetails Control
        /// </summary>
        private void AddMoreSkills()
        {
            string year = TotalYears();
            try
            {
                // Check if viewstate is not null
                if (ViewState["SkillDetails"] != null)
                {
                    DataTable datatable = (DataTable)ViewState["SkillDetails"];
                    DataRow datarow = null;
                    // Check rows greater than zero
                    if (datatable.Rows.Count > 0)
                    {
                        for (int i = 1; i <= datatable.Rows.Count; i++)
                        {
                            // Creating new row
                            datarow = datatable.NewRow();
                            datarow["CandidateId"] = hfCandidateId.Value.Trim();
                            datarow["TechnicalSkills"] = ddlTechnicalSkills.SelectedItem.Value;
                            datarow["FromDate"] = ddlFromMonth.SelectedItem.Text.Trim() + "/" + ddlFromYear.SelectedItem.Text.Trim();
                            datarow["TillDate"] = ddlTillMonth.SelectedItem.Text.Trim() + "/" + ddlTillYear.SelectedItem.Text.Trim();
                            datarow["Proficiency"] = ddlProficiency.SelectedItem.Text.Trim();

                            // Calculate Year

                            datarow["TotalYear"] = year;
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
                        ViewState["SkillDetails"] = datatable;

                        // Binding gridview with new row
                        gvSkillsDetails.DataSource = datatable;
                        gvSkillsDetails.DataBind();
                    }
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method to Get Total Years of Experience
        /// </summary>
        /// <returns>System.String</returns>
        private string TotalYears()
        {
            double year = 0.0;
            DateTime fromMonth, tillMonth;
            try
            {
                fromMonth = new DateTime(Convert.ToInt32(ddlFromYear.SelectedItem.Text), Convert.ToInt32(ddlFromMonth.SelectedIndex + 1), 1);
                tillMonth = new DateTime(Convert.ToInt32(ddlTillYear.SelectedItem.Text), Convert.ToInt32(ddlTillMonth.SelectedIndex + 1), 1);
                int months = (tillMonth.Month - fromMonth.Month) + 12 * (tillMonth.Year - fromMonth.Year);
                year = Math.Abs((double)months / 12);
            }
            catch (Exception)
            {
                // throw;
            }
            return year.ToString();
        }

        /// <summary>
        /// Handles the Click event of btnSaveSkills Control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSaveSkills_Click(object sender, EventArgs e)
        {
            CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
            DataTable dt = (DataTable)ViewState["SkillDetails"];
            try
            {
                currentDesiredJobBAL.SaveTechnicalSkillsBAL(dt);
                Response.Write("<script language='javascript'>alert('Technical Skills Details saved successfully')</script>");
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
        /// Handles ItemCommand event of rptrTechnicalSkills control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void rptrTechnicalSkills_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Label lblTechnicalSkill = (Label)e.Item.FindControl("lblTechnicalSkill");
            Label lblFromDate = (Label)e.Item.FindControl("lblFromDate");
            Label lblTillDate = (Label)e.Item.FindControl("lblTillDate");
            Label lblProficiency = (Label)e.Item.FindControl("lblProficiency");

            DropDownList ddlTechnicalSkill = (DropDownList)e.Item.FindControl("ddlTechnicalSkill");
            DropDownList ddlFromMonth = (DropDownList)e.Item.FindControl("ddlFromMonth");
            DropDownList ddlFromYear = (DropDownList)e.Item.FindControl("ddlFromYear");
            DropDownList ddlTillMonth = (DropDownList)e.Item.FindControl("ddlTillMonth");
            DropDownList ddlTillYear = (DropDownList)e.Item.FindControl("ddlTillYear");
            DropDownList ddlProficiency = (DropDownList)e.Item.FindControl("ddlProficiency");

            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");
            LinkButton lnkUpdate = (LinkButton)e.Item.FindControl("lnkUpdate");
            LinkButton lnkCancel = (LinkButton)e.Item.FindControl("lnkCancel");
            // Check repeater commond for edit
            if (e.CommandName == "edit")
            {
                lblTechnicalSkill.Visible = false;
                lblFromDate.Visible = false;
                lblTillDate.Visible = false;
                lblProficiency.Visible = false;

                ddlTechnicalSkill.Visible = true;
                ddlFromMonth.Visible = true;
                ddlFromYear.Visible = true;
                ddlTillMonth.Visible = true;
                ddlTillYear.Visible = true;
                ddlProficiency.Visible = true;

                lnkEdit.Visible = false;
                lnkDelete.Visible = false;
                lnkUpdate.Visible = true;
                lnkCancel.Visible = true;
            }
            // Check repeater commond for update
            if (e.CommandName == "update")
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
                currentDesiredJobEntity.TechnicalSkills = ddlTechnicalSkill.SelectedItem.Text.Trim();
                currentDesiredJobEntity.FromDate = ddlFromMonth.SelectedItem.Text.Trim() + "/" + ddlFromYear.SelectedItem.Text.Trim();

                currentDesiredJobEntity.TillDate = ddlTillMonth.SelectedItem.Text.Trim() + "/" + ddlTillYear.SelectedItem.Text.Trim();

                currentDesiredJobEntity.Proficiency = ddlProficiency.SelectedItem.Text.Trim();

                currentDesiredJobEntity.SkillId = Convert.ToInt32(e.CommandArgument);
                currentDesiredJobEntity.TotalExperience = TotalYears();
                DataSet ds = new DataSet();
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                currentDesiredJobBAL.UpdateTechnicalSkillsBAL(currentDesiredJobEntity);

                BindRepeaterTechnicalSkills();
            }
            // Check repeater commond for delete
            if (e.CommandName == "delete")
            {
                int SkillId = Convert.ToInt32(e.CommandArgument);
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                currentDesiredJobBAL.DeleteTechnicalSkillBAL(SkillId);

                BindRepeaterTechnicalSkills();
            }
            // Check repeater commond for cancel
            if (e.CommandName == "cancel")
            {
                BindRepeaterTechnicalSkills();
            }
        }

        /// <summary>
        /// Handles ItemDataBound event of rptrTechnicalSkills control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void rptrTechnicalSkills_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            try
            {
                string fromDate, tillDate;
                int count = 0, count1 = 0;
                DataSet dsViewTechnicalSkills = new DataSet();
                CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
                dsViewTechnicalSkills = currentDesiredJobBAL.ViewTechnicalSkillDetailsBAL(candidateId);

                fromDate = Convert.ToString(dsViewTechnicalSkills.Tables[0].Rows[0]["FromDate"]); ;
                string[] Words = fromDate.Split(new char[] { '/' });

                tillDate = Convert.ToString(dsViewTechnicalSkills.Tables[0].Rows[0]["TillDate"]); ;
                string[] Words1 = tillDate.Split(new char[] { '/' });

                DropDownList ddlTechnicalSkill = (DropDownList)e.Item.FindControl("ddlTechnicalSkill");
                if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
                {
                    DataSet dsTechnicalSkills = new DataSet();
                    dsTechnicalSkills = currentDesiredJobBAL.GetTechnicalSkillsDetailsBAL();
                    // Check dataset is not null
                    if (dsTechnicalSkills != null)
                    {
                        ddlTechnicalSkill.DataSource = dsTechnicalSkills;
                        ddlTechnicalSkill.DataTextField = "TechnicalSkillName";
                        ddlTechnicalSkill.DataValueField = "TechnicalSkillTypeId";
                        ddlTechnicalSkill.DataBind();
                        ddlTechnicalSkill.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "TechnicalSkills"));
                    }
                }
                DropDownList ddlFromYear = (DropDownList)e.Item.FindControl("ddlFromYear");
                DropDownList ddlFromMonth = (DropDownList)e.Item.FindControl("ddlFromMonth");
                if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
                {
                    List<string> monthList = CommonUtil.Utility.GetMonths();
                    ddlFromMonth.DataSource = monthList;

                    ddlFromMonth.DataBind();

                    List<string> yearList = CommonUtil.Utility.GetYears();
                    ddlFromYear.DataSource = yearList;
                    ddlFromYear.DataBind();

                    foreach (string Word in Words)
                    {
                        count += 1;
                        if (count == 1)
                        { ddlFromMonth.SelectedValue = Word; }
                        if (count == 2)
                        {
                            ddlFromYear.SelectedValue = Word;
                        }
                    }
                }
                DropDownList ddlTillYear = (DropDownList)e.Item.FindControl("ddlTillYear");
                DropDownList ddlTillMonth = (DropDownList)e.Item.FindControl("ddlTillMonth");
                if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
                {
                    List<string> monthList = CommonUtil.Utility.GetMonths();
                    ddlTillMonth.DataSource = monthList;

                    ddlTillMonth.DataBind();
                    List<string> yearList = CommonUtil.Utility.GetYears();
                    ddlTillYear.DataSource = yearList;
                    ddlTillYear.DataBind();

                    foreach (string Word in Words1)
                    {
                        count1 += 1;
                        if (count1 == 1)
                        {
                            ddlTillMonth.SelectedValue = Word;
                        }
                        if (count1 == 2)
                        {
                            ddlTillYear.SelectedValue = Word;
                        }
                    }
                }

                DropDownList ddlProficiency = (DropDownList)e.Item.FindControl("ddlProficiency");
                if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
                {
                    ddlProficiency.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Proficiency"));
                }
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        /// <summary>
        /// Handles SelectedIndexChanged event of ddlTechnicalSkills control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void ddlTechnicalSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlTechnicalSkills.SelectedItem.Text == "----Other----")
                {
                    divAddMoreSkills.Visible = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Handles click event of btnAdd control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
        }
    }
}