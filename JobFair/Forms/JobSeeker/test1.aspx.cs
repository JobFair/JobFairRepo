﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Convert.ToString(Session["userid"]);
            Response.Write("Welcome " + var);
        }
    }
}