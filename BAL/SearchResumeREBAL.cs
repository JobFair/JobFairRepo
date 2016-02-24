using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BAL
{
   public class SearchResumeREBAL
    {
       public DataSet GetClientNameBAL()
       {
           SearchResumeREDAL searchResumeDAL = new SearchResumeREDAL();
           return searchResumeDAL.GetClientNameDAL();
       }

       public DataSet GetPositionBAL(long clientId)
       {
           SearchResumeREDAL searchResumeDAL = new SearchResumeREDAL();
           return searchResumeDAL.GetPositionDAL(clientId);
       }

       public int GetRequirementIdBAL(string position)
       {
           SearchResumeREDAL searchResumeDAL = new SearchResumeREDAL();
           return searchResumeDAL.GetRequirementIdDAL(position);
       }
    }
}
