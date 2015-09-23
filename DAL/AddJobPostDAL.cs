using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entities.JobSeeker;
using System.Data.SqlClient;
using System.Configuration;
using Entities.Recruiter;

namespace DAL
{
    /// <summary>
    /// jop post DAL
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
                                            new SqlParameter("@JobId",jobpostEntity.JobId),
                                            new SqlParameter("@JobTitle",jobpostEntity.JobTitle),
                                            new SqlParameter("@JobLocationCity",jobpostEntity.JobLocationCity),
                                            new SqlParameter("@JobLocationArea",jobpostEntity.JobLocationArea),
                                            new SqlParameter("@CompanyLevel",jobpostEntity.CompanyLevel),
                                            new SqlParameter("@Industry",jobpostEntity.Industry),
                                            new SqlParameter("@Department",jobpostEntity.Department),
                                            new SqlParameter("@FunctionalArea",jobpostEntity.FunctionalArea),
                                            new SqlParameter("@JobDescription",jobpostEntity.JobDescription),
                                            new SqlParameter("@KeywordsRoles",jobpostEntity.KeywordsRoles),
                                            new SqlParameter("@KeywordsTechnical",jobpostEntity.KeywordsRoles),
                                            new SqlParameter("@WorkExprience",jobpostEntity.WorkExprience),
                                            new SqlParameter("@Gender",jobpostEntity.Gender),
                                            new SqlParameter("@OfferedAnnualSalary",jobpostEntity.OfferedAnnualSalary),
                                            new SqlParameter("@OtherSalaryDetails",jobpostEntity.OtherSalaryDetails),
                                            new SqlParameter("@NumberOfVacancies",jobpostEntity.NumberOfVacancies),

                                        };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_RE_InsertJobPost, sqlparams);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }




       
    }

}