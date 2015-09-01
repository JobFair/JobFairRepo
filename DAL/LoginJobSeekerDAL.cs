using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;
using System.Data;
using System.Configuration;

namespace DAL
{
   public class LoginJobSeekerDAL
    {
       private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Login of jobseeker
        /// </summary>
        /// <param name="logjsEntity">To add parameters into database</param>
        /// <returns>SqlDataReader</returns>
        /// jyoti
        /// 
        public SqlDataReader JobSeekerLoginDAL(LogInJobSeekerEnitity logjsEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sqlparams = { new SqlParameter("@userName", logjsEntity.UserName), 
                                               new SqlParameter("@password", logjsEntity.Password)
                                               
                                           };
                SqlDataReader dr = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, "selectJobSeeker", sqlparams);
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
