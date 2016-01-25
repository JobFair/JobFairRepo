using BAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        private bool isCheck = true;
        public string RecruiterID = "12";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check the isCheck is true for edit
                if (isCheck)
                {
                    BindRepeaterTechnicalSkills();
                    divTechnicalRepeater.Visible = true;
                }
                else
                {

                    BindTechnicalSkills();
                    BindMonth();
                    BindYears();
                    //hfCandidateId.Value = candidateId;
                    AddTechnicalSkills();
                }
            }


        }

private void BindRepeaterTechnicalSkills()
{
 	 try
            {
                DataSet dsTechnicalSkills = new DataSet();
         ProfessionalDetailBAL professionaldetailBAL = new ProfessionalDetailBAL();
                 dsTechnicalSkills = professionaldetailBAL.ViewTechnicalSkillDetailsBAL(RecruiterID);
                // Check dataset is not null
                if (dsTechnicalSkills != null)
                {
                    rptrTechnicalSkills.DataSource = dsTechnicalSkills;
                    rptrTechnicalSkills.DataBind();
                }
            }
            catch (Exception)
            {
                // throw;
            }
}

private void AddTechnicalSkills()
{

                try
            {
                // Creating DataTable
                DataTable datatable = new DataTable();
                DataRow datarow;
                datatable.TableName = "SkillDetails";
                // Creating columns for DataTable
                datatable.Columns.Add(new DataColumn("CandidateId", typeof(string)));
                datatable.Columns.Add(new DataColumn("TechnicalSkills", typeof(int)));
                datatable.Columns.Add(new DataColumn("FromDate", typeof(string)));
                datatable.Columns.Add(new DataColumn("TillDate", typeof(string)));
                datatable.Columns.Add(new DataColumn("Proficiency", typeof(string)));
                datatable.Columns.Add(new DataColumn("TotalYear", typeof(string)));
                datarow = datatable.NewRow();
                datatable.Rows.Add(datarow);
                ViewState["SkillDetails"] = datatable;
                gvSkillsDetails.DataSource = datatable;
                gvSkillsDetails.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
}

private void BindYears()
{
 	try
            {
                List<string> yearlist = CommonUtil.Utility.GetYears();
                ddlFromYear.DataSource = yearlist;
                ddlTillYear.DataSource = yearlist;
                ddlFromYear.DataBind();
                ddlTillYear.DataBind();
            }
            catch (Exception)
            {
                //  throw;
            }
}

private void BindMonth()
{
 	  try
            {
                List<string> monthlist = CommonUtil.Utility.GetMonths();
                ddlFromMonth.DataSource = monthlist;
                ddlTillMonth.DataSource = monthlist;
                ddlFromMonth.DataBind();
                ddlTillMonth.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
}

        private void BindTechnicalSkills()
        {
             try
            {
                DataSet dsTechnicalSkill = new DataSet();
             ProfessionalDetailBAL  professionaldetailBAL = new ProfessionalDetailBAL();
                dsTechnicalSkill = professionaldetailBAL.GetTechnicalSkillsDetailsBAL();
                // Check dataset is not null
                if (dsTechnicalSkill != null)
                {
                    ddlTechnicalSkills.DataSource = dsTechnicalSkill;
                    ddlTechnicalSkills.DataValueField = "TechnicalSkillId";
                    ddlTechnicalSkills.DataTextField = "TechnicalSkillName";
                    ddlTechnicalSkills.DataBind();
                    ddlTechnicalSkills.Items.Insert(Convert.ToInt32(ddlTechnicalSkills.Items[ddlTechnicalSkills.Items.Count - 1].Value), new ListItem("----Other----", ""));
                    ddlTechnicalSkills.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }
        }

}
    
