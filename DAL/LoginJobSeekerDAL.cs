using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;

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
        public SqlDataReader LoginJSDAL(Entities.LogInEnitity logjsEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_Login", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userid", logjsEntity.UserName);
                cmd.Parameters.AddWithValue("@password", logjsEntity.Password);
                //cmd.Parameters.Add("@candidateid", SqlDbType.VarChar, 500);
                //cmd.Parameters["@candidateid"].Direction = ParameterDirection.Output;
                //string candidate = cmd.Parameters["@candidateid"].Value.ToString();
                SqlDataReader dr = cmd.ExecuteReader();
                
                //SqlParameter[] sqlparams = { new SqlParameter("@userid", logjsEntity.UserName), new SqlParameter("@password", logjsEntity.Password) };
                //SqlDataReader dr = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, "sp_Login", sqlparams);
            
                    return dr;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //connection.Close();
            }
        }
    }
}