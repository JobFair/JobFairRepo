using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class FeedbackJSDAL
    {
       
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        /// <summary>
        /// Dal layer method to store  feedback data in database
        /// </summary>
        /// <param name="feedbackEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int FeedbackDAL(Entities.FeedbackEntity feedbackEntity)
        {
            int result = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams = {
                                             new SqlParameter("@Name ",feedbackEntity.Name),
                                             new SqlParameter("@Subject",feedbackEntity.Subject),
                                             new SqlParameter("@Feedback ",feedbackEntity.Feedback)
                                            };
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_Insertfeedback);
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