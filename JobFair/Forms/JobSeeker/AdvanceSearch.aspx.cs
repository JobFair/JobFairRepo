﻿using BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class AdvanceSearch : System.Web.UI.Page
    {
        private object ds;
        string candidateId;
        protected void Page_Load(object sender, EventArgs e)
        {
            candidateId = Convert.ToString(Session["candidateId"]);
            if (candidateId == "")
            {
                //string message = "Sorry your session has been expired !!!!";
                //string url = "LogIn.aspx";
                //string script = "window.onload = function(){ alert('";
                //script += message;
                //script += "');";
                //script += "window.location = '";
                //script += url;
                //script += "'; }";
                //ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
                 Response.Redirect("LogIn.aspx");
            }
            if (!IsPostBack)
            {
                BindIndustry();
                BindDepartment();
                BindState();
            }
        }

        /// <summary>
        /// bind industry to dropdown and stored in database
        /// </summary>
        private void BindIndustry()
        {
            try
            {
                ds = AdvanceJobSearchBAL.GetIndustry();
                ddlIndustry.DataSource = ds;
                ddlIndustry.DataTextField = "IndustryName";
                ddlIndustry.DataValueField = "IndustryId";
                ddlIndustry.DataBind();
                ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BindDepartment()
        {
            try
            {
                ds = AdvanceJobSearchBAL.GetFunctionalArea();
                ddlJobCategory.DataSource = ds;
                ddlJobCategory.DataTextField = "FunctionalArea";
                ddlJobCategory.DataValueField = "FunctionalAreaId";
                ddlJobCategory.DataBind();
                ddlJobCategory.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BindState()
        {
            try
            {
                AdvanceJobSearchBAL advaceJobSearchBAL = new AdvanceJobSearchBAL();
                ds = advaceJobSearchBAL.GetState();
                ddlState.DataSource = ds;
                ddlState.DataTextField = "StateName";
                ddlState.DataValueField = "StateId";
                ddlState.DataBind();
                ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("jobSearch.aspx?keySkills=" + this.txtkeyskill.Text.Trim() + "&city=" + ddlCity.SelectedItem.Text + "&experience=" + ddlWorkExperience.SelectedItem.Text + "&minSalary=" + ddlMinSalary.SelectedItem.Text + "&maxSalary=" + ddlMaxSalary.SelectedItem.Text+"&functionalArea="+ddlJobCategory.SelectedValue);
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int cityId = Convert.ToInt32(ddlCity.SelectedValue);
                ds = AdvanceJobSearchBAL.GetArea(cityId);
                ddlLocation.DataSource = ds;
                ddlLocation.DataTextField = "AreaName";
                ddlLocation.DataValueField = "AreaId";
                ddlLocation.DataBind();
                ddlLocation.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int stateId = Convert.ToInt32(ddlState.SelectedValue);
                ds = AdvanceJobSearchBAL.GetCity(stateId);
                ddlCity.DataSource = ds;
                ddlCity.DataTextField = "cityName";
                ddlCity.DataValueField = "cityID";
                ddlCity.DataBind();
                ddlCity.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> GetKeySkills(string prefixText)
        {
            DataTable dt = new DataTable();

            AdvanceJobSearchBAL advanceSearchBAL = new AdvanceJobSearchBAL();
            dt = advanceSearchBAL.GetTechnicalSkillBAL(prefixText);
            List<string> TechnicalSkillName = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TechnicalSkillName.Add(dt.Rows[i][2].ToString());
            }
            return TechnicalSkillName;
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }
    }
}