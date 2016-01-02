using BAL;
using Entities.Recruiter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace JobFair.Forms.Recruiter
{
    public partial class PostNewJob : System.Web.UI.Page
    {
        private int DegreeId;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    BindDropDownIndustry();
                    BindDropDownDepartment();
                    BindDropDownFunctionalArea();
                    BindUnderGraduateDiploma(DegreeId);
                    BindPostGraduateDiploma(DegreeId);
                    BindMasterDegree(DegreeId);
                    BindDoctorOfPhilosophy(DegreeId);
                    BindBachelorDegree(DegreeId);
                    BindQuestions();
                    BindState();
                    BindClientName();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            // bool isCheck = false;
            // int JobId;
            //isCheck = Convert.ToBoolean(Request.QueryString["isCheck"]);
            //if (isCheck)
            //{
            //    try
            //    {
            //        DataSet dataset = new DataSet();
            //        ManageJobsBAL manageJobsBAL = new ManageJobsBAL();
            //        JobId = Convert.ToInt32(Request.QueryString["JobId"]);
            //        dataset = manageJobsBAL.ViewJobsDetailsBAL(JobId);

            //        int stateId = Convert.ToInt32(dataset.Tables[0].Rows[0]["JobLocationState"]);
            //        ds = PostNewJobBAL.GetCity(stateId);
            //        ddlCity.DataSource = ds;
            //        ddlCity.DataTextField = "cityName";
            //        ddlCity.DataValueField = "cityID";
            //        ddlCity.DataBind();
            //        ddlCity.Items.Insert(0, "cityName");

            //        //int cityId = Convert.ToInt32(ddlCity.SelectedValue);
            //        //ds = PostNewJobBAL.GetArea(cityId);
            //        //ddlLocation.DataSource = ds;
            //        //ddlLocation.DataTextField = "AreaName";
            //        //ddlLocation.DataValueField = "AreaId";
            //        //ddlLocation.DataBind();
            //        //ddlLocation.Items.Insert(0, "AreaName");

            //        //Industry.IndustryName, FunctionalArea.FunctionalArea, Departments.DepartmentName,
            //        //AddJobPostEntity addJobPostEntity = new AddJobPostEntity();

            //        txtJobtitle.Text = dataset.Tables[0].Rows[0]["JobTitle"].ToString();
            //        ddlState.SelectedItem.Text = dataset.Tables[0].Rows[0]["JobLocationState"].ToString();
            //        ddlCity.SelectedItem.Value = dataset.Tables[0].Rows[0]["JobLocationCity"].ToString();
            //        //ddlLocation.SelectedItem.Value = dataset.Tables[0].Rows[0]["JobLocationArea"].ToString();
            //        //ddlCompanyLevel.SelectedItem.Value = dataset.Tables[0].Rows[0]["CompanyLevel"].ToString();
            //        ddlIndustry.SelectedValue = dataset.Tables[0].Rows[0]["IndustryName"].ToString();
            //        ddlDepartment.SelectedValue = dataset.Tables[0].Rows[0]["DepartmentName"].ToString();
            //        ddlFunArea.SelectedValue = dataset.Tables[0].Rows[0]["FunctionalArea"].ToString();
            //        txtJobDescription.Text = dataset.Tables[0].Rows[0]["JobDescription"].ToString();
            //        txtKeyRoles.Text = dataset.Tables[0].Rows[0]["KeywordsRoles"].ToString();
            //        txtKeyTechnical.Text = dataset.Tables[0].Rows[0]["KeywordsTechnical"].ToString();
            //        ddlworkexprience.SelectedItem.Text = dataset.Tables[0].Rows[0]["WorkExperience"].ToString();
            //        ddlgender.SelectedItem.Text = dataset.Tables[0].Rows[0]["Gender"].ToString();
            //        ddlsalarymin.SelectedItem.Text = dataset.Tables[0].Rows[0]["OfferedAnnualSalaryMin"].ToString();
            //        ddlsalarymax.SelectedItem.Text = dataset.Tables[0].Rows[0]["OfferedAnnualSalaryMax"].ToString();
            //        txtsalarydetaills.Text = dataset.Tables[0].Rows[0]["OtherSalaryDetails"].ToString();
            //        txtVacancies.Text = dataset.Tables[0].Rows[0]["NumberOfVacancies"].ToString();
            //        chkjobtype.SelectedItem.Text = dataset.Tables[0].Rows[0]["JobType"].ToString();
            //        chkemploymenttype.Text = dataset.Tables[0].Rows[0]["EmploymentStatus"].ToString();
            //        //RadioButtonList1.SelectedItem.Value = dataset.Tables[0].Rows[0]["RecruitmentType"].ToString();
            //        chkcompanyname.SelectedItem.Text = dataset.Tables[0].Rows[0]["CompanyName"].ToString();

            //        //int result = addJobPostBAL.JobPostBAL(addJobPostEntity);
            //        //if (result > 0)
            //        //{
            //        //    Response.Write("<script language='javascript'>alert('JobPost')</script>");
            //        //}
            //        //else
            //        //{
            //        //    Response.Write("<script language='javascript'>alert('Sorry')</script>");
            //        //}
            //    }
            //    catch (Exception ex)
            //    {
            //        Label1.Text = ex.Message.ToString();
            //    }

            // }
        }
        /// <summary>
        //Binding dropdown with UnderGraduateDiploma
        // </summary>
      
        private void BindUnderGraduateDiploma(int DegreeId)
        {
            try
            {
                DegreeId = 3;
                chklstUGD.DataSource = PostNewJobBAL.GetUnderGraduateDiplomaBAL(DegreeId);
                chklstUGD.DataTextField = "DegreeName";
                chklstUGD.DataValueField = "SpecializationId";
                chklstUGD.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BindClientName()
        {
            try
            {
                DataSet ds = new DataSet();
                PostNewJobBAL postnewjobBAL = new PostNewJobBAL();
                ds = postnewjobBAL.GetClientName();
                if (ds != null)
                {
                    ddlclientname.DataSource = ds;
                    ddlclientname.DataTextField = "ClientName";
                    ddlclientname.DataValueField = "ClientId";
                    ddlclientname.DataBind();
                    ddlclientname.Items.Insert(0, new ListItem("-----select--------", "0"));


                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void BindState()
        {
            try
            {
                DataSet ds = new DataSet();
                PostNewJobBAL postnewjobBAL = new PostNewJobBAL();
                ds = postnewjobBAL.GetState();
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
       ///    Binding dropdown with PostGraduateDiploma
       /// </summary>

        private void BindPostGraduateDiploma(int DegreeId)
        {
            try
            {
                DegreeId = 5;
                chklstPGDiploma.DataSource = PostNewJobBAL.GetPostGraduateDiplomaBAL(DegreeId);
                chklstPGDiploma.DataTextField = "DegreeName";
                chklstPGDiploma.DataValueField = "SpecializationId";
                chklstPGDiploma.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

       /// <summary>
       ///  Binding dropdown with MasterDegree
       /// </summary>
 
        private void BindMasterDegree(int DegreeId)
        {
            try
            {
                DegreeId = 6;
                chklstMasterDegree.DataSource = PostNewJobBAL.GetMasterDegreeBAL(DegreeId);
                chklstMasterDegree.DataTextField = "DegreeName";
                chklstMasterDegree.DataValueField = "SpecializationId";
                chklstMasterDegree.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

       /// <summary>
       ///   Binding dropdown with DoctorOfPhilosophy
       /// </summary>

        private void BindDoctorOfPhilosophy(int DegreeId)
        {
            try
            {
                DegreeId = 7;
                chklstPHD.DataSource = PostNewJobBAL.GetDoctorOfPhilosophyBAL(DegreeId);
                chklstPHD.DataTextField = "DegreeName";
                chklstPHD.DataValueField = "SpecializationId";
                chklstPHD.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///   Binding dropdown with BachelorDegree
        /// </summary>
        private void BindBachelorDegree(int DegreeId)
        {
            try
            {
                DegreeId = 4;
                chklstBachelorsDegree.DataSource = PostNewJobBAL.GetBachelorDegreeBAL(DegreeId);
                chklstBachelorsDegree.DataTextField = "DegreeName";
                chklstBachelorsDegree.DataValueField = "SpecializationId";
                chklstBachelorsDegree.DataBind();
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
                ddlquestionnaire.DataTextField = "Question";
                ddlquestionnaire.DataValueField = "QuestionId";
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

        //protected void DropDownCheckBoxes1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //   // selectedItemspanel.Controls.Clear();
        //    //foreach (ListItem item in (sender as ListControl).Items)
        //    //{
        //    //    if (item.Selected)
        //    //    {
        //    //     selectedItemspanel.Controls.Add(new Literal() { Text = item.Text + "<br/>" });
        //    //        // selectedItemspanel=string.Join(",",)

        //    //        //var selectedArea = DropDownCheckBoxes1.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
        //    //        //txtarea.Text = string.Join(",", selectedArea.Select(x => x.Text));
        //    //    }
        //    //}
        //}

        protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            try
            {
                if (rdb1.Selected)
                {
                    txtaboutcompany.Visible = true;
                }
                else if (rdb2.Selected)
                {
                    txtaboutcompany.Visible = false;
                    txtaboutcompany.Visible = false;
                    chkcompanyname.Visible = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                int stateId = Convert.ToInt32(ddlState.SelectedValue);
                ds = PostNewJobBAL.GetCity(stateId);
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
                ddllocation.DataSource = ds;
                ddllocation.DataTextField = "AreaName";
                ddllocation.DataValueField = "AreaId";
                ddllocation.DataBind();
                ddllocation.Items.Insert(0, new ListItem("--Select--", "0"));
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
        public static List<string> Gettechnicalskill(string prefixText)
        {
            try
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

        protected void btnHSC_Click(object sender, EventArgs e)
        {
            pnlHSC.Visible = true;
        }

        protected void chklstHSC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var hsc = chklstHSC.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                txtHSC.Text = string.Join(",", hsc.Select(x => x.Text));
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void chklstUGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var ugDiploma = chklstUGD.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                txtUGD.Text = string.Join(",", ugDiploma.Select(x => x.Text));
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void chklstBachelorsDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var bachelorsDegree = chklstBachelorsDegree.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                txtBachelorsDegree.Text = string.Join(",", bachelorsDegree.Select(x => x.Text));
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void chklstPGDiploma_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var pgDiploma = chklstPGDiploma.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                txtPGDiploma.Text = string.Join(",", pgDiploma.Select(x => x.Text));
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void chklstMasterDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var masterDegree = chklstMasterDegree.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                txtMasterDegree.Text = string.Join(",", masterDegree.Select(x => x.Text));
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void chklstPHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var phd = chklstPHD.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
                txtPHD.Text = string.Join(",", phd.Select(x => x.Text));
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnUGD_Click(object sender, EventArgs e)
        {
            pnlUGD.Visible = true;
        }

        protected void btnBachelorsDegree_Click(object sender, EventArgs e)
        {
            pnlBachelorsDegree.Visible = true;
        }

        protected void btnPGDiploma_Click(object sender, EventArgs e)
        {
            pnlPGDiploma.Visible = true;
        }

        protected void btnMasterDegree_Click(object sender, EventArgs e)
        {
            pnlMasterDegree.Visible = true;
        }

        protected void btnPHD_Click(object sender, EventArgs e)
        {
            pnlPHD.Visible = true;
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

       


    }
}