﻿using BAL;
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
            // Check if page is not postback
            if (!IsPostBack)
            {
                AddDefaultFirstRecord();
            }
        }

        /// <summary>
        /// Add default record to gridview
        /// </summary>
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

        /// <summary>
        /// Handles the Click event of the btnAddQuestion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnAddQuestion_Click(object sender, EventArgs e)
        {
            AddNewRecordRowToGrid();
            txtQuestion.Text = "";
            ddlQuestionType.SelectedIndex = 0;
            txtAnswer.Text = "";
        }

        /// <summary>
        /// Add record to grdQuestionnarie control
        /// </summary>
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
                            drCurrentRow["QuestionnaireId"] = ViewState["QuestionnarieId"];
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

        /// <summary>
        /// Handles the Click event of the btnSubmit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
                ViewState["QuestionnarieId"] = null;
                Response.Write("<script language='javascript'>alert('Questionnarie created...')</script>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnAddQuestionnarie control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnAddQuestionnarie_Click(object sender, EventArgs e)
        {
            try
            {
                QuestionnarieREBAL questionnarieBAL = new QuestionnarieREBAL();
                recruiterId = 12;
                questionnarieName = txtQuestionnarieName.Text.Trim();
                questionnarieId = questionnarieBAL.SaveQuestionnarieBAL(questionnarieName, recruiterId);
                // Check if questionnarieId is not equal to zero
                if (questionnarieId != 0)
                {
                    ViewState["QuestionnarieId"] = questionnarieId;
                    pnlQuestion.Visible = true;
                    pnlQuestionnarie.Visible = false;
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Questionnarie already exists')</script>");
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }
    }
}