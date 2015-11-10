using Entities.JobSeeker;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// CurrentDesiredJobDAL class
    /// </summary>
    public class CurrentDesiredJobDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Method in DAL layer for CurrentJobDetails
        /// </summary>
        /// <param name="currentJobEntity">Current job details entity</param>
        /// <returns>System.Int32</returns>
       

       

        public DataTable GetPreferredCityDAL(string PrefixText)
        {
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from City where CityName like @citynames + '%' ", connection);
                cmd.Parameters.AddWithValue("@citynames", PrefixText);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetPreferredAreaDAL(string prefixText)
        {
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from CityArea where AreaName like @areaname + '%' ", connection);
                cmd.Parameters.AddWithValue("@areaname", prefixText);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable SaveExperienceDetailsDAL(DataTable dt)
        {
            try
            {
                connection.Open();
                // Creating object of SqlBulkCopy
                SqlBulkCopy objbulk = new SqlBulkCopy(connection);
                //assigning Destination table name
                objbulk.DestinationTableName = "JS_CurrentPastExperience";
                // Mapping Table column
                objbulk.ColumnMappings.Add("CandidateId", "CandidateId");
                objbulk.ColumnMappings.Add("CompanyCurrentOrPast", "CompanyCurrentOrPast");
                objbulk.ColumnMappings.Add("ComapnyName", "ComapnyName");
                objbulk.ColumnMappings.Add("Designation", "Designation");
                objbulk.ColumnMappings.Add("RolesResponsibilities", "RolesResponsibilities");
                objbulk.ColumnMappings.Add("FromMonth", "FromMonth");
                objbulk.ColumnMappings.Add("FromYear", "FromYear");
                objbulk.ColumnMappings.Add("TillMonth", "TillMonth");               
                objbulk.ColumnMappings.Add("TillYear", "TillYear");
                objbulk.ColumnMappings.Add("Industry", "Industry");
                objbulk.ColumnMappings.Add("Department", "Department");
                objbulk.ColumnMappings.Add("EmploymentStatus", "EmploymentStatus");
                objbulk.ColumnMappings.Add("JobType", "JobType");
                objbulk.ColumnMappings.Add("CompanyType", "CompanyType");
                objbulk.ColumnMappings.Add("Reason", "Reason");

                // Inserting bulk Records into DataBase
                objbulk.WriteToServer(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }            
        }

        public DataTable SaveJobLookingDetailsDAL(DataTable dt)
        {
            try
            {
                connection.Open();
                //creating object of SqlBulkCopy
                SqlBulkCopy objbulk = new SqlBulkCopy(connection);
                //assigning Destination table name
                objbulk.DestinationTableName = "JS_JobPostLookingFor";
                //Mapping Table column
                objbulk.ColumnMappings.Add("CandidateId", "CandidateId");
                objbulk.ColumnMappings.Add("JobPostLookingFor", "JobPostLookingFor");
                objbulk.ColumnMappings.Add("Industry", "Industry");
                objbulk.ColumnMappings.Add("Department", "Department");
                objbulk.ColumnMappings.Add("FunctionalRole", "FunctionalRole");
                objbulk.ColumnMappings.Add("RelevantExperience", "RelevantExperience");
                //inserting bulk Records into DataBase
                objbulk.WriteToServer(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SaveJobDetailsDAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[6];
                sparams[0] = new SqlParameter("@candidateId", currentDesiredJobEntity.Candidateid);
                sparams[1] = new SqlParameter("@resumeHeadline", currentDesiredJobEntity.ResumeHeadline);
                sparams[2] = new SqlParameter("@objective", currentDesiredJobEntity.Objective);
                sparams[3] = new SqlParameter("@profileSummary", currentDesiredJobEntity.ProfileSummary);
                sparams[4] = new SqlParameter("@employeedOrNot", currentDesiredJobEntity.CurrentEmployeedUnemployeed);
                sparams[5] = new SqlParameter("@totalExperiecnce", currentDesiredJobEntity.TotalExperience);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertJobDetails, sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void SaveDesiredJobDetailsDAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[12];
                sparams[0] = new SqlParameter("@candidateid", currentDesiredJobEntity.Candidateid);
                sparams[1] = new SqlParameter("@currentWorkingStatus", currentDesiredJobEntity.CurrentWorkingStatus);
                sparams[2] = new SqlParameter("@currentanualSal", currentDesiredJobEntity.CurrentAnualSal);
                sparams[3] = new SqlParameter("@expectedanualSal", currentDesiredJobEntity.ExpectedAnualSal);
                sparams[4] = new SqlParameter("@noticeperiod", currentDesiredJobEntity.NoticePeriod);
                sparams[5] = new SqlParameter("@employmentstatus", currentDesiredJobEntity.EmploymentStatus);
                sparams[6] = new SqlParameter("@jobtype", currentDesiredJobEntity.JobType);
                sparams[7] = new SqlParameter("@companyType", currentDesiredJobEntity.CompanyType);
                sparams[8] = new SqlParameter("@availabilityForInterview", currentDesiredJobEntity.Availabilityforinterview);
                sparams[9] = new SqlParameter("@timeInWeekdays",currentDesiredJobEntity.TimeInWeekdays);
                sparams[10] = new SqlParameter("@preferredcity", currentDesiredJobEntity.PreferredCity);
                sparams[11] = new SqlParameter("@preferredarea", currentDesiredJobEntity.PreferrefArea);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_InsertDesiredJobDetails", sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}