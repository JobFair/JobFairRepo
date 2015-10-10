using BAL;
using Entities.JobSeeker;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    public partial class ProfessionalDetails : System.Web.UI.UserControl
    {
        private CurrentDesiredJobBAL currentjobBAL = new CurrentDesiredJobBAL();
        private DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDropDownIndustry();
                BindDropDownDepartment();
                BindDropDownCountry();
            }
        }

        /// <summary>
        /// Method for binding Dropdown with Country_table of database
        /// </summary>
        private void BindDropDownCountry()
        {
            ds = currentjobBAL.GetCountry();
            ddlCountry.DataSource = ds;
            ddlCountry.DataTextField = "CountryName";
            ddlCountry.DataValueField = "CountryId";
            ddlCountry.DataBind();
            ddlCountry.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Method for binding Dropdown with Department_table of database
        /// </summary>

        private void BindDropDownDepartment()
        {
            ds = currentjobBAL.GetDepartment();

            ddlDepartment.DataSource = ds;
            ddlDepartment.DataTextField = "DepartmentName";
            ddlDepartment.DataValueField = "DepartmentId";
            ddlDepartment.DataBind();
            ddlDepartment.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Method for binding DropDown with Industry_table of database
        /// </summary>
        private void BindDropDownIndustry()
        {
            ds = currentjobBAL.GetIndustry();
            ddlIndustry.DataSource = ds;
            ddlIndustry.DataTextField = "IndustryName";
            ddlIndustry.DataValueField = "IndustryId";
            ddlIndustry.DataBind();
            ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Handles the Click event of the btnSave control of current job details
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <cref="EventArgs">instance containing event data</param>
        protected void btnSave_Click(object sender, EventArgs e)
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
                Label1.Text = Years + "Years-" + Month + "Months";
                CurrentDesiredJobEntity currentJobEntity = new CurrentDesiredJobEntity();
                CurrentDesiredJobBAL currentjobBAL = new CurrentDesiredJobBAL();

                currentJobEntity.Candidateid = "JS00001";
                currentJobEntity.ResumeHeadline = txtResumeHeadline.Text;
                currentJobEntity.TotalExperience = Years + "." + Month;
                currentJobEntity.Industry = Convert.ToInt32(ddlIndustry.SelectedItem.Value);
                currentJobEntity.Department = ddlDepartment.SelectedIndex;
                currentJobEntity.CurrentJobRole = txtCurrentJobRole.Text;
                currentJobEntity.PrimFunctionalRole = ddlPrimaryRole.SelectedItem.Text;
                currentJobEntity.PrimJobDescrip = txtJobdescriptionPrimar.Text;
                currentJobEntity.PrimTechSkills = txtTechnicalskillPrimary.Text;
                currentJobEntity.SecFunctionalRole = ddlSecRole.SelectedItem.Text;
                currentJobEntity.SecJobDescrip = txtjobdescriptionSec.Text;
                currentJobEntity.SecTechSkills = txtTechnicalskillSec.Text;
                currentJobEntity.Designation = txtDesignation.Text;
                currentJobEntity.ReasonforJobChange = txtReasonforJobchange.Text;
                currentJobEntity.CurrentEmployer = txtemployeer.Text;
                currentJobEntity.TechnicalSkills = txtTechSkills.Text;
                int result = currentjobBAL.CurrentProfessionalDetailsBAL(currentJobEntity);
                if (result > 0)
                {
                    lblmsgsave.Text = "Your current professional  details saved successfully";
                }
                else
                {
                    lblmsgsave.Text = "Your current professional  details are not saved";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnsaveDesJob control of desired job details
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <cref="EventArgs">instance containing event data</param>
        protected void btnsaveDesJob_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentDesiredJobBAL cdjBAL = new CurrentDesiredJobBAL();
                CurrentDesiredJobEntity cdjEntity = new CurrentDesiredJobEntity();
                cdjEntity.Candidateid = "JS00001";
                cdjEntity.JobPostLooking = txtJobPostLooking.Text;
                cdjEntity.RelevantExp = txtReleventExp.Text;
                cdjEntity.CurrentAnualSal = Convert.ToDouble(txtcurrentannualsalary.Text);
                cdjEntity.ExpectedAnualSal = Convert.ToDouble(txtexpectedsalary.Text);
                cdjEntity.NoticePeriod = ddlNoticePeriod.SelectedItem.Text;
                cdjEntity.EmploymentStatus = cblEmploymentStatus.SelectedItem.Text;
                cdjEntity.JobType = cblJobType.SelectedItem.Text;
                cdjEntity.WorkArea = txtworkarea.Text;
                cdjEntity.PreferredCountry = ddlCountry.SelectedItem.Value;
                cdjEntity.PreferredState = ddlState.SelectedItem.Value;
                cdjEntity.PreferredCity = ddlCountry.SelectedItem.Value;
                int result = cdjBAL.DesiredJobDetailsBAL(cdjEntity);
                if (result > 0)
                {
                    lblmsg.Text = "Your desired job details saved successfully";
                }
                else
                {
                    lblmsg.Text = "Your details not saved successfully";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ddlCountry_SelectedIndexChanged() index of ddlCountry for selection of country
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <cref="EventArgs">instance containing event data</param>
        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CountryId = Convert.ToInt32(ddlCountry.SelectedValue);
            DataSet ds = new DataSet();
            ds = currentjobBAL.GetState(CountryId);
            ddlState.DataSource = ds;

            ddlState.DataTextField = "StateName";
            ddlState.DataValueField = "StateId";
            ddlState.DataBind();
            ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// ddlState_SelectedIndexChanged() index of ddlState for selection of state
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The <cref="EventArgs">instance containing event data</param>
        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int StateId = Convert.ToInt32(ddlState.SelectedValue);
            DataSet ds = new DataSet();
            ds = currentjobBAL.GetCity(StateId);
            ddlCity.DataSource = ds;

            ddlCity.DataTextField = "cityName";
            ddlCity.DataValueField = "cityID";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, new ListItem("--Select--", "0"));
        }

       

      
    }
}