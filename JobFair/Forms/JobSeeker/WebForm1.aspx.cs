using BAL;
using System;
using System.Collections.Generic;
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
            if (candidateId == "")
            {
                string message = "Sorry your session has been expired !!!!";
                string url = "LogIn.aspx";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "');";
                script += "window.location = '";
                script += url;
                script += "'; }";
                ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
                // Response.Redirect("LogIn.aspx");
            }
        }

    }
}