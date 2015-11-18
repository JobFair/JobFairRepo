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

        public DataSet ViewPersonalDetailsDAL(string candidateId)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectPersonalDetails, sparams);
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Pesonal Details of job seeker
        /// </summary>
        /// <param name="personalDetailsEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int SavePersonalDetails(PersonalDetailsJSEntity personalDetailsEntity)
        {
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
                                              new SqlParameter("@gender",personalDetailsEntity.gender),
                                              new SqlParameter("@maritialStatus",personalDetailsEntity.maritialStatus),
                                              new SqlParameter("@passportNumber", personalDetailsEntity.passportNumber),
                                              new SqlParameter("@passportValidity",personalDetailsEntity.passportValidity),
                                              new SqlParameter("@photo", "~/UploadImages/"+personalDetailsEntity.photo)
                                            };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertPersonalDetails, sqlparams);

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