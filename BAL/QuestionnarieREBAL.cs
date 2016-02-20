using DAL;
using System;
using System.Data;

namespace BAL
{
    public class QuestionnarieREBAL
    {
        public Int32 SaveQuestionnarieBAL(string questionnarieName, long recruiterId)
        {
            QuestionnarieREDAL questionnarieDAL = new QuestionnarieREDAL();
            return questionnarieDAL.SaveQuestionnarieDAL(questionnarieName, recruiterId);
        }

        public DataTable SaveQuestionBAL(DataTable dtQuestionnarie)
        {
            QuestionnarieREDAL questionnarieDAL = new QuestionnarieREDAL();
            return questionnarieDAL.SaveQuestionDAL(dtQuestionnarie);
        }

        public DataSet ViewQuestionnarieBAL(Int32 questionnarieId)
        {
            QuestionnarieREDAL questionnarieDAL = new QuestionnarieREDAL();
            return questionnarieDAL.ViewQuestionnarieDAL(questionnarieId);
        }
    }
}