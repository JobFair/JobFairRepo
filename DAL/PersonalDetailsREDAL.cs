using Entities.Recruiter;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PersonalDetailsREDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Pesonal Details recruiter
        /// </summary>
        /// <param name="personalDetailsEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int SavePersonalDetails(PersonalDetailsEntity personalDetailsEntity)
        {
            int result = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sqlparams = {
                                              new SqlParameter("@recruiterId",personalDetailsEntity.recruiterId),
                                              new SqlParameter("@permantAddress",personalDetailsEntity.permantAddress),
                                              new SqlParameter("@permantCountryId",personalDetailsEntity.permantCountryId),
                                              new SqlParameter("@permantStateId",personalDetailsEntity.permantStateId),
                                              new SqlParameter("@permantCityId",personalDetailsEntity.permantCityId),
                                              new SqlParameter("@permantArea",personalDetailsEntity.permantArea),
                                              new SqlParameter("@permantPincode",personalDetailsEntity.permantPincode),
                                              new SqlParameter("@dateOfBirth", personalDetailsEntity.dateOfBirth.Date),
                                              new SqlParameter("@maritialStatus",personalDetailsEntity.maritialStatus),
                                              new SqlParameter("@passportNumber", personalDetailsEntity.passportNumber),
                                              new SqlParameter("@passportValidity",personalDetailsEntity.passportValidity),
                                              new SqlParameter("@passportIssue",personalDetailsEntity.passportIssue)
                                            };
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_RE_InsertPersonalDetails, sqlparams);
            }
            catch (Exception)
            {
                // throw ;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public DataSet ViewPersonalDetailsDAL(long recruiterId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@recruiterId", recruiterId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_RE_SelectPersonalDetails, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            return ds;
        }

        public int UpdatePersonalDetailsDAL(PersonalDetailsEntity objPersonalDetailsEntity)
        {
            int result = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sqlparams = {
                                              new SqlParameter("@recruiterId",objPersonalDetailsEntity.recruiterId),
                                              new SqlParameter("@presentAddress",objPersonalDetailsEntity.presentAddress),
                                              new SqlParameter("@presentCountryId",objPersonalDetailsEntity.presentCountryId),
                                              new SqlParameter("@presentStateId",objPersonalDetailsEntity.presentStateId),
                                              new SqlParameter("@presentCityId",objPersonalDetailsEntity.presentCityId),
                                              new SqlParameter("@presentArea",objPersonalDetailsEntity.presentArea),
                                              new SqlParameter("@presentPincode",objPersonalDetailsEntity.presentPincode),
                                              new SqlParameter("@permantAddress",objPersonalDetailsEntity.permantAddress),
                                              new SqlParameter("@permantCountryId",objPersonalDetailsEntity.permantCountryId),
                                              new SqlParameter("@permantStateId",objPersonalDetailsEntity.permantStateId),
                                              new SqlParameter("@permantCityId",objPersonalDetailsEntity.permantCityId),
                                              new SqlParameter("@permantArea",objPersonalDetailsEntity.permantArea),
                                              new SqlParameter("@permantPincode",objPersonalDetailsEntity.permantPincode),
                                              new SqlParameter("@dateOfBirth", objPersonalDetailsEntity.dateOfBirth.Date),
                                              new SqlParameter("@maritalStatus",objPersonalDetailsEntity.maritialStatus),
                                              new SqlParameter("@passportNumber", objPersonalDetailsEntity.passportNumber),
                                              new SqlParameter("@passportValidity",objPersonalDetailsEntity.passportValidity)
                                            };
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_RE_UpdatePersonalDetails, sqlparams);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}