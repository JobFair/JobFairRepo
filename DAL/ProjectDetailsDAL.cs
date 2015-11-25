using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Entities.JobSeeker;

namespace DAL
{
    public class ProjectDetailsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Get the functional roles
        /// </summary>
        /// <returns></returns>
        public DataSet GetRole()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_FunctionalRoles);
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///  Insert Project Details
        /// </summary>
        /// <param name="dtProjectDetails">Object for inserting data into database</param>
        /// <returns></returns>
        public DataTable SaveProjectDetailsDAL(DataTable dtProjectDetails)
        {
            try
            {
                connection.Open();
                // Creating object of SqlBulkCopy
                SqlBulkCopy objbulk = new SqlBulkCopy(connection);
                // Assigning Destination table name
                objbulk.DestinationTableName = "JS_ProjectDetail";
                // Mapping Table column
                objbulk.ColumnMappings.Add("CandidateId", "CandidateId");
                objbulk.ColumnMappings.Add("ProjectFor", "ProjectFor");
                objbulk.ColumnMappings.Add("ProjectTitle", "ProjectTitle");
                objbulk.ColumnMappings.Add("CompanyName", "CompanyName");
                objbulk.ColumnMappings.Add("Role", "RoleName");
                objbulk.ColumnMappings.Add("ClientName", "ClientName");
                objbulk.ColumnMappings.Add("Duration", "Duration");
                objbulk.ColumnMappings.Add("ProjectLocation", "ProjectLocation");
                objbulk.ColumnMappings.Add("EmploymentType", "EmploymentType");
                objbulk.ColumnMappings.Add("ProjectDetails", "ProjectDetails");
                objbulk.ColumnMappings.Add("RolesandResponsibility", "RolesandResponsibility");
                objbulk.ColumnMappings.Add("TeamSize", "TeamSize");
                objbulk.ColumnMappings.Add("SkillUsed", "SkillUsed");
                objbulk.ColumnMappings.Add("ProjectLive", "ProjectLive");
                objbulk.ColumnMappings.Add("ProjectLink", "ProjectLink");
                objbulk.ColumnMappings.Add("Degree", "Degree");
                // Inserting bulk Records into DataBase
                objbulk.WriteToServer(dtProjectDetails);
                return dtProjectDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet ViewProjectDetailsDAL(string candidateId)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectProjectDetails, sparams);
                return ds;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int UpdateProjectDetailsDAL(ProjectDetailsEntity projectDetailsEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sqlparams = {
                                              //new SqlParameter("@candidateId",projectDetailsEntity.CandidateId),
                                              new SqlParameter("@companyName",projectDetailsEntity.CompanyName),
                                              new SqlParameter("@projectTitle",projectDetailsEntity.ProjectTitle),
                                              new SqlParameter("@role",projectDetailsEntity.YourRole),
                                              new SqlParameter("@clientName",projectDetailsEntity.ClientName),
                                              new SqlParameter("@projectLocation",projectDetailsEntity.ProjectLocation),
                                              new SqlParameter("@duration",projectDetailsEntity.Duration),
                                              new SqlParameter("@employmentType",projectDetailsEntity.EmploymentType),
                                              new SqlParameter("@projectDescription",projectDetailsEntity.ProjectDescription),
                                              new SqlParameter("@teamSize",projectDetailsEntity.TeamSize),
                                              new SqlParameter("@skillUsed",projectDetailsEntity.SkillUsed),
                                              new SqlParameter("@rolesandResponsibility",projectDetailsEntity.RolesandResponsibility),
                                              new SqlParameter("@projectLive",projectDetailsEntity.ProjectLive),
                                              new SqlParameter("@projectLink", projectDetailsEntity.ProjectLink),
                                              new SqlParameter("@projectId",projectDetailsEntity.ProjectId),
                                              new SqlParameter("@degree",projectDetailsEntity.Degree)
                                             
                                            };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateProjectDetails, sqlparams);

                return result;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataSet DeleteProjectDetailsDAL(int projectId)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlParameter[] sparams = { new SqlParameter("@projectId", projectId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_DeleteProjectDetails, sparams);
                return ds;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}