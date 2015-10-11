using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace JobFair.Forms.JobSeeker
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string candidateId;
        protected void Page_Load(object sender, EventArgs e)
        {
            candidateId = Convert.ToString(Session["candidateId"]);
            Response.Write(candidateId);
        }
     
    }
}