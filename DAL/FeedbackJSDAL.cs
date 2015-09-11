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
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        public int FeedbackDAL(Entities.FeedbackEntity fdentity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams = {
                                             new SqlParameter("@Name ",fdentity.Name),
                                             new SqlParameter("@Subject",fdentity.Subject),
                                             new SqlParameter("@Feedback ",fdentity.Feedback)
                                            };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_insertfeedback", sqlparams);
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
