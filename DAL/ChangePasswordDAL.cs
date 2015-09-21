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
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams = {
                                             new SqlParameter("@userId",changepasswordEntity.UserId),
                                             new SqlParameter("@newPassword",changepasswordEntity.NewPassword),
                                             new SqlParameter("@oldPassword",changepasswordEntity.OldPassword)
                                            };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_ChangePassword, sqlparams);

                return result;
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
