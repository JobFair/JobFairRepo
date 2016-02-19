using BAL;
using Entities.Recruiter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;

namespace JobFair.Forms.Recruiter
{
    public partial class PostNewJob : System.Web.UI.Page
    {
        private int DegreeId, jobPostId = 4;
        bool isEdit = true;
        Int64 recruiterId = 12;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    BindDropDownIndustry();
                    BindDropDownDepartment();
                    BindDropDownFunctionalArea();
                    BindQuestions();
                    BindState();
                    BindRequirementName();
                    if (isEdit)
                    {
                        BindJobPost(jobPostId, recruiterId);
                    }

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void BindJobPost(int jobPostId, long recruiterId)
        {
            try
            {
                Int32 stateId, cityId;
                DataSet dsViewJobPost = new DataSet();
                PostNewJobBAL postNewJobBAL = new PostNewJobBAL();
                dsViewJobPost = postNewJobBAL.ViewJobPostBAL(jobPostId, recruiterId);
                if (dsViewJobPost != null)
                {
                    DataSet dsCity = new DataSet();
                    stateId = Convert.ToInt32(dsViewJobPost.Tables[0].Rows[0]["JobLocationState"]);
                    dsCity = PostNewJobBAL.GetCity(stateId);
                    if (dsCity != null)
                    {
                        ddlCity.DataSource = dsCity;
                        ddlCity.DataTextField = "CityName";
                        ddlCity.DataValueField = "CityId";
                        ddlCity.DataBind();
                    }

                    DataSet dsArea = new DataSet();
                    cityId = Convert.ToInt32(dsViewJobPost.Tables[0].Rows[0]["JobLocationCity"]);
                    dsArea = PostNewJobBAL.GetArea(cityId);
                    if (dsArea != null)
                    {
                        ddllocation.DataSource = dsArea;
                        ddllocation.DataTextField = "AreaName";
                        ddllocation.DataValueField = "AreaId";
                        ddllocation.DataBind();
                    }
                    lblClientName.Text = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["ClientName"]);
                    lblPosition.Text = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["Position"]);
                    lblRequirementId.Text = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["RequirementId"]);
                    txtJobtitle.Text = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["JobTitle"]);
                    ddlState.SelectedValue = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["JobLocationState"]);
                    ddlCity.SelectedValue = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["JobLocationCity"]);
                    ddllocation.SelectedValue = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["JobLocationArea"]);
                    ddlCompanytype.SelectedValue = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["CompanyLevel"]);
                    ddlIndustry.SelectedValue = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["JobIndustryId"]);
                    ddlDepartment.SelectedValue = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["DepartmentId"]);
                    ddlFunArea.SelectedValue = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["FunctionalAreaId"]);
                    txtJobDescription.Text = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["JobDescription"]);
                    txtKeyRoles.Text = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["KeywordsRoles"]);
                    txtKeyTechnical.Text = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["KeywordsTechnical"]);
                    ddlWorkExperienceMin.SelectedValue = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["WorkExperienceMin"]);
                    ddlWorkExperienceMax.SelectedValue = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["WorkExperienceMax"]);
                    ddlgender.SelectedValue = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["Gender"]);
                    ddlsalarymin.SelectedValue = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["OfferedAnnualSalaryMin"]);
                    ddlsalarymax.SelectedValue = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["OfferedAnnualSalaryMax"]);
                    txtsalarydetaills.Text = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["OtherSalaryDetails"]);
                    txtVacancies.Text = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["NumberOfVacancies"]);
                    txtQualification.Text = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["Qualification"]);
                    txtCandidateProfile.Text = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["DescribeCandidateProfile"]);
                    ddlquestionnaire.SelectedValue = Convert.ToString(dsViewJobPost.Tables[0].Rows[0]["QuestionnaireId"]);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        /// <summary>
        /// Bind requirement name
        /// </summary>
        private void BindRequirementName()
        {
            try
            {
                PostNewJobBAL postNewJobBAL = new PostNewJobBAL();
                DataSet dsRequirement = new DataSet();
                dsRequirement = postNewJobBAL.GetRequirementBAL();
                // Check if dataset is not null
                if (dsRequirement != null)
                {
                    ddlRequirementName.DataSource = dsRequirement;
                    ddlRequirementName.DataTextField = "Position";
                    ddlRequirementName.DataValueField = "ClientRequirementId";
                    ddlRequirementName.DataBind();
                    ddlRequirementName.Items.Insert(0, new ListItem("-----select--------", "0"));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Bind state
        /// </summary>
        private void BindState()
        {
            try
            {
                DataSet ds = new DataSet();
                PostNewJobBAL postnewjobBAL = new PostNewJobBAL();
                ds = postnewjobBAL.GetState();
                // Check if dataset is not null
                if (ds != null)
                {
                    ddlState.DataSource = ds;
                    ddlState.DataTextField = "StateName";
                    ddlState.DataValueField = "StateId";
                    ddlState.DataBind();
                    ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method for binding Dropdown with Industry_table of database
        /// </summary>

        private void BindDropDownIndustry()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = PostNewJobBAL.GetIndustry();
                // Check if dataset is not null
                if (ds != null)
                {
                    ddlIndustry.DataSource = ds;
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

        /// <summary>
        /// Method for binding Dropdown with Department_table of database
        /// </summary>
        private void BindDropDownDepartment()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = PostNewJobBAL.GetDepartment();
                // Check if dataset is not null
                if (ds != null)
                {
                    ddlDepartment.DataSource = ds;
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

        /// <summary>
        /// Method for binding Dropdown with functionalarea_table of database
        /// </summary>
        private void BindDropDownFunctionalArea()
        {
            try
            {
                ddlFunArea.DataSource = PostNewJobBAL.FunctionalArea();
                ddlFunArea.DataTextField = "FunctionalArea";
                ddlFunArea.DataValueField = "FunctionalAreaId";
                ddlFunArea.DataBind();

                ddlFunArea.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Binding dropdown with Questionaries
        /// </summary>
        private void BindQuestions()
        {
            try
            {
                PostNewJobBAL newJobPostBAL = new PostNewJobBAL();
                ddlquestionnaire.DataSource = newJobPostBAL.GetQuestionsBAL();
                ddlquestionnaire.DataTextField = "QuestionnaireName";
                ddlquestionnaire.DataValueField = "QuestionnaireId";
                ddlquestionnaire.DataBind();
                ddlquestionnaire.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnPostjob control of current job details
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <cref="EventArgs">instance containing event data</param>
        public void btnPostJob_Click(object sender, EventArgs e)
        {
            try
            {
                PostNewJobBAL addJobPostBAL = new PostNewJobBAL();
                AddJobPostEntity addJobPostEntity = new AddJobPostEntity();

                addJobPostEntity.RecruiterID = "12";
                addJobPostEntity.JobTitle = txtJobtitle.Text.Trim();
                addJobPostEntity.JobLocationState = ddlState.SelectedItem.Value;
                addJobPostEntity.JobLocationCity = ddlCity.SelectedItem.Value;
                addJobPostEntity.JobLocationArea = ddllocation.SelectedItem.Value;
                addJobPostEntity.CompanyLevel = ddlCompanytype.SelectedItem.Text.Trim();
                addJobPostEntity.IndustryId = Convert.ToInt32(ddlIndustry.SelectedValue);
                addJobPostEntity.DepartmentId = Convert.ToInt32(ddlDepartment.SelectedValue);
                addJobPostEntity.FunctionalAreaId = Convert.ToInt32(ddlFunArea.SelectedValue);
                addJobPostEntity.JobDescription = txtJobDescription.Text.Trim();
                addJobPostEntity.KeywordsRoles = txtKeyRoles.Text.Trim();
                addJobPostEntity.KeywordsTechnical = txtKeyTechnical.Text.Trim();
                addJobPostEntity.WorkExperienceMin = ddlWorkExperienceMin.SelectedItem.Text.Trim();
                addJobPostEntity.WorkExperienceMax = ddlWorkExperienceMax.SelectedItem.Text.Trim();
                addJobPostEntity.Gender = ddlgender.SelectedItem.Text.Trim();
                addJobPostEntity.OfferedAnnualSalaryMin = Convert.ToString(ddlsalarymin.SelectedItem);
                addJobPostEntity.OfferedAnnualSalaryMax = Convert.ToString(ddlsalarymax.SelectedItem);
                addJobPostEntity.OtherSalaryDetails = txtsalarydetaills.Text.Trim();
                addJobPostEntity.NumberOfVacancies = Convert.ToInt32(txtVacancies.Text.Trim());
                addJobPostEntity.JobType = lblselectedjobtype.Text;
                addJobPostEntity.EmploymentStatus = lblemploymentstatus.Text;
                addJobPostEntity.RecruitmentType = rdbrecruitmenttype.SelectedItem.Text;
                // Check if recruitmentType is In-House
                if (addJobPostEntity.RecruitmentType == "In-House")
                {
                    addJobPostEntity.CompanyName = rblCompanyName.SelectedItem.Text;
                }
                else
                {
                    addJobPostEntity.CompanyName = "null";
                }
                addJobPostEntity.ClientName = lblClientName.Text.Trim();
                addJobPostEntity.Position = lblPosition.Text.Trim();
                addJobPostEntity.RequirementId = Convert.ToInt32(lblRequirementId.Text);

                if (addJobPostEntity.CompanyName == "Logos Corporate Solutions")
                {
                    addJobPostEntity.CompanyProfile = lblCompanyProfile.Text;
                }
                else
                {
                    addJobPostEntity.CompanyProfile = lblCompanyProfileiTech.Text;
                }
                addJobPostEntity.Qualification = txtQualification.Text;
                addJobPostEntity.QueationnareId = Convert.ToInt32(ddlquestionnaire.SelectedValue);
                addJobPostEntity.DescribeCandidateProfile = txtCandidateProfile.Text;
                int result = addJobPostBAL.JobPostBAL(addJobPostEntity);
                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('JobPost Done ')</script>");
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

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                int stateId = Convert.ToInt32(ddlState.SelectedValue);
                ds = PostNewJobBAL.GetCity(stateId);
                // Check if dataset is not null
                if (ds != null)
                {
                    ddlCity.DataSource = ds;
                    ddlCity.DataTextField = "cityName";
                    ddlCity.DataValueField = "cityID";
                    ddlCity.DataBind();
                    ddlCity.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                int cityId = Convert.ToInt32(ddlCity.SelectedValue);
                ds = PostNewJobBAL.GetArea(cityId);
                // Check if dataset is not null
                if (ds != null)
                {
                    ddllocation.DataSource = ds;
                    ddllocation.DataTextField = "AreaName";
                    ddllocation.DataValueField = "AreaId";
                    ddllocation.DataBind();
                    ddllocation.Items.Insert(0, new ListItem("--Select--", "0"));
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
                PostNewJobBAL postnewjobBAL = new PostNewJobBAL();
                dt = postnewjobBAL.GetRolesBAL(prefixText);
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
                PostNewJobBAL postnewjobBAL = new PostNewJobBAL();
                dt = postnewjobBAL.GetTechnicalskillBAL(prefixText);
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

        protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> area_List = new List<string>();
                foreach (ListItem item in ddllocation.Items)
                {
                    // Check if item selected
                    if (item.Selected)
                    {
                        area_List.Add(item.Value);
                    }
                    lbllocation.Text = string.Join(",", area_List.ToArray());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void chkjobtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> job_type = new List<string>();
                foreach (ListItem item in chkjobtype.Items)
                {
                    // Check if item selected
                    if (item.Selected)
                    {
                        job_type.Add(item.Value);
                    }
                    lblselectedjobtype.Text = string.Join(",", job_type.ToArray());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void chkemploymenttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> employment_type = new List<string>();
                foreach (ListItem item in chkemploymenttype.Items)
                {
                    // Check if item is selected
                    if (item.Selected)
                    {
                        employment_type.Add(item.Value);
                    }
                    lblemploymentstatus.Text = string.Join(",", employment_type.ToArray());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void chkCandidateProfile_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCandidateProfile.Checked)
            {
                pnlCandidateProfile.Visible = true;
                return;
            }
            pnlCandidateProfile.Visible = false;
        }

        protected void lnkbtnRefresh_Click(object sender, EventArgs e)
        {
            BindQuestions();
        }

        protected void lnkbtnQuestionary_Click1(object sender, EventArgs e)
        {
            string url = "Questionrie.aspx";
            StringBuilder sb = new StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.open('");
            sb.Append(url);
            sb.Append("');");
            sb.Append("</script>");
            ClientScript.RegisterStartupScript(this.GetType(),
                    "script", sb.ToString());
        }

        protected void rdbrecruitmenttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbrecruitmenttype.SelectedItem.Text == "In-House")
            {
                pnlInHouse.Visible = true;
                pnlClient.Visible = false;
                pnlCompanyProfile.Visible = false;
            }
            else
            {
                pnlInHouse.Visible = false;
                pnlClient.Visible = true;
                pnlCompanyProfile.Visible = false;
            }
        }

        protected void rblCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblCompanyName.SelectedItem.Text == "Logos Corporate Solutions")
            {
                pnlCompanyProfile.Visible = true;
                lblCompanyProfile.Visible = true;
                lblCompanyProfileiTech.Visible = false;
            }
            else
            {
                pnlCompanyProfile.Visible = true;
                lblCompanyProfileiTech.Visible = true;
                lblCompanyProfile.Visible = false;
            }
        }

        protected void ddlRequirementName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                PostNewJobBAL postNewJobBAL = new PostNewJobBAL();
                int requirementId = Convert.ToInt32(ddlRequirementName.SelectedValue);
                ds = postNewJobBAL.GetRequirementDetailBAL(requirementId);
                // Check if dataset is not null
                if (ds != null)
                {
                    lblClientName.Text = Convert.ToString(ds.Tables[0].Rows[0]["ClientName"]);
                    lblPosition.Text = Convert.ToString(ds.Tables[0].Rows[0]["Position"]);
                    lblRequirementId.Text = Convert.ToString(ds.Tables[0].Rows[0]["ClientRequirementId"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnAddTechnical_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
        }

        /// <summary>
        /// Handles the Click event of the btnAddTechnicalSkill control
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <cref="EventArgs">instance containing event data</param>
        protected void btnAddTechnicalSkill_Click(object sender, EventArgs e)
        {
            PostNewJobBAL postNewJobBAL = new PostNewJobBAL();
            AddJobPostEntity addJobPostEntity = new AddJobPostEntity();
            addJobPostEntity.TechnicalSkill = txtTechnicalSkill.Text.Trim();
            postNewJobBAL.AddTechnicalSkillsDetailsBAL(addJobPostEntity);
            Panel2.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the btnAddRoles control
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <cref="EventArgs">instance containing event data</param>
        protected void btnAddRoles_Click(object sender, EventArgs e)
        {
            PostNewJobBAL postNewJobBAL = new PostNewJobBAL();
            AddJobPostEntity addJobPostEntity = new AddJobPostEntity();
            addJobPostEntity.RoleSkill = txtRoleSkills.Text.Trim();
            postNewJobBAL.AddRoleSkillsDetailsBAL(addJobPostEntity);
            Panel1.Visible = false;
        }

        protected void btnAddMoreRoles_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }
    }
}