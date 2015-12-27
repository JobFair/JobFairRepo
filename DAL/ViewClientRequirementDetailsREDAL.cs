using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ViewClientRequirementDetailsREDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public DataSet ViewClientRequirementDAL(long recruiterId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@recruiterId", recruiterId)
                                         };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_RE_ViewClientRequirements, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }

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

        public DataSet ViewActiveRequirementDAL(long recruiterId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@recruiterId", recruiterId)
                                         };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_RE_SelectActiveRequirement, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }

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
    }
}