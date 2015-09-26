﻿using Entities.JobSeeker;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProjectDetailsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Get the functional roles
        /// </summary>
        /// <returns></returns>
        public DataTable GetRole()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from JS_Roles", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            return table;
        }

        /// <summary>
        /// Add Project Details
        /// </summary>
        /// <param name="addProjectDetailsEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int SaveProjectDetailsDAL(ProjectDetailsEntity addProjectDetailsEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams ={
                                            new SqlParameter("@candidateId",addProjectDetailsEntity.CandidateId),
                                            new SqlParameter("@companyName",addProjectDetailsEntity.CompanyName),
                                            new SqlParameter("@projectTitle",addProjectDetailsEntity.ProjectTitle),
                                            new SqlParameter("@yourRole",addProjectDetailsEntity.YourRole),
                                            new SqlParameter("@clientName",addProjectDetailsEntity.ClientName),
                                            new SqlParameter("@projectLocation",addProjectDetailsEntity.ProjectLocation),
                                            new SqlParameter("@duration",addProjectDetailsEntity.Duration),
                                            new SqlParameter("@employeeType",addProjectDetailsEntity.EmployeeType),
                                            new SqlParameter("@projectDescription",addProjectDetailsEntity.ProjectDescription),
                                            new SqlParameter("@teamSize",addProjectDetailsEntity.TeamSize),
                                            new SqlParameter("@skillUsed",addProjectDetailsEntity.SkillUsed)
                                        };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertProjectDetails, sqlparams);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}