using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    /// <summary>
    /// LogInJobSeekerDAL class
    /// </summary>
    public class LogInJobSeekerDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Login for Jobseeker
        /// </summary>
        /// <param name="logjsEntity">The login entity for checking data from database </param>
        /// <return>SqlDataReader </returns>
        public string LoginJSDAL(Entities.LoginEnitity logjsEntity)
        {
            string candidateid = "";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sparams = new SqlParameter[3];
                sparams[0] = new SqlParameter("@userid", logjsEntity.UserName);
                sparams[1] = new SqlParameter("@password", logjsEntity.Password);
                sparams[2] = new SqlParameter("@candidateid", SqlDbType.VarChar, 500);
                sparams[2].Direction = ParameterDirection.Output;
                SqlDataReader dr = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, Constants.sp_Login, sparams);
                candidateid = sparams[2].Value.ToString();
                if (string.IsNullOrEmpty(candidateid))
                {
                    return null;
                }
            }
            catch (Exception )
            {
                //throw ex;
            }
            finally
            {
                connection.Close();
            }
            return candidateid;
        }
    }
}