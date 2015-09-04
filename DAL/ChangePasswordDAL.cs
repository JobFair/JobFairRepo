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
    /// Change Password
    /// </summary>
    /// 
    public class ChangePasswordDAL
    {

        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cpentity"></param>
        /// <returns></returns>
        public int ChangePasswordDALMethod(ChangePasswordEnitity cpentity)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams = {
                                             new SqlParameter("@userId",cpentity.UserId),
                                             new SqlParameter("@newPassword",cpentity.NewPassword),
                                             new SqlParameter("@oldPassword",cpentity.OldPassword)
                                            };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_ChangePassword", sqlparams);

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
