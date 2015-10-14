using BAL;
using Entities.Recruiter;
using System;
using System.Data;
using System.Web.UI.WebControls;

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
            }
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
        protected void btnPostJob_Click(object sender, EventArgs e)
        {
            try
            {
               

                PostNewJobBAL addJobPostBAL = new PostNewJobBAL();
                AddJobPostEntity addJobPostEntity = new AddJobPostEntity();

                addJobPostEntity.RecruiterID = "RE12";
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
                addJobPostEntity.Workexperience = 
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

        protected void DropDownCheckBoxes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem item in DropDownCheckBoxes1.Items)
            {
                if (item.Selected)
                {
                    lblHSCSelect.Text = item.Text;
                }
            }
        }

        protected void rdbcompanyname_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbcompanyname.Checked)
            {
                txtaboutcompany.Visible = true;
                lblcompanyname1.Visible = true;
                lblclientoflogossolutios.Visible = false;
            }
            else
            {
                txtaboutcompany.Visible = false;
            }
        }

        protected void rdbcompanyname1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbcompanyname1.Checked)
            {
                rdbcompanyname.Visible = false;
                txtclient.Visible = true;
                txtaboutcompany.Visible = false;
                lblclientoflogossolutios.Visible = true;
                lblcompanyname1.Visible = false;
            }
            else
            {
                txtclient.Visible = false;
            
            }
        }

    
    }
}