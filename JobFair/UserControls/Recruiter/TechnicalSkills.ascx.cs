using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using  BAL;
using Entities.Recruiter;

namespace JobFair.UserControls.Recruiter
{
    public partial class RE_TechnicalSkills : System.Web.UI.UserControl
    {
            public  Int64 RecruiterID = 12;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)

            {
                // Check the isCheck is true for edit
               
                    BindTechnicalSkills();
                    AddTechnicalSkills();
                    BindMonth();
                    BindYears();
                    //BindRepeaterTechnicalSkills();
                    //divTechnicalRepeater.Visible = true;
               
               
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
                //  throw;
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
                // throw;
            }
        }




        //private void BindRepeaterTechnicalSkills()
        //{
        //    try
        //    {
        //        DataSet dsTechnicalSkills = new DataSet();
        //        ProfessionalDetailBAL professionaldetailBAL = new ProfessionalDetailBAL();
        //        dsTechnicalSkills = professionaldetailBAL.ViewTechnicalSkillDetailsBAL(RecruiterID);
        //        // Check dataset is not null
        //        if (dsTechnicalSkills != null)
        //        {
        //            rptrTechnicalSkills.DataSource = dsTechnicalSkills;
        //            rptrTechnicalSkills.DataBind();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        // throw;
        //    }
        //}


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


        private void BindTechnicalSkills()
        {
            try
            {
                DataSet dsTechnicalSkill = new DataSet();
                ProfessionalDetailBAL professionaldetailBAL = new ProfessionalDetailBAL();
                dsTechnicalSkill = professionaldetailBAL.GetTechnicalSkillsDetailsBAL();
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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ProfessionalDetailBAL professionalDetailBAL = new ProfessionalDetailBAL();
            ProfessionalDetailsEntity professionalDetailentity = new ProfessionalDetailsEntity();
            professionalDetailentity.TechnicalSkill = txtAddSkill.Text.Trim();
            professionalDetailBAL.AddTechnicalSkillBAL(professionalDetailentity);
            divAddMoreSkills.Visible = false; 

        }

        protected void ddlTechnicalSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlTechnicalSkills.SelectedItem.ToString() == "----Other----")
                {
                    divAddMoreSkills.Visible = true;
                }

            }
            catch (Exception)
            {

                throw;
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

        protected void btnSaveSkills_Click(object sender, EventArgs e)
        {
            ProfessionalDetailBAL professioalDetailBAL = new ProfessionalDetailBAL();
            DataTable dt = (DataTable)ViewState["SkillDetails"];
            try
            {
                professioalDetailBAL.SaveTechnicalSkillsBAL(dt);
                Response.Write("<script language='javascript'>alert('Technical Skills Details saved successfully')</script>");
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
   