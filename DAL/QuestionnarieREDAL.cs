using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class QuestionnarieREDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public Tuple<DataTable, Int32> SaveQuestionnarieDAL(DataTable dtQuestionnarie, string questionnarieName, long recruiterId)
        {
            Int32 questionnarieId;
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
                SqlBulkCopy objbulk = new SqlBulkCopy(connection);
                // Assigning Destination table name
                objbulk.DestinationTableName = "RE_Questions";
                // Mapping Table column
               
                objbulk.ColumnMappings.Add("QuestionName", "QuestionName");
                objbulk.ColumnMappings.Add("QuestionType", "QuestionType");
                objbulk.ColumnMappings.Add("AnswerOption", "AnswerOption");
                objbulk.ColumnMappings.Add("QuestionnarieId","QuestionnarieId");
                //objbulk.ColumnMappings.Add("QuestionnaireId", "questionnarieId");
                // Inserting bulk Records into DataBase
                objbulk.WriteToServer(dtQuestionnarie);
                //if (string.IsNullOrEmpty(candidateId))
                //{
                //    return null;
                //}
                //return questionnarieId;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return Tuple.Create(dtQuestionnarie, questionnarieId);
        }
    }
}