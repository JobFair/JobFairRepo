using Entities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PersonalDetailsJSDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Pesonal Details of job seeker
        /// </summary>
        /// <param name="candidateId">Object for view data</param>
        /// <returns>dataset</returns>
        public DataSet ViewPersonalDetailsDAL(string candidateId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectPersonalDetails, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            return ds;
        }

        /// <summary>
        /// Pesonal Details of job seeker
        /// </summary>
        /// <param name="personalDetailsEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int SavePersonalDetails(PersonalDetailsJSEntity personalDetailsEntity)
        {
            int result = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sqlparams = {
                                              new SqlParameter("@candidateId",personalDetailsEntity.candidateId),
                                              new SqlParameter("@pressentAddress",personalDetailsEntity.presentAddress),
                                              new SqlParameter("@presentCountryId",personalDetailsEntity.presentCountryId),
                                              new SqlParameter("@presentStateId",personalDetailsEntity.presentStateId),
                                              new SqlParameter("@presentCityId",personalDetailsEntity.presentCityId),
                                              new SqlParameter("@presentArea",personalDetailsEntity.presentArea),
                                              new SqlParameter("@presentPincode",personalDetailsEntity.presentPincode),
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
                                              new SqlParameter("@photo", "~/UploadImages/"+personalDetailsEntity.photo)
                                            };
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertPersonalDetails, sqlparams);
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

        /// <summary>
        /// Pesonal Details of job seeker
        /// </summary>
        /// <param name="personalDetailsEntity">Object for updating data to database</param>
        /// <returns>System.Int32</returns>
        public int UpdatePersonalDetailsDAL(PersonalDetailsJSEntity personalDetailsEntity)
        {
            int result = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sqlparams = {
                                              new SqlParameter("@candidateId",personalDetailsEntity.candidateId),
                                              new SqlParameter("@presentAddress",personalDetailsEntity.presentAddress),
                                              new SqlParameter("@presentCountryId",personalDetailsEntity.presentCountryId),
                                              new SqlParameter("@presentStateId",personalDetailsEntity.presentStateId),
                                              new SqlParameter("@presentCityId",personalDetailsEntity.presentCityId),
                                              new SqlParameter("@presentArea",personalDetailsEntity.presentArea),
                                              new SqlParameter("@presentPincode",personalDetailsEntity.presentPincode),
                                              new SqlParameter("@permantAddress",personalDetailsEntity.permantAddress),
                                              new SqlParameter("@permantCountryId",personalDetailsEntity.permantCountryId),
                                              new SqlParameter("@permantStateId",personalDetailsEntity.permantStateId),
                                              new SqlParameter("@permantCityId",personalDetailsEntity.permantCityId),
                                              new SqlParameter("@permantArea",personalDetailsEntity.permantArea),
                                              new SqlParameter("@permantPincode",personalDetailsEntity.permantPincode),
                                              new SqlParameter("@dateOfBirth", personalDetailsEntity.dateOfBirth.Date),
                                              new SqlParameter("@maritalStatus",personalDetailsEntity.maritialStatus),
                                              new SqlParameter("@passportNumber", personalDetailsEntity.passportNumber),
                                              new SqlParameter("@passportValidity",personalDetailsEntity.passportValidity),
                                              new SqlParameter("@photo", "~/UploadImages/"+personalDetailsEntity.photo)
                                            };
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdatePersonalDetails, sqlparams);
            }
            catch (Exception)
            {
                //  throw ;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}