using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LogInJobSeekerDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Login for Jobseeker
        /// </summary>
        /// <param name="logjsEntity">The login entity for checking data from database </param>
        /// <return>SqlDataReader </returns>
        public SqlDataReader LoginJSDAL(Entities.LogInJobSeekerEnitity logjsEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sqlparams = { new SqlParameter("@userid", logjsEntity.UserName), new SqlParameter("@password", logjsEntity.Password) };
                SqlDataReader dr = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, "sp_Login", sqlparams);
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}