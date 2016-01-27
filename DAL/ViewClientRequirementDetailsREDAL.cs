using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ViewClientRequirementDetailsREDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// View client requirements dal
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <returns>dataset</returns>
        public DataSet ViewClientRequirementDAL(long recruiterId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = {
                                             new SqlParameter("@recruiterId", recruiterId)
                                         };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_RE_ViewClientRequirements, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }

        /// <summary>
        /// View client requirement details dal
        /// </summary>
        /// <param name="clientId">clientId</param>
        /// <param name="clientRequirementId">clientRequirementId</param>
        /// <returns>dataset</returns>
        public DataSet ViewClientRequirementDetailsDAL(long clientId, long clientRequirementId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = {
                                             new SqlParameter("@clientId", clientId),
                                             new SqlParameter("@clientRequirementId",clientRequirementId)
                                         };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_RE_ViewClientRequirementDetalils, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }

        /// <summary>
        /// View active requirement dal
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <returns>dataset</returns>
        public DataSet ViewActiveRequirementDAL(long recruiterId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = {
                                           new SqlParameter("@recruiterId", recruiterId)
                                         };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_RE_SelectActiveRequirement, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }

        /// <summary>
        /// View inactive requirements dal
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <returns>dataset</returns>
        public DataSet ViewInActiveRequirementsDAL(long recruiterId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@recruiterId", recruiterId)
                                         };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_RE_SelectInActiveRequirements, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }

        /// <summary>
        /// Update requirement status dal
        /// </summary>
        /// <param name="clientRequirementId">clientRequirementId</param>
        /// <returns>dataset</returns>
        public int UpdateRequirementStatusDAL(long clientRequirementId)
        {
            int result = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sparams = {
                                             new SqlParameter("@clientRequirementId", clientRequirementId)
                                         };
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_RE_UpdateClientRequirementStatus, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        /// <summary>
        /// View search inactive requirements dal
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <param name="clientName">clientName</param>
        /// <param name="position">position</param>
        /// <param name="fromDate">fromDate</param>
        /// <param name="toDate">toDate</param>
        /// <returns>dataset</returns>
        public DataSet ViewInActiveRequiremntSearchDAL(long recruiterId, string clientName, string position, DateTime? fromDate, DateTime? toDate)
        {
            connection.Open();
            DataSet dsSearch = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand(Constants.sp_RE_SelectInActiveRequirements, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@recruiterId", recruiterId);
                cmd.Parameters.AddWithValue("@clientName", clientName);
                cmd.Parameters.AddWithValue("@position", position);
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsSearch);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return dsSearch;
        }

        /// <summary>
        /// View search activerequirements dal
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <param name="clientName">clientName</param>
        /// <param name="position">position</param>
        /// <param name="fromDate">fromDate</param>
        /// <param name="toDate">toDate</param>
        /// <returns>dataset</returns>
        public DataSet ViewActiveRequirementSearchDAL(long recruiterId, string clientName, string position, DateTime? fromDate, DateTime? toDate)
        {
            connection.Open();
            DataSet dsSearch = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand(Constants.sp_RE_SelectActiveRequirement, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@recruiterId", recruiterId);
                cmd.Parameters.AddWithValue("@clientName", clientName);
                cmd.Parameters.AddWithValue("@position", position);
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsSearch);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return dsSearch;
        }
    }
}