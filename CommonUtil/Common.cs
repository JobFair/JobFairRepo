using DAL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CommonUtil
{
    public class Common
    {
        private DataSet ds = new DataSet();
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public DataSet GetCountryDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_Country");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataSet GetStateDAL(int countryid)
        {
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@countryId", countryid) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_State", sparams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataSet GetCityDAL(int stateid)
        {
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@stateId", stateid) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_City", sparams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataSet GetIndustryDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_Industry");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get Department
        /// </summary>
        /// <returns></returns>
        internal DataSet GetDepartmentDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_Department");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataSet GetFunctionalAreaDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_FunctionalArea");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }


}
        internal DataSet GetEducationalDegreeTypeDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_JS_InsertEducationDegreesType");
                return ds;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        internal DataSet GetLanguagesDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_Language");
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
