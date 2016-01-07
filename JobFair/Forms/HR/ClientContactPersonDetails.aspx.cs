using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BAL;
using System;
using System.Collections.Generic;


namespace JobFair.Forms.HR
{
    public partial class ClientContactPersonDetails : System.Web.UI.Page
    {
        private ClientContactPersonDetailsBAL clientContactPersonDetails = null;
        private string HrId;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["HrId"] != null)
            //{
            //    if (Session["HrId"].ToString() != "")
            //    {
            //        HrId = Convert.ToString(Session["HrId"]);

                    if (!IsPostBack)
                    {
                        try
                        {
                            clientContactPersonDetails = new ClientContactPersonDetailsBAL();
                            AddDefaultFirstRecord();
                        }
                        catch (Exception)
                        {
                            // throw;
                        }
                //    }
                //}
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewRecordRowToGrid();
                txtName.Text = "";
                txtDesignation.Text = "";
                txtEmail.Text = "";
                txtContactNo.Text = "";
                rblistIsActive.SelectedIndex = -1;
            }
            catch (Exception)
            {
                // throw;
            }
        }
        private void AddNewRecordRowToGrid()
        {
            try
            {
                DataTable dtCurrentTable = (DataTable)ViewState["ClientContactPersonDetails"];
                DataRow drCurrentRow = null;

                if (dtCurrentTable.Rows.Count > 0)
                {
                    for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                    {

                        //Creating new row and assigning values
                        drCurrentRow = dtCurrentTable.NewRow();
                        drCurrentRow["ClientId"] = 1;
                        drCurrentRow["HrId"] = 1;//hfHrId;//hfHrId.Value.Trim();
                        drCurrentRow["ContactPersonName"] = txtName.Text.Trim();
                        drCurrentRow["Designation"] = txtDesignation.Text.Trim();
                        drCurrentRow["EmailId"] = txtEmail.Text.Trim();
                        drCurrentRow["ContactNo"] = txtContactNo.Text.Trim();
                        drCurrentRow["IsActive"] = rblistIsActive.SelectedItem.Text.Trim();
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
                    ViewState["ClientContactPersonDetails"] = dtCurrentTable;
                    //binding Gridview with New Row
                    grvAddMore.DataSource = dtCurrentTable;
                    grvAddMore.DataBind();
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
                //creating DataTable
                DataTable dt = new DataTable();
                DataRow dr;
                dt.TableName = "ClientContactPersonDetails";
                //creating columns for DataTable
                dt.Columns.Add(new DataColumn("ClientId", typeof(string)));
                dt.Columns.Add(new DataColumn("HrId", typeof(string)));
                dt.Columns.Add(new DataColumn("ContactPersonName", typeof(string)));
                dt.Columns.Add(new DataColumn("Designation", typeof(string)));
                dt.Columns.Add(new DataColumn("EmailId", typeof(string)));
                dt.Columns.Add(new DataColumn("ContactNo", typeof(string)));
                dt.Columns.Add(new DataColumn("IsActive", typeof(string)));
                dr = dt.NewRow();
                dt.Rows.Add(dr);

                ViewState["ClientContactPersonDetails"] = dt;
                grvAddMore.DataSource = dt;
                grvAddMore.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }
        protected void btnSaveDetails_Click(object sender, EventArgs e)
        {
            try
            {
                ClientContactPersonDetailsBAL clientContactPersonDetailsBAL = new ClientContactPersonDetailsBAL();
                DataTable clientContactPersonDetailsEntity = (DataTable)ViewState["ClientContactPersonDetails"];
                clientContactPersonDetailsBAL.SaveClientContactPersonDetailsBAL(clientContactPersonDetailsEntity);
                grvAddMore.DataSource = null;
                grvAddMore.DataBind();
                Response.Write("<script language='javascript'>alert('Contact Person Details Inserted')</script>");
            }
            catch (Exception)
            {
                // throw;
            }
        }
    }
}