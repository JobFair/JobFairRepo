using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    public class FeedbackJSDAL
    {
        /// <summary>
        /// Dal layer method to store  feedback data in database
        /// </summary>
        /// <param name="feedbackEntity">Object for inserting data into database</param>
        /// <returns>System.String</returns>
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        public int FeedbackDAL(Entities.FeedbackEntity feedbackEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams = {
                                             new SqlParameter("@Name ",feedbackEntity.Name),
                                             new SqlParameter("@Subject",feedbackEntity.Subject),
                                             new SqlParameter("@Feedback ",feedbackEntity.Feedback)
                                            };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure,Constants.sp_JS_insertfeedback);
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
