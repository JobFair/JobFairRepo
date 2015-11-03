using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class UserDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["candidateId"] == "undefined")
            {
                Response.Redirect("LogIn.aspx");
            }
           string candidateId = Convert.ToString(Session["candidateId"]);
            
        }
    }
}