using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Recruiter;

namespace DAL
{
    public class ContactDetailsREDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

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
                                              new SqlParameter("@recruiterId",contactDetailsEntity.RecruiterId),
                                              new SqlParameter("@altMobNo",contactDetailsEntity.AltMobileNo ),
                                              new SqlParameter("@landLineNo", contactDetailsEntity.LandLineNo),
                                              new SqlParameter("@whatsappNo",contactDetailsEntity.WhatsAppNo),
                                              new SqlParameter("@linkedId", contactDetailsEntity.LinkedId),
                                              new SqlParameter("@facebookId",contactDetailsEntity.FacebookId),
                                              new SqlParameter("@twitterId", contactDetailsEntity.TwitterId),
                                              new SqlParameter("@gtalkId",contactDetailsEntity.GtalkId),
                                              new SqlParameter("@skypeId", contactDetailsEntity.SkypeId),
                                              new SqlParameter("@googleP",contactDetailsEntity.GooglePlus),
                                              new SqlParameter("@altEmailId",contactDetailsEntity.AltEmailId)
                                            };
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_RE_InsertContactDetails, sqlparams);
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