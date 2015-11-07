using BAL;
using Entities.JobSeeker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;

namespace JobFair.UserControls.JobSeeker
{
     /// <summary>
    /// Class MoreCertifications.
    /// </summary>
    public partial class MoreCertifications : System.Web.UI.UserControl
    {
        private MoreCertificationBAL certificationDetails = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 certificationDetails = new MoreCertificationBAL();
                // Bind Month List
                List<string> monthList = CommonUtil.Utility.GetMonths();
                ddlMonth.DataSource = monthList;
                ddlMonth.DataBind();

                // Bind Year List
                List<string> yearList = CommonUtil.Utility.GetYears();
                ddlYear.DataSource = yearList;
                ddlYear.DataBind();

                AddDefaultFirstRecord();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewRecordRowToGrid();
            txtCertificationName.Text = "";
            txtCertificationInstitute.Text = "";
            txtCertificationDuration.Text = "";
            ddlMonth.SelectedIndex = 0;
            ddlYear.SelectedIndex = 0;
            txtCertificationGrade.Text = "";
            
        }
        private void AddNewRecordRowToGrid()
        {
            try
            {
                    DataTable dtCurrentTable = (DataTable)ViewState["EducationalDetails"];
                    DataRow drCurrentRow = null;

                    if (dtCurrentTable.Rows.Count > 0)
                    {
                        for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                        {
                            //TimeSpan o = new TimeSpan(0, 0, 0);
                            //DateTime startDate = Convert.ToDateTime(this.txtFromDate.Text.Trim(), new CultureInfo("en-Gb"));
                            //DateTime endDate = Convert.ToDateTime(this.txtTodate.Text.Trim(), new CultureInfo("en-Gb"));
                            //o += endDate.Subtract(startDate);
                            //int days = o.Days;

                            //Creating new row and assigning values
                            drCurrentRow = dtCurrentTable.NewRow();
                            drCurrentRow["CandidateId"] = "JS9";//hfCandidateId.Value.Trim();
                            drCurrentRow["CertificationName"] = txtCertificationName.Text.Trim();
                            drCurrentRow["Institute"] = txtCertificationInstitute.Text.Trim();
                            drCurrentRow["Duration"] = txtCertificationDuration.Text.Trim();
                            drCurrentRow["YearOfCompletion"] = ddlMonth.SelectedItem.Text + ddlYear.SelectedItem.Text;
                            drCurrentRow["Grade"] = txtCertificationGrade.Text.Trim();
                        }
                        //Removing initial blank row
                        if (dtCurrentTable.Rows[0][0].ToString() == "")
                        {
                            dtCurrentTable.Rows[0].Delete();
                            dtCurrentTable.AcceptChanges();
                        }

                        //Added New Record to the DataTable
                        dtCurrentTable.Rows.Add(drCurrentRow);
                        //storing DataTable to ViewState
                        ViewState["EducationalDetails"] = dtCurrentTable;
                        //binding Gridview with New Row
                        grvAddMore.DataSource = dtCurrentTable;
                        grvAddMore.DataBind();
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
                //creating DataTable
                DataTable dt = new DataTable();
                DataRow dr;
                dt.TableName = "EducationalDetails";
                //creating columns for DataTable
                dt.Columns.Add(new DataColumn("CandidateId", typeof(string)));
                dt.Columns.Add(new DataColumn("CertificationName", typeof(string)));
                dt.Columns.Add(new DataColumn("Institute", typeof(string)));
                dt.Columns.Add(new DataColumn("Duration", typeof(string)));
                dt.Columns.Add(new DataColumn("YearOfCompletion", typeof(string)));
                dt.Columns.Add(new DataColumn("Grade", typeof(string)));
                dr = dt.NewRow();
                dt.Rows.Add(dr);

                ViewState["EducationalDetails"] = dt;
                grvAddMore.DataSource = dt;
                grvAddMore.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void btnsubmitCertifications_Click(object sender, EventArgs e)
        {
            MoreCertificationBAL certificationDetailsBAL = new MoreCertificationBAL();
            DataTable dtcertificationDetails = (DataTable)ViewState["EducationalDetails"];
            certificationDetailsBAL.SaveMoreCertificationBAL(dtcertificationDetails);
            grvAddMore.DataSource = null;
            grvAddMore.DataBind();
            Response.Write("<script language='javascript'>alert('Project Details Inserted')</script>");
        }
    }
}