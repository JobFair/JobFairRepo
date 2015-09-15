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
        public string SaveRegisterNewJobSeekerDAL(RegisterEntity rjsEntity)
        {
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sparams = new SqlParameter[12];
                sparams[0] = new SqlParameter("@userid", rjsEntity.UserId);
                sparams[1] = new SqlParameter("@fname", rjsEntity.FirstName);
                sparams[2] = new SqlParameter("@lname", rjsEntity.LastName);
                sparams[3] = new SqlParameter("@emailId", rjsEntity.EmailId);
                sparams[4] = new SqlParameter("@gender", rjsEntity.Gender);
                sparams[5] = new SqlParameter("@mobNo", rjsEntity.MobileNo);
                sparams[6] = new SqlParameter("@currCity", rjsEntity.CurrentCity);
                sparams[7] = new SqlParameter("@address", rjsEntity.CurrentAddress);
                sparams[8] = new SqlParameter("@refCandidatelId", rjsEntity.RefCandidateId);
                sparams[9] = new SqlParameter("@password", rjsEntity.Password);
                sparams[10] = new SqlParameter("@uploadresumepath", rjsEntity.UploadResumepath.ToString());
                sparams[11] = new SqlParameter("@Newcandidateid", SqlDbType.VarChar, 500);
                sparams[11].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_InsertRegisterUser", sparams);

                string candidateId = Convert.ToString(sparams[11].Value);
                if (string.IsNullOrEmpty(candidateId))
                {
                    return null;
                }
                return candidateId;
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