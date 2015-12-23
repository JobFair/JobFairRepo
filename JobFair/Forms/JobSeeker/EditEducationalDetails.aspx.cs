using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.JobSeeker;
using System.Data;

namespace JobFair.Forms.JobSeeker
{
    public partial class EditEducationalDetails : System.Web.UI.Page
    {
        private string candidateId;
        private bool isEdit = true;
        private int degreeId;
        private int specializationId;

        protected void Page_Load(object sender, EventArgs e)
        {
            //isEdit = Convert.ToBoolean(Request.QueryString["isCheck"]);
            if (Session["candidateId"] != null)
            {
                if (Session["candidateId"].ToString() != "")
                {
                    //CheckAuthorised(candidateId);
                    candidateId = Convert.ToString(Session["candidateId"]);
                    degreeId = Convert.ToInt32(Request.QueryString["dId"]);
                    specializationId = Convert.ToInt32(Request.QueryString["sId"]);

                    if (!IsPostBack)
                    {
                        try
                        {
                            BindAllEducationalDetails();

                            if (isEdit)
                            {
                                BindEducationalDetails();
                            }
                        }
                        catch (Exception)
                        {
                            // throw;
                        }
                    }
                }
            }
        }
        private void BindAllEducationalDetails()
        {
            try
            {
                BindSpecialization();
                
                //Declration For ALL
                List<string> YearList = CommonUtil.Utility.GetYears();
                List<string> MonthList = CommonUtil.Utility.GetMonths();
                BindYear(YearList);
                BindMonth(MonthList);
            }
            catch (Exception)
            {
                // throw;
            }
        }
        private void BindEducationalDetails()
        {
            try
            {
                //List<EducationalDetailsEntity> educationDetailsList = new List<EducationalDetailsEntity>();
                EducationalDetailsBAL educationalDetails = new EducationalDetailsBAL();
                // Get only selected checkboxes list
                //var selectedDegreeTypes = chkList.Items.Cast<ListItem>().Where(li => li.Selected).ToList();

                // Get only selected checkboxes list
                //var selectedDegreeTypes = chkList.Items.Cast<ListItem>().Where(li => li.Selected).ToList();

                DataSet dsEducationalDetails = new DataSet();

                dsEducationalDetails = educationalDetails.SelectEducationalDetailsBAL(candidateId, degreeId, specializationId);
                if (dsEducationalDetails != null)
                {
                    // var listofDegrees = Convert.ToString(degreeIdS);
                    // foreach (var list in listofDegrees)
                    // for (; ; degreeIdS++)
                    {
                        EducationalDetailsEntity EditDetails = new EducationalDetailsEntity();
                        EditDetails.CandidateId = candidateId;
                        //ddlHQ.SelectedItem.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["HighestQualificationId"]);
                        //dsEducationalDetails = educationalDetails.UpdateEducationalDetailsBAL(CandidateId);
                        lblHead.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["DegreeName"]);
                        EditDetails.DegreeId = Convert.ToInt32(degreeId); ;
                        txtMedium.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["MediumOfEducation"]);
                        string Status = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Status"]);
                        rblStat.Items.FindByValue(Status).Selected = true;
                        ddlSpecialization.SelectedValue = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["SpecializationId"]);
                        

                        string FromYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]); ;
                        string[] FromYearSplit = FromYear.Split(new char[] { '/' });
                        int CountFrom = 0;
                        foreach (string Word in FromYearSplit)
                        {
                            CountFrom += 1;
                            if (CountFrom == 1)
                            { ddlMonthFrom.SelectedValue = Word; }
                            if (CountFrom == 2)
                            { ddlYearFrom.SelectedValue = Word; }
                        }

                        string ToYear = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]); ;
                        string[] ToYearSplit = ToYear.Split(new char[] { '/' });
                        int countTo = 0;
                        foreach (string Word in ToYearSplit)
                        {
                            countTo += 1;
                            if (countTo == 1)
                            { ddlMonthTo.SelectedValue = Word; }
                            if (countTo == 2)
                            { ddlYearTo.SelectedValue = Word; }
                        }

                        //ddlSSCMonthFrom.SelectedItem.Text + ddlSSCYearFrom.SelectedItem.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["FromYear"]);
                        //ddlSSCMonthTo.Text + ddlSSCYearTo.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["ToYear"]);
                        txtCollege.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["College"]);
                        txtUniversity.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["University"]);
                        txtPercentage.Text = Convert.ToString(dsEducationalDetails.Tables[0].Rows[0]["Percantage"]);
                        // Add object to the education details collection
                        //educationDetailsList.Add(sscDetails);
                        btnUpdate.Visible = true;
                    }
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        /// <summary>
        /// Method for binding DropDown with DegreeDetails_Table of Database
        /// </summary>
        private void BindSpecialization()
        {
            try
            {
                degreeId = Convert.ToInt32(Request.QueryString["dId"]);
                DataSet dsDegreeDetails = new DataSet();
                EducationalDetailsBAL specializationDetails = new EducationalDetailsBAL();
                // Get Degree details
                dsDegreeDetails = specializationDetails.GetDegreeDetailsBAL(degreeId);
                if (dsDegreeDetails != null)
                {
                    ddlSpecialization.DataSource = dsDegreeDetails;
                    ddlSpecialization.DataValueField = "SpecializationId";
                    ddlSpecialization.DataTextField = "DegreeName";
                    ddlSpecialization.DataBind();

                    ddlSpecialization.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception)
            {
                // throw;
            }
        }
        private void BindYear(List<string> YearList)
        {
            try
            {
                ddlYearFrom.DataSource = YearList;
                ddlYearFrom.DataBind();
                ddlYearTo.DataSource = YearList;
                ddlYearTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void BindMonth(List<string> MonthList)
        {
            try
            {
                ddlMonthFrom.DataSource = MonthList;
                ddlMonthFrom.DataBind();
                ddlMonthTo.DataSource = MonthList;
                ddlMonthTo.DataBind();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                EducationalDetailsBAL educationalDetailsBAL = new EducationalDetailsBAL();
                EducationalDetailsEntity educationalDetails = new EducationalDetailsEntity();
                educationalDetails.CandidateId = candidateId;
                educationalDetails.DegreeId = Convert.ToInt32(degreeId); ;
                educationalDetails.MediumOfEducation = txtMedium.Text.Trim();
                educationalDetails.OldSpecializationId = Convert.ToInt32(Request.QueryString["sId"]);
                educationalDetails.SpecializationId = Convert.ToInt32(ddlSpecialization.SelectedValue.Trim());
                educationalDetails.Status = rblStat.SelectedValue.Trim();
                educationalDetails.FromYear = ddlMonthFrom.Text + '/' + ddlYearFrom.Text;
                educationalDetails.ToYear = ddlMonthTo.Text + '/' + ddlYearTo.Text;
                educationalDetails.College = txtCollege.Text.Trim();
                educationalDetails.University = txtUniversity.Text.Trim();
                educationalDetails.Percantage = txtPercentage.Text.Trim();
                // Add object to the update education details
                educationalDetailsBAL.UpdateEducationalDetailsBAL(educationalDetails);
                //Response.Redirect("JSViewProfile.aspx");
            }
            catch (Exception)
            {
                // throw;
            }
        }
    }
}