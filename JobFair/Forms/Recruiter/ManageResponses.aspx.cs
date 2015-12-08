﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.Recruiter;

namespace JobFair.Forms.Recruiter
{
    public partial class ManageResponses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindClientName();
        }

        private void BindClientName()
        {
            DataSet datasetClientName = new DataSet();
            ManageResponsesBAL manageResponsesBAL = new ManageResponsesBAL();
            ManageResponsesEntity manageResponsesEntity = new ManageResponsesEntity();
            manageResponsesEntity.RecruiterId = "RE12";
            datasetClientName=manageResponsesBAL.BindClientNameBAL(manageResponsesEntity);
            ddlClientName.DataSource = datasetClientName;
            ddlClientName.DataTextField = "ClientName";
            ddlClientName.DataValueField = "ClientId";
            ddlClientName.DataBind();
        }
    }
}