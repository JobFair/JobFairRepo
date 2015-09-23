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
                                              new SqlParameter("@presentCountry",personalDetailsEntity.presentCountry),
                                              new SqlParameter("@presentState",personalDetailsEntity.presentState),
                                              new SqlParameter("@presentCity",personalDetailsEntity.presentCity),
                                              new SqlParameter("@presentArea",personalDetailsEntity.presentArea),
                                              new SqlParameter("@presentPincode",personalDetailsEntity.presentPincode),
                                              new SqlParameter("@permantAddress",personalDetailsEntity.permantAddress),
                                              new SqlParameter("@permantCountry",personalDetailsEntity.permantCountry),
                                              new SqlParameter("@permantState",personalDetailsEntity.permantState),
                                              new SqlParameter("@permantCity",personalDetailsEntity.permantCity),
                                              new SqlParameter("@permantArea",personalDetailsEntity.permantArea),
                                              new SqlParameter("@permantPincode",personalDetailsEntity.permantPincode),
                                              new SqlParameter("@dateOfBirth", personalDetailsEntity.dateOfBirth.Date),
                                              new SqlParameter("@gender",personalDetailsEntity.gender),
                                              new SqlParameter("@maritialStatus",personalDetailsEntity.maritialStatus),
                                              new SqlParameter("@passportNumber", personalDetailsEntity.passportNumber),
                                              new SqlParameter("@passportValidity",personalDetailsEntity.passportValidity.Date),
                                              new SqlParameter("@workStatus", personalDetailsEntity.workStatus),
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