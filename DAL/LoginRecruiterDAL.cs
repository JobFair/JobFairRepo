using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// LoginRecruiterDAL class
    /// </summary>
    public class LoginRecruiterDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Login for recruiter in DAL layer method is LoginRecruDAL()
        /// </summary>
        /// <param name="lnEntity">The login entity</param>
        /// <returns>System.String</returns>
        public string LoginRecruDAL(Entities.LogInEnitity lnEntity)
        {
            try
            {
                connection.Open();
                //Parameters to pass to the stored procedure
                SqlParameter[] sparms = new SqlParameter[3];
                sparms[0] = new SqlParameter("@emailid", lnEntity.UserName);
                sparms[1] = new SqlParameter("@password", lnEntity.Password);
                sparms[2] = new SqlParameter("@id", SqlDbType.VarChar, 500);
                sparms[2].Direction = ParameterDirection.Output;

                SqlDataReader dr = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure,Constants.sp_LoginRecruiter, sparms);
                string recruiterId = Convert.ToString(sparms[2].Value);

                if (string.IsNullOrEmpty(recruiterId))
                {
                    return null;
                }
                return recruiterId;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}