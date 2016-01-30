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


        public DataSet ViewClientContactPersonDetailsDAL(long hrId, long clientId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = {
                                             new SqlParameter("@hrId", hrId),
                                             new SqlParameter("@clientId", clientId)
                                         };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_HR_ViewClientContactPersonDetails, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }

        /// <summary>
        /// Method of class ClientContactPersonDetailsDAL for Updating ClientContactPersonDetails in database
        /// </summary>
        /// <param name="clientdetailsEntity">Object of ClientContactPersonDetailsEntity</param>
        /// <returns>System.Int32</returns>
        public int UpdateClientContactPersonDetailsDAL(ClientContactPersonDetailsEntity clientContactPersonDetailsEntity)
        {
            try
            {
                connection.Open();
                //Add parameter for stored procedure                
                SqlParameter[] sparam = { 
                                          new SqlParameter("@contactPersonId", clientContactPersonDetailsEntity.ContactPersonId),
                                          new SqlParameter("@clientid", clientContactPersonDetailsEntity.ClientId),
                                          new SqlParameter("@hrid", clientContactPersonDetailsEntity.HrId),
                                          new SqlParameter("@contactPersonName", clientContactPersonDetailsEntity.ContactPersonName),
                                          new SqlParameter("@designation", clientContactPersonDetailsEntity.Designation),
                                          new SqlParameter("@emailId", clientContactPersonDetailsEntity.EmailId),
                                          new SqlParameter("@contactNo", clientContactPersonDetailsEntity.ContactNo),
                                          new SqlParameter("@isActive", clientContactPersonDetailsEntity.IsActive),
                                        };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_HR_UpdateClientContactPersonDetails, sparam);
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
