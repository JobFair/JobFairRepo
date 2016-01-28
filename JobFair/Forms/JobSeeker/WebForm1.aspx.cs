using BAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;
using Entities.Recruiter;



namespace JobFair.Forms.JobSeeker
{
    public partial class WebForm1 : System.Web.UI.Page
    {
          public Int64 RecruiterId = 12;
        protected void Page_Load(object sender, EventArgs e)
        {
             
            if (!IsPostBack)
            {
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
            ProfessionalDetailBAL professionalDetailBAL =  new ProfessionalDetailBAL();
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
    }

}
   

   
    
