using Entities.Recruiter;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// Job post
    /// </summary>
    public class PostNewJobDAL
    {
        private SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Get requirement details dal
        /// </summary>
        /// <param name="requirementId">for retrive data from data from database</param>
        /// <returns>DataSet</returns>
        public DataSet GetRequirementDetailDAL(int requirementId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@clientRequirementId", requirementId) };
                ds = SqlHelper.ExecuteDataset(Connection, CommandType.StoredProcedure, Constants.sp_RE_RequirementDetails, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }

        /// <summary>
        /// Dal layer method to store new job post data into jobpost table in database
        /// </summary>
        /// <param name="jobpostEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int JobPostDAL(AddJobPostEntity jobpostEntity)
        {
            try
            {
                Connection.Open();
                SqlParameter[] sqlparams ={
                                            new SqlParameter("@RecruiterID",jobpostEntity.RecruiterID),
                                            new SqlParameter("@JobTitle",jobpostEntity.JobTitle),
                                            new SqlParameter("@JobLocationState",jobpostEntity.JobLocationState),
                                            new SqlParameter("@JobLocationCity",jobpostEntity.JobLocationCity),
                                            new SqlParameter("@JobLocationArea",jobpostEntity.JobLocationArea),
                                            new SqlParameter("@CompanyLevel",jobpostEntity.CompanyLevel),
                                            new SqlParameter("@JobIndustryId",jobpostEntity.IndustryId),
                                            new SqlParameter("@DepartmentId",jobpostEntity.DepartmentId),
                                            new SqlParameter("@FunctionalAreaId",jobpostEntity.FunctionalAreaId),
                                            new SqlParameter("@JobDescription",jobpostEntity.JobDescription),
                                            new SqlParameter("@KeywordsRoles",jobpostEntity.KeywordsRoles),
                                            new SqlParameter("@KeywordsTechnical",jobpostEntity.KeywordsTechnical),
                                            new SqlParameter("@WorkExperienceMin",jobpostEntity.WorkExperienceMin),
                                            new SqlParameter("@WorkExperienceMax",jobpostEntity.WorkExperienceMax),
                                            new SqlParameter("@Gender",jobpostEntity.Gender),
                                            new SqlParameter("@OfferedAnnualSalaryMin",jobpostEntity.OfferedAnnualSalaryMin),
                                            new SqlParameter("@OfferedAnnualSalaryMax",jobpostEntity.OfferedAnnualSalaryMax),
                                            new SqlParameter("@OtherSalaryDetails",jobpostEntity.OtherSalaryDetails),
                                            new SqlParameter("@NumberOfVacancies",jobpostEntity.NumberOfVacancies),
                                            new SqlParameter("@JobType",jobpostEntity.JobType),
                                            new SqlParameter("@EmploymentStatus",jobpostEntity.EmploymentStatus),
                                            new SqlParameter("@RecruitmentType",jobpostEntity.RecruitmentType),
                                            new SqlParameter("@CompanyName",jobpostEntity.CompanyName),
                                            new  SqlParameter("@ClientName",jobpostEntity.ClientName),
                                            new SqlParameter("@Position",jobpostEntity.Position),
                                            new SqlParameter("@requirementId",jobpostEntity.RequirementId),
                                            new SqlParameter("@companyProfile",jobpostEntity.CompanyProfile),
                                            new SqlParameter("@qualification",jobpostEntity.Qualification),
                                            new SqlParameter("@questionnareId",jobpostEntity.QueationnareId),
                                            new SqlParameter("@describeCandidateProfile",jobpostEntity.DescribeCandidateProfile)
                                        };

                return SqlHelper.ExecuteNonQuery(Connection, CommandType.StoredProcedure, Constants.sp_RE_InsertJobPost, sqlparams);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// DAL for GetQuestions
        /// </summary>
        /// <returns>Dataset</returns>
        public DataSet GetQuestionsDAL()
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(Connection, CommandType.Text, "select * from RE_Questionnaire");
            return ds;
        }

        /// <summary>
        /// Get state dal
        /// </summary>
        /// <returns>dataset</returns>
        public DataSet GetStateDAL()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(Connection, CommandType.Text, "select * from State");
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Get roles dal
        /// </summary>
        /// <param name="prefixText">prefixText</param>
        /// <returns>Datatable</returns>
        public DataTable GetRoles(string prefixText)
        {
            Connection.Open();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(Constants.sp_SelectRoleSkills, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleName", prefixText);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        /// <summary>
        /// Get technical skills dal
        /// </summary>
        /// <param name="prefixText">prefixText</param>
        /// <returns>Datatable</returns>
        public DataTable GetTechnicalSkill(string prefixText)
        {
            Connection.Open();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(Constants.sp_SelectTechnicalSkills, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TechnicalSkillName", prefixText);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        /// <summary>
        /// Get client name dal
        /// </summary>
        /// <returns>Dataset</returns>
        public DataSet GetClientname()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(Connection, CommandType.Text, "select ClientId,ClientName from HR_ClientDetails");
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Get recruiter name dal
        /// </summary>
        /// <returns>Dataset</returns>
        public DataSet GetRecruiterNameDAL()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(Connection, CommandType.StoredProcedure, Constants.sp_RE_SelectRequirement);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }

        /// <summary>
        /// Insert roles skills dal
        /// </summary>
        /// <param name="jobpostEntity">AddJobPostEntity</param>
        public void AddRoleSkillsDetailsDAL(AddJobPostEntity jobpostEntity)
        {
            try
            {
                Connection.Open();
                SqlParameter[] sparams = { new SqlParameter("@SkillName", jobpostEntity.RoleSkill) };
                SqlHelper.ExecuteNonQuery(Connection, CommandType.StoredProcedure, Constants.sp_JS_InsertRoleSkill, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// Insert technical skills dal
        /// </summary>
        /// <param name="jobpostEntity">AddJobPostEntity</param>
        public void AddTechnicalSkillsDetailsDAL(AddJobPostEntity jobpostEntity)
        {
            try
            {
                Connection.Open();
                SqlParameter[] sparams = { new SqlParameter("@SkillName", jobpostEntity.TechnicalSkill) };
                SqlHelper.ExecuteNonQuery(Connection, CommandType.StoredProcedure, Constants.sp_JS_InsertTechnicalSkills, sparams);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}