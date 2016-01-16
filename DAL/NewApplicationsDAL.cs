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
  public  class NewApplicationsDAL
    {
      private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        public System.Data.DataSet GetCandidateDetails(   long candidateId)
        {
            DataSet dsclientdetails = new DataSet();

            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsclientdetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_CandidateDetails, sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
            return dsclientdetails;
        }
    }
}
