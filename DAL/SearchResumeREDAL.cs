using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SearchResumeREDAL
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public DataSet GetClientNameDAL()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_RE_SelectActiveClientName);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }

        public DataSet GetPositionDAL(long clientId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@clientId", clientId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_RE_SelectActiveRequirementPosition, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }

        public int GetRequirementIdDAL(string position)
        {
            Int32 requirementId = 0;
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@position", position) };
                requirementId = Convert.ToInt32(SqlHelper.ExecuteScalar(connection, CommandType.StoredProcedure, Constants.sp_RE_SelectRequirementId, sparams));
            }
            catch (Exception)
            {
                throw;
            }
            return requirementId;
        }
    }
}