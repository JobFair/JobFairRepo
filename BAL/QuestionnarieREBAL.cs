using DAL;
using System;
using System.Data;

namespace BAL
{
    public class QuestionnarieREBAL
    {
        public Tuple<DataTable, Int32> SaveQuestionnarieBAL(DataTable dtQuestionnarie, string questionnarieName, long recruiterId)
        {
            QuestionnarieREDAL questionnarieDAL = new QuestionnarieREDAL();
            return questionnarieDAL.SaveQuestionnarieDAL(dtQuestionnarie, questionnarieName, recruiterId);
        }

        public DataSet ViewQuestionnarieBAL(Int32 questionnarieId)
        {
            QuestionnarieREDAL questionnarieDAL = new QuestionnarieREDAL();
            return questionnarieDAL.ViewQuestionnarieDAL(questionnarieId);
        }
    }
}