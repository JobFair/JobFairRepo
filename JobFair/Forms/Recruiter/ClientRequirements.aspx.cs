using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities.Recruiter;
using BAL;
using System.Data;

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

        protected void btnSubmit(object sender, EventArgs e)
        {
            ClientRequirementsEntitiy clientReq = new ClientRequirementsEntitiy();
            clientReq.RecruiterID = "RE11";
            clientReq.ClientId = 1;
            clientReq.Position = txtPosition.Text.Trim();
            clientReq.JobDescription = txtjobpost.Text.Trim();
            clientReq.DateOfRequirementSent = Convert.ToDateTime(txtDateOfReqSent.Text);
            clientReq.DueDate = Convert.ToDateTime(txtDueDate.Text);
            clientReq.NumberOfVacancies = Convert.ToInt32(txtNumberOfVacancy.Text.Trim());
            clientReq.PositionClosed = Convert.ToBoolean(rblPositionClosed.SelectedValue);
        }
    }
}