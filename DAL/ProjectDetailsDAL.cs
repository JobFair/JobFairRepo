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
            try
            {
                DataTable table = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from JS_Roles", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
                return table;
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        public DataTable SaveProjectDetailsDAL(DataTable dtProductSold)
        {
            try
            {
                connection.Open();
                //creating object of SqlBulkCopy
                SqlBulkCopy objbulk = new SqlBulkCopy(connection);
                //assigning Destination table name
                objbulk.DestinationTableName = "JS_ProjectDetail";
                //Mapping Table column
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
                //inserting bulk Records into DataBase
                objbulk.WriteToServer(dtProductSold);
                return dtProductSold;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}