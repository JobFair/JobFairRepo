﻿using BAL;
using Entities.JobSeeker;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class AdvanceSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string candidateId;
            // Check session is not null
            if (Session["candidateId"] != null)
            {
                if (Session["candidateId"].ToString() != "")
                {
                    candidateId = Convert.ToString(Session["candidateId"]);
                    // Check page is not post back
                    if (!IsPostBack)
                    {
                        try
                        {
                            BindState();
                            BindIndustry();
                        }
                        catch (Exception)
                        {
                            // throw;
                        }
                    }
                }
            }
            else
            {
                Response.Redirect("LogIn.aspx");
            }
        }

        /// <summary>
        /// Bind industry to chkIndustry
        /// </summary>
        private void BindIndustry()
        {
            try
            {
                object dsIndustry;
                dsIndustry = AdvanceJobSearchBAL.GetIndustry();
                // Check dataset is not null
                if (dsIndustry != null)
                {
                    chkIndustry.DataSource = dsIndustry;
                    chkIndustry.DataTextField = "IndustryName";
                    chkIndustry.DataValueField = "IndustryId";
                    chkIndustry.DataBind();
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// On selected index change bind area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object dsArea;
                int cityId = Convert.ToInt32(ddlCity.SelectedValue);
                dsArea = AdvanceJobSearchBAL.GetArea(cityId);
                // Check dataset is not null
                if (dsArea != null)
                {
                    chkarea.DataSource = dsArea;
                    chkarea.DataTextField = "AreaName";
                    chkarea.DataValueField = "AreaId";
                    chkarea.DataBind();
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// On selected index change bind city
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object dsCity;
                int stateId = Convert.ToInt32(ddlState.SelectedValue);
                dsCity = AdvanceJobSearchBAL.GetCity(stateId);
                // Check dataset is not null
                if (dsCity != null)
                {
                    ddlCity.DataSource = dsCity;
                    ddlCity.DataTextField = "cityName";
                    ddlCity.DataValueField = "cityID";
                    ddlCity.DataBind();
                    ddlCity.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Bind industry to dropdown and stored in database
        /// </summary>

        private void BindState()
        {
            try
            {
                object dsState;
                AdvanceJobSearchBAL advaceJobSearchBAL = new AdvanceJobSearchBAL();
                dsState = advaceJobSearchBAL.GetState();
                // Check dataset is not null
                if (dsState != null)
                {
                    ddlState.DataSource = dsState;
                    ddlState.DataTextField = "StateName";
                    ddlState.DataValueField = "StateId";
                    ddlState.DataBind();
                    ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        ///  Searchrecord on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                AdvanceSearchDetailsEntity advanceSearchEntity = new AdvanceSearchDetailsEntity();
                advanceSearchEntity.KeySkill = txtkeyskill.Text.Trim();
                advanceSearchEntity.State = ddlState.SelectedValue.Trim();
                advanceSearchEntity.City = ddlCity.SelectedValue.Trim();
                advanceSearchEntity.Area = chkarea.SelectedValue.Trim();
                advanceSearchEntity.WorkExp = ddlWorkExperience.SelectedItem.Text.Trim();
                advanceSearchEntity.MinSalary = ddlMinSalary.SelectedItem.Text.Trim();
                advanceSearchEntity.MaxSalary = ddlMaxSalary.SelectedItem.Text.Trim();
                advanceSearchEntity.Industry = Convert.ToInt32(chkIndustry.SelectedValue.Trim());
                advanceSearchEntity.EmpStatus = chkEmploymentStatus.SelectedItem.Text.Trim();
                advanceSearchEntity.JobType = chkJobType.SelectedItem.Text.Trim();
                advanceSearchEntity.RecruitmentType = chkRecruitmentType.SelectedItem.Text.Trim();
                //AdvanceJobSearchBAL advancesearchBAL = new AdvanceJobSearchBAL();
                //DataSet result = advancesearchBAL.GetSearch(advanceSearchEntity);
                AdvanceSearchDetailsEntity search = new AdvanceSearchDetailsEntity();
                Session["myObject"] = advanceSearchEntity;
                Response.Redirect("jobSearch.aspx");
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> GetRoles(string prefixText)
        {
            DataTable dtRoles = new DataTable();

            AdvanceJobSearchBAL advanceSearchBAL = new AdvanceJobSearchBAL();
            dtRoles = advanceSearchBAL.GetRoles(prefixText);
            List<string> rolename = new List<string>();
            try
            {
                // Check datatable is not null
                if (dtRoles != null)
                {
                    for (int i = 0; i < dtRoles.Rows.Count; i++)
                    {
                        rolename.Add(dtRoles.Rows[i][1].ToString());
                    }
                }
            }
            catch (Exception)
            {
                //  throw;
            }
            return rolename;
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }

        /// <summary>
        ///  On selected index change add area to textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chkarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedArea = chkarea.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                txtarea.Text = string.Join(",", selectedArea.Select(x => x.Text));
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        /// <summary>
        ///  On selected index change add industry to textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chkIndustry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectIndustry = chkIndustry.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                txtindusry.Text = string.Join(",", selectIndustry.Select(x => x.Text));
            }
            catch (Exception)
            {
                //  throw;
            }
        }

        protected void btnarea_Click(object sender, EventArgs e)
        {
            Panelarea.Visible = true;
        }
    }
}