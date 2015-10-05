using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.Recruiter;
using System.Data;


namespace JobFair.Forms.Recruiter
{
    public partial class ManageJobs : System.Web.UI.Page
    {
        /// <summary>
        /// Class ManageJobs
        /// </summary>

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            ManageJobsBAL manageJobsBAL = new ManageJobsBAL();
            //Bind repeater control
            dataset = manageJobsBAL.ManageJobsDetailsBAL();
            repJobsDetails.DataSource = dataset;
            repJobsDetails.DataBind();
        }
    }
}