using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    public class LogInJobSeekerDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        public System.Data.SqlClient.SqlDataReader LoginJSDAL(Entities.LogInJobSeekerEnitity logjsEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sqlparams = { new SqlParameter("@userName", logjsEntity.UserName), new SqlParameter("@password", logjsEntity.Password) };
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
