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

        public DataSet ViewContactDetailsDAL(string candidateId)
        {
            try
            {
                 DataSet ds = new DataSet();
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectContactDetails, sparams);
                return ds;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// Insert Contact Details
        /// </summary>
        /// <param name="contactDetailsEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int SaveContactDetailsDAL(ContactDetailsEntity contactDetailsEntity)
        {
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
                                              new SqlParameter("@googleP",contactDetailsEntity.GooglePlus)
                                            };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertContactDetails, sqlparams);

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