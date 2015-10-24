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
                addJobPostEntity.JobLocationState = ddlState.SelectedItem.Text.Trim();
                addJobPostEntity.JobLocationCity = ddlCity.SelectedItem.Text.Trim();
                addJobPostEntity.JobLocationArea = ddlLocation.SelectedItem.Text.Trim();
                addJobPostEntity.CompanyLevel = ddlCompanyLevel.SelectedItem.Text.Trim();
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
                addJobPostEntity.RecruitmentType = RadioButtonList1.SelectedItem.ToString();

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
                    selectedItemspanel.Controls.Add(new Literal() 
                    { Text = item.Text +"<br/>"}
                    );

                }
            }
        }

      

        protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
             if (rdb1.Selected)
            {
                txtaboutcompany.Visible = true;
                lblcompanyname1.Visible = true;
                lblclientoflogossolutios.Visible = false;
                txtclient.Visible = false;
            }
             else 
             {
                 txtaboutcompany.Visible = false;
                 txtclient.Visible = true;
                 txtaboutcompany.Visible = false;
                 lblclientoflogossolutios.Visible = true;
                 lblcompanyname1.Visible = false;
             }

        }


        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cityId = Convert.ToInt32(ddlCity.SelectedValue);
            ds = PostNewJobBAL.GetArea(cityId);
            ddlLocation.DataSource = ds;
            ddlLocation.DataTextField = "AreaName";
            ddlLocation.DataValueField = "AreaId";
            ddlLocation.DataBind();
            ddlLocation.Items.Insert(0, new ListItem("--Select--", "0"));
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

        protected void ddlquestiontype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlanswertypw_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
        protected void lbHSC_Click(object sender, EventArgs e)
        {
            lblHSCSelect.Text = string.Empty;
        }

        protected void lbUGD_Click(object sender, EventArgs e)
        {
            lblUGDSelect.Text = string.Empty;
        }

        protected void lbBD_Click(object sender, EventArgs e)
        {
            lblBDSelect.Text = string.Empty;
        }

        protected void lbPGD_Click(object sender, EventArgs e)
        {
            lblPGDSelect.Text = string.Empty;
        }

        protected void lbMD_Click(object sender, EventArgs e)
        {
            lblMDSelect.Text = string.Empty;
        }

        protected void lbPHD_Click(object sender, EventArgs e)
        {
            lblPHDSelect.Text = string.Empty;
        }
         
        protected void ddlUGDiploma_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            foreach(ListItem item in  ddlUGDiploma.Items)
            {
                if (item.Selected)
                {
                    lblUGDSelect.Text = item.Text;
                
                }
            }
        }

        protected void ddlBachelorsDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            foreach (ListItem item in ddlBachelorsDegree.Items)
            {
                if (item.Selected)
                {
                    lblBDSelect.Text = item.Text;
                
                
                }
            }
        }

        protected void ddlPGDiploma_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach ( ListItem item in ddlPGDiploma.Items)
            {
                if (item.Selected)
                {
                    lblPGDSelect.Text = item.Text;
                }
            }
        }

        protected void ddlMasterDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem item in ddlMasterDegree.Items)
            {
                if (item.Selected)
                {
                    lblMDSelect.Text = item.Text;
                }
                
            }

        }

        protected void ddlPHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem item in ddlPHD.Items)
            {
                if (item.Selected)
                {
                    lblPHDSelect.Text = item.Text;
                
                }
            }
        }
    }
}
