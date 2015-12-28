using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.HR;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    /// <summary>
    /// Class ClientDetailsDAL
    /// </summary>
    public class ClientContactPersonDetailsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
            
        /// <summary>
        /// Saving ClientContactPersonDetailsDAL for saving ContactPersonDetails in database
        /// </summary>
        /// <param name="clientcontactpersondetailsEntity">Object of ClientContactPersonDetailsEntity</param>
        /// <returns>System.Int32</returns>
        public DataTable SaveClientContactPersonDetailsDAL(DataTable clientContactPersonDetailsEntity)
        {
            try
            {
                connection.Open();
                //creating object of SqlBulkCopy
                SqlBulkCopy objbulk = new SqlBulkCopy(connection);
                //assigning Destination table name
                objbulk.DestinationTableName = "HR_ClientContactPersonDetails";
                //Mapping Table column
                objbulk.ColumnMappings.Add("ClientId", "ClientId");
                objbulk.ColumnMappings.Add("HrId", "HrId");
                objbulk.ColumnMappings.Add("ContactPersonName", "ContactPersonName");
                objbulk.ColumnMappings.Add("Designation", "Designation");
                objbulk.ColumnMappings.Add("EmailId", "EmailId");
                objbulk.ColumnMappings.Add("ContactNo", "ContactNo");
                objbulk.ColumnMappings.Add("IsActive", "IsActive");
                //inserting bulk Records into DataBase
                objbulk.WriteToServer(clientContactPersonDetailsEntity);
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return clientContactPersonDetailsEntity;
        }
    }
}
