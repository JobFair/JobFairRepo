using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class QuestionnarieREDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Insert questionnarie DAL
        /// </summary>
        /// <param name="questionnarieName">questionnarieName</param>
        /// <param name="recruiterId">recruiterId</param>
        /// <returns>System.Int32</returns>
        public Int32 SaveQuestionnarieDAL(string questionnarieName, long recruiterId)
        {
            Int32 questionnarieId = 0;
            try
            {
                connection.Open();

                // Parameters to pass to the stored procedure

                SqlParameter[] sparams = new SqlParameter[3];

                sparams[0] = new SqlParameter("@recruiterId", recruiterId);
                sparams[1] = new SqlParameter("@questionnarieName", questionnarieName);
                sparams[2] = new SqlParameter("@questionnarieId", SqlDbType.Int, 200);
                sparams[2].Direction = ParameterDirection.Output;
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_RE_InsertQuestionnarie, sparams);
                questionnarieId = Convert.ToInt32(sparams[2].Value);
                if (questionnarieId == 0)
                {
                    return 0;
                }
                //return questionnarieId;
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return questionnarieId;
        }

        /// <summary>
        /// Insert questions to database when create questionnarie
        /// </summary>
        /// <param name="dtQuestionnarie">for save the bulk of data to database</param>
        /// <returns>DataTable</returns>
        public DataTable SaveQuestionDAL(DataTable dtQuestionnarie)
        {
            try
            {
                connection.Open();
                SqlBulkCopy objbulk = new SqlBulkCopy(connection);
                // Assigning Destination table name
                objbulk.DestinationTableName = "RE_Questions";
                // Mapping Table column

                objbulk.ColumnMappings.Add("QuestionName", "QuestionName");
                objbulk.ColumnMappings.Add("QuestionType", "QuestionType");
                objbulk.ColumnMappings.Add("AnswerOption", "AnswerOption");
                objbulk.ColumnMappings.Add("QuestionnaireId", "QuestionnaireId");
                // Inserting bulk Records into DataBase
                objbulk.WriteToServer(dtQuestionnarie);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return dtQuestionnarie;
        }

        /// <summary>
        /// View questionnarie DAL
        /// </summary>
        /// <param name="questionnarieId">For view questionnarie</param>
        /// <returns>DataSet</returns>
        public DataSet ViewQuestionnarieDAL(Int32 questionnarieId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@questionnarieId", questionnarieId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_RE_ViewQuestionnarie, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }
    }
}