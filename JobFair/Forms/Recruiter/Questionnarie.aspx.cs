using BAL;
using System;
using System.Data;

namespace JobFair.Forms.Recruiter
{
    public partial class Questionrie : System.Web.UI.Page
    {
        private string questionnarieName;
        private int questionnarieId;
        private Int64 recruiterId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AddDefaultFirstRecord();
            }
        }

        private void AddDefaultFirstRecord()
        {
            try
            {
                // Creating DataTable
                DataTable dt = new DataTable();
                DataRow dr;
                dt.TableName = "Questionnarie";
                // Creating columns for DataTable
              
                dt.Columns.Add(new DataColumn("QuestionnaireId", typeof(Int32)));
                dt.Columns.Add(new DataColumn("QuestionName", typeof(string)));
                dt.Columns.Add(new DataColumn("QuestionType", typeof(string)));
                dt.Columns.Add(new DataColumn("AnswerOption", typeof(string)));

                dr = dt.NewRow();
                dt.Rows.Add(dr);
                // dt.Rows.Add(dr);
                ViewState["Questionnarie"] = dt;
                grdQuestionnarie.DataSource = dt;
                grdQuestionnarie.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        protected void btnAddQuestion_Click(object sender, EventArgs e)
        {
            AddNewRecordRowToGrid();
        }

        private void AddNewRecordRowToGrid()
        {
            try
            {
                // Check if viewstate is not null
                if (ViewState["Questionnarie"] != null)
                {
                    DataTable dtCurrentTable = (DataTable)ViewState["Questionnarie"];
                    DataRow drCurrentRow = null;
                    // Check datatable rows greater than zero
                    if (dtCurrentTable.Rows.Count > 0)
                    {
                        for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                        {
                            // Creating new row and assigning values
                            drCurrentRow = dtCurrentTable.NewRow();
                            //drCurrentRow["RecruiterId"] = 12;
                            drCurrentRow["QuestionnaireId"] =questionnarieId;
                            drCurrentRow["QuestionName"] = txtQuestion.Text.Trim();
                            drCurrentRow["QuestionType"] = ddlQuestionType.SelectedItem.Text;
                            drCurrentRow["AnswerOption"] = txtAnswer.Text.Trim();
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
                        ViewState["Questionnarie"] = dtCurrentTable;
                        // Binding Gridview with New Row
                        grdQuestionnarie.DataSource = dtCurrentTable;
                        grdQuestionnarie.DataBind();
                    }
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        protected void ddlQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlQuestionType.SelectedValue == "TextBox")
            {
                txtAnswer.ReadOnly = true;
            }
            else
            {
                txtAnswer.ReadOnly = false;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                QuestionnarieREBAL questionnarieBAL = new QuestionnarieREBAL();
                DataTable dtQuestionnarie = (DataTable)ViewState["Questionnarie"];
                questionnarieBAL.SaveQuestionBAL(dtQuestionnarie);
                grdQuestionnarie.DataSource = null;
                grdQuestionnarie.DataBind();
                ViewState["Questionnarie"] = null;
                Response.Write("<script language='javascript'>alert('Questionnarie created...')</script>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnAddQuestionnarie_Click(object sender, EventArgs e)
        {
            try
            {
                QuestionnarieREBAL questionnarieBAL = new QuestionnarieREBAL();
                recruiterId = 12;
                questionnarieName = txtQuestionnarieName.Text.Trim();
                questionnarieId = questionnarieBAL.SaveQuestionnarieBAL(questionnarieName, recruiterId);
                if(questionnarieId!=null)
                {
                    pnlQuestion.Visible = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}