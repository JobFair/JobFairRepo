using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ViewJobPostJSDAL
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// View all job post DAL
        /// </summary>
        /// <returns>dataset</returns>
        public DataSet ViewAllJobPostDAL()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectAllJobPost);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }
    }
}