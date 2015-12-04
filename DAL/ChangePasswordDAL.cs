using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entities;

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

            try
            {
                connection.Open();
              
                SqlParameter[] sparams = new SqlParameter[3];
                sparams[0]=new SqlParameter("@userId",changepasswordEntity.UserId);
                sparams[1] = new SqlParameter("@newPassword", changepasswordEntity.NewPassword);
                sparams[2] = new SqlParameter("@oldPassword", changepasswordEntity.OldPassword);

                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_ChangePassword, sparams);

                return result;
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
