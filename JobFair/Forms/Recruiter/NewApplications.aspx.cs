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

        protected void btnaccept_Click(object sender, EventArgs e)
        {
           
            GetAcceptCandidate(candidateId);
            Response.Write("<script language='javascript'>alert('Accept')</script>");

        }

        private void GetAcceptCandidate(long candidateId)
        {
            DataSet dsAcceptCandidate = new DataSet();
            NewApplicationsBAL newapplicationBAL = new NewApplicationsBAL();
            dsAcceptCandidate  =  newapplicationBAL.GetAcceptCandidate(candidateId);
        }

        protected void Btnreject_Click(object sender, EventArgs e)
        {
            GetRejectCandidate(candidateId);
            Response.Write("<script language='javascript'>alert('Reject')</script>");

        }

        private void GetRejectCandidate(long candidateId)
        {
             DataSet  dsRejectCandidate = new DataSet();
            NewApplicationsBAL newapplicationBAL = new NewApplicationsBAL();
            dsRejectCandidate = newapplicationBAL.GetRejectCandidate(candidateId);
        }

       
    }
}