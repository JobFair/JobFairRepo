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
        public string RegisterNewJobSeekerDAL(RegisterEntity rjsEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_JS_InsertRegisterUser", connection);
                cmd.CommandType = CommandType.StoredProcedure;
              
               

                string candidateId = "";

                cmd.Parameters.AddWithValue("@userid", rjsEntity.UserId);
                cmd.Parameters.AddWithValue("@fname", rjsEntity.FirstName);
                cmd.Parameters.AddWithValue("@lname", rjsEntity.LastName);
                cmd.Parameters.AddWithValue("@emailId", rjsEntity.EmailId);
                cmd.Parameters.AddWithValue("@gender", rjsEntity.Gender);
                cmd.Parameters.AddWithValue("@mobNo", rjsEntity.MobileNo);
                cmd.Parameters.AddWithValue("@currCity", rjsEntity.CurrentCity);
                cmd.Parameters.AddWithValue("@address", rjsEntity.CurrentAddress);
                cmd.Parameters.AddWithValue("@refCandidatelId", rjsEntity.RefCandidateId);
                cmd.Parameters.AddWithValue("@password", rjsEntity.Password);
                cmd.Parameters.AddWithValue("@uploadresumepath", rjsEntity.UploadResumepath.ToString());

                cmd.Parameters.Add("@Newcandidateid", SqlDbType.VarChar, 500);
                cmd.Parameters["@Newcandidateid"].Direction = ParameterDirection.Output;

               
                int result = cmd.ExecuteNonQuery();
                candidateId = cmd.Parameters["@Newcandidateid"].Value.ToString();

                if (result > 0)
                {
                    if (candidateId != null)

                        return candidateId;
                }
                return null;
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