﻿using BAL;
using Entities.Recruiter;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class AdvanceSearch : System.Web.UI.Page
    {
        private object ds;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDropDownIndustry();
            
        }
        /// <summary>
        /// bind industry to dropdown and stored in database
        /// </summary>
        private void BindDropDownIndustry()
        {
            ds = AdvanceJobSearchBAL.GetIndustry();
            ddlIndustry.DataSource = ds;
            ddlIndustry.DataTextField = "IndustryName";
            ddlIndustry.DataValueField = "IndustryId";
            ddlIndustry.DataBind();
            ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));

        }
    }
}