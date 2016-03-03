using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// LogInJobSeekerDAL class
    /// </summary>
    public class LogInJobSeekerDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Login for Jobseeker
        /// </summary>
        /// <param name="logjsEntity">The login entity for checking data from database </param>
        /// <return>SqlDataReader </returns>
        public string LoginJSDAL(Entities.LoginEnitity logjsEntity)
        {
            string candidateid = "";
            string isreffered = "";
            string Result ="";
        
            
           
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sparams = new SqlParameter[4];
                sparams[0] = new SqlParameter("@userid", logjsEntity.UserName);
                sparams[1] = new SqlParameter("@password", logjsEntity.Password);
                sparams[2] = new SqlParameter("@candidateid", SqlDbType.Int);
                sparams[3] = new SqlParameter("@isreffered", SqlDbType.Bit);
                sparams[2].Direction = ParameterDirection.Output;
                sparams[3].Direction = ParameterDirection.Output;
               
                SqlDataReader dr = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, Constants.sp_Login, sparams);
                candidateid = sparams[2].Value.ToString();
                isreffered = sparams[3].Value.ToString();
                Result = candidateid +"/ "+isreffered;

               

                if (string.IsNullOrEmpty(candidateid) )
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
            return  Result;
           
             

            
          }
         
    }
}