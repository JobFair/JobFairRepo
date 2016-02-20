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
using Entities.HR;

namespace JobFair.Forms.HR
{
    public partial class ClientContactPersonDetails : System.Web.UI.Page
    {
        private ClientContactPersonDetailsBAL clientContactPersonDetails = null;
        int HrId = 1; int ClientId = 1;

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
                            ViewRecord(HrId,ClientId);
                            AddDefaultFirstRecord();
                        }
                        catch (Exception)
                        {
                            // throw;
                        }
                    }
                //}
            //}
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
                        drCurrentRow["IsDelete"] = "No";
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

        private void ViewRecord(long HrId,long ClientId)
        {
            try
            {
                DataSet dsViewRecord = new DataSet();
                ClientContactPersonDetailsBAL ViewClientContactPersonDetails = new ClientContactPersonDetailsBAL();
                dsViewRecord = ViewClientContactPersonDetails.ViewClientContactPersonDetailsBAL(HrId, ClientId);
                if (dsViewRecord != null)
                {
                    grvView.DataSource = dsViewRecord;
                    grvView.DataBind();
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }
        protected void grvView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvView.EditIndex = e.NewEditIndex;
            ViewRecord(HrId,ClientId);
        }
        protected void grvView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvView.PageIndex = e.NewPageIndex;
            ViewRecord(HrId, ClientId);
        }
        protected void grvView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grvView.EditIndex = -1;
            ViewRecord(HrId, ClientId);
        }
        protected void grvView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                ClientContactPersonDetailsBAL UpdateclientContactPersonDetailsBAL = new ClientContactPersonDetailsBAL();
                ClientContactPersonDetailsEntity clientContactPersonDetailsEntity = new ClientContactPersonDetailsEntity();
                //ViewRecord(HrId, ClientId);
                //GridView grView = (GridView)(sender as Control)e.Item.FindControl("grvView");
                //GridViewRow gvRow = (GridView)(sender as Control).Parent.Parent;
                GridView grView = (GridView)sender;
                //int UPhrId = Convert.ToInt32(grView.FooterRow.FindControl("lblHrId")as Label).Text);
                //int clientId = Convert.ToInt32(((Label)grView.FindControl("lblClientId")).Text);
                //int UPcontactPersonId = Convert.ToInt32((grView.FooterRow.FindControl("lblContactPersonId") as Label).Text);
                //Label lblClientName = (Label)e.Item.FindControl("lblClientName");
                //int UpContactPersonId = 1;
                var UPcontactPersonId = ((Label)grvView.Rows[e.RowIndex].FindControl("lblContactPersonId")).Text;
                var UPhrId = ((Label)grvView.Rows[e.RowIndex].FindControl("lblHrId")).Text;
                var UPclientId = ((Label)grvView.Rows[e.RowIndex].FindControl("lblClientId")).Text;
                string UPtxtName = ((TextBox)grvView.Rows[e.RowIndex].FindControl("txtName")).Text;
                string UPtxtDesignation = ((TextBox)grvView.Rows[e.RowIndex].FindControl("txtDesignation")).Text;
                string UPtxtEmail = ((TextBox)grvView.Rows[e.RowIndex].FindControl("txtEmail")).Text;
                var UPtxtContactNo = ((TextBox)grvView.Rows[e.RowIndex].FindControl("txtContactNo")).Text;
                string UPrblistIsActive = ((RadioButtonList)grvView.Rows[e.RowIndex].FindControl("rblistIsActive")).SelectedItem.Text;

                // Assign values to the entities
                clientContactPersonDetailsEntity.ContactPersonId = Convert.ToInt32(UPcontactPersonId);
                clientContactPersonDetailsEntity.HrId = Convert.ToInt32(UPhrId);
                clientContactPersonDetailsEntity.ClientId = Convert.ToInt32(UPclientId);
                clientContactPersonDetailsEntity.ContactPersonName = UPtxtName;
                clientContactPersonDetailsEntity.Designation = UPtxtDesignation;
                clientContactPersonDetailsEntity.EmailId = UPtxtEmail;
                clientContactPersonDetailsEntity.ContactNo = Convert.ToInt32(UPtxtContactNo);
                //Convert.ToInt32(ddlFunctionalArea.SelectedValue);
                clientContactPersonDetailsEntity.IsActive = UPrblistIsActive;
                // Saving data to the database
                int result = UpdateclientContactPersonDetailsBAL.UpdateClientContactPersonDetailsBAL(clientContactPersonDetailsEntity);
                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('Update Client Contact Person Details Successfully')</script>");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Client Contact Person Details won't Saved')</script>");
                }
            }
            catch (Exception)
            {
                //throw;
            }
            finally
            {
                grvView.EditIndex = -1;
                ViewRecord(HrId, ClientId);
            }
        }
        protected void grvView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                ClientContactPersonDetailsBAL DeleteclientContactPersonDetailsBAL = new ClientContactPersonDetailsBAL();
                ClientContactPersonDetailsEntity clientContactPersonDetailsEntity = new ClientContactPersonDetailsEntity();
                var lblClientName = ((Label)grvView.Rows[e.RowIndex].FindControl("lblContactPersonName")).Text;

                var DecontactPersonId = ((Label)grvView.Rows[e.RowIndex].FindControl("lblContactPersonId")).Text;
                var DehrId = ((Label)grvView.Rows[e.RowIndex].FindControl("lblHrId")).Text;
                var DeclientId = ((Label)grvView.Rows[e.RowIndex].FindControl("lblClientId")).Text;
                //var contactPersonId = 1;
                //var hrId = 1;
                //var clientId = 1;
                // Assign values to the entities
                clientContactPersonDetailsEntity.ContactPersonId = Convert.ToInt32(DecontactPersonId);
                clientContactPersonDetailsEntity.HrId = Convert.ToInt32(DehrId);
                clientContactPersonDetailsEntity.ClientId = Convert.ToInt32(DeclientId);
                int result = DeleteclientContactPersonDetailsBAL.DeleteClientContactPersonDetailsBAL(clientContactPersonDetailsEntity);
                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('Delete Client Contact Person Details Successfully')</script>");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Client Contact Person Details won't Deleted')</script>");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                grvView.EditIndex = -1;
                ViewRecord(HrId, ClientId);
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
                dt.Columns.Add(new DataColumn("IsDelete", typeof(string)));
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
                ClientContactPersonDetailsBAL SaveclientContactPersonDetailsBAL = new ClientContactPersonDetailsBAL();
                DataTable clientContactPersonDetailsEntity = (DataTable)ViewState["ClientContactPersonDetails"];
                SaveclientContactPersonDetailsBAL.SaveClientContactPersonDetailsBAL(clientContactPersonDetailsEntity);
                grvAddMore.DataSource = null;
                grvAddMore.DataBind();
                ViewRecord(HrId, ClientId);
                Response.Write("<script language='javascript'>alert('Saved Client Contact Person Details Successfully')</script>");
            }
            catch (Exception)
            {
                 throw;
            }
        }
    }
}