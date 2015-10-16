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
     
     public class UpdateJobPostDAL
    {
         private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
         public Int32 UpdateRecord(AddJobPostEntity JobPostentity)
         {
           
           try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams ={
                                            
                                            new SqlParameter("@JobTitle",JobPostentity.JobTitle),
                                            new SqlParameter("@JobLocationCity",JobPostentity.JobLocationCity),
                                            new SqlParameter("@JobLocationArea",JobPostentity.JobLocationArea),
                                            new SqlParameter("@CompanyLevel",JobPostentity.CompanyLevel),
                                            new SqlParameter("@Industry",JobPostentity.IndustryId),
                                            new SqlParameter("@Department",JobPostentity.DepartmentId),
                                            new SqlParameter("@FunctionalArea",JobPostentity.FunctionalAreaId),
                                            new SqlParameter("@JobDescription",JobPostentity.JobDescription),
                                            new SqlParameter("@KeywordsRoles",JobPostentity.KeywordsRoles),
                                            new SqlParameter("@KeywordsTechnical",JobPostentity.KeywordsRoles),
                                            new SqlParameter("@WorkExperience",JobPostentity.WorkExperience),
                                            new SqlParameter("@Gender",JobPostentity.Gender),
                                            new SqlParameter("@OfferedAnnualSalary",JobPostentity.OfferedAnnualSalaryMin),
                                              new SqlParameter("@OfferedAnnualSalary",JobPostentity.OfferedAnnualSalaryMax),
                                              new SqlParameter("@OtherSalaryDetails",JobPostentity.OtherSalaryDetails),
                                            new SqlParameter("@NumberOfVacancies",JobPostentity.NumberOfVacancies),

                                        };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_RE_UpdateJobPost", sqlparams);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}