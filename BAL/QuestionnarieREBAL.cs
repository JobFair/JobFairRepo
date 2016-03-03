using DAL;
using System;
using System.Data;

namespace BAL
{
    public class QuestionnarieREBAL
    {
        /// <summary>
        /// Save questionnarie of recruiter bal
        /// </summary>
        /// <param name="questionnarieName">questionnarieName</param>
        /// <param name="recruiterId">recruiterId</param>
        /// <returns>System.Int32</returns>
        public Int32 SaveQuestionnarieBAL(string questionnarieName, long recruiterId)
        {
            QuestionnarieREDAL questionnarieDAL = new QuestionnarieREDAL();
            return questionnarieDAL.SaveQuestionnarieDAL(questionnarieName, recruiterId);
        }

        /// <summary>
        /// Save questions of recruiter bal
        /// </summary>
        /// <param name="dtQuestionnarie">dtQuestionnarie</param>
        /// <returns>DataTable</returns>
        public DataTable SaveQuestionBAL(DataTable dtQuestionnarie)
        {
            QuestionnarieREDAL questionnarieDAL = new QuestionnarieREDAL();
            return questionnarieDAL.SaveQuestionDAL(dtQuestionnarie);
        }

        /// <summary>
        /// View questionnarie bal
        /// </summary>
        /// <param name="questionnarieId">questionnarieId</param>
        /// <returns>DataSet</returns>
        public DataSet ViewQuestionnarieBAL(Int32 questionnarieId)
        {
            QuestionnarieREDAL questionnarieDAL = new QuestionnarieREDAL();
            return questionnarieDAL.ViewQuestionnarieDAL(questionnarieId);
        }
    }
}