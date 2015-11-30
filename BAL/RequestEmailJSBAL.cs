using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BAL
{
   public class RequestEmailJSBAL
    {
       public DataSet GetEmailBAL(string candidateId)
       {
           try
           {
               RequestEmailJSDAL requestEmailJSDAL = new RequestEmailJSDAL();
               return requestEmailJSDAL.GetEmailDAL(candidateId);
           }
           catch (Exception)
           {
               
               throw;
           }
       }
    }
}
