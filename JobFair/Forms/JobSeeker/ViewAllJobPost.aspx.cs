﻿using BAL;
using System;
using System.Data;
using System.IO;
using System.Net.Mail;

namespace JobFair.Forms.JobSeeker
{
    public partial class ViewAllJobPost : System.Web.UI.Page
    {
        private string email, jobtitle, candidateId, recruiterName, rId, clientName, requirementId,isreffered;
        private Int64 cId;
        Int32 id;
        private DataSet dsviewjobpost = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
         {
            try
            {
                id = Convert.ToInt32(Request.QueryString["jid"]);
                cId = Convert.ToInt64(Request.QueryString["cId"]);
                candidateId = Convert.ToString(Session["candidateId"]);
                isreffered = Convert.ToString(Session["Isreffered"]);
                
                // Label1.Text = Session["jobid"].ToString();
                if (!IsPostBack)
                {
                    if (candidateId == "")
                    {
                        GetData(id);
                        pnlApplyLogin.Visible = true;
                        pnlApply.Visible = false;
                    }
                    else
                    {
                        BindRequestEmail(candidateId);
                        GetData(id);
                        pnlApply.Visible = true;
                        pnlApplyLogin.Visible = false;
                    }
                }
                //BindReapetor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BindRequestEmail(string candidateId)
        {
            try
            {
                DataSet dsRequestEmail = new DataSet();
                RequestEmailJSBAL requestEmailJSBAL = new RequestEmailJSBAL();
                dsRequestEmail = requestEmailJSBAL.GetEmailBAL(candidateId);
                if (dsRequestEmail != null)
                {
                    email = Convert.ToString(dsRequestEmail.Tables[0].Rows[0]["EmailId"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GetData(Int32 id)
        {
            try
            {
                ViewAllJobPostBAL viewalljobpostBAL = new ViewAllJobPostBAL();
                dsviewjobpost = viewalljobpostBAL.GetData(id);
                if (dsviewjobpost != null)
                {
                    lblTitle.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["JobTitle"]);
                    jobtitle = lblTitle.Text;
                    lblCompanyName.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["CompanyName"]);
                    lblExperienceMin.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["WorkExperienceMin"]);
                    lblExperienceMax.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["WorkExperienceMax"]);
                    lblCity.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["CityName"]);
                    lblCompanyLevel.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["CompanyLevel"]);
                    lblVacancies.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["NumberOfVacancies"]);
                    lblEmplymentStatus.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["EmploymentStatus"]);
                    lblJobType.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["JobType"]);
                    lblGender.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["Gender"]);
                    lblIndustry.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["IndustryName"]);
                    lblDepartmet.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["DepartmentName"]);
                    lblFunctionalArea.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["FunctionalArea"]);
                    lblMinSalary.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["OfferedAnnualSalaryMin"]);
                    lblMaxSalary.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["OfferedAnnualSalaryMax"]);
                    lblJobDesc.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["JobDescription"]);
                    lblRoles.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["KeywordsRoles"]);
                    lblTechnicalSkills.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["KeywordsTechnical"]);
                    lblClientName.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["ClientName"]);
                    lblRequirementId.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["RequirementId"]);
                    lblRecruiterId.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["RecruiterID"]);
                    lblRecruiterName.Text = Convert.ToString(dsviewjobpost.Tables[0].Rows[0]["RecruiterfullName"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void GetCandidateProfile(string candidateId)
        {
            string refCandidateId, profileSummary, resumeHeadline, totalExperience, gender, currentCTC, expectedCTC, noticePeriod, companyType, prefferdState, prefferedCity, prefferedArea, reasonForJobchange, cityName, areaName, countryName, stateName, currentAddress, pincode;
            try
            {
                ViewAllJobPostBAL viewAllJobPostBAL = new ViewAllJobPostBAL();
                DataSet dsCandidateProfile = new DataSet();
                dsCandidateProfile = viewAllJobPostBAL.ViewCandidateProfileForEmail(candidateId);
                if (dsCandidateProfile != null)
                {
                    refCandidateId = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["RefCandidatelId"]);
                    profileSummary = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["ProfileSummary"]);
                    resumeHeadline = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["ResumeHeadline"]);
                    totalExperience = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["TotalExpriance"]);
                    gender = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["Gender"]);
                    currentCTC = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["CurrentAnualSalary"]);
                    expectedCTC = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["ExpectedAnualSalary"]);
                    noticePeriod = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["NoticePeriod"]);
                    companyType = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["CompanyType"]);
                    prefferdState = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["PreferredStateName"]);
                    prefferedCity = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["PreferredCityName"]);
                    prefferedArea = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["PreferredAreaName "]);
                    reasonForJobchange = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["ReasonForJobChange"]);
                    cityName = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["CityName"]);
                    areaName = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["AreaName"]);
                    countryName = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["CountryName"]); 
                    stateName = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["StateName"]);
                    currentAddress = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["CurrentAddress"]);
                    pincode = Convert.ToString(dsCandidateProfile.Tables[0].Rows[0]["PinCode"]);

                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("logos.expertadvice@gmail.com");
                    //   msg.To.Add("hr@logossolutions.co.in");
                    msg.To.Add("saurabh.logossolutions@gmail.com");
                    msg.Subject = " Job application for the " + lblTitle.Text;
                    // Check if selected value equal to Other Help
                    string strBody = "<html><body><table><tr><td><h2>Job Post Details</h2></td></tr> " +
                        "<tr><td>Job Post </td><td>:</td><td>" + lblTitle.Text + "</td></tr> " +
                        "<tr><td>Job ID </td><td>:</td><td>" + id + "</td></tr> " +
                        "<tr><td>Client Name </td><td>:</td><td>" + lblClientName.Text + "</td></tr> " +
                        "<tr><td>Client Requirement ID </td><td>:</td><td>" + lblRequirementId.Text + "</td></tr> " +
                        "<tr><td>Recruiter ID </td><td>:</td><td>" + lblRecruiterId.Text + "</td></tr> " +
                        "<tr><td>Name of the Recruiter</td><td>:</td>" + lblRecruiterName.Text + "<td></td></tr> " +
                        "<tr><td><h2>Candidate Details</h2></td></tr> " +
                                "<tr><td>Candidate ID </td><td>:</td><td>" + candidateId + "</td></tr> " +
                                " <tr><td>Reference ID, If Any  </td><td>:</td><td>" + refCandidateId + "</td></tr> " +
                                " <tr><td>Resume Headline </td><td>:</td><td>" + resumeHeadline + "</td></tr> " +
                                " <tr><td>Summary</td><td>:</td><td>" + profileSummary + "</td></tr> " +
                                " <tr><td>Total Experience </td><td>:</td><td>" + totalExperience + "</td></tr> " +
                                " <tr><td>Gender </td><td>:</td><td>" + gender + "</td></tr> " +
                                " <tr><td>Current Annual Salary (Yearly) </td><td>:</td><td>" + currentCTC + "</td></tr> " +
                                " <tr><td>Expected Annual Salary (Yearly) </td><td>:</td><td>" + expectedCTC + "</td></tr> " +
                                " <tr><td>Notice Period </td><td>:</td><td>" + noticePeriod + "</td></tr> " +
                                " <tr><td> Reason for the Job Change </td><td>:</td><td>" + reasonForJobchange + "</td></tr>" +
                                " <tr><td>Desire Company Type  </td><td>:</td><td>" + companyType + "</td></tr> " +
                                " <tr><td>Language Known </td><td>:</td><td></td></tr> " +
                                " <tr><td>Technical Skills / Key Skills </td><td>:</td><td></td></tr> " +
                                " <tr><td>Present Address </td><td>:</td><td>" + currentAddress + "</td></tr> " +
                                " <tr><td>City </td><td>:</td><td>" + cityName + "</td></tr>" +
                                " <tr><td>Area  </td><td>:</td><td>" + areaName + "</td></tr> " +
                                " <tr><td>Pincode </td><td>:</td><td>" + pincode + "</td></tr> " +
                                " <tr><td>Preferred State  </td><td>:</td><td>" + prefferdState + "</td></tr> " +
                                " <tr><td>Preferred City  </td><td>:</td><td>" + prefferedCity + "</td></tr> " +
                                " <tr><td>Preferred Job Locations</td><td>:</td><td>" + prefferedArea + "</td></tr><br /> " +
                             " </table> </body></html>";
                    msg.Body = strBody;
                    msg.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("logos.expertadvice@gmail.com", "logos@gmail");
                    smtp.EnableSsl = true;
                    smtp.Send(msg);
                    msg = null;
                    Response.Write("<script language='javascript'>alert('Registration Done...');</script>");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private int CheckMailSend(Int32 id, string candidateId)
        {
            ViewAllJobPostBAL viewalljobpostBAL = new ViewAllJobPostBAL();
            return viewalljobpostBAL.CheckMailSend(id, candidateId);
        }

        private bool SentMail(string jobtitle)
        {
            try
            {
                GetCandidateProfile(candidateId);

                string from = "saurabh.logossolutions@gmail.com";
                string subject = " You applied for " + lblTitle.Text + "at Logos Job Fair on " + DateTime.Now.ToString();
                string content = "hello..";
                //string contentId = "image1";
                //string path = Server.MapPath(@"/Images");
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress(from);
                Msg.To.Add("saurabh.logossolutions@gmail.com");
                StreamReader reader = new StreamReader(Server.MapPath("~/SendMail.html"));
                string readFile = reader.ReadToEnd();
                string strContent = "";
                strContent = readFile;
                strContent = strContent.Replace("[CandidateID]", candidateId);
                Msg.Subject = subject;
                //LinkedResource logo = new LinkedResource(path);
                //logo.ContentId = "companylogo";
                //AlternateView av1 = AlternateView.CreateAlternateViewFromString("<html><body><img src=../../Images/logoitch.jpg/><br></body></html>" + strContent, null, MediaTypeNames.Text.Html);
                //av1.LinkedResources.Add(logo);
                //Msg.AlternateViews.Add(av1);
                Msg.Body = strContent.ToString();
                Msg.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("logos.expertadvice@gmail.com", "logos@gmail");
                smtp.EnableSsl = true;
                smtp.Send(Msg);
                Msg = null;
                Response.Write("<script language='javascript'>alert('Your Application Sent Sucessfully')</script>");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected void btnApply_Click1(object sender, EventArgs e)
        {
            if (SentMail(jobtitle))
            {
                CheckMailSend(id, candidateId);
            }
            GetCandidateProfile(candidateId);
        }

        protected void btnApplyRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnApplyLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn.aspx?redirect=" + Request.Url.ToString());
        }

        protected void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("ForwardJobToFriend.aspx?jid="+id);
        }

        //private void BindReapetor()
        //{
        //    try
        //    {
        //        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        //        SqlDataAdapter da = new SqlDataAdapter("",connection);
        //        da.SelectCommand = new SqlCommand("select JobTitle,JobDescription,OfferedAnnualSalaryMin,OfferedAnnualSalaryMax,KeywordsTechnical,CompanyName from RE_JobPost", connection);
        //        DataSet ds = new DataSet();
        //        da.Fill(ds, "data");
        //       rptrviewpost.DataSource  = ds.Tables[0].DefaultView;
        //        rptrviewpost.DataBind();

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}