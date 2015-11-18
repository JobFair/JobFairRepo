using BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    /// <summary>
    /// TechnicalSkillsDetails Class
    /// </summary>
    public partial class TechnicalSkillsDetails : System.Web.UI.UserControl
    {
        private DataSet ds = new DataSet();
        private TechnicalSkillsDetailsBAL technicalSkillsBAL = new TechnicalSkillsDetailsBAL();
        /// <summary>
        /// Handles the Load event of Page
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTechnicalSkills();
                BindMonth();
                BindYears();
                hfCandidateId.Value = "JS3";
                AddTechnicalSkills();
               
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
                throw;
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

                throw;
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

                throw;
            }
        }
        /// <summary>
        /// Method to Create Skills Records Table for gvSkillsDetails Control
        /// </summary>
        private void BindTechnicalSkills()
        {
            try
            {           
            DataSet ds = new DataSet();
            CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
            ds = currentDesiredJobBAL.GetTechnicalSkillsDetailsBAL();
            ddlTechnicalSkills.DataSource = ds;
            ddlTechnicalSkills.DataValueField = "TechnicalSkillId";
            ddlTechnicalSkills.DataTextField = "TechnicalSkillName";
            ddlTechnicalSkills.DataBind();
            ddlTechnicalSkills.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Handles the Click event of btnAddMoreSkills Control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>      
        protected void btnAddMoreSkills_Click(object sender, EventArgs e)
        {
            AddMoreSkills();
        }
        /// <summary>
        /// Method to Insert Data into gvSkillsDetails Control
        /// </summary>
        private void AddMoreSkills()
        {
            string year = TotalYears();
            try
            {
                if (ViewState["SkillDetails"] != null)
                {
                    DataTable datatable = (DataTable)ViewState["SkillDetails"];
                    DataRow datarow = null;
                    if (datatable.Rows.Count > 0)
                    {
                        for (int i = 1; i <= datatable.Rows.Count; i++)
                        {
                            // Creating new row
                            datarow = datatable.NewRow();
                            datarow["CandidateId"] = hfCandidateId.Value.Trim();
                            datarow["TechnicalSkills"] = ddlTechnicalSkills.SelectedItem.Value;
                            datarow["FromDate"] = ddlFromMonth.SelectedItem.Text +" "+ ddlFromYear.SelectedItem.Text;
                            datarow["TillDate"] = ddlTillMonth.SelectedItem.Text+" "+ddlTillYear.SelectedItem.Text;
                            datarow["Proficiency"] = ddlProficiency.SelectedItem.Text;

                            // Calculate Year
                            
                             datarow["TotalYear"] = year ;
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
                throw;
            }
        }
        /// <summary>
        /// Method to Get Total Years of Experience 
        /// </summary>
        /// <returns>System.String</returns>
        private string TotalYears()
        {
            DateTime d1 = new DateTime(Convert.ToInt32(ddlFromYear.SelectedItem.Text), Convert.ToInt32(ddlFromMonth.SelectedIndex + 1), 1);
            DateTime d2 = new DateTime(Convert.ToInt32(ddlTillYear.SelectedItem.Text), Convert.ToInt32(ddlTillMonth.SelectedIndex + 1), 1);
            int months = (d2.Month - d1.Month) + 12 * (d2.Year - d1.Year);
            double year = Math.Abs((double)months / 12);
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