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
                objbulk.ColumnMappings.Add("FromDate", "FromDate");
                objbulk.ColumnMappings.Add("TillDate", "TillDate");
                objbulk.ColumnMappings.Add("RelevantExperience", "RelevantExperience");
                objbulk.ColumnMappings.Add("Industry", "Industry");
                objbulk.ColumnMappings.Add("Department", "Department");
                objbulk.ColumnMappings.Add("FunctionalArea", "FunctionalArea");
                objbulk.ColumnMappings.Add("EmploymentStatus", "EmploymentStatus");
                objbulk.ColumnMappings.Add("JobType", "JobType");
                objbulk.ColumnMappings.Add("CompanyType", "CompanyType");
                objbulk.ColumnMappings.Add("Reason", "Reason");

                // Inserting bulk Records into DataBase
                objbulk.WriteToServer(dt);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return dt;
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
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return dt;
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
                // throw;
            }
            finally
            {
                connection.Close();
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
                SqlParameter[] sparams = new SqlParameter[15];
                sparams[0] = new SqlParameter("@candidateid", currentDesiredJobEntity.Candidateid);
                sparams[1] = new SqlParameter("@currentWorkingStatus", currentDesiredJobEntity.CurrentWorkingStatus);
                sparams[2] = new SqlParameter("@currentanualSal", currentDesiredJobEntity.CurrentAnualSal);
                sparams[3] = new SqlParameter("@expectedanualSal", currentDesiredJobEntity.ExpectedAnualSal);
                sparams[4] = new SqlParameter("@noticeperiod", currentDesiredJobEntity.NoticePeriod);
                sparams[5] = new SqlParameter("@employmentstatus", currentDesiredJobEntity.EmploymentStatus);
                sparams[6] = new SqlParameter("@jobtype", currentDesiredJobEntity.JobType);
                sparams[7] = new SqlParameter("@companyType", currentDesiredJobEntity.CompanyType);
                sparams[8] = new SqlParameter("@availabilityForInterview", currentDesiredJobEntity.Availabilityforinterview);
                sparams[9] = new SqlParameter("@preferredCountry", currentDesiredJobEntity.PreferredCountry);
                sparams[10] = new SqlParameter("@preferredState", currentDesiredJobEntity.PreferredState);
                sparams[11] = new SqlParameter("@preferredcity", currentDesiredJobEntity.PreferredCity);
                sparams[12] = new SqlParameter("@preferredarea", currentDesiredJobEntity.PreferrefArea);

                sparams[13] = new SqlParameter("@beforeTime", currentDesiredJobEntity.BeforeTime);

                sparams[14] = new SqlParameter("@afterTime", currentDesiredJobEntity.AfterTime);

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_InsertDesiredJobDetails", sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Get technical skills details DAL
        /// </summary>
        /// <returns>dataset</returns>
        public DataSet GetTechnicalSkillsDetailsDAL()
        {
            DataSet ds = new DataSet();
            connection.Open();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from TechnicalSkillsDetails order by TechnicalSkillName asc");
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }

        /// <summary>
        /// Save technical skills DAL
        /// </summary>
        /// <param name="dt">dt</param>
        /// <returns>datatable</returns>
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
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        /// <summary>
        /// Get role skills DAL
        /// </summary>
        /// <returns>dataset</returns>
        public DataSet GetRoleSkillsDAL()
        {
            DataSet ds = new DataSet();
            connection.Open();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from RoleSkills order by RoleName asc");
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }

        /// <summary>
        /// Save role skills DAL
        /// </summary>
        /// <param name="dt">dt</param>
        /// <returns>datatable</returns>
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
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        /// <summary>
        /// View current job details DAL
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewCurrentJobDetailsDAL(string candidateId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectCurrentDesiredJobDetails, sparams);
            }
            catch (Exception)
            {
                //  throw;
            }
            return ds;
        }

        /// <summary>
        /// Update job looking for DAL
        /// </summary>
        /// <param name="currentDesiredJobEntity">CurrentDesiredJobEntity</param>
        public void UpdateJobLookingForDAL(CurrentDesiredJobEntity currentDesiredJobEntity)
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
                // throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Delete job post looking for DAL
        /// </summary>
        /// <param name="jobPostlookingId">JobpostlookingId</param>
        public void DeleteJobPostLookingForDAL(int jobPostlookingId)
        {
            try
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
                connection.Open();

                SqlParameter[] sparams = { new SqlParameter("@JobpostlookingId", jobPostlookingId) };

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_DeleteJobPostLookingFor, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// View jobpost looking for DAL
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewJobPostLookingForDAL(string candidateId)
        {
            DataSet ds = new DataSet();
            try
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
                connection.Open();

                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };

                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectJobPostLookingFor, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }

        /// <summary>
        /// View current and past job details DAL
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>candidateId</returns>
        public DataSet ViewCurrentPastJobDetailsDAL(string candidateId)
        {
            DataSet ds = new DataSet();
            try
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
                connection.Open();

                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };

                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectCurrentPastJobDeatails, sparams);
            }
            catch (Exception)
            {
                //  throw;
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }

        /// <summary>
        /// Update current and past experience details DAL
        /// </summary>
        /// <param name="currentDesiredJobEntity">CurrentDesiredJobEntity</param>
        public void UpdateCurrentPastExperienceDetailsDAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[16];
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
                sparams[14] = new SqlParameter("@clientName", currentDesiredJobEntity.ClientName);
                sparams[15] = new SqlParameter("@clientSite", currentDesiredJobEntity.ClientSite);

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateCurrentPastExpDetails, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Delete current and past job details DAL
        /// </summary>
        /// <param name="expId">expId</param>
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
                // throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// View technical skills details DAL
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewTechSkillDetailsDAL(string candidateId)
        {
            DataSet ds = new DataSet();
            try
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
                connection.Open();

                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };

                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectTechnicalSkills, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }

        /// <summary>
        /// Update technical skills DAL
        /// </summary>
        /// <param name="currentDesiredJobEntity">CurrentDesiredJobEntity</param>
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
                // throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Delete technical skills DAL
        /// </summary>
        /// <param name="SkillId">SkillId</param>
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
                //  throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// View roles skills details DAL
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns></returns>
        public DataSet ViewRoleSkillDetailsDAL(string candidateId)
        {
            DataSet ds = new DataSet();
            try
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
                connection.Open();

                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };

                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectRoleSkills, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }

        /// <summary>
        /// Update roles skills DAL
        /// </summary>
        /// <param name="currentDesiredJobEntity">CurrentDesiredJobEntity</param>
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
                // throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Delete role skills DAL
        /// </summary>
        /// <param name="skillId">SkillId</param>
        public void DeleteRoleSkillDAL(int skillId)
        {
            try
            {
                CurrentDesiredJobEntity currentDesiredJobEntity = new CurrentDesiredJobEntity();
                connection.Open();

                SqlParameter[] sparams = { new SqlParameter("@id", skillId) };

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_DeleteRoleSkill, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Method in CurrentDesiredJobDAL class to add new role skill in table
        /// </summary>
        /// <param name="currentDesiredJobEntity">Entity of CurrentDesiredJobEntity</param>
        public void AddRoleSkillsDetailsDAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = { new SqlParameter("@SkillName", currentDesiredJobEntity.RoleSkills) };
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertRoleSkill, sparams);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method in CurrentDesiredJobDAL class to add new technical skill in table
        /// </summary>
        /// <param name="currentDesiredJobEntity">Entity of CurrentDesiredJobEntity</param>
        public void AddTechnicalSkillsDetailsDAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = { new SqlParameter("@skillName", currentDesiredJobEntity.TechnicalSkills) };
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertTechnicalSkills, sparams);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method in CurrentDesiredJobDAL class to update Desired Details in Database
        /// </summary>
        /// <param name="currentDesiredJobEntity">Entity of CurrentDesiredJobEntity</param>
        public void UpdateProfessionalDetailsDAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[20];
                sparams[0] = new SqlParameter("@candidateid", currentDesiredJobEntity.Candidateid);
                sparams[1] = new SqlParameter("@currentWorkingStatus", currentDesiredJobEntity.CurrentWorkingStatus);
                sparams[2] = new SqlParameter("@currentanualSal", currentDesiredJobEntity.CurrentAnualSal);
                sparams[3] = new SqlParameter("@expectedanualSal", currentDesiredJobEntity.ExpectedAnualSal);
                sparams[4] = new SqlParameter("@noticeperiod", currentDesiredJobEntity.NoticePeriod);
                sparams[5] = new SqlParameter("@employmentstatus", currentDesiredJobEntity.EmploymentStatus);
                sparams[6] = new SqlParameter("@jobtype", currentDesiredJobEntity.JobType);
                sparams[7] = new SqlParameter("@companyType", currentDesiredJobEntity.CompanyType);
                sparams[8] = new SqlParameter("@availabilityForInterview", currentDesiredJobEntity.Availabilityforinterview);
                sparams[9] = new SqlParameter("@preferredCountry", currentDesiredJobEntity.PreferredCountry);
                sparams[10] = new SqlParameter("@preferredState", currentDesiredJobEntity.PreferredState);
                sparams[11] = new SqlParameter("@preferredcity", currentDesiredJobEntity.PreferredCity);
                sparams[12] = new SqlParameter("@preferredarea", currentDesiredJobEntity.PreferrefArea);
                sparams[13] = new SqlParameter("@beforeTime", currentDesiredJobEntity.BeforeTime);
                sparams[14] = new SqlParameter("@afterTime", currentDesiredJobEntity.AfterTime);
                sparams[15] = new SqlParameter("@resumeHeadline", currentDesiredJobEntity.ResumeHeadline);
                sparams[16] = new SqlParameter("@objective", currentDesiredJobEntity.Objective);
                sparams[17] = new SqlParameter("@profileSummary", currentDesiredJobEntity.ProfileSummary);
                sparams[18] = new SqlParameter("@employeedOrNot", currentDesiredJobEntity.CurrentEmployeedUnemployeed);
                sparams[19] = new SqlParameter("@totalExperiecnce", currentDesiredJobEntity.TotalExperience);

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateDesiredJobDetails, sparams);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteOneRecordOfGridViewExperienceDAL(int ID)
        {
            connection.Open();
            SqlParameter[] sparams = { new SqlParameter("@id", ID) };
        }
    }
}