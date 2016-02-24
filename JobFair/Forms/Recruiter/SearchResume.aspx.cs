using BAL;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.Forms.Recruiter
{
    public partial class SearchResume : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetClientName();
            }
        }

        private void GetClientName()
        {
            try
            {
                SearchResumeREBAL searchResumeBAL = new SearchResumeREBAL();
                DataSet dsClientName = new DataSet();
                dsClientName = searchResumeBAL.GetClientNameBAL();
                if (dsClientName != null)
                {
                    ddlClientName.DataSource = dsClientName;
                    ddlClientName.DataTextField = "ClientName";
                    ddlClientName.DataValueField = "ClientId";
                    ddlClientName.DataBind();
                    ddlClientName.Items.Insert(0, new ListItem("-----select--------", "0"));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void ddlClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SearchResumeREBAL searchResumeBAL = new SearchResumeREBAL();
                DataSet dsPosition = new DataSet();
                Int64 clientId = Convert.ToInt64(ddlClientName.SelectedValue);
                dsPosition = searchResumeBAL.GetPositionBAL(clientId);
                if (dsPosition != null)
                {
                    ddlPosition.DataSource = dsPosition;
                    ddlPosition.DataTextField = "Position";
                    ddlPosition.DataValueField = "Position";
                    ddlPosition.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void ddlPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SearchResumeREBAL searchResumeBAL = new SearchResumeREBAL();
                string position = Convert.ToString(ddlPosition.SelectedValue);
                Int32 requirementId = searchResumeBAL.GetRequirementIdBAL(position);
                if(requirementId!=null)
                {
                    lblRequirementId.Text = Convert.ToString(requirementId);
                }
              
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}