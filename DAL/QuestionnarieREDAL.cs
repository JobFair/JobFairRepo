﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class QuestionnarieREDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public Int32 SaveQuestionnarieDAL( string questionnarieName, long recruiterId)
        {
            Int32 questionnarieId=0;
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
                //SqlBulkCopy objbulk = new SqlBulkCopy(connection);
                //// Assigning Destination table name
                //objbulk.DestinationTableName = "RE_Questions";
                //// Mapping Table column
                
                //objbulk.ColumnMappings.Add("QuestionName", "QuestionName");
                //objbulk.ColumnMappings.Add("QuestionType", "QuestionType");
                //objbulk.ColumnMappings.Add("AnswerOption", "AnswerOption");
                //objbulk.ColumnMappings.Add("QuestionnaireId", "QuestionnaireId");
                //// Inserting bulk Records into DataBase
                //objbulk.WriteToServer(dtQuestionnarie);
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
            return questionnarieId;
        }

        public DataTable SaveQuestionDAL(DataTable dtQuestionnarie)
        {
            DataTable dt = new DataTable();
            return dt;
        }

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