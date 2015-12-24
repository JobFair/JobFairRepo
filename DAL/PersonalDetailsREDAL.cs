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
    }
}