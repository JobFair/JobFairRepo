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
        public DataSet GetRole()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("select * from RoleSkills order by RoleName", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
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
                objbulk.ColumnMappings.Add("Role", "Role");
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
    }
}