using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ViewJobPostJSDAL
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

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