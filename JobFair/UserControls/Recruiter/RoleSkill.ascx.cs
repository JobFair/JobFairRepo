using BAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;
using Entities.Recruiter;
using System.Web.UI;


namespace JobFair.UserControls.Recruiter
{
    public partial class RoleSkill : System.Web.UI.UserControl
    {
        public Int64 RecruiterId = 12;
        private bool Ischeck = true;

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {


                if (Ischeck)
                {
                    BindRepeaterRoleSkills();
                    divRoleSkillsEdit.Visible = true;
                    divRoleSkillsInsert.Visible = false;

                }

                else
                    BindRoleSkills();
                BindMonth();
                BindYears();
                AddTechnicalSkills();
            }
        }

        private void AddTechnicalSkills()
        {
            try
            {
                // Creating DataTable
                DataTable datatable = new DataTable();
                DataRow datarow;
                datatable.TableName = "SkillDetails";
                // Creating columns for DataTable
                datatable.Columns.Add(new DataColumn("RecruiterID", typeof(string)));
                datatable.Columns.Add(new DataColumn("RoleSkills", typeof(int)));
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
                // throw;
            }
        }

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
                //  throw;
            }
        }

        private void BindRoleSkills()
        {
            DataSet dsRoles = new DataSet();
            ProfessionalDetailBAL professionalDetailBAL = new ProfessionalDetailBAL();
            try
            {
                dsRoles = professionalDetailBAL.GetRoleSkillsBAL();
                // Check dataset is not null
                if (dsRoles != null)
                {
                    ddlRoleSkills.DataSource = dsRoles;
                    ddlRoleSkills.DataTextField = "RoleName";
                    ddlRoleSkills.DataValueField = "RoleId";
                    ddlRoleSkills.DataBind();

                    ddlRoleSkills.Items.Insert(Convert.ToInt32(ddlRoleSkills.Items.Count), new ListItem("----Other----", ""));
                    ddlRoleSkills.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        protected void btnAddMoreSkills_Click(object sender, EventArgs e)
        {
            AddMoreSkills();
        }

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
                            datarow["RecruiterId"] = 12;
                            datarow["RoleSkills"] = ddlRoleSkills.SelectedItem.Value;
                            datarow["FromDate"] = ddlFromMonth.SelectedItem.Text + "/" + ddlFromYear.SelectedItem.Text;
                            datarow["TillDate"] = ddlTillMonth.SelectedItem.Text + "/" + ddlTillYear.SelectedItem.Text;
                            datarow["Proficiency"] = ddlProficiency.SelectedItem.Text;

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

        private string TotalYears()
        {
            double year = 0.0;
            DateTime fromYear, tillYear;
            int months;
            try
            {
                fromYear = new DateTime(Convert.ToInt32(ddlFromYear.SelectedItem.Text), Convert.ToInt32(ddlFromMonth.SelectedIndex + 1), 1);
                tillYear = new DateTime(Convert.ToInt32(ddlTillYear.SelectedItem.Text), Convert.ToInt32(ddlTillMonth.SelectedIndex + 1), 1);
                months = (tillYear.Month - fromYear.Month) + 12 * (tillYear.Year - fromYear.Year);
                year = Math.Abs((double)months / 12);
            }
            catch (Exception)
            {
                //  throw;
            }
            return year.ToString();
        }

        protected void btnSaveSkills_Click(object sender, EventArgs e)
        {
            ProfessionalDetailBAL professioalDetailBAL = new ProfessionalDetailBAL();
            DataTable dt = (DataTable)ViewState["SkillDetails"];
            try
            {
                professioalDetailBAL.SaveRechnicalSkillsBAL(dt);
                Response.Write("<script language='javascript'>alert('Role Skills Details saved successfully')</script>");
            }
            catch (Exception)
            {
                //  throw;
            }
            finally
            {
                dt = null;
                professioalDetailBAL = null;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ProfessionalDetailBAL professionalDetailBAL = new ProfessionalDetailBAL();
            ProfessionalDetailsEntity professionalDetailentity = new ProfessionalDetailsEntity();
            professionalDetailentity.RoleSkills = txtAddSkill.Text.Trim();
            professionalDetailBAL.AddRoleSkills(professionalDetailentity);
            divAddMoreSkills.Visible = false;

        }

        protected void ddlRoleSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlRoleSkills.SelectedItem.ToString() == "----Other----")
                {
                    divAddMoreSkills.Visible = true;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void rptrRoleSkills_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Label lblRoleSkill = (Label)e.Item.FindControl("lblRoleSkill");
            Label lblFromDate = (Label)e.Item.FindControl("lblFromDate");
            Label lblTillDate = (Label)e.Item.FindControl("lblTillDate");
            Label lblProficiency = (Label)e.Item.FindControl("lblProficiency");


            DropDownList ddlRoleSkill = (DropDownList)e.Item.FindControl("ddlRoleSkill");
            //TextBox txtAddSkill = (TextBox)e.Item.FindControl("txtAddSkill");
            DropDownList ddlFromMonth = (DropDownList)e.Item.FindControl("ddlFromMonth");
            DropDownList ddlFromYear = (DropDownList)e.Item.FindControl("ddlFromYear");
            DropDownList ddlTillMonth = (DropDownList)e.Item.FindControl("ddlTillMonth");
            DropDownList ddlTillYear = (DropDownList)e.Item.FindControl("ddlTillYear");
            DropDownList ddlProficiency = (DropDownList)e.Item.FindControl("ddlProficiency");

            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");
            LinkButton lnkUpdate = (LinkButton)e.Item.FindControl("lnkUpdate");
            LinkButton lnkCancel = (LinkButton)e.Item.FindControl("lnkCancel");

            if (e.CommandName == "edit")
            {
                lblRoleSkill.Visible = false;
                lblFromDate.Visible = false;
                lblTillDate.Visible = false;
                lblProficiency.Visible = false;

                ddlRoleSkill.Visible = true;
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


            if (e.CommandName == "update")
            {


                ProfessionalDetailsEntity professionalDetailsentity = new ProfessionalDetailsEntity();
                professionalDetailsentity.RoleSkills = ddlRoleSkill.SelectedValue.Trim();
                professionalDetailsentity.FromDate = ddlFromMonth.SelectedItem.Text.Trim() + "/" + ddlFromYear.SelectedItem.Text.Trim();
                professionalDetailsentity.TillDate = ddlTillMonth.SelectedItem.Text.Trim() + "/" + ddlTillYear.SelectedItem.Text.Trim();
                professionalDetailsentity.Proficiency = ddlProficiency.SelectedItem.Text.Trim();
                professionalDetailsentity.RoleskillId = Convert.ToInt32(e.CommandArgument);
                professionalDetailsentity.TotalExprience = TotalYears();
                ProfessionalDetailBAL professionalDetailBAL = new ProfessionalDetailBAL();
                professionalDetailBAL.UpdateRoleSkillsBAL(professionalDetailsentity);
                BindRepeaterRoleSkills();



            }

            if (e.CommandName == "delete")
            {
                int RoleskillId = Convert.ToInt32(e.CommandArgument);
                ProfessionalDetailBAL professionalDetailBAL = new ProfessionalDetailBAL();
                professionalDetailBAL.DeleteRoleSkillBAL(RoleskillId);
                BindRepeaterRoleSkills();
            }
            // Check repeater commond for cancel
            if (e.CommandName == "cancel")
            {
                BindRepeaterRoleSkills();
            }
        }

        protected void rptrRoleSkills_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            DataSet dsRoleSkill = new DataSet();
            ProfessionalDetailBAL professionalDetailBAL = new ProfessionalDetailBAL();
            dsRoleSkill = professionalDetailBAL.ViewRoleSkillDetailsBAL(RecruiterId);
            string fromDate, tillDate;
            fromDate = Convert.ToString(dsRoleSkill.Tables[0].Rows[0]["FromDate"]); ;
            string[] Words = fromDate.Split(new char[] { '/' });
            int count = 0;
            tillDate = Convert.ToString(dsRoleSkill.Tables[0].Rows[0]["TillDate"]); ;
            string[] Words1 = tillDate.Split(new char[] { '/' });
            int count1 = 0;

            DropDownList ddlRoleSkill = (DropDownList)e.Item.FindControl("ddlRoleSkill");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataSet dsRoles = new DataSet();
                dsRoles = professionalDetailBAL.GetRoleSkillsBAL();
                if (dsRoles != null)
                {
                    ddlRoleSkill.DataSource = dsRoles;
                    ddlRoleSkill.DataTextField = "RoleName";
                    ddlRoleSkill.DataValueField = "RoleId";
                    ddlRoleSkill.DataBind();
                    ddlRoleSkill.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "RoleSkills"));
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




        private void BindRepeaterRoleSkills()
        {
            try
            {
                DataSet dsRoleSkills = new DataSet();
                ProfessionalDetailBAL professionalDetailBAL = new ProfessionalDetailBAL();
                dsRoleSkills = professionalDetailBAL.ViewRoleSkillDetailsBAL(RecruiterId);
                // Check dataset is not null
                if (dsRoleSkills != null)
                {
                    rptrRoleSkills.DataSource = dsRoleSkills;
                    rptrRoleSkills.DataBind();
                }
            }
            catch (Exception)
            {
                // throw;

            }
        }
    }
}