using BAL;
using Entities.Recruiter;
using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace JobFair.Forms.Recruiter
{
    public partial class PostNewJob : System.Web.UI.Page
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
                BindState();
            }
            bool isCheck;
            int JobId;
            isCheck = Convert.ToBoolean(Request.QueryString["isCheck"]);
            if(isCheck=true)
            {
                try
                {
                    DataSet dataset = new DataSet();
                    ManageJobsBAL manageJobsBAL = new ManageJobsBAL();
                    JobId = Convert.ToInt32(Request.QueryString["JobId"]);
                    dataset = manageJobsBAL.ViewJobsDetailsBAL(JobId);

                    int stateId = Convert.ToInt32(dataset.Tables[0].Rows[0]["JobLocationState"]);
                    ds = PostNewJobBAL.GetCity(stateId);
                    ddlCity.DataSource = ds;
                    ddlCity.DataTextField = "cityName";
                    ddlCity.DataValueField = "cityID";
                    ddlCity.DataBind();
                    ddlCity.Items.Insert(0, "cityName");

                    //int cityId = Convert.ToInt32(ddlCity.SelectedValue);
                    //ds = PostNewJobBAL.GetArea(cityId);
                    //ddlLocation.DataSource = ds;
                    //ddlLocation.DataTextField = "AreaName";
                    //ddlLocation.DataValueField = "AreaId";
                    //ddlLocation.DataBind();
                    //ddlLocation.Items.Insert(0, "AreaName");

                    //Industry.IndustryName, FunctionalArea.FunctionalArea, Departments.DepartmentName,
                    //AddJobPostEntity addJobPostEntity = new AddJobPostEntity();

                    txtJobtitle.Text = dataset.Tables[0].Rows[0]["JobTitle"].ToString();
                    ddlState.SelectedItem.Text = dataset.Tables[0].Rows[0]["JobLocationState"].ToString();
                    ddlCity.SelectedItem.Value = dataset.Tables[0].Rows[0]["JobLocationCity"].ToString();
                    ddlLocation.SelectedItem.Value = dataset.Tables[0].Rows[0]["JobLocationArea"].ToString();
                    ddlCompanyLevel.SelectedItem.Value = dataset.Tables[0].Rows[0]["CompanyLevel"].ToString();
                    ddlIndustry.SelectedValue = dataset.Tables[0].Rows[0]["IndustryName"].ToString();
                    ddlDepartment.SelectedValue = dataset.Tables[0].Rows[0]["DepartmentName"].ToString();
                    ddlFunArea.SelectedValue = dataset.Tables[0].Rows[0]["FunctionalArea"].ToString();
                    txtJobDescription.Text = dataset.Tables[0].Rows[0]["JobDescription"].ToString();
                    txtKeyRoles.Text = dataset.Tables[0].Rows[0]["KeywordsRoles"].ToString();
                    txtKeyTechnical.Text = dataset.Tables[0].Rows[0]["KeywordsTechnical"].ToString();
                    ddlworkexprience.SelectedItem.Text = dataset.Tables[0].Rows[0]["WorkExperience"].ToString();
                    ddlgender.SelectedItem.Text = dataset.Tables[0].Rows[0]["Gender"].ToString();
                    ddlsalarymin.SelectedItem.Text = dataset.Tables[0].Rows[0]["OfferedAnnualSalaryMin"].ToString();
                    ddlsalarymax.SelectedItem.Text = dataset.Tables[0].Rows[0]["OfferedAnnualSalaryMax"].ToString();
                    txtsalarydetaills.Text = dataset.Tables[0].Rows[0]["OtherSalaryDetails"].ToString();
                    txtVacancies.Text = dataset.Tables[0].Rows[0]["NumberOfVacancies"].ToString();
                    chkjobtype.SelectedItem.Text = dataset.Tables[0].Rows[0]["JobType"].ToString();
                    chkemploymenttype.Text = dataset.Tables[0].Rows[0]["EmploymentStatus"].ToString();
                    RadioButtonList1.SelectedItem.Value = dataset.Tables[0].Rows[0]["RecruitmentType"].ToString();
                    chkcompanyname.SelectedItem.Text = dataset.Tables[0].Rows[0]["CompanyName"].ToString();
                    
                    //int result = addJobPostBAL.JobPostBAL(addJobPostEntity);
                    //if (result > 0)
                    //{
                    //    Response.Write("<script language='javascript'>alert('JobPost')</script>");
                    //}
                    //else
                    //{
                    //    Response.Write("<script language='javascript'>alert('Sorry')</script>");
                    //}
                }
                catch (Exception ex)
                {
                    Label1.Text = ex.Message.ToString();
                }
                
               
            }
        }

        private void BindState()
        {
            PostNewJobBAL postnewjobBAL = new PostNewJobBAL();
            ds = postnewjobBAL.GetState();
            ddlState.DataSource = ds;
            ddlState.DataTextField = "StateName";
            ddlState.DataValueField = "StateId";
            ddlState.DataBind();
            ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
        }



        /// <summary>
        /// Method for binding Dropdown with Industry_table of database
        /// </summary>

        private void BindDropDownIndustry()
        {
            ds = PostNewJobBAL.GetIndustry();
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
            ds = PostNewJobBAL.GetDepartment();
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
            ddlFunArea.DataSource = PostNewJobBAL.FunctionalArea();
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
            ddlUGDiploma.DataSource = PostNewJobBAL.GetUnderGraduateDiplomaBAL();
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
            ddlPGDiploma.DataSource = PostNewJobBAL.GetPostGraduateDiplomaBAL();
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
            ddlMasterDegree.DataSource = PostNewJobBAL.GetMasterDegreeBAL();
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
            ddlPHD.DataSource = PostNewJobBAL.GetDoctorOfPhilosophyBAL();
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
            ddlBachelorsDegree.DataSource = PostNewJobBAL.GetBachelorDegreeBAL();
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
            PostNewJobBAL newJobPostBAL = new PostNewJobBAL();
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
        public void btnPostJob_Click(object sender, EventArgs e)
        {





            try
            {
                PostNewJobBAL addJobPostBAL = new PostNewJobBAL();
                AddJobPostEntity addJobPostEntity = new AddJobPostEntity();

                addJobPostEntity.RecruiterID = "RE12";
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
                addJobPostEntity.WorkExperience = ddlworkexprience.SelectedItem.Text.Trim();
                addJobPostEntity.Gender = ddlgender.SelectedItem.Text.Trim();
                addJobPostEntity.OfferedAnnualSalaryMin = Convert.ToString(ddlsalarymin.SelectedItem);
                addJobPostEntity.OfferedAnnualSalaryMax = Convert.ToString(ddlsalarymax.SelectedItem);
                addJobPostEntity.OtherSalaryDetails = txtsalarydetaills.Text.Trim();
                addJobPostEntity.NumberOfVacancies = Convert.ToInt32(txtVacancies.Text.Trim());
                addJobPostEntity.JobType = lblselectedjobtype.Text;
                addJobPostEntity.EmploymentStatus = lblemploymentstatus.Text;
                addJobPostEntity.RecruitmentType = rdbrecruitmenttype.SelectedItem.Text;
                addJobPostEntity.CompanyName = chkcompanyname.SelectedItem.Text.Trim();
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

        protected void DropDownCheckBoxes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItemspanel.Controls.Clear();
            foreach (ListItem item in (sender as ListControl).Items)
            {
                if (item.Selected)
                {
                    selectedItemspanel.Controls.Add(new Literal() { Text = item.Text + "<br/>" }
                    );

                }
            }
        }



        protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (rdb1.Selected)
            {
              
                txtaboutcompany.Visible = true;
               


            }
            else if(rdb2.Selected)
            {
                txtaboutcompany.Visible = false;
                txtaboutcompany.Visible = false;
                chkcompanyname.Visible = true;


            }

        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stateId = Convert.ToInt32(ddlState.SelectedValue);
            ds = PostNewJobBAL.GetCity(stateId);
            ddlCity.DataSource = ds;
            ddlCity.DataTextField = "cityName";
            ddlCity.DataValueField = "cityID";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cityId = Convert.ToInt32(ddlCity.SelectedValue);
            ds = PostNewJobBAL.GetArea(cityId);
            ddllocation.DataSource = ds;
            ddllocation.DataTextField = "AreaName";
            ddllocation.DataValueField = "AreaId";
            ddllocation.DataBind();
            ddllocation.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod()]

        public static List<string> GetRoles(string prefixText)
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
        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod()]
        public static List<string>Gettechnicalskill(string prefixText)
        {
            DataTable dt = new DataTable();
           PostNewJobBAL postnewjobBAL = new PostNewJobBAL();
           dt = postnewjobBAL.GettechnicalskillBAL(prefixText);
            List<string> skillname = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                skillname.Add(dt.Rows[i][2].ToString());
            }
            return skillname;
        }


        protected void lbUGD_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        protected void lbBD_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
        }

        protected void lbPGD_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
        }

        protected void lbMD_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
        }

        protected void lbPHD_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
        }

        protected void ddlUGDiploma_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (ListItem item in ddlUGDiploma.Items)
            {
                if (item.Selected)
                {
                    panel1.Controls.Add(new Literal() { Text = item.Text + "<br/>" }
                      );
                }
            }
        }

        protected void ddlBachelorsDegree_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (ListItem item in ddlBachelorsDegree.Items)
            {
                if (item.Selected)
                {
                    panel2.Controls.Add(new Literal() { Text = item.Text + "<br>" });

                }
            }
        }

        protected void ddlPGDiploma_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem item in ddlPGDiploma.Items)
            {
                if (item.Selected)
                {
                    panel3.Controls.Add(new Literal() { Text = item.Text + "<br>" });
                }
            }
        }

        protected void ddlMasterDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem item in ddlMasterDegree.Items)
            {
                if (item.Selected)
                {
                    panel4.Controls.Add(new Literal() { Text = item.Text + "<br>" });
                }

            }

        }

        protected void ddlPHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem item in ddlPHD.Items)
            {
                if (item.Selected)
                {
                    panel5.Controls.Add(new Literal() { Text = item.Text + "<br>" });
                }
            }
        }

        protected void lbHSC_Click(object sender, EventArgs e)
        {
            selectedItemspanel.Controls.Clear();
        }

        protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<string> area_List = new List<string>();
            foreach (ListItem item in ddllocation.Items)
            {
                if (item.Selected)
                {
                    area_List.Add(item.Value);

                }
                lbllocation.Text = string.Join(",", area_List.ToArray());
            }


        }
        List<string> job_type = new List<string>();

        protected void chkjobtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> job_type = new List<string>();
            foreach (ListItem item in chkjobtype.Items)
            {
                if (item.Selected)
                {
                    job_type.Add(item.Value);
                
                }
                lblselectedjobtype.Text = string.Join(",",job_type.ToArray());
            }
        }

        protected void chkemploymenttype_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<string> employment_type = new List<string>();
            foreach(ListItem item in chkemploymenttype.Items)
            {
                if(item.Selected)
                {
                    employment_type.Add(item.Value);
                
                }
                lblemploymentstatus.Text = string.Join(",", employment_type.ToArray());
            }
        }

       
    }
}
