using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Entities.Common;

namespace DAL
{
    /// <summary>
    /// LogInEmployerDAL class
    /// </summary>
    public class LogInEmployerDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Login for Jobseeker
        /// </summary>
        /// <param name="logjsEntity">The login entity for checking data from database </param>
        /// <return>SqlDataReader </returns>
        public string LoginEmpDAL(Entities.LoginEnitity logEmpEntity)
        {
            string Employerid = "";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sparams = new SqlParameter[3];
                sparams[0] = new SqlParameter("@userId", logEmpEntity.UserName);
                sparams[1] = new SqlParameter("@password", logEmpEntity.Password);
                sparams[2] = new SqlParameter("@candidateid", SqlDbType.Int);
                sparams[2].Direction = ParameterDirection.Output;

                SqlDataReader dr = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, Constants.sp_Login, sparams);
                Employerid = sparams[2].Value.ToString();
                if (string.IsNullOrEmpty(Employerid))
                {
                    return null;
                }
                // return isreffered;

            }
            catch (Exception)
            {
                //throw ex;
            }
            finally
            {
                connection.Close();
            }
            return Employerid;
        }
    }
}
