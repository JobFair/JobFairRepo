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
        /// <param name="pdEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int PersonalDetailsInsert(PersonalDetailsJSEntity pdEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sqlparams = {
                                              new SqlParameter("@candidateId",pdEntity.candidateId),
                                              new SqlParameter("@pressentAddress",pdEntity.presentAddress),
                                              new SqlParameter("@presentCountry",pdEntity.presentCountry),
                                              new SqlParameter("@presentState",pdEntity.presentState),
                                              new SqlParameter("@presentCity",pdEntity.presentCity),
                                              new SqlParameter("@presentArea",pdEntity.presentArea),
                                              new SqlParameter("@presentPincode",pdEntity.presentPincode),
                                              new SqlParameter("@permantAddress",pdEntity.permantAddress),
                                              new SqlParameter("@permantCountry",pdEntity.permantCountry),
                                              new SqlParameter("@permantState",pdEntity.permantState),
                                              new SqlParameter("@permantCity",pdEntity.permantCity),
                                              new SqlParameter("@permantArea",pdEntity.permantArea),
                                              new SqlParameter("@permantPincode",pdEntity.permantPincode),
                                              new SqlParameter("@dateOfBirth", pdEntity.dateOfBirth.Date),
                                              new SqlParameter("@gender",pdEntity.gender),
                                              new SqlParameter("@maritialStatus",pdEntity.maritialStatus),
                                              new SqlParameter("@passportNumber", pdEntity.passportNumber),
                                              new SqlParameter("@passportValidity",pdEntity.passportValidity.Date),
                                              new SqlParameter("@workStatus", pdEntity.workStatus),
                                              new SqlParameter("@photo", "~/UploadImages/"+pdEntity.photo)
                                            };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_InsertPersonalDetails", sqlparams);

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