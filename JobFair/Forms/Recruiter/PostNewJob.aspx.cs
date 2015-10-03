using BAL;
using Entities.Recruiter;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.Forms.Recruiter
{
    public partial class PostNewJob1 : System.Web.UI.Page
    {
        private DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDropDownIndustry();
                BindDropDownDepartment();
                BindDropDownFunctionalArea();
                BindUnderGraduateDiploma();
                BindPostGraduateDiploma();
                BindMasterDegree();
                BindDoctorOfPhilosophy();
                BindBachelorDegree();
                BindQuestions();
            }
        }

        /// <summary>
        /// Method for binding Dropdown with Industry_table of database
        /// </summary>

        private void BindDropDownIndustry()
        {
            ds = NewJobPostBAL.GetIndustry();
            ddlIndustry.DataSource = ds;
            ddlIndustry.DataTextField = "IndustryName";
            ddlIndustry.DataValueField = "IndustryId";
            ddlIndustry.DataBind();
            ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Method for binding Dropdown with Department_table of database
        /// </summary>
        private void BindDropDownDepartment()
        {
            ds = NewJobPostBAL.GetDepartment();
            ddlDepartment.DataSource = ds;
            ddlDepartment.DataTextField = "DepartmentName";
            ddlDepartment.DataValueField = "DepartmentId";
            ddlDepartment.DataBind();
            ddlDepartment.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Method for binding Dropdown with functionalarea_table of database
        /// </summary>
        private void BindDropDownFunctionalArea()
        {
            ddlFunArea.DataSource = NewJobPostBAL.FunctionalArea();
            ddlFunArea.DataTextField = "FunctionalArea";
            ddlFunArea.DataValueField = "FunctionalAreaId";
            ddlFunArea.DataBind();
            ddlFunArea.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Binding dropdown with UnderGraduateDiploma
        /// </summary>
        private void BindUnderGraduateDiploma()
        {
            ddlUGDiploma.DataSource = NewJobPostBAL.GetUnderGraduateDiplomaBAL();
            ddlUGDiploma.DataTextField = "UGDName";
            ddlUGDiploma.DataValueField = "UGDID";
            ddlUGDiploma.DataBind();
            ddlUGDiploma.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Binding dropdown with PostGraduateDiploma
        /// </summary>
        private void BindPostGraduateDiploma()
        {
            ddlPGDiploma.DataSource = NewJobPostBAL.GetPostGraduateDiplomaBAL();
            ddlPGDiploma.DataTextField = "PGDName";
            ddlPGDiploma.DataValueField = "PGDId";
            ddlPGDiploma.DataBind();
            ddlPGDiploma.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Binding dropdown with MasterDegree
        /// </summary>
        private void BindMasterDegree()
        {
            ddlMasterDegree.DataSource = NewJobPostBAL.GetMasterDegreeBAL();
            ddlMasterDegree.DataTextField = "MDName";
            ddlMasterDegree.DataValueField = "MDId";
            ddlMasterDegree.DataBind();
            ddlMasterDegree.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Binding dropdown with DoctorOfPhilosophy
        /// </summary>
        private void BindDoctorOfPhilosophy()
        {
            ddlPHD.DataSource = NewJobPostBAL.GetDoctorOfPhilosophyBAL();
            ddlPHD.DataTextField = "PHDName";
            ddlPHD.DataValueField = "PHDId";
            ddlPHD.DataBind();
            ddlPHD.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Binding dropdown with BachelorDegree
        /// </summary>
        private void BindBachelorDegree()
        {
            ddlBachelorsDegree.DataSource = NewJobPostBAL.GetBachelorDegreeBAL();
            ddlBachelorsDegree.DataTextField = "BDName";
            ddlBachelorsDegree.DataValueField = "BDId";
            ddlBachelorsDegree.DataBind();
            ddlBachelorsDegree.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Binding dropdown with Questionaries
        /// </summary>
        private void BindQuestions()
        {
            NewJobPostBAL newJobPostBAL = new NewJobPostBAL();
            ddlQuestionary.DataSource = newJobPostBAL.GetQuestionsBAL();
            ddlQuestionary.DataTextField = "Question";
            ddlQuestionary.DataValueField = "QuestionId";
            ddlQuestionary.DataBind();
            ddlQuestionary.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Handles the Click event of the btnPostjob control of current job details
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <cref="EventArgs">instance containing event data</param>
        protected void btnPostJob_Click(object sender, EventArgs e)
        {
            try
            {
                //calculting total experience
                DateTime FromYear = Convert.ToDateTime(txtFromdate.Text);
                DateTime ToYear = Convert.ToDateTime(txtTill.Text);
                //Creating object of TimeSpan Class
                TimeSpan objTimeSpan = ToYear - FromYear;
                //years
                int Years = ToYear.Year - FromYear.Year;
                int Month = ToYear.Month - FromYear.Month;
                Label2.Text = Years + "Years-" + Month + "Months";

                NewJobPostBAL addJobPostBAL = new NewJobPostBAL();
                AddJobPostEntity addJobPostEntity = new AddJobPostEntity();

                addJobPostEntity.RecruiterID = "RE1";
                addJobPostEntity.JobTitle = txtJobtitle.Text.Trim();
                addJobPostEntity.JobLocationCity = txtJobLocation.Text.Trim();
                addJobPostEntity.JobLocationArea = txtJobLocationArea.Text.Trim();
                addJobPostEntity.CompanyLevel = ddlCompanyLevel.SelectedItem.Text.Trim();
                addJobPostEntity.IndustryId = Convert.ToInt32(ddlIndustry.SelectedValue);
                addJobPostEntity.DepartmentId = Convert.ToInt32(ddlDepartment.SelectedValue);
                addJobPostEntity.FunctionalAreaId = Convert.ToInt32(ddlFunArea.SelectedValue);
                addJobPostEntity.JobDescription = txtJobDescription.Text.Trim();
                addJobPostEntity.KeywordsRoles = txtKeyRoles.Text.Trim();
                addJobPostEntity.KeywordsTechnical = txtKeyTechnical.Text.Trim();
                addJobPostEntity.WorkExprience = Years + "." + Month;
                addJobPostEntity.Gender = ddlgender.SelectedItem.Text.Trim();
                addJobPostEntity.OfferedAnnualSalaryMin = Convert.ToString(ddlsalarymin.SelectedItem);
                addJobPostEntity.OfferedAnnualSalaryMax = Convert.ToString(ddlsalarymax.SelectedItem);
                addJobPostEntity.OtherSalaryDetails = txtsalarydetaills.Text.Trim();
                addJobPostEntity.NumberOfVacancies = Convert.ToInt32(txtVacancies.Text.Trim());
                addJobPostEntity.PostedDate = DateTime.Now;

                int result = addJobPostBAL.JobPostBAL(addJobPostEntity);
                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('JobPost')</script>");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Sorry')</script>");
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message.ToString();
            }
        }
    }
}