using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MoreWorkshopDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Saving MoreWorkshop Deatils JobSeeker.
        /// </summary>
        /// <param name="workshopEntity">Object for inserting data into database</param>
        /// <returns>True/false</returns>
        public DataTable SaveMoreWorkshopDAL(DataTable workEntity)
        {
            try
            {
                connection.Open();
                //creating object of SqlBulkCopy
                SqlBulkCopy objbulk = new SqlBulkCopy(connection);
                //assigning Destination table name
                objbulk.DestinationTableName = "JS_MoreWorkshop";
                //Mapping Table column
                objbulk.ColumnMappings.Add("CandidateId", "CandidateId");
                objbulk.ColumnMappings.Add("WorkshopName", "WorkshopName");
                objbulk.ColumnMappings.Add("Institute", "Institute");
                objbulk.ColumnMappings.Add("Duration", "Duration");
                objbulk.ColumnMappings.Add("FromYear", "FromYear");
                objbulk.ColumnMappings.Add("ToYear", "ToYear");
                objbulk.ColumnMappings.Add("Grade", "Grade");
                //inserting bulk Records into DataBase
                objbulk.WriteToServer(workEntity);
            }
            catch (Exception)
            {
                //  throw;
            }
            finally
            {
                connection.Close();
            }
            return workEntity;
        }
    }
}