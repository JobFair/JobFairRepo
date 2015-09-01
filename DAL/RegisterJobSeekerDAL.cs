using Entities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class RegisterJobSeekerDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Register Jobseeker
        /// </summary>
        /// <param name="rjsEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int RegisterNewJobSeekerDAL(RegisterJobSeekerEntity rjsEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams = {
                                              new SqlParameter("@userid",rjsEntity.UserId),
                                              new SqlParameter("@fname", rjsEntity.FirstName ),
                                              new SqlParameter("@lname", rjsEntity.LastName),
                                              new SqlParameter("@emailId", rjsEntity.EmailId),
                                              new SqlParameter("@gender", rjsEntity.Gender),
                                              new SqlParameter("@mobNo", rjsEntity.MobileNo),
                                              new SqlParameter("@currCity", rjsEntity.CurrentCity),
                                              new SqlParameter("@address", rjsEntity.CurrentAddress),
                                              new SqlParameter("@password",rjsEntity.Password),
                                              new SqlParameter("@refEmailId",rjsEntity.RefEmailId),
                                              new SqlParameter("@uploadresumepath", rjsEntity.UploadResumepath.ToString())
                                            };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "InsertJSRegister", sqlparams);

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