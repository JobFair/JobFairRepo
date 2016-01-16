using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.JobSeeker;
using System.Data;

namespace JobFair.Forms.Recruiter
{
     
    public partial class NewApplications : System.Web.UI.Page
    {
        Int64 candidateId = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                 //candidateId = Convert.ToString(Session["candidateId"]);
                 if (!IsPostBack)
                 {
                     BindCandidateDetails(candidateId);
                 
                 }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void BindCandidateDetails(long candidateId)
        {
            DataSet dsclientdetails = new DataSet();
            NewApplicationsBAL newapplicaionsBAL = new NewApplicationsBAL();
            dsclientdetails = newapplicaionsBAL.GetClientDetails(candidateId);
            rptrcandidatedetails.DataSource = dsclientdetails;
            rptrcandidatedetails.DataBind();

        }
    }
}