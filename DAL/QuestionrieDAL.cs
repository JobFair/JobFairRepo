using Entities.Recruiter;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class QuestionrieDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public int addquestionrieDAL(QuestionrieEntity questionrieEntity)
        {
            int result = 0;
            try
            {
                connection.Open();
                SqlParameter[] sqlparams ={
		                                    new SqlParameter("@Question",questionrieEntity.Question),
                                              new SqlParameter("@Answer",questionrieEntity.Answer),
                                             new SqlParameter("@QuestionType",questionrieEntity.QuestionType),
                                      };

                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_RE_insertQuestionrie, sqlparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}