using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using System.Data;

namespace JobFair.Forms.Recruiter
{
    public partial class ViewApplications : System.Web.UI.Page
    {
        public string candidateId="1";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCandidate(candidateId);
               
            }
        }

        private void BindCandidate( string candidateId)
        {
            DataSet dsviewapplications = new DataSet();
            
            ViewApplicationsBAL viewapplicatiosBAL = new ViewApplicationsBAL();
            dsviewapplications = viewapplicatiosBAL.GetCandidateDetails(candidateId);
            rptrviewapplication.DataSource = dsviewapplications;
            rptrviewapplication.DataBind();

           
        }
    }
}