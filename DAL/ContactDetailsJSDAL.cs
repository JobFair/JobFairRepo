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
                                              new SqlParameter("@uId", cdentity.UserID),
                                              new SqlParameter("@altMobNo",cdentity.AltMobileNo ),
                                              new SqlParameter("@landNo", cdentity.LandLineNo),
                                              new SqlParameter("@whatsappNo",cdentity.WhatsAppNo),
                                              new SqlParameter("@linkedId", cdentity.LinkedID),
                                              new SqlParameter("@fbId",cdentity.FacebookID),
                                              new SqlParameter("@twitterId", cdentity.TwitterID),
                                              new SqlParameter("@Gtalk",cdentity.GtalkID),
                                              new SqlParameter("@skypeId", cdentity.SkypeID),
                                              new SqlParameter("@googleP",cdentity.GooglePlus)  
                                            };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "insertJSContactDetails", sqlparams);

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
