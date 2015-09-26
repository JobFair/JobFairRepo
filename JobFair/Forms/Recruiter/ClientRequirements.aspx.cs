using BAL;
using Entities.JobSeeker;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.Forms.Recruiter
{
    /// <summary>
    /// Class ClientRequirements.
    /// </summary>
    public partial class ClientRequirements : System.Web.UI.Page
    {
        private ClientRequirementsBAL clientrequirements = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clientrequirements = new ClientRequirementsBAL();
                DataSet clientData = new DataSet();
                // Get Client Name details
                clientData = clientrequirements.GetClientNameDAL();
                ddlClientName.DataSource = clientData;
                ddlClientName.DataValueField = "ClientId";
                ddlClientName.DataTextField = "ClientName";
                ddlClientName.DataBind();
                ddlClientName.Items.Insert(0, new ListItem("--Select--", "0"));
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}