using Entities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ContactDetailsJSDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// View Contact Details.
        /// </summary>
        /// <param name="candidateId">for selecting data into database</param>
        /// <returns>dataset</returns>
        public DataSet ViewContactDetailsDAL(string candidateId, int userType)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId),
                                           new SqlParameter("@userType",userType)};
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectContactDetails, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            return ds;
        }

        /// <summary>
        /// Insert Contact Details
        /// </summary>
        /// <param name="contactDetailsEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int SaveContactDetailsDAL(ContactDetailsEntity contactDetailsEntity)
        {
            int result = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams = {
                                              new SqlParameter("@candidateId",contactDetailsEntity.CandidateId),
                                              new SqlParameter("@altMobNo",contactDetailsEntity.AltMobileNo ),
                                              new SqlParameter("@landLineNo", contactDetailsEntity.LandLineNo),
                                              new SqlParameter("@whatsappNo",contactDetailsEntity.WhatsAppNo),
                                              new SqlParameter("@linkedId", contactDetailsEntity.LinkedId),
                                              new SqlParameter("@facebookId",contactDetailsEntity.FacebookId),
                                              new SqlParameter("@twitterId", contactDetailsEntity.TwitterId),
                                              new SqlParameter("@gtalkId",contactDetailsEntity.GtalkId),
                                              new SqlParameter("@skypeId", contactDetailsEntity.SkypeId),
                                              new SqlParameter("@googleP",contactDetailsEntity.GooglePlus),
                                              new SqlParameter("@altEmailId",contactDetailsEntity.AltEmailId),
                                              new SqlParameter("@userType",contactDetailsEntity.UserType)
                                            };
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertContactDetails, sqlparams);
            }
            catch (Exception)
            {
                //throw;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        /// <summary>
        /// Update Contact Details
        /// </summary>
        /// <param name="contactDetailsEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int UpdateContactDetailsDAL(ContactDetailsEntity contactDetailsEntity)
        {
            int result = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams = {
                                              new SqlParameter("@candidateId",contactDetailsEntity.CandidateId),
                                              new SqlParameter("@altMobNo",contactDetailsEntity.AltMobileNo ),
                                              new SqlParameter("@landLine", contactDetailsEntity.LandLineNo),
                                              new SqlParameter("@whatsappNo",contactDetailsEntity.WhatsAppNo),
                                              new SqlParameter("@linkedId", contactDetailsEntity.LinkedId),
                                              new SqlParameter("@facebookId",contactDetailsEntity.FacebookId),
                                              new SqlParameter("@twitterId", contactDetailsEntity.TwitterId),
                                              new SqlParameter("@gtalkId",contactDetailsEntity.GtalkId),
                                              new SqlParameter("@skypeId", contactDetailsEntity.SkypeId),
                                              new SqlParameter("@googleP",contactDetailsEntity.GooglePlus),
                                              new SqlParameter("@altEmailId",contactDetailsEntity.AltEmailId),
                                              new SqlParameter("@userType",contactDetailsEntity.UserType)
                                            };
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateContactDetails, sqlparams);
            }
            catch (Exception)
            {
                //throw;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}