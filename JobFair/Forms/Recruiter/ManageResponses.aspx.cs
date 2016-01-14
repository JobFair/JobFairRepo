using System;
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

            

            BindActiveJobs();
            BindInActiveJobs();


        }

        private void BindInActiveJobs()
        {
            DataSet dsInActiveJobs = new DataSet();
            ManageResponsesBAL manageresponsesBAL = new ManageResponsesBAL();
            dsInActiveJobs = manageresponsesBAL.GetInActiveJobs();
            rptrinactivejobs.DataSource = dsInActiveJobs;
            rptrinactivejobs.DataBind();
        }

        private void BindActiveJobs()
        {
            DataSet dsactivejobs = new DataSet();
            ManageResponsesBAL manageresponsesBAL = new ManageResponsesBAL();
            dsactivejobs = manageresponsesBAL.GetActiveJobs();
            rptractivejobs.DataSource = dsactivejobs;
            rptractivejobs.DataBind();
        }


    }



}