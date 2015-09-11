using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entities;

namespace DAL
{
   public class ContactDetailsJSDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        /// <summary>
        /// Insert Contact Details
        /// </summary>
        /// <param name="cdentity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int ContactDetailsDAL(ContactDetailsEntity cdentity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams = {
                                              new SqlParameter("@candidateId",cdentity.CandidateId),
                                              new SqlParameter("@altMobNo",cdentity.AltMobileNo ),
                                              new SqlParameter("@landLineNo", cdentity.LandLineNo),
                                              new SqlParameter("@whatsappNo",cdentity.WhatsAppNo),
                                              new SqlParameter("@linkedId", cdentity.LinkedId),
                                              new SqlParameter("@facebookId",cdentity.FacebookId),
                                              new SqlParameter("@twitterId", cdentity.TwitterId),
                                              new SqlParameter("@gtalkId",cdentity.GtalkId),
                                              new SqlParameter("@skypeId", cdentity.SkypeId),
                                              new SqlParameter("@googleP",cdentity.GooglePlus)  
                                            };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_InsertContactDetails", sqlparams);

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
