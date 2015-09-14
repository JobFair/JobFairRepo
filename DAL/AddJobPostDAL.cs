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
    public class AddJobPostDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        //public DataTable LoadRole()
        //{
        //    DataTable table = new DataTable();
        //    SqlCommand cmd = new SqlCommand("select * from RS_JobPost", connection);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(table);
        //    return table;
        //}
        public int JobPostDAL(AddJobPostEntity JPentity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams ={
                                            
                                            new SqlParameter("@JobTitle",JPentity.JobTitle),
                                            new SqlParameter("@JobLocationCity",JPentity.JobLocationCity),
                                            new SqlParameter("@JobLocationArea",JPentity.JobLocationArea),
                                            new SqlParameter("@CompanyLevel",JPentity.CompanyLevel),
                                            new SqlParameter("@Industry",JPentity.Industry),
                                            new SqlParameter("@Department",JPentity.Department),
                                            new SqlParameter("@FunctionalArea",JPentity.FunctionalArea),
                                            new SqlParameter("@JobDescription",JPentity.JobDescription),
                                            new SqlParameter("@KeywordsRoles",JPentity.KeywordsRoles),
                                            new SqlParameter("@KeywordsTechnical",JPentity.KeywordsRoles),
                                             new SqlParameter("@WorkExprience",JPentity.WorkExprience),
                                               new SqlParameter("@Gender",JPentity.Gender),
                                                 new SqlParameter("@OfferedAnnualSalary",JPentity.OfferedAnnualSalary),
                                                   new SqlParameter("@OtherSalaryDetails",JPentity.OtherSalaryDetails),
                                                     new SqlParameter("@NumberOfVacancies",JPentity.NumberOfVacancies),

                                        };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_RS_InsertJobPost", sqlparams);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}