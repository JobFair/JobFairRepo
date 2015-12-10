using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class RequestEmailJSDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        /// <summary>
        /// Get email id dal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet GetEmailDAL(string candidateId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectRegisterDetails, sparams);
            }
            catch (Exception)
            {
                //  throw;
            }
            return ds;
        }
    }
}