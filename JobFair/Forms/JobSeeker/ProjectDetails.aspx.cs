using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace JobFair.Forms.JobSeeker
{
    public partial class ProjectDetails : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AddDefaultFirstRecord();
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
            TextBox1.Text = "";
        }
        private void AddNewRecordRowToGrid()
        {
            if (ViewState["ProductsSold"] != null)
            {
                DataTable dtCurrentTable = (DataTable)ViewState["ProductsSold"];
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
                        //Creating new row and assigning values
                        drCurrentRow = dtCurrentTable.NewRow();
                        drCurrentRow["ProjectFor"] = rbtProjectTypeList.SelectedItem.Text;
                        drCurrentRow["ProjectTitle"] = txtProjectTitle.Text;
                        drCurrentRow["CompanyName"] = txtCompanyName.Text;
                        drCurrentRow["Role"] = ddlRole.SelectedItem.Text;
                        drCurrentRow["ClientName"] = txtClientName.Text;
                        drCurrentRow["Duration"] = Convert.ToInt32(days);
                        drCurrentRow["ProjectLocation"] = txtLocation.Text;

                        if (rbtFullTime.Checked)
                        {
                            drCurrentRow["EmploymentType"] = "FullTime";
                        }
                        else if (rbtPartTime.Checked)
                        {
                            drCurrentRow["EmploymentType"] = "PartTime";
                        }

                        drCurrentRow["ProjectDetails"] = txtProjectDetails.Text;
                        drCurrentRow["RolesandResponsibility"] = txtRolesAndResponsibility.Text;
                        drCurrentRow["TeamSize"] = ddlTeamSize.SelectedItem.Text;
                        drCurrentRow["SkillUsed"] = txtSkillUsed.Text;

                        if (rbtYes.Checked)
                        {
                            drCurrentRow["ProjectLive"] = "Yes";
                        }
                        else if (rbtNo.Checked)
                        {
                            drCurrentRow["ProjectLive"] = "No";
                        }
                        drCurrentRow["ProjectLink"] = txtLink.Text;
                        drCurrentRow["Degree"] = TextBox1.Text;
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
                    ViewState["ProductsSold"] = dtCurrentTable;
                    //binding Gridview with New Row
                    GridView1.DataSource = dtCurrentTable;
                    GridView1.DataBind();
                }
            }
        }
        private void AddDefaultFirstRecord()
        {
            //creating DataTable
            DataTable dt = new DataTable();
            DataRow dr;
            dt.TableName = "ProductsSold";
            //creating columns for DataTable
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

            ViewState["ProductsSold"] = dt;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
       
       
        protected void btnsubmitProject_Click(object sender, EventArgs e)
        {
            ProjectDetailsBAL projectDetailsBAL = new ProjectDetailsBAL();
            DataTable dtProductSold = (DataTable)ViewState["ProductsSold"];
           projectDetailsBAL.SaveProjectDetailsBAL(dtProductSold);
            Response.Write("<script language='javascript'>alert('Project Details Inserted')</script>");
           
        }

    }
}