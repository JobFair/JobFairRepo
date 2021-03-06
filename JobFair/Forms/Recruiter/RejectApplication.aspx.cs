﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using System.Data;

namespace JobFair.Forms.Recruiter
{
    public partial class RejectApplication : System.Web.UI.Page
    {
        public int candidateId='1';
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                BindRejectApplication(candidateId);
            }
        }
        /// <summary>
        ///  Bind Reject  candidate to repeater
        /// </summary>
        /// <param name="candidateId"></param>
        private void BindRejectApplication(int candidateId)
        {
            try
            {
                DataSet dsrejectapplication = new DataSet();
                RejectApplicationBAL rejectapplicationBAL = new RejectApplicationBAL();
                dsrejectapplication = rejectapplicationBAL.GetRejectApplication(candidateId);
                rptrRejectApplication.DataSource = dsrejectapplication;
                rptrRejectApplication.DataBind();
            }
            catch (Exception)
            {
                
                throw;
            }
          
        }
    }
}