using BAL;
using System;
using System.Collections.Generic;
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
                GetIndustry();
                GetFunctionalArea();
                GetDepartment();
            }
        }

        private void GetDepartment()
        {
            try
            {
                SearchResumeREBAL searchResumeBAL = new SearchResumeREBAL();
                DataSet dsDepartment = new DataSet();
                dsDepartment = searchResumeBAL.GetDepartmentBAL();
                if (dsDepartment != null)
                {
                    ddlDepartment.DataSource = dsDepartment;
                    ddlDepartment.DataTextField = "DepartmentName";
                    ddlDepartment.DataValueField = "DepartmentId";
                    ddlDepartment.DataBind();
                    ddlDepartment.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GetFunctionalArea()
        {
            try
            {
                SearchResumeREBAL searchResumeBAL = new SearchResumeREBAL();
                DataSet dsFunctionalArea = new DataSet();
                dsFunctionalArea = searchResumeBAL.GetFunctionalAreaBAL();
                if (dsFunctionalArea != null)
                {
                    ddlFunctionalArea.DataSource = dsFunctionalArea;
                    ddlFunctionalArea.DataTextField = "FunctionalArea";
                    ddlFunctionalArea.DataValueField = "FunctionalAreaId";
                    ddlFunctionalArea.DataBind();
                    ddlFunctionalArea.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GetIndustry()
        {
            try
            {
                DataSet dsIndustry = new DataSet();
                SearchResumeREBAL searchResumeBAL = new SearchResumeREBAL();
                dsIndustry = searchResumeBAL.GetIndustryBAL();
                if (dsIndustry != null)
                {
                    ddlIndustry.DataSource = dsIndustry;
                    ddlIndustry.DataTextField = "IndustryName";
                    ddlIndustry.DataValueField = "IndustryId";
                    ddlIndustry.DataBind();
                    ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                throw;
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

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod()]
        public static List<string> GetRoles(string prefixText)
        {
            try
            {
                DataTable dt = new DataTable();
                SearchResumeREBAL searchResumeBAL = new SearchResumeREBAL();
                dt = searchResumeBAL.GetRolesBAL(prefixText);
                List<string> rolename = new List<string>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    rolename.Add(dt.Rows[i][1].ToString());
                }
                return rolename;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod()]
        public static List<string> GetTechnicalskill(string prefixText)
        {
            try
            {
                DataTable dt = new DataTable();
                SearchResumeREBAL searchResumeBAL = new SearchResumeREBAL();
                dt = searchResumeBAL.GetTechnicalskillBAL(prefixText);
                List<string> skillname = new List<string>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    skillname.Add(dt.Rows[i][1].ToString());
                }
                return skillname;
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
                if (requirementId != null)
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