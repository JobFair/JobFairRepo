using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LoginRecruiterDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public string LoginRecruDAL(Entities.LogInEnitity lnEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sparms = new SqlParameter[3];
                sparms[0] = new SqlParameter("@emailid", lnEntity.UserName);
                sparms[1] = new SqlParameter("@password", lnEntity.Password);
                sparms[2] = new SqlParameter("@id", SqlDbType.VarChar, 500);
                sparms[2].Direction = ParameterDirection.Output;

                SqlDataReader dr = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, "sp_LoginRecruiter", sparms);
                string recruiterId = Convert.ToString(sparms[2].Value);

                if (string.IsNullOrEmpty(recruiterId))
                {
                    return recruiterId;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}