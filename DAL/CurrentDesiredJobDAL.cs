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
        public int SaveCurrentProfessionalDetailsDAL(CurrentDesiredJobEntity currentJobEntity)
        {
            try
            {
                connection.Open();

                //Parameters to pass to the stored procedure
                SqlParameter[] sparams = { new SqlParameter("@candidateId",currentJobEntity.Candidateid),
                                            new SqlParameter("@resumeheadline",currentJobEntity.ResumeHeadline),
                                            new SqlParameter("@totalExp",currentJobEntity.TotalExperience),
                                            new SqlParameter("@industryId",currentJobEntity.Industry),
                                            new SqlParameter("@departmentId",currentJobEntity.Department),
                                            new SqlParameter("@currentjobrole",currentJobEntity.CurrentJobRole),
                                            new SqlParameter("@currentemployer",currentJobEntity.CurrentEmployer),
                                            new SqlParameter("@primfunrole",currentJobEntity.PrimFunctionalRole),
                                            new SqlParameter("@primjobdesrip",currentJobEntity.PrimJobDescrip),
                                            new SqlParameter("@primtechskills",currentJobEntity.PrimTechSkills),
                                            new SqlParameter("@secfunrole",currentJobEntity.SecFunctionalRole),
                                            new SqlParameter("@secjobdescrip",currentJobEntity.SecJobDescrip),
                                            new SqlParameter("@sectechskills",currentJobEntity.SecTechSkills),
                                            new SqlParameter("@technicalskills",currentJobEntity.TechnicalSkills),
                                            new SqlParameter("@reasonforjobchange",currentJobEntity.ReasonforJobChange),
                                            new SqlParameter("@designation",currentJobEntity.Designation)};

                int res = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertProfessionalDetails, sparams);
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Method in DAL layer for DesiredJobDetails
        /// </summary>
        /// <param name="desiredjobEntity">Object of CurrentDesiredJobEntity class</param>
        /// <returns>System.Int32</returns>
        public int SaveDesiredJobDetailsDAL(CurrentDesiredJobEntity desiredjobEntity)
        {
            try
            {
                connection.Open();

                //Parameters to pass to the stored procedure
                SqlParameter[] sparams ={new SqlParameter("@candidateid",desiredjobEntity.Candidateid),
                                      new SqlParameter("@jobpostlooking",desiredjobEntity.JobPostLooking),
                                      new SqlParameter("@releventExp",desiredjobEntity.RelevantExp),
                                      new SqlParameter("@currentanualSal",desiredjobEntity.CurrentAnualSal),
                                      new SqlParameter("@expectedanualSal",desiredjobEntity.ExpectedAnualSal),
                                      new SqlParameter("@noticeperiod",desiredjobEntity.NoticePeriod),
                                      new SqlParameter("@employmentstatus",desiredjobEntity.EmploymentStatus),
                                      new SqlParameter("@jobtype",desiredjobEntity.JobType),
                                      new SqlParameter("@workarea",desiredjobEntity.WorkArea),
                                      new SqlParameter("@preferrdCountry",desiredjobEntity.PreferredCountry),
                                      new SqlParameter("@preferredstate",desiredjobEntity.PreferredState),
                                      new SqlParameter("@preferredcity",desiredjobEntity.PreferredCity)};
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertDesiredJobDetails, sparams);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

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
    }
}