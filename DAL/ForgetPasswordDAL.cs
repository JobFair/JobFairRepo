using Entities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ForgetPasswordDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// To get Forget Password
        /// </summary>
        /// <param name="fpEntity">Object for getting password from database</param>
        /// <returns>System.Data.DataSet</returns>
        public DataSet GetEmailDetailsDAL(ForgetPasswordEntity fpEntity)
        {
            connection.Open();

            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("ForgetPassword", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", fpEntity.EmailId.ToString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "EmailDetails");
                connection.Close();
                return ds;
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