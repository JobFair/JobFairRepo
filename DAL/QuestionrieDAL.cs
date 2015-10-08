using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entities.Recruiter;
using System.Data.SqlClient;
using System.Configuration;


namespace DAL
{
   public class QuestionrieDAL
    {

       private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        
       public int addquestionrieDAL(QuestionrieEntity questionrieEntity)
       {
           try
           {

               connection.Open();
               SqlParameter[] sqlparams ={
		                                    new SqlParameter("@Question",questionrieEntity.Question),
                                              new SqlParameter("@Answer",questionrieEntity.Answer),
                                             new SqlParameter("@QuestionType",questionrieEntity.QuestionType),
                                           
                                      };
           
               int result = SqlHelper.ExecuteNonQuery(connection,CommandType.StoredProcedure,Constants.sp_RE_insertQuestionrie,sqlparams);
           return result;
       }
           catch (Exception ex)
           {

               throw  ex;
           }
             }
        }
}
