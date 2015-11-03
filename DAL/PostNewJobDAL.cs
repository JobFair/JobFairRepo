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
        private SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
   
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
                                            new SqlParameter("@IndustryId",jobpostEntity.IndustryId),
                                            new SqlParameter("@DepartmentId",jobpostEntity.DepartmentId),
                                            new SqlParameter("@FunctionalAreaId",jobpostEntity.FunctionalAreaId),
                                            new SqlParameter("@JobDescription",jobpostEntity.JobDescription),
                                            new SqlParameter("@KeywordsRoles",jobpostEntity.KeywordsRoles),
                                            new SqlParameter("@KeywordsTechnical",jobpostEntity.KeywordsRoles),
                                            new SqlParameter("@Workexperience",jobpostEntity.WorkExperience),
                                            new SqlParameter("@Gender",jobpostEntity.Gender),
                                            new SqlParameter("@OfferedAnnualSalaryMin",jobpostEntity.OfferedAnnualSalaryMin),
                                            new SqlParameter("@OfferedAnnualSalaryMax",jobpostEntity.OfferedAnnualSalaryMax),
                                            new SqlParameter("@OtherSalaryDetails",jobpostEntity.OtherSalaryDetails),
                                            new SqlParameter("@NumberOfVacancies",jobpostEntity.NumberOfVacancies),
                                            new SqlParameter("@JobType",jobpostEntity.JobType),
                                            new SqlParameter("@EmploymentStatus",jobpostEntity.EmploymentStatus),
                                            new SqlParameter("@RecruitmentType",jobpostEntity.RecruitmentType),
                                            new SqlParameter("@CompanyName",jobpostEntity.CompanyName)
                                          
                                        };
                SqlParameter[] sqlparams1 ={
                                                new SqlParameter("@RecruiterID",jobpostEntity.RecruiterID),
                                           };
                int result = SqlHelper.ExecuteNonQuery(Connection, CommandType.StoredProcedure, Constants.sp_RE_InsertJobPost, sqlparams);
            //    int result1 = SqlHelper.ExecuteNonQuery(Connection, CommandType.StoredProcedure, Constants.sp_InsertJobPostHistory, sqlparams1);
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
            ds = SqlHelper.ExecuteDataset(Connection, CommandType.Text, "select * from RE_Questionrie");
            return ds;
        }






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








        public DataTable GetRoles(string prefixText)
        {
            DataTable dt = new DataTable();
            Connection.Open();
            SqlCommand cmd = new SqlCommand("select * from JS_Roles  where rolename like @roleName+'%'", Connection);
            cmd.Parameters.AddWithValue("@rolename", prefixText);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
         
           
        }
    }
}