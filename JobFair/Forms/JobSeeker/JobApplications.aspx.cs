using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;



namespace JobFair.Forms.JobSeeker
{
    public partial class JobApplications : System.Web.UI.Page
    {
        DataSet dsjobapplication = new DataSet();
      
        protected void Page_Load(object sender, EventArgs e)
        {
            JobApplicationsBAL jobapplicationBAL = new JobApplicationsBAL();
                dsjobapplication = jobapplicationBAL.GetData();
                rptrjobapplications.DataSource = dsjobapplication;
                rptrjobapplications.DataBind();
           

        }

       

       
    }
}