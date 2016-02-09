using Entities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// RegisterJobSeekerDAL class
    /// </summary>
    public class RegisterJobSeekerDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Dal layer method to store new candidate data into jobseeker table in database
        /// </summary>
        /// <param name="registerEntity">Object for inserting data into database</param>
        /// <returns>System.String</returns>
        public string SaveRegisterNewJobSeekerDAL(RegisterEntity registerEntity)
        {
            string candidateId = "";
            try
            {
                connection.Open();

                // Parameters to pass to the stored procedure

                SqlParameter[] sparams = new SqlParameter[16];

                sparams[0] = new SqlParameter("@fname", registerEntity.FirstName);
                sparams[1] = new SqlParameter("@lname", registerEntity.LastName);
                sparams[2] = new SqlParameter("@emailId", registerEntity.EmailId);
                sparams[3] = new SqlParameter("@gender", registerEntity.Gender);
                sparams[4] = new SqlParameter("@mobNo", registerEntity.MobileNo);
                sparams[5] = new SqlParameter("@address", registerEntity.CurrentAddress);
                sparams[6] = new SqlParameter("@countryId", registerEntity.Country);
                sparams[7] = new SqlParameter("@stateId", registerEntity.State);
                sparams[8] = new SqlParameter("@cityId", registerEntity.CityId);
                sparams[9] = new SqlParameter("@cityArea", registerEntity.CityArea);
                sparams[10] = new SqlParameter("@pincode", registerEntity.Pincode);
                sparams[11] = new SqlParameter("@refCandidatelId", registerEntity.RefCandidateId);
                sparams[12] = new SqlParameter("@password", registerEntity.Password);
                sparams[13] = new SqlParameter("@uploadresumepath", registerEntity.UploadResumepath.ToString());
                sparams[14] = new SqlParameter("@Newcandidateid", SqlDbType.BigInt, 500);
                sparams[14].Direction = ParameterDirection.Output;
                sparams[15] = new SqlParameter("@isMailSent", registerEntity.IsMailSent);

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertRegisterUser, sparams);

                candidateId = Convert.ToString(sparams[14].Value);
                if (string.IsNullOrEmpty(candidateId))
                {
                    return null;
                }
                return candidateId;
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