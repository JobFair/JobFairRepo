using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Recruiter;
using DAL;

namespace BAL
{
   public class QuestionrieBAL
    {

       public int addquestionrie(QuestionrieEntity questionriEntity)
       {
           QuestionrieDAL questionrieDAL = new QuestionrieDAL();
           return questionrieDAL.addquestionrieDAL(questionriEntity);
       
       }
    }
}
