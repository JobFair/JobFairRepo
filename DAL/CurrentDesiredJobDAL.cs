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
        /// Method to Save Experience details in Database in CurrentDesiredJobDAL class
        /// </summary>
        /// <param name="dt">Parameter of Datatable to pass data</param>
        /// <returns>System.Data.DataTable</returns>
        public DataTable SaveExperienceDetailsDAL(DataTable dt)
        {
            try
            {
                connection.Open();

                // Creating object of SqlBulkCopy
                SqlBulkCopy objbulk = new SqlBulkCopy(connection);

                // Assigning Destination table name
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
        /// <summary>
        /// Method to Save Job Looking Details of Jobseeker in Database in CurrentDesiredJobDAL class
        /// </summary>
        /// <param name="dt">Parameter of Datatable to pass data</param>
        /// <returns>System.Data.DataTable</returns>
        public DataTable SaveJobLookingDetailsDAL(DataTable dt)
        {
            try
            {
                connection.Open();

                // Creating object of SqlBulkCopy
                SqlBulkCopy objbulk = new SqlBulkCopy(connection);

                // Assigning Destination table name
                objbulk.DestinationTableName = "JS_JobPostLookingFor";

                // Mapping Table column
                objbulk.ColumnMappings.Add("CandidateId", "CandidateId");
                objbulk.ColumnMappings.Add("JobPostLookingFor", "JobPostLookingFor");
                objbulk.ColumnMappings.Add("Industry", "Industry");
                objbulk.ColumnMappings.Add("Department", "Department");
                objbulk.ColumnMappings.Add("FunctionalRole", "FunctionalRole");
                objbulk.ColumnMappings.Add("RelevantExperience", "RelevantExperience");

                // Inserting bulk Records into DataBase
                objbulk.WriteToServer(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Method to Save Job Details in Database in CurrentDesiredJobDAL class
        /// </summary>
        /// <param name="currentDesiredJobEntity">Object of CurrentDesiredJobEntity</param>
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

        /// <summary>
        /// Method to Save Desired Job Details in Database in CurrentDesiredJobDAL class
        /// </summary>
        /// <param name="currentDesiredJobEntity">Object of CurrentDesiredJobEntity</param>
        public void SaveDesiredJobDetailsDAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[19];
                sparams[0] = new SqlParameter("@candidateid", currentDesiredJobEntity.Candidateid);
                sparams[1] = new SqlParameter("@currentWorkingStatus", currentDesiredJobEntity.CurrentWorkingStatus);
                sparams[2] = new SqlParameter("@currentanualSal", currentDesiredJobEntity.CurrentAnualSal);
                sparams[3] = new SqlParameter("@expectedanualSal", currentDesiredJobEntity.ExpectedAnualSal);
                sparams[4] = new SqlParameter("@noticeperiod", currentDesiredJobEntity.NoticePeriod);
                sparams[5] = new SqlParameter("@employmentstatus", currentDesiredJobEntity.EmploymentStatus);
                sparams[6] = new SqlParameter("@jobtype", currentDesiredJobEntity.JobType);
                sparams[7] = new SqlParameter("@companyType", currentDesiredJobEntity.CompanyType);
                sparams[8] = new SqlParameter("@availabilityForInterview", currentDesiredJobEntity.Availabilityforinterview);
                sparams[9] = new SqlParameter("@preferredState", currentDesiredJobEntity.PreferredState);
                sparams[10] = new SqlParameter("@preferredcity", currentDesiredJobEntity.PreferredCity);
                sparams[11] = new SqlParameter("@preferredarea", currentDesiredJobEntity.PreferrefArea);
                sparams[12] = new SqlParameter("@beforeHours", currentDesiredJobEntity.BeforeHours);
                sparams[13] = new SqlParameter("@beforeMinutes", currentDesiredJobEntity.BeforeMinutes);
                sparams[14] = new SqlParameter("@beforeTime", currentDesiredJobEntity.BeforeTime);
                sparams[15] = new SqlParameter("@afterHours", currentDesiredJobEntity.AfterHours);
                sparams[16] = new SqlParameter("@afterMinutes", currentDesiredJobEntity.AfterMinutes);
                sparams[17] = new SqlParameter("@afterTime", currentDesiredJobEntity.AfterTime);
                sparams[18] = new SqlParameter("@timeISTETE", currentDesiredJobEntity.TimeISTETE);
              

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_InsertDesiredJobDetails", sparams);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet GetTechnicalSkillsDetailsDAL()
        {
            DataSet ds = new DataSet();
            connection.Open();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from TechnicalSkillsDetails order by TechnicalSkillName asc");
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SaveTechnicalSkillsDAL(DataTable dt)
        {
            try
            {

                connection.Open();

                // Creating object of SqlBulkCopy
                SqlBulkCopy objbulk = new SqlBulkCopy(connection);

                // Assigning Destination table name
                objbulk.DestinationTableName = "JS_TechnicalSkillDetails";

                // Mapping Table column
                objbulk.ColumnMappings.Add("CandidateId", "CandidateId");
                objbulk.ColumnMappings.Add("TechnicalSkills", "TechnicalSkills");
                objbulk.ColumnMappings.Add("FromDate", "FromDate");
                objbulk.ColumnMappings.Add("TillDate", "TillDate");
                objbulk.ColumnMappings.Add("Proficiency", "Proficiency");
                objbulk.ColumnMappings.Add("TotalYear", "TotalYear");

                // Inserting bulk Records into DataBase
                objbulk.WriteToServer(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet GetRoleSkillsDAL()
        {
            DataSet ds = new DataSet();
            connection.Open();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from RoleSkills order by RoleName asc");
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SaveRoleSkillsDAL(DataTable dt)
        {
            try
            {

                connection.Open();

                // Creating object of SqlBulkCopy
                SqlBulkCopy objbulk = new SqlBulkCopy(connection);

                // Assigning Destination table name
                objbulk.DestinationTableName = "JS_RoleSkillsDetails";

                // Mapping Table column
                objbulk.ColumnMappings.Add("CandidateId", "CandidateId");
                objbulk.ColumnMappings.Add("RoleSkills", "RoleSkills");
                objbulk.ColumnMappings.Add("FromDate", "FromDate");
                objbulk.ColumnMappings.Add("TillDate", "TillDate");
                objbulk.ColumnMappings.Add("Proficiency", "Proficiency");
                objbulk.ColumnMappings.Add("TotalYear", "TotalYear");

                // Inserting bulk Records into DataBase
                objbulk.WriteToServer(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet ViewCurrentJobDetailsDAL(string candidateId)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlParameter[] sparams = { new SqlParameter("@candiadteId", candidateId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectCurrentDesiredJobDetails, sparams);
               
                return ds;
            }
            catch (Exception)
            {
                
                throw;
            }
        }



        public void UpdateJobLookingDAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            try
            {

                
            connection.Open();
            SqlParameter[] sparams = new SqlParameter[6];
            sparams[0] = new SqlParameter("@JobpostlookingId", currentDesiredJobEntity.JobPostLookingId);
            sparams[1] = new SqlParameter("@jobPostLookingFor", currentDesiredJobEntity.JobPostLookingFor);
            sparams[2] = new SqlParameter("@industry", currentDesiredJobEntity.Industry);
            sparams[3] = new SqlParameter("@department", currentDesiredJobEntity.Department);
            sparams[4] = new SqlParameter("@functionalRole", currentDesiredJobEntity.FunctionalRole);
            sparams[5] = new SqlParameter("@relevantExp", Convert.ToDouble(currentDesiredJobEntity.RelevantExp));

            SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateJobPostLookingFor, sparams);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteJobPostLookingForDAL(int JobpostlookingId)
        {
            try
            {
                
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
            connection.Open();

            SqlParameter[] sparams = { new SqlParameter("@JobpostlookingId", JobpostlookingId) };


            SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_DeleteJobPostLookingFor, sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public DataSet ViewRepeaterJobPostLookingBAL(string candidateId)
        {
            try
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
            connection.Open();

            SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };


            return SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectJobPostLookingFor, sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataSet ViewRepeaterCurrentPastJobDetailsDAL(string candidateId)
        {
            try
            {
                 CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
            connection.Open();

            SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };


           return SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectCurrentPastJobDeatails, sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void UpdateCurrentPastExpDetailsDAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            try
            {


                connection.Open();
                SqlParameter[] sparams = new SqlParameter[14];
                sparams[0] = new SqlParameter("@id", currentDesiredJobEntity.ExpId);
                sparams[1] = new SqlParameter("@companyCurrentOrPast", currentDesiredJobEntity.CurrentCompanyOrNot);
                sparams[2] = new SqlParameter("@companyName", currentDesiredJobEntity.CompanyName);
                sparams[3] = new SqlParameter("@rolesResponsibilities", currentDesiredJobEntity.RolesResponsibility);
                sparams[4] = new SqlParameter("@fromMonth", currentDesiredJobEntity.FromMonth);
                sparams[5] = new SqlParameter("@fromYear", currentDesiredJobEntity.FromYear);
                sparams[6] = new SqlParameter("@tillMonth", currentDesiredJobEntity.TillMonth);
                sparams[7] = new SqlParameter("@tillYear", currentDesiredJobEntity.TillYear);
                sparams[8] = new SqlParameter("@industry", currentDesiredJobEntity.Industry);
                sparams[9] = new SqlParameter("@department", currentDesiredJobEntity.Department);
                sparams[10] = new SqlParameter("@employmentStatus", currentDesiredJobEntity.CurrentEmploymentStatus);
                sparams[11] = new SqlParameter("@jobType", currentDesiredJobEntity.JobType);
                sparams[12] = new SqlParameter("@companyType", currentDesiredJobEntity.CompanyType);
                sparams[13] = new SqlParameter("@reason", currentDesiredJobEntity.ReasonForJobChange);
               

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateCurrentPastExpDetails, sparams);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteCurrentPastJobDetailsDAL(int expId)
        {
            try
            {
                  CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
            connection.Open();

            SqlParameter[] sparams = { new SqlParameter("@id", expId) };


            SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_DeleteCurrentPastJobDetails, sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataSet ViewRepeaterTechSkillDetailsDAL(string candidateId)
        {
            try
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
                connection.Open();

                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };


                return SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectTechnicalSkills, sparams);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateTechnicalSkillsDAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {          
                 try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[6];
                sparams[0] = new SqlParameter("@skillId", currentDesiredJobEntity.SkillId);
                sparams[1] = new SqlParameter("@technicalSkill", currentDesiredJobEntity.TechnicalSkills);
                sparams[2] = new SqlParameter("@fromDate", currentDesiredJobEntity.FromDate);
                sparams[3] = new SqlParameter("@tillDate", currentDesiredJobEntity.TillDate);
                sparams[4] = new SqlParameter("@proficiency", currentDesiredJobEntity.Proficiency);
                sparams[5] = new SqlParameter("@totalYear", currentDesiredJobEntity.TotalExperience);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateTechnicalSkills, sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void DeleteTechnicalSkillDAL(int SkillId)
        {
            try
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
                connection.Open();

                SqlParameter[] sparams = { new SqlParameter("@id", SkillId) };


                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_DeleteTechnicalSkill, sparams);
            }
            catch (Exception)
            {

                throw;
            }
        }


       // Pending
        public DataSet ViewRepeaterRoleSkillDetailsDAL(string candidateId)
        {
            try
            {
                 try
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
                connection.Open();

                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };


                return SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectRoleSkills, sparams);
            }
            catch (Exception)
            {

                throw;
            }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void UpdateRoleSkillsDAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[6];
                sparams[0] = new SqlParameter("@skillId", currentDesiredJobEntity.SkillId);
                sparams[1] = new SqlParameter("@roleSkill", currentDesiredJobEntity.RoleSkills);
                sparams[2] = new SqlParameter("@fromDate", currentDesiredJobEntity.FromDate);
                sparams[3] = new SqlParameter("@tillDate", currentDesiredJobEntity.TillDate);
                sparams[4] = new SqlParameter("@proficiency", currentDesiredJobEntity.Proficiency);
                sparams[5] = new SqlParameter("@totalYear", currentDesiredJobEntity.TotalExperience);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateRoleSkills, sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void DeleteRoleSkillBAL(int SkillId)
        {
            try
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
                connection.Open();

                SqlParameter[] sparams = { new SqlParameter("@id", SkillId) };


                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_DeleteRoleSkill, sparams);
            }
            catch (Exception)
            {

                throw;
            } 
        }
    }
}