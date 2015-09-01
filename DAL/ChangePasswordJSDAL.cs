using Entities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ChangePasswordJSDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Changing Password of Jobseeker
        /// </summary>
        /// <param name="cpentity">To add parameters into database</param>
        /// <returns>System.Int32</returns>
        /// jyoti
        public int ChangePasswordDAL(ChangePasswordEnitity cpentity)
        {
            connection.Close();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sparams = { new SqlParameter("@userName", cpentity.UserName), new SqlParameter("@newpassword", cpentity.NewPassword), new SqlParameter("@oldpassword", cpentity.OldPassword) };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "ChangePassword", sparams);

                connection.Close();

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    return -1;
                }
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