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
        /// <summary>
        /// Bind active jobs to repeater
        /// </summary>

        private void BindInActiveJobs()
        {
            try
            {
                DataSet dsInActiveJobs = new DataSet();
                ManageResponsesBAL manageresponsesBAL = new ManageResponsesBAL();
                dsInActiveJobs = manageresponsesBAL.GetInActiveJobs();
                rptrinactivejobs.DataSource = dsInActiveJobs;
                rptrinactivejobs.DataBind();

            }
            catch (Exception)
            {
                
                throw;
            }
           
        }
        /// <summary>
        /// Bind inactive jobs to repeater
        /// </summary>

        private void BindActiveJobs()
        {
            try
            {
                DataSet dsactivejobs = new DataSet();
                ManageResponsesBAL manageresponsesBAL = new ManageResponsesBAL();
                dsactivejobs = manageresponsesBAL.GetActiveJobs();
                rptractivejobs.DataSource = dsactivejobs;
                rptractivejobs.DataBind();
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }
    }



}