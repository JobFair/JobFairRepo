using Entities.Recruiter;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// jop post
    /// </summary>
    public class NewJobPostDAL
    {
        /// <summary>
        /// Dal layer method to store new job post data into jobpost table in database
        /// </summary>
        /// <param name="jobpostEntity">Object for inserting data into database</param>
        /// <returns>System.String</returns>
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public int JobPostDAL(AddJobPostEntity jobpostEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sqlparams ={
                                            new SqlParameter("@RecruiterID",jobpostEntity.RecruiterID),
                                            new SqlParameter("@JobTitle",jobpostEntity.JobTitle),
                                            new SqlParameter("@JobLocationCity",jobpostEntity.JobLocationCity),
                                            new SqlParameter("@JobLocationArea",jobpostEntity.JobLocationArea),
                                            new SqlParameter("@CompanyLevel",jobpostEntity.CompanyLevel),
                                            new SqlParameter("@IndustryId",jobpostEntity.IndustryId),
                                            new SqlParameter("@DepartmentId",jobpostEntity.DepartmentId),
                                            new SqlParameter("@FunctionalAreaId",jobpostEntity.FunctionalAreaId),
                                            new SqlParameter("@JobDescription",jobpostEntity.JobDescription),
                                            new SqlParameter("@KeywordsRoles",jobpostEntity.KeywordsRoles),
                                            new SqlParameter("@KeywordsTechnical",jobpostEntity.KeywordsRoles),
                                            new SqlParameter("@Workexperience",jobpostEntity.Workexperience),
                                            new SqlParameter("@Gender",jobpostEntity.Gender),
                                            new SqlParameter("@OfferedAnnualSalaryMin",jobpostEntity.OfferedAnnualSalaryMin),
                                              new SqlParameter("@OfferedAnnualSalaryMax",jobpostEntity.OfferedAnnualSalaryMax),
                                            new SqlParameter("@OtherSalaryDetails",jobpostEntity.OtherSalaryDetails),
                                            new SqlParameter("@NumberOfVacancies",jobpostEntity.NumberOfVacancies),
                                            new  SqlParameter("@PostedDate",jobpostEntity.PostedDate)
                                        };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_RE_InsertJobPost, sqlparams);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// DAL for GetQuestions 
        /// </summary>
        /// <returns></returns>
        public DataSet GetQuestionsDAL()
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from RE_Questionrie");
            return ds;
        }
    }
}