using BAL;
using CommonUtil;
using Entities.JobSeeker;
using System;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    public partial class ProfessionalDetails : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDropDownIndustry();
                BindDropDownDepartment();
                BindDropDownCountry();
            }
        }

        private void BindDropDownCountry()
        {
            ddlCountry.DataSource = Utility.GetCountry();
            ddlCountry.DataTextField = "CountryName";
            ddlCountry.DataValueField = "CountryId";
            ddlCountry.DataBind();
            ddlCountry.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        private void BindDropDownDepartment()
        {
            ddlDepartment.DataSource = Utility.GetDepartmentBAL();
            ddlDepartment.DataTextField = "DepartmentName";
            ddlDepartment.DataValueField = "DepartmentId";
            ddlDepartment.DataBind();
            ddlDepartment.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        private void BindDropDownIndustry()
        {
            ddlIndustry.DataSource = Utility.GetIndustryBAL();
            ddlIndustry.DataTextField = "IndustryName";
            ddlIndustry.DataValueField = "IndustryId";
            ddlIndustry.DataBind();
            ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
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
                CurrentDesiredJobEntity curentity = new CurrentDesiredJobEntity();
                CurrentDesiredJobBAL curjobBAL = new CurrentDesiredJobBAL();

                curentity.Candidateid = "JS00001";
                curentity.ResumeHeadline = txtResumeHeadline.Text;
                curentity.TotalExperience = Years + "." + Month;
                curentity.Industry = Convert.ToInt32(ddlIndustry.SelectedItem.Value);
                curentity.Department = ddlDepartment.SelectedIndex;
                curentity.CurrentJobRole = txtCurrentJobRole.Text;
                curentity.PrimFunctionalRole = ddlPrimaryRole.SelectedItem.Text;
                curentity.PrimJobDescrip = txtJobdescriptionPrimar.Text;
                curentity.PrimTechSkills = txtTechnicalskillPrimary.Text;
                curentity.SecFunctionalRole = ddlSecRole.SelectedItem.Text;
                curentity.SecJobDescrip = txtjobdescriptionSec.Text;
                curentity.SecTechSkills = txtTechnicalskillSec.Text;
                curentity.Designation = txtDesignation.Text;
                curentity.ReasonforJobChange = txtReasonforJobchange.Text;
                curentity.CurrentEmployer = txtemployeer.Text;
                curentity.TechnicalSkills = txtTechSkills.Text;
                int result = curjobBAL.CurrentProfessionalDetailsBAL(curentity);
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
        /// Desired job details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// Jyoti
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CountryId = Convert.ToInt32(ddlCountry.SelectedValue);

            ddlState.DataSource = Utility.GetStateBAL(CountryId);

            ddlState.DataTextField = "StateName";
            ddlState.DataValueField = "StateId";
            ddlState.DataBind();
            ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int StateId = Convert.ToInt32(ddlState.SelectedValue);

            ddlCity.DataSource = Utility.GetCityBAL(StateId);

            ddlCity.DataTextField = "cityName";
            ddlCity.DataValueField = "cityID";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, new ListItem("--Select--", "0"));
        }
    }
}