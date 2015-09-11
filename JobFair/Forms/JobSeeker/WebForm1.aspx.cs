using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string candidateId;
        protected void Page_Load(object sender, EventArgs e)
        {
            candidateId =Convert.ToString( Session["candidateId"]);
            Response.Write(candidateId);
        }
    }
}