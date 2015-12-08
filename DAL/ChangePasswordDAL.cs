using Entities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// ChangePasswordDAL class
    /// </summary>
    ///
    public class ChangePasswordDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Change password method from DAL layer
        /// </summary>
        /// <param name="changepasswordEntity">Object of ChangePasswordEnitity class </param>
        /// <returns>System.Int32</returns>
        public int ChangePasswordDALMethod(ChangePasswordEnitity changepasswordEntity)
        {
            int result = 0;
            try
            {
                connection.Open();

                SqlParameter[] sparams = new SqlParameter[3];
                sparams[0] = new SqlParameter("@userId", changepasswordEntity.UserId);
                sparams[1] = new SqlParameter("@newPassword", changepasswordEntity.NewPassword);
                sparams[2] = new SqlParameter("@oldPassword", changepasswordEntity.OldPassword);

                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_ChangePassword, sparams);
            }
            catch (Exception)
            {
                //  throw;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}