using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class JobApplications : System.Web.UI.Page
    {
        private string candidateId;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                candidateId = Convert.ToString(Session["candidateId"]);
               
            }
            catch (Exception)
            {
                
                throw;
            }
            Binddatarepeator(candidateId);
        }

        private void Binddatarepeator(string candidateId)
        {
            try
            {
                   DataSet  dsjobapplication = new DataSet();
                   SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
                   SqlCommand cmd = new SqlCommand("select JobTitle,  where candidateId = @candidateId", connection);

            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

       
    }
}