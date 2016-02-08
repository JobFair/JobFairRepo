using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BAL
{
   public class QuestionnarieREBAL
    {
       public Tuple<DataTable,Int32> SaveQuestionnarieBAL(DataTable dtQuestionnarie,string questionnarieName,long recruiterId)
       {
           QuestionnarieREDAL questionnarieDAL = new QuestionnarieREDAL();
           return questionnarieDAL.SaveQuestionnarieDAL(dtQuestionnarie, questionnarieName, recruiterId);
       }
    }
}
