using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
     public class RequestEmailJSDAL
    {
         private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
         public DataSet GetEmailDAL(string candidateId)
         {
             try
             {
                 DataSet ds = new DataSet();
                 SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                 ds = SqlHelper.ExecuteDataset(connection, CommandType.Text,"select EmailId from JS_RegisterDetails where candidateId=@candidateId",sparams);
                 return ds;
             }
             catch (Exception)
             {
                 
                 throw;
             }
         }
    }
}
